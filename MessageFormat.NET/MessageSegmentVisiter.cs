using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	public interface IActionVisitor<in TBase>
		where TBase : class
	{
		/// <summary>
		/// Register action on <see cref="T"/>.
		/// </summary>
		/// <typeparam name="T">Concrete type.</typeparam>
		/// <param name="action">Action.</param>
		void Register<T>(Action<T> action)
			where T : TBase;

		/// <summary>
		/// Visit concrete type.
		/// </summary>
		/// <param name="value">Type to visit.</param>
		void Visit<T>(T value)
			where T : TBase;
	}

	class ActionVisitor<TBase> : IActionVisitor<TBase>
			where TBase : class
	{
		private readonly Dictionary<Type, Action<TBase>> _repository =
			new Dictionary<Type, Action<TBase>>();

		public void Register<T>(Action<T> action)
			where T : TBase
		{
			_repository[typeof(T)] = x => action((T)x);
		}

		public void Visit<T>(T value)
			where T : TBase
		{
			Action<TBase> action = _repository[value.GetType()];
			action(value);
		}
	}

	abstract class MessageSegmentVisiter
	{
		ActionVisitor<Segment> Visiter;
		ActionVisitor<Argument> ArgumentVisiter;

		public MessageSegmentVisiter()
		{
			Visiter = new ActionVisitor<Segment>();
			
			Visiter.Register<TextSegment>(Visit);
			Visiter.Register<ArgSegment>(Visit);
			Visiter.Register<PluralSegment>(Visit);

			ArgumentVisiter = new ActionVisitor<Argument>();
			ArgumentVisiter.Register<NamedArgument>(Visit);
			ArgumentVisiter.Register<NumberedArgument>(Visit);			
		}

		protected void Visit(Message m)
		{
			foreach (var seg in m.Segments)
				Visiter.Visit(seg);
		}

		protected abstract void Visit(TextSegment ts);

		protected void Visit(ArgSegment argSeg)
		{
			ArgumentVisiter.Visit(argSeg.Argument);			
		}

		protected abstract void Visit(PluralSegment ps);
		protected abstract void Visit(NamedArgument na);
		protected abstract void Visit(NumberedArgument na);
	}
}
