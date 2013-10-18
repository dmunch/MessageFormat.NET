using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{
	class MessageFormatListener : ImessageformatListener
	{
		public Message Message = null;

		public void EnterMessageText(messageformatParser.MessageTextContext context)
		{
		}

		public void ExitMessageText(messageformatParser.MessageTextContext context)
		{
			var segment = new TextSegment(context.GetText());
			Message.Segments.Add(segment);
		}

		public void EnterMessage(messageformatParser.MessageContext context)
		{
			Message = new Message(Message);
		}

		public void ExitMessage(messageformatParser.MessageContext context)
		{
			var oldMessage = Message;

			if (Message.Parent != null)
				Message = Message.Parent;

			if (Message.Segments.Last() is PluralSegment)
			{
				var pluralSegment = Message.Segments.Last() as PluralSegment;
				pluralSegment.Alternatives.Last().Message = oldMessage;
			}
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
			var argSegment = new ArgSegment();
			Message.Segments.Add(argSegment);
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
			var argument = new NumberedArgument(int.Parse(context.IDNUMBER().ToString()));

			ArgSegment argSegment = Message.Segments.Last() as ArgSegment;
			argSegment.Argument = argument;
		}

		public void ExitArgNumber(messageformatParser.ArgNumberContext context)
		{

		}

		public void EnterArgName(messageformatParser.ArgNameContext context)
		{
			var argument = new NamedArgument(context.IDNAME().ToString());

			ArgSegment argSegment = Message.Segments.Last() as ArgSegment;
			argSegment.Argument = argument;
		}

		public void ExitArgName(messageformatParser.ArgNameContext context)
		{

		}

		public void EnterSimpleArg(messageformatParser.SimpleArgContext context)
		{
			var argSegment = new ArgSegment();
			Message.Segments.Add(argSegment);
		}

		public void ExitSimpleArg(messageformatParser.SimpleArgContext context)
		{

		}

		public void EnterStyle(messageformatParser.StyleContext context)
		{

		}
		public void ExitStyle(messageformatParser.StyleContext context)
		{
			//Console.Write(context.GetText().Trim());
		}

		public void EnterType(messageformatParser.TypeContext context)
		{

		}
		public void ExitType(messageformatParser.TypeContext context)
		{
			ArgSegment segment = Message.Segments.Last() as ArgSegment;
			segment.Argument.SetType(context.GetText().Trim());
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
			var argSegment = new PluralSegment();
			Message.Segments.Add(argSegment);
		}

		public void ExitPluralArg(messageformatParser.PluralArgContext context)
		{
		}

		public void EnterOffsetValue(messageformatParser.OffsetValueContext context)
		{
		}

		public void ExitOffsetValue(messageformatParser.OffsetValueContext context)
		{
			PluralSegment pluralSegment = Message.Segments.Last() as PluralSegment;
			pluralSegment.Offset = int.Parse(context.IDNUMBER().ToString());
		}

		public void EnterKeyword(messageformatParser.KeywordContext context)
		{
		}

		public void ExitKeyword(messageformatParser.KeywordContext context)
		{
			PluralSegment pluralSegment = Message.Segments.Last() as PluralSegment;
			var alternative = new PluralKeywordAlternative();
			alternative.Keyword = context.GetText();

			pluralSegment.Alternatives.Add(alternative);
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

			PluralSegment pluralSegment = Message.Segments.Last() as PluralSegment;
			var alternative = new PluralExplicitAlternative();
			alternative.ExplicitValue = int.Parse(context.IDNUMBER().ToString());

			pluralSegment.Alternatives.Add(alternative);
		}
		#endregion
	}
}
