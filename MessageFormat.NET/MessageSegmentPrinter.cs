using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	class MessageSegmentPrinter : MessageSegmentVisiter
	{
		public void Print(Message m)
		{
			this.Visit(m);
		}

		protected override void Visit(TextSegment ts)
		{
			Console.Write(ts.Text);
		}

		protected override void Visit(PluralSegment ps)
		{
			throw new NotImplementedException();
		}

		protected override void Visit(NamedArgument na)
		{
			Console.Write(string.Format("{{{0}, {1}}}", na.Name, na.Type));
		}

		protected override void Visit(NumberedArgument na)
		{
			Console.Write(string.Format("{{{0}, {1}}}", na.Number, na.Type));
		}
	}	
}
