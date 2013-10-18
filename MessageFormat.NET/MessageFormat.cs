using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	class MessageFormat
	{
		public static string Format(string formatString, IDictionary<string, object> namedFields, params object[] numberedFields)
		{
			var m = Parse(formatString);
			var formatter = new MessageSegmentFormatter();
			return formatter.Format(m, namedFields, numberedFields);
		}

		public static string Format(string formatString, params object[] numberedFields)
		{
			return Format(formatString, null, numberedFields);
		}

		public static Message Parse(string formatString)
		{
			var input = new Antlr4.Runtime.AntlrInputStream(formatString);
			var lexer = new messageformatLexer(input);
			var tokens = new Antlr4.Runtime.CommonTokenStream(lexer);
			var parser = new messageformatParser(tokens);

			var tree = parser.message();
			//Console.WriteLine(tree.ToStringTree());
			var messageFormatListener = new MessageFormatListener();

			var walker = new Antlr4.Runtime.Tree.ParseTreeWalker();
			walker.Walk(messageFormatListener, tree);

			return messageFormatListener.Message;
		}
	}
}
