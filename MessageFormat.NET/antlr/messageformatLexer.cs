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
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.1-SNAPSHOT")]
public partial class messageformatLexer : Lexer {
	public const int
		T__25=1, T__24=2, T__23=3, T__22=4, T__21=5, T__20=6, T__19=7, T__18=8, 
		T__17=9, T__16=10, T__15=11, T__14=12, T__13=13, T__12=14, T__11=15, T__10=16, 
		T__9=17, T__8=18, T__7=19, T__6=20, T__5=21, T__4=22, T__3=23, T__2=24, 
		T__1=25, T__0=26, IDNUMBER=27, IDNAME=28, WSS=29;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"<INVALID>",
		"'long'", "'many'", "'short'", "'other'", "','", "'percent'", "'full'", 
		"' '", "'{'", "'spellout'", "'}'", "'few'", "'date'", "'medium'", "'='", 
		"'currency'", "'one'", "'ordinal'", "'offset:'", "'number'", "'two'", 
		"'duration'", "'zero'", "'time'", "'integer'", "'plural'", "IDNUMBER", 
		"IDNAME", "WSS"
	};
	public static readonly string[] ruleNames = {
		"T__25", "T__24", "T__23", "T__22", "T__21", "T__20", "T__19", "T__18", 
		"T__17", "T__16", "T__15", "T__14", "T__13", "T__12", "T__11", "T__10", 
		"T__9", "T__8", "T__7", "T__6", "T__5", "T__4", "T__3", "T__2", "T__1", 
		"T__0", "IDNUMBER", "IDNAME", "ID_LETTER", "DIGIT", "WSS", "WS", "WSF"
	};


	public messageformatLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "messageformat.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 30 : WSS_action(_localctx, actionIndex); break;
		}
	}
	private void WSS_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0: Skip();  break;
		}
	}

	public static readonly string _serializedATN =
		"\x3\xB6D5\x5D61\xF22C\xAD89\x44D2\xDF97\x846A\xE419\x2\x1F\xF1\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE"+
		"\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17"+
		"\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18"+
		"\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A"+
		"\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B"+
		"\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x6\x1C\xD7\n\x1C\r\x1C\xE\x1C\xD8\x3\x1D"+
		"\x3\x1D\x3\x1D\a\x1D\xDE\n\x1D\f\x1D\xE\x1D\xE1\v\x1D\x3\x1E\x3\x1E\x3"+
		"\x1F\x3\x1F\x3 \x6 \xE8\n \r \xE \xE9\x3 \x3 \x3!\x3!\x3\"\x3\"\x2\x2"+
		"\x2#\x3\x2\x3\x1\x5\x2\x4\x1\a\x2\x5\x1\t\x2\x6\x1\v\x2\a\x1\r\x2\b\x1"+
		"\xF\x2\t\x1\x11\x2\n\x1\x13\x2\v\x1\x15\x2\f\x1\x17\x2\r\x1\x19\x2\xE"+
		"\x1\x1B\x2\xF\x1\x1D\x2\x10\x1\x1F\x2\x11\x1!\x2\x12\x1#\x2\x13\x1%\x2"+
		"\x14\x1\'\x2\x15\x1)\x2\x16\x1+\x2\x17\x1-\x2\x18\x1/\x2\x19\x1\x31\x2"+
		"\x1A\x1\x33\x2\x1B\x1\x35\x2\x1C\x1\x37\x2\x1D\x1\x39\x2\x1E\x1;\x2\x2"+
		"\x1=\x2\x2\x1?\x2\x1F\x2\x41\x2\x2\x1\x43\x2\x2\x1\x3\x2\x4\x5\x2\x43"+
		"\\\x61\x61\x63|\x5\x2\v\f\xF\xF\"\"\xF0\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2"+
		"\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2"+
		"\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3"+
		"\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2"+
		"\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2"+
		"%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3"+
		"\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35"+
		"\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x3"+
		"\x45\x3\x2\x2\x2\x5J\x3\x2\x2\x2\aO\x3\x2\x2\x2\tU\x3\x2\x2\x2\v[\x3\x2"+
		"\x2\x2\r]\x3\x2\x2\x2\xF\x65\x3\x2\x2\x2\x11j\x3\x2\x2\x2\x13l\x3\x2\x2"+
		"\x2\x15n\x3\x2\x2\x2\x17w\x3\x2\x2\x2\x19y\x3\x2\x2\x2\x1B}\x3\x2\x2\x2"+
		"\x1D\x82\x3\x2\x2\x2\x1F\x89\x3\x2\x2\x2!\x8B\x3\x2\x2\x2#\x94\x3\x2\x2"+
		"\x2%\x98\x3\x2\x2\x2\'\xA0\x3\x2\x2\x2)\xA8\x3\x2\x2\x2+\xAF\x3\x2\x2"+
		"\x2-\xB3\x3\x2\x2\x2/\xBC\x3\x2\x2\x2\x31\xC1\x3\x2\x2\x2\x33\xC6\x3\x2"+
		"\x2\x2\x35\xCE\x3\x2\x2\x2\x37\xD6\x3\x2\x2\x2\x39\xDA\x3\x2\x2\x2;\xE2"+
		"\x3\x2\x2\x2=\xE4\x3\x2\x2\x2?\xE7\x3\x2\x2\x2\x41\xED\x3\x2\x2\x2\x43"+
		"\xEF\x3\x2\x2\x2\x45\x46\an\x2\x2\x46G\aq\x2\x2GH\ap\x2\x2HI\ai\x2\x2"+
		"I\x4\x3\x2\x2\x2JK\ao\x2\x2KL\a\x63\x2\x2LM\ap\x2\x2MN\a{\x2\x2N\x6\x3"+
		"\x2\x2\x2OP\au\x2\x2PQ\aj\x2\x2QR\aq\x2\x2RS\at\x2\x2ST\av\x2\x2T\b\x3"+
		"\x2\x2\x2UV\aq\x2\x2VW\av\x2\x2WX\aj\x2\x2XY\ag\x2\x2YZ\at\x2\x2Z\n\x3"+
		"\x2\x2\x2[\\\a.\x2\x2\\\f\x3\x2\x2\x2]^\ar\x2\x2^_\ag\x2\x2_`\at\x2\x2"+
		"`\x61\a\x65\x2\x2\x61\x62\ag\x2\x2\x62\x63\ap\x2\x2\x63\x64\av\x2\x2\x64"+
		"\xE\x3\x2\x2\x2\x65\x66\ah\x2\x2\x66g\aw\x2\x2gh\an\x2\x2hi\an\x2\x2i"+
		"\x10\x3\x2\x2\x2jk\a\"\x2\x2k\x12\x3\x2\x2\x2lm\a}\x2\x2m\x14\x3\x2\x2"+
		"\x2no\au\x2\x2op\ar\x2\x2pq\ag\x2\x2qr\an\x2\x2rs\an\x2\x2st\aq\x2\x2"+
		"tu\aw\x2\x2uv\av\x2\x2v\x16\x3\x2\x2\x2wx\a\x7F\x2\x2x\x18\x3\x2\x2\x2"+
		"yz\ah\x2\x2z{\ag\x2\x2{|\ay\x2\x2|\x1A\x3\x2\x2\x2}~\a\x66\x2\x2~\x7F"+
		"\a\x63\x2\x2\x7F\x80\av\x2\x2\x80\x81\ag\x2\x2\x81\x1C\x3\x2\x2\x2\x82"+
		"\x83\ao\x2\x2\x83\x84\ag\x2\x2\x84\x85\a\x66\x2\x2\x85\x86\ak\x2\x2\x86"+
		"\x87\aw\x2\x2\x87\x88\ao\x2\x2\x88\x1E\x3\x2\x2\x2\x89\x8A\a?\x2\x2\x8A"+
		" \x3\x2\x2\x2\x8B\x8C\a\x65\x2\x2\x8C\x8D\aw\x2\x2\x8D\x8E\at\x2\x2\x8E"+
		"\x8F\at\x2\x2\x8F\x90\ag\x2\x2\x90\x91\ap\x2\x2\x91\x92\a\x65\x2\x2\x92"+
		"\x93\a{\x2\x2\x93\"\x3\x2\x2\x2\x94\x95\aq\x2\x2\x95\x96\ap\x2\x2\x96"+
		"\x97\ag\x2\x2\x97$\x3\x2\x2\x2\x98\x99\aq\x2\x2\x99\x9A\at\x2\x2\x9A\x9B"+
		"\a\x66\x2\x2\x9B\x9C\ak\x2\x2\x9C\x9D\ap\x2\x2\x9D\x9E\a\x63\x2\x2\x9E"+
		"\x9F\an\x2\x2\x9F&\x3\x2\x2\x2\xA0\xA1\aq\x2\x2\xA1\xA2\ah\x2\x2\xA2\xA3"+
		"\ah\x2\x2\xA3\xA4\au\x2\x2\xA4\xA5\ag\x2\x2\xA5\xA6\av\x2\x2\xA6\xA7\a"+
		"<\x2\x2\xA7(\x3\x2\x2\x2\xA8\xA9\ap\x2\x2\xA9\xAA\aw\x2\x2\xAA\xAB\ao"+
		"\x2\x2\xAB\xAC\a\x64\x2\x2\xAC\xAD\ag\x2\x2\xAD\xAE\at\x2\x2\xAE*\x3\x2"+
		"\x2\x2\xAF\xB0\av\x2\x2\xB0\xB1\ay\x2\x2\xB1\xB2\aq\x2\x2\xB2,\x3\x2\x2"+
		"\x2\xB3\xB4\a\x66\x2\x2\xB4\xB5\aw\x2\x2\xB5\xB6\at\x2\x2\xB6\xB7\a\x63"+
		"\x2\x2\xB7\xB8\av\x2\x2\xB8\xB9\ak\x2\x2\xB9\xBA\aq\x2\x2\xBA\xBB\ap\x2"+
		"\x2\xBB.\x3\x2\x2\x2\xBC\xBD\a|\x2\x2\xBD\xBE\ag\x2\x2\xBE\xBF\at\x2\x2"+
		"\xBF\xC0\aq\x2\x2\xC0\x30\x3\x2\x2\x2\xC1\xC2\av\x2\x2\xC2\xC3\ak\x2\x2"+
		"\xC3\xC4\ao\x2\x2\xC4\xC5\ag\x2\x2\xC5\x32\x3\x2\x2\x2\xC6\xC7\ak\x2\x2"+
		"\xC7\xC8\ap\x2\x2\xC8\xC9\av\x2\x2\xC9\xCA\ag\x2\x2\xCA\xCB\ai\x2\x2\xCB"+
		"\xCC\ag\x2\x2\xCC\xCD\at\x2\x2\xCD\x34\x3\x2\x2\x2\xCE\xCF\ar\x2\x2\xCF"+
		"\xD0\an\x2\x2\xD0\xD1\aw\x2\x2\xD1\xD2\at\x2\x2\xD2\xD3\a\x63\x2\x2\xD3"+
		"\xD4\an\x2\x2\xD4\x36\x3\x2\x2\x2\xD5\xD7\x5=\x1F\x2\xD6\xD5\x3\x2\x2"+
		"\x2\xD7\xD8\x3\x2\x2\x2\xD8\xD6\x3\x2\x2\x2\xD8\xD9\x3\x2\x2\x2\xD9\x38"+
		"\x3\x2\x2\x2\xDA\xDF\x5;\x1E\x2\xDB\xDE\x5;\x1E\x2\xDC\xDE\x5=\x1F\x2"+
		"\xDD\xDB\x3\x2\x2\x2\xDD\xDC\x3\x2\x2\x2\xDE\xE1\x3\x2\x2\x2\xDF\xDD\x3"+
		"\x2\x2\x2\xDF\xE0\x3\x2\x2\x2\xE0:\x3\x2\x2\x2\xE1\xDF\x3\x2\x2\x2\xE2"+
		"\xE3\t\x2\x2\x2\xE3<\x3\x2\x2\x2\xE4\xE5\x4\x32;\x2\xE5>\x3\x2\x2\x2\xE6"+
		"\xE8\x5\x43\"\x2\xE7\xE6\x3\x2\x2\x2\xE8\xE9\x3\x2\x2\x2\xE9\xE7\x3\x2"+
		"\x2\x2\xE9\xEA\x3\x2\x2\x2\xEA\xEB\x3\x2\x2\x2\xEB\xEC\b \x2\x2\xEC@\x3"+
		"\x2\x2\x2\xED\xEE\a\"\x2\x2\xEE\x42\x3\x2\x2\x2\xEF\xF0\t\x3\x2\x2\xF0"+
		"\x44\x3\x2\x2\x2\a\x2\xD8\xDD\xDF\xE9";
	public static readonly ATN _ATN =
		ATNSimulator.Deserialize(_serializedATN.ToCharArray());
}
