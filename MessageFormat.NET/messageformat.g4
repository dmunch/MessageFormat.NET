grammar messageformat;

message : messageText (argument messageText)+;
messageText: (.*?) | ' ';

argument: simpleArg
        | noneArg ; 

noneArg : '{' argNameOrNumber '}';
simpleArg : '{' argNameOrNumber ',' type (',' style)? '}';

argNameOrNumber : argNumber 
		| argName 
		;

argName : IDNAME;
argNumber:  IDNUMBER;

type : (' ')*('number' | 'date' | 'time' | 'spellout' | 'ordinal' | 'duration')(' ')* ; 
style : (' ')*('short' | 'medium' | 'long' | 'full' | 'integer' | 'currency' | 'percent')(' ')*; // | argStyleText

IDNUMBER : [0-9]+;
IDNAME : [a-zA-Z]+[0-9]* ;             // match lower-case identifiers
WS : ([ \t\r\n]+ | (' ')+) -> skip ; // skip spaces, tabs, newlines

