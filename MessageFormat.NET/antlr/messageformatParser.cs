//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from messageformat.g4 by ANTLR 4.1-SNAPSHOT
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.1-SNAPSHOT")]
public partial class messageformatParser : Parser {
	public const int
		T__25=1, T__24=2, T__23=3, T__22=4, T__21=5, T__20=6, T__19=7, T__18=8, 
		T__17=9, T__16=10, T__15=11, T__14=12, T__13=13, T__12=14, T__11=15, T__10=16, 
		T__9=17, T__8=18, T__7=19, T__6=20, T__5=21, T__4=22, T__3=23, T__2=24, 
		T__1=25, T__0=26, IDNUMBER=27, IDNAME=28, WSS=29, WS=30;
	public static readonly string[] tokenNames = {
		"<INVALID>", "'long'", "'many'", "'short'", "'other'", "','", "'percent'", 
		"'full'", "' '", "'{'", "'spellout'", "'}'", "'few'", "'date'", "'medium'", 
		"'='", "'currency'", "'one'", "'ordinal'", "'offset:'", "'number'", "'two'", 
		"'duration'", "'zero'", "'time'", "'integer'", "'plural'", "IDNUMBER", 
		"IDNAME", "WSS", "WS"
	};
	public const int
		RULE_message = 0, RULE_messageText = 1, RULE_argument = 2, RULE_noneArg = 3, 
		RULE_simpleArg = 4, RULE_pluralArg = 5, RULE_argNameOrNumber = 6, RULE_argName = 7, 
		RULE_argNumber = 8, RULE_type = 9, RULE_style = 10, RULE_pluralStyle = 11, 
		RULE_offsetValue = 12, RULE_selector = 13, RULE_explicitValue = 14, RULE_keyword = 15;
	public static readonly string[] ruleNames = {
		"message", "messageText", "argument", "noneArg", "simpleArg", "pluralArg", 
		"argNameOrNumber", "argName", "argNumber", "type", "style", "pluralStyle", 
		"offsetValue", "selector", "explicitValue", "keyword"
	};

	public override string GrammarFileName { get { return "messageformat.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public messageformatParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class MessageContext : ParserRuleContext {
		public ArgumentContext[] argument() {
			return GetRuleContexts<ArgumentContext>();
		}
		public MessageTextContext messageText(int i) {
			return GetRuleContext<MessageTextContext>(i);
		}
		public MessageTextContext[] messageText() {
			return GetRuleContexts<MessageTextContext>();
		}
		public ArgumentContext argument(int i) {
			return GetRuleContext<ArgumentContext>(i);
		}
		public MessageContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_message; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterMessage(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitMessage(this);
		}
	}

	[RuleVersion(0)]
	public MessageContext message() {
		MessageContext _localctx = new MessageContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_message);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32; messageText();
			State = 38;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==9) {
				{
				{
				State = 33; argument();
				State = 34; messageText();
				}
				}
				State = 40;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MessageTextContext : ParserRuleContext {
		public MessageTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_messageText; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterMessageText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitMessageText(this);
		}
	}

	[RuleVersion(0)]
	public MessageTextContext messageText() {
		MessageTextContext _localctx = new MessageTextContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_messageText);
		try {
			int _alt;
			State = 48;
			switch ( Interpreter.AdaptivePredict(_input,2,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 44;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,1,_ctx);
				while ( _alt!=1 && _alt!=-1 ) {
					if ( _alt==1+1 ) {
						{
						{
						State = 41;
						MatchWildcard();
						}
						} 
					}
					State = 46;
					_errHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(_input,1,_ctx);
				}
				}
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 47; Match(8);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgumentContext : ParserRuleContext {
		public PluralArgContext pluralArg() {
			return GetRuleContext<PluralArgContext>(0);
		}
		public SimpleArgContext simpleArg() {
			return GetRuleContext<SimpleArgContext>(0);
		}
		public NoneArgContext noneArg() {
			return GetRuleContext<NoneArgContext>(0);
		}
		public ArgumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_argument; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterArgument(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitArgument(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentContext argument() {
		ArgumentContext _localctx = new ArgumentContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_argument);
		try {
			State = 53;
			switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 50; simpleArg();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 51; noneArg();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 52; pluralArg();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NoneArgContext : ParserRuleContext {
		public ITerminalNode[] WS() { return GetTokens(messageformatParser.WS); }
		public ArgNameOrNumberContext argNameOrNumber() {
			return GetRuleContext<ArgNameOrNumberContext>(0);
		}
		public ITerminalNode WS(int i) {
			return GetToken(messageformatParser.WS, i);
		}
		public NoneArgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_noneArg; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterNoneArg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitNoneArg(this);
		}
	}

	[RuleVersion(0)]
	public NoneArgContext noneArg() {
		NoneArgContext _localctx = new NoneArgContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_noneArg);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55; Match(9);
			State = 59;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 56; Match(WS);
				}
				}
				State = 61;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 62; argNameOrNumber();
			State = 66;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 63; Match(WS);
				}
				}
				State = 68;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 69; Match(11);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SimpleArgContext : ParserRuleContext {
		public StyleContext style() {
			return GetRuleContext<StyleContext>(0);
		}
		public ITerminalNode[] WS() { return GetTokens(messageformatParser.WS); }
		public TypeContext type() {
			return GetRuleContext<TypeContext>(0);
		}
		public ArgNameOrNumberContext argNameOrNumber() {
			return GetRuleContext<ArgNameOrNumberContext>(0);
		}
		public ITerminalNode WS(int i) {
			return GetToken(messageformatParser.WS, i);
		}
		public SimpleArgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_simpleArg; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterSimpleArg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitSimpleArg(this);
		}
	}

	[RuleVersion(0)]
	public SimpleArgContext simpleArg() {
		SimpleArgContext _localctx = new SimpleArgContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_simpleArg);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 71; Match(9);
			State = 72; argNameOrNumber();
			State = 76;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 73; Match(WS);
				}
				}
				State = 78;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 79; Match(5);
			State = 83;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 80; Match(WS);
				}
				}
				State = 85;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 86; type();
			State = 90;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 87; Match(WS);
				}
				}
				State = 92;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 101;
			_la = _input.La(1);
			if (_la==5) {
				{
				State = 93; Match(5);
				State = 97;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==WS) {
					{
					{
					State = 94; Match(WS);
					}
					}
					State = 99;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 100; style();
				}
			}

			State = 103; Match(11);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PluralArgContext : ParserRuleContext {
		public ITerminalNode[] WS() { return GetTokens(messageformatParser.WS); }
		public ArgNameOrNumberContext argNameOrNumber() {
			return GetRuleContext<ArgNameOrNumberContext>(0);
		}
		public ITerminalNode WS(int i) {
			return GetToken(messageformatParser.WS, i);
		}
		public PluralStyleContext pluralStyle() {
			return GetRuleContext<PluralStyleContext>(0);
		}
		public PluralArgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_pluralArg; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterPluralArg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitPluralArg(this);
		}
	}

	[RuleVersion(0)]
	public PluralArgContext pluralArg() {
		PluralArgContext _localctx = new PluralArgContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_pluralArg);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 105; Match(9);
			State = 106; argNameOrNumber();
			State = 110;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 107; Match(WS);
				}
				}
				State = 112;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 113; Match(5);
			State = 117;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 114; Match(WS);
				}
				}
				State = 119;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 120; Match(26);
			State = 124;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 121; Match(WS);
				}
				}
				State = 126;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 127; Match(5);
			State = 131;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 128; Match(WS);
				}
				}
				State = 133;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 134; pluralStyle();
			State = 138;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==WS) {
				{
				{
				State = 135; Match(WS);
				}
				}
				State = 140;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 141; Match(11);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgNameOrNumberContext : ParserRuleContext {
		public ArgNumberContext argNumber() {
			return GetRuleContext<ArgNumberContext>(0);
		}
		public ArgNameContext argName() {
			return GetRuleContext<ArgNameContext>(0);
		}
		public ArgNameOrNumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_argNameOrNumber; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterArgNameOrNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitArgNameOrNumber(this);
		}
	}

	[RuleVersion(0)]
	public ArgNameOrNumberContext argNameOrNumber() {
		ArgNameOrNumberContext _localctx = new ArgNameOrNumberContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_argNameOrNumber);
		try {
			State = 145;
			switch (_input.La(1)) {
			case IDNUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 143; argNumber();
				}
				break;
			case IDNAME:
				EnterOuterAlt(_localctx, 2);
				{
				State = 144; argName();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgNameContext : ParserRuleContext {
		public ITerminalNode IDNAME() { return GetToken(messageformatParser.IDNAME, 0); }
		public ArgNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_argName; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterArgName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitArgName(this);
		}
	}

	[RuleVersion(0)]
	public ArgNameContext argName() {
		ArgNameContext _localctx = new ArgNameContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_argName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 147; Match(IDNAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgNumberContext : ParserRuleContext {
		public ITerminalNode IDNUMBER() { return GetToken(messageformatParser.IDNUMBER, 0); }
		public ArgNumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_argNumber; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterArgNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitArgNumber(this);
		}
	}

	[RuleVersion(0)]
	public ArgNumberContext argNumber() {
		ArgNumberContext _localctx = new ArgNumberContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_argNumber);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 149; Match(IDNUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeContext : ParserRuleContext {
		public TypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_type; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterType(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitType(this);
		}
	}

	[RuleVersion(0)]
	public TypeContext type() {
		TypeContext _localctx = new TypeContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 151;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 10) | (1L << 13) | (1L << 18) | (1L << 20) | (1L << 22) | (1L << 24))) != 0)) ) {
			_errHandler.RecoverInline(this);
			}
			Consume();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StyleContext : ParserRuleContext {
		public StyleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_style; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterStyle(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitStyle(this);
		}
	}

	[RuleVersion(0)]
	public StyleContext style() {
		StyleContext _localctx = new StyleContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_style);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 153;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 1) | (1L << 3) | (1L << 6) | (1L << 7) | (1L << 14) | (1L << 16) | (1L << 25))) != 0)) ) {
			_errHandler.RecoverInline(this);
			}
			Consume();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PluralStyleContext : ParserRuleContext {
		public SelectorContext selector(int i) {
			return GetRuleContext<SelectorContext>(i);
		}
		public OffsetValueContext offsetValue() {
			return GetRuleContext<OffsetValueContext>(0);
		}
		public MessageContext[] message() {
			return GetRuleContexts<MessageContext>();
		}
		public ITerminalNode[] WS() { return GetTokens(messageformatParser.WS); }
		public ITerminalNode WS(int i) {
			return GetToken(messageformatParser.WS, i);
		}
		public SelectorContext[] selector() {
			return GetRuleContexts<SelectorContext>();
		}
		public MessageContext message(int i) {
			return GetRuleContext<MessageContext>(i);
		}
		public PluralStyleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_pluralStyle; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterPluralStyle(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitPluralStyle(this);
		}
	}

	[RuleVersion(0)]
	public PluralStyleContext pluralStyle() {
		PluralStyleContext _localctx = new PluralStyleContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_pluralStyle);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 156;
			_la = _input.La(1);
			if (_la==19) {
				{
				State = 155; offsetValue();
				}
			}

			State = 174;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 158; selector();
				State = 162;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==WS) {
					{
					{
					State = 159; Match(WS);
					}
					}
					State = 164;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 165; Match(9);
				State = 166; message();
				State = 167; Match(11);
				State = 171;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,19,_ctx);
				while ( _alt!=2 && _alt!=-1 ) {
					if ( _alt==1 ) {
						{
						{
						State = 168; Match(WS);
						}
						} 
					}
					State = 173;
					_errHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(_input,19,_ctx);
				}
				}
				}
				State = 176;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 2) | (1L << 4) | (1L << 12) | (1L << 15) | (1L << 17) | (1L << 21) | (1L << 23))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OffsetValueContext : ParserRuleContext {
		public ITerminalNode IDNUMBER() { return GetToken(messageformatParser.IDNUMBER, 0); }
		public OffsetValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_offsetValue; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterOffsetValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitOffsetValue(this);
		}
	}

	[RuleVersion(0)]
	public OffsetValueContext offsetValue() {
		OffsetValueContext _localctx = new OffsetValueContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_offsetValue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 178; Match(19);
			State = 179; Match(IDNUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SelectorContext : ParserRuleContext {
		public ExplicitValueContext explicitValue() {
			return GetRuleContext<ExplicitValueContext>(0);
		}
		public KeywordContext keyword() {
			return GetRuleContext<KeywordContext>(0);
		}
		public SelectorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_selector; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterSelector(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitSelector(this);
		}
	}

	[RuleVersion(0)]
	public SelectorContext selector() {
		SelectorContext _localctx = new SelectorContext(_ctx, State);
		EnterRule(_localctx, 26, RULE_selector);
		try {
			State = 183;
			switch (_input.La(1)) {
			case 15:
				EnterOuterAlt(_localctx, 1);
				{
				State = 181; explicitValue();
				}
				break;
			case 2:
			case 4:
			case 12:
			case 17:
			case 21:
			case 23:
				EnterOuterAlt(_localctx, 2);
				{
				State = 182; keyword();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExplicitValueContext : ParserRuleContext {
		public ITerminalNode IDNUMBER() { return GetToken(messageformatParser.IDNUMBER, 0); }
		public ExplicitValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_explicitValue; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterExplicitValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitExplicitValue(this);
		}
	}

	[RuleVersion(0)]
	public ExplicitValueContext explicitValue() {
		ExplicitValueContext _localctx = new ExplicitValueContext(_ctx, State);
		EnterRule(_localctx, 28, RULE_explicitValue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 185; Match(15);
			State = 186; Match(IDNUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KeywordContext : ParserRuleContext {
		public KeywordContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_keyword; }
		public override void EnterRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.EnterKeyword(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImessageformatListener typedListener = listener as ImessageformatListener;
			if (typedListener != null) typedListener.ExitKeyword(this);
		}
	}

	[RuleVersion(0)]
	public KeywordContext keyword() {
		KeywordContext _localctx = new KeywordContext(_ctx, State);
		EnterRule(_localctx, 30, RULE_keyword);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 188;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 2) | (1L << 4) | (1L << 12) | (1L << 17) | (1L << 21) | (1L << 23))) != 0)) ) {
			_errHandler.RecoverInline(this);
			}
			Consume();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xB6D5\x5D61\xF22C\xAD89\x44D2\xDF97\x846A\xE419\x3 \xC1\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t"+
		"\x10\x4\x11\t\x11\x3\x2\x3\x2\x3\x2\x3\x2\a\x2\'\n\x2\f\x2\xE\x2*\v\x2"+
		"\x3\x3\a\x3-\n\x3\f\x3\xE\x3\x30\v\x3\x3\x3\x5\x3\x33\n\x3\x3\x4\x3\x4"+
		"\x3\x4\x5\x4\x38\n\x4\x3\x5\x3\x5\a\x5<\n\x5\f\x5\xE\x5?\v\x5\x3\x5\x3"+
		"\x5\a\x5\x43\n\x5\f\x5\xE\x5\x46\v\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\a"+
		"\x6M\n\x6\f\x6\xE\x6P\v\x6\x3\x6\x3\x6\a\x6T\n\x6\f\x6\xE\x6W\v\x6\x3"+
		"\x6\x3\x6\a\x6[\n\x6\f\x6\xE\x6^\v\x6\x3\x6\x3\x6\a\x6\x62\n\x6\f\x6\xE"+
		"\x6\x65\v\x6\x3\x6\x5\x6h\n\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\a\ao\n\a\f\a"+
		"\xE\ar\v\a\x3\a\x3\a\a\av\n\a\f\a\xE\ay\v\a\x3\a\x3\a\a\a}\n\a\f\a\xE"+
		"\a\x80\v\a\x3\a\x3\a\a\a\x84\n\a\f\a\xE\a\x87\v\a\x3\a\x3\a\a\a\x8B\n"+
		"\a\f\a\xE\a\x8E\v\a\x3\a\x3\a\x3\b\x3\b\x5\b\x94\n\b\x3\t\x3\t\x3\n\x3"+
		"\n\x3\v\x3\v\x3\f\x3\f\x3\r\x5\r\x9F\n\r\x3\r\x3\r\a\r\xA3\n\r\f\r\xE"+
		"\r\xA6\v\r\x3\r\x3\r\x3\r\x3\r\a\r\xAC\n\r\f\r\xE\r\xAF\v\r\x6\r\xB1\n"+
		"\r\r\r\xE\r\xB2\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x5\xF\xBA\n\xF\x3\x10\x3"+
		"\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3.\x2\x2\x12\x2\x2\x4\x2\x6\x2\b\x2"+
		"\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x16\x2\x18\x2\x1A\x2\x1C\x2\x1E"+
		"\x2 \x2\x2\x5\b\x2\f\f\xF\xF\x14\x14\x16\x16\x18\x18\x1A\x1A\b\x2\x3\x3"+
		"\x5\x5\b\t\x10\x10\x12\x12\x1B\x1B\b\x2\x4\x4\x6\x6\xE\xE\x13\x13\x17"+
		"\x17\x19\x19\xC7\x2\"\x3\x2\x2\x2\x4\x32\x3\x2\x2\x2\x6\x37\x3\x2\x2\x2"+
		"\b\x39\x3\x2\x2\x2\nI\x3\x2\x2\x2\fk\x3\x2\x2\x2\xE\x93\x3\x2\x2\x2\x10"+
		"\x95\x3\x2\x2\x2\x12\x97\x3\x2\x2\x2\x14\x99\x3\x2\x2\x2\x16\x9B\x3\x2"+
		"\x2\x2\x18\x9E\x3\x2\x2\x2\x1A\xB4\x3\x2\x2\x2\x1C\xB9\x3\x2\x2\x2\x1E"+
		"\xBB\x3\x2\x2\x2 \xBE\x3\x2\x2\x2\"(\x5\x4\x3\x2#$\x5\x6\x4\x2$%\x5\x4"+
		"\x3\x2%\'\x3\x2\x2\x2&#\x3\x2\x2\x2\'*\x3\x2\x2\x2(&\x3\x2\x2\x2()\x3"+
		"\x2\x2\x2)\x3\x3\x2\x2\x2*(\x3\x2\x2\x2+-\v\x2\x2\x2,+\x3\x2\x2\x2-\x30"+
		"\x3\x2\x2\x2./\x3\x2\x2\x2.,\x3\x2\x2\x2/\x33\x3\x2\x2\x2\x30.\x3\x2\x2"+
		"\x2\x31\x33\a\n\x2\x2\x32.\x3\x2\x2\x2\x32\x31\x3\x2\x2\x2\x33\x5\x3\x2"+
		"\x2\x2\x34\x38\x5\n\x6\x2\x35\x38\x5\b\x5\x2\x36\x38\x5\f\a\x2\x37\x34"+
		"\x3\x2\x2\x2\x37\x35\x3\x2\x2\x2\x37\x36\x3\x2\x2\x2\x38\a\x3\x2\x2\x2"+
		"\x39=\a\v\x2\x2:<\a \x2\x2;:\x3\x2\x2\x2<?\x3\x2\x2\x2=;\x3\x2\x2\x2="+
		">\x3\x2\x2\x2>@\x3\x2\x2\x2?=\x3\x2\x2\x2@\x44\x5\xE\b\x2\x41\x43\a \x2"+
		"\x2\x42\x41\x3\x2\x2\x2\x43\x46\x3\x2\x2\x2\x44\x42\x3\x2\x2\x2\x44\x45"+
		"\x3\x2\x2\x2\x45G\x3\x2\x2\x2\x46\x44\x3\x2\x2\x2GH\a\r\x2\x2H\t\x3\x2"+
		"\x2\x2IJ\a\v\x2\x2JN\x5\xE\b\x2KM\a \x2\x2LK\x3\x2\x2\x2MP\x3\x2\x2\x2"+
		"NL\x3\x2\x2\x2NO\x3\x2\x2\x2OQ\x3\x2\x2\x2PN\x3\x2\x2\x2QU\a\a\x2\x2R"+
		"T\a \x2\x2SR\x3\x2\x2\x2TW\x3\x2\x2\x2US\x3\x2\x2\x2UV\x3\x2\x2\x2VX\x3"+
		"\x2\x2\x2WU\x3\x2\x2\x2X\\\x5\x14\v\x2Y[\a \x2\x2ZY\x3\x2\x2\x2[^\x3\x2"+
		"\x2\x2\\Z\x3\x2\x2\x2\\]\x3\x2\x2\x2]g\x3\x2\x2\x2^\\\x3\x2\x2\x2_\x63"+
		"\a\a\x2\x2`\x62\a \x2\x2\x61`\x3\x2\x2\x2\x62\x65\x3\x2\x2\x2\x63\x61"+
		"\x3\x2\x2\x2\x63\x64\x3\x2\x2\x2\x64\x66\x3\x2\x2\x2\x65\x63\x3\x2\x2"+
		"\x2\x66h\x5\x16\f\x2g_\x3\x2\x2\x2gh\x3\x2\x2\x2hi\x3\x2\x2\x2ij\a\r\x2"+
		"\x2j\v\x3\x2\x2\x2kl\a\v\x2\x2lp\x5\xE\b\x2mo\a \x2\x2nm\x3\x2\x2\x2o"+
		"r\x3\x2\x2\x2pn\x3\x2\x2\x2pq\x3\x2\x2\x2qs\x3\x2\x2\x2rp\x3\x2\x2\x2"+
		"sw\a\a\x2\x2tv\a \x2\x2ut\x3\x2\x2\x2vy\x3\x2\x2\x2wu\x3\x2\x2\x2wx\x3"+
		"\x2\x2\x2xz\x3\x2\x2\x2yw\x3\x2\x2\x2z~\a\x1C\x2\x2{}\a \x2\x2|{\x3\x2"+
		"\x2\x2}\x80\x3\x2\x2\x2~|\x3\x2\x2\x2~\x7F\x3\x2\x2\x2\x7F\x81\x3\x2\x2"+
		"\x2\x80~\x3\x2\x2\x2\x81\x85\a\a\x2\x2\x82\x84\a \x2\x2\x83\x82\x3\x2"+
		"\x2\x2\x84\x87\x3\x2\x2\x2\x85\x83\x3\x2\x2\x2\x85\x86\x3\x2\x2\x2\x86"+
		"\x88\x3\x2\x2\x2\x87\x85\x3\x2\x2\x2\x88\x8C\x5\x18\r\x2\x89\x8B\a \x2"+
		"\x2\x8A\x89\x3\x2\x2\x2\x8B\x8E\x3\x2\x2\x2\x8C\x8A\x3\x2\x2\x2\x8C\x8D"+
		"\x3\x2\x2\x2\x8D\x8F\x3\x2\x2\x2\x8E\x8C\x3\x2\x2\x2\x8F\x90\a\r\x2\x2"+
		"\x90\r\x3\x2\x2\x2\x91\x94\x5\x12\n\x2\x92\x94\x5\x10\t\x2\x93\x91\x3"+
		"\x2\x2\x2\x93\x92\x3\x2\x2\x2\x94\xF\x3\x2\x2\x2\x95\x96\a\x1E\x2\x2\x96"+
		"\x11\x3\x2\x2\x2\x97\x98\a\x1D\x2\x2\x98\x13\x3\x2\x2\x2\x99\x9A\t\x2"+
		"\x2\x2\x9A\x15\x3\x2\x2\x2\x9B\x9C\t\x3\x2\x2\x9C\x17\x3\x2\x2\x2\x9D"+
		"\x9F\x5\x1A\xE\x2\x9E\x9D\x3\x2\x2\x2\x9E\x9F\x3\x2\x2\x2\x9F\xB0\x3\x2"+
		"\x2\x2\xA0\xA4\x5\x1C\xF\x2\xA1\xA3\a \x2\x2\xA2\xA1\x3\x2\x2\x2\xA3\xA6"+
		"\x3\x2\x2\x2\xA4\xA2\x3\x2\x2\x2\xA4\xA5\x3\x2\x2\x2\xA5\xA7\x3\x2\x2"+
		"\x2\xA6\xA4\x3\x2\x2\x2\xA7\xA8\a\v\x2\x2\xA8\xA9\x5\x2\x2\x2\xA9\xAD"+
		"\a\r\x2\x2\xAA\xAC\a \x2\x2\xAB\xAA\x3\x2\x2\x2\xAC\xAF\x3\x2\x2\x2\xAD"+
		"\xAB\x3\x2\x2\x2\xAD\xAE\x3\x2\x2\x2\xAE\xB1\x3\x2\x2\x2\xAF\xAD\x3\x2"+
		"\x2\x2\xB0\xA0\x3\x2\x2\x2\xB1\xB2\x3\x2\x2\x2\xB2\xB0\x3\x2\x2\x2\xB2"+
		"\xB3\x3\x2\x2\x2\xB3\x19\x3\x2\x2\x2\xB4\xB5\a\x15\x2\x2\xB5\xB6\a\x1D"+
		"\x2\x2\xB6\x1B\x3\x2\x2\x2\xB7\xBA\x5\x1E\x10\x2\xB8\xBA\x5 \x11\x2\xB9"+
		"\xB7\x3\x2\x2\x2\xB9\xB8\x3\x2\x2\x2\xBA\x1D\x3\x2\x2\x2\xBB\xBC\a\x11"+
		"\x2\x2\xBC\xBD\a\x1D\x2\x2\xBD\x1F\x3\x2\x2\x2\xBE\xBF\t\x4\x2\x2\xBF"+
		"!\x3\x2\x2\x2\x18(.\x32\x37=\x44NU\\\x63gpw~\x85\x8C\x93\x9E\xA4\xAD\xB2"+
		"\xB9";
	public static readonly ATN _ATN =
		ATNSimulator.Deserialize(_serializedATN.ToCharArray());
}
