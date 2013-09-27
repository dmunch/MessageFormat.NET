grammar messageformat;

message : messageText (argument messageText)*;
messageText: (.*?) | ' ';

argument: simpleArg
        | noneArg  
	| pluralArg ;

noneArg : '{' WS* argNameOrNumber WS* '}';
simpleArg : '{' argNameOrNumber WS* ',' WS* type WS* (',' WS* style)? '}';
pluralArg : '{' argNameOrNumber WS* ',' WS* 'plural' WS* ',' WS* pluralStyle WS*'}';

argNameOrNumber : argNumber 
		| argName 
		;

argName : IDNAME;
argNumber:  IDNUMBER;

type : 'number' | 'date' | 'time' | 'spellout' | 'ordinal' | 'duration'; 
style : 'short' | 'medium' | 'long' | 'full' | 'integer' | 'currency' | 'percent'; // | argStyleText

pluralStyle : (offsetValue)? (selector WS* '{' message '}' WS* )+;
offsetValue : 'offset:' IDNUMBER;
selector : explicitValue | keyword;
explicitValue : '=' IDNUMBER;
keyword: 'zero' | 'one' | 'two' | 'few' | 'many' | 'other';

IDNUMBER : (DIGIT)+;
IDNAME : ID_LETTER (ID_LETTER | DIGIT)* ; // From C language
fragment ID_LETTER : 'a'..'z'|'A'..'Z'|'_' ;
fragment DIGIT : '0'..'9' ;


WSS: WSF+ -> skip;
fragment WS: ' ';
fragment WSF : [ \t\r\n] ; // skip spaces, tabs, newlines

