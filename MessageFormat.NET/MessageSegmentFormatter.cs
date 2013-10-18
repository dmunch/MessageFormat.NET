using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	class MessageSegmentFormatter : MessageSegmentVisiter
	{
		IDictionary<string, object> NamedFields;
		object[] NumberedFields;

		StringBuilder Builder;

		public string Format(Message m, IDictionary<string, object> namedFields, params object[] numberedFields)
		{
			this.NamedFields = namedFields;
			this.NumberedFields = numberedFields;

			Builder = new StringBuilder();

			this.Visit(m);

			return Builder.ToString();
		}

		protected override void Visit(TextSegment ts)
		{
			Builder.Append(ts.Text);
		}

		protected override void Visit(PluralSegment ps)
		{
			throw new NotImplementedException();
		}

		protected override void Visit(NamedArgument na)
		{
			Builder.Append(NamedFields[na.Name].ToString());
		}

		protected override void Visit(NumberedArgument na)
		{
			Builder.Append(NumberedFields[na.Number].ToString());
		}
	}
}
