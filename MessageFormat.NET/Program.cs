using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	public class MessageFormatListener : ImessageformatListener
	{				
		public void EnterMessageText(messageformatParser.MessageTextContext context)
		{
			Console.Write(context.GetText());
		}

		public void ExitMessageText(messageformatParser.MessageTextContext context)
		{
		}

		public void EnterMessage(messageformatParser.MessageContext context)
		{

		}

		public void ExitMessage(messageformatParser.MessageContext context)
		{
			Console.WriteLine();
		}
		
		public void EnterEveryRule(Antlr4.Runtime.ParserRuleContext ctx)
		{
			
		}

		public void ExitEveryRule(Antlr4.Runtime.ParserRuleContext ctx)
		{
			
		}

		public void VisitErrorNode(Antlr4.Runtime.Tree.IErrorNode node)
		{
			
		}

		public void VisitTerminal(Antlr4.Runtime.Tree.ITerminalNode node)
		{
			
		}

		public void EnterArgument(messageformatParser.ArgumentContext context)
		{
			
		}

		public void ExitArgument(messageformatParser.ArgumentContext context)
		{
			
		}

		public void EnterNoneArg(messageformatParser.NoneArgContext context)
		{
			
		}

		public void ExitNoneArg(messageformatParser.NoneArgContext context)
		{
			
		}

		public void EnterArgNameOrNumber(messageformatParser.ArgNameOrNumberContext context)
		{
		}

		public void ExitArgNameOrNumber(messageformatParser.ArgNameOrNumberContext context)
		{
			
		}
		
		public void EnterArgNumber(messageformatParser.ArgNumberContext context)
		{
			Console.Write(context.IDNUMBER());
		}

		public void ExitArgNumber(messageformatParser.ArgNumberContext context)
		{
			
		}

		public void EnterArgName(messageformatParser.ArgNameContext context)
		{			
			Console.Write(context.IDNAME());
		}

		public void ExitArgName(messageformatParser.ArgNameContext context)
		{
			
		}

		public void EnterSimpleArg(messageformatParser.SimpleArgContext context)
		{
			
		}

		public void ExitSimpleArg(messageformatParser.SimpleArgContext context)
		{
		}

		public void EnterStyle(messageformatParser.StyleContext context)
		{

		}
		public void ExitStyle(messageformatParser.StyleContext context)
		{
			Console.Write(context.GetText().Trim());
		}

		public void EnterType(messageformatParser.TypeContext context)
		{

		}
		public void ExitType(messageformatParser.TypeContext context)
		{
			Console.Write(context.GetText().Trim());
		}

		#region "pluralStyle"
		
		public void EnterSelector(messageformatParser.SelectorContext context)
		{
		}

		public void ExitSelector(messageformatParser.SelectorContext context)
		{
		}

		public void EnterPluralArg(messageformatParser.PluralArgContext context)
		{
		}

		public void ExitPluralArg(messageformatParser.PluralArgContext context)
		{
		}

		public void EnterOffsetValue(messageformatParser.OffsetValueContext context)
		{
		}

		public void ExitOffsetValue(messageformatParser.OffsetValueContext context)
		{
		}

		public void EnterKeyword(messageformatParser.KeywordContext context)
		{
		}

		public void ExitKeyword(messageformatParser.KeywordContext context)
		{
			Console.Write(context.GetText());
			Console.Write(" ");
		}

		public void EnterPluralStyle(messageformatParser.PluralStyleContext context)
		{
		}

		public void ExitPluralStyle(messageformatParser.PluralStyleContext context)
		{
		}

		public void EnterExplicitValue(messageformatParser.ExplicitValueContext context)
		{
		}

		public void ExitExplicitValue(messageformatParser.ExplicitValueContext context)
		{
			Console.Write(context.IDNUMBER());
			Console.Write(" ");
		}
		#endregion
	}

	class Program
	{
		static void Main(string[] args)
		{
			//var input = new Antlr4.Runtime.AntlrInputStream("test10 {test1} {0} {kk}");
			var input = new Antlr4.Runtime.AntlrInputStream("text blabla {0,date} text {1,time,long} t {0 } {bla1} {siegfried}");
			//var input = new Antlr4.Runtime.AntlrInputStream("{days, plural , =0 {aucune} one {heure} other {heures}}");
			
			var lexer = new messageformatLexer(input);
			var tokens = new Antlr4.Runtime.CommonTokenStream(lexer);
			var parser = new messageformatParser(tokens);

			var tree = parser.message();
			//Console.WriteLine(tree.ToStringTree());
			
			var walker = new Antlr4.Runtime.Tree.ParseTreeWalker();
			walker.Walk(new MessageFormatListener(), tree);

			Console.ReadLine();
		}
	}
}
