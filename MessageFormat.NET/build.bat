@echo off
SET CLASSPATH=D:\Users\login\Documents\i18n\MessageFormat.NET\packages\Antlr4.4.1.0-alpha003\tools\antlr4-csharp-4.1-SNAPSHOT-complete.jar
SET PATH=%PATH%;C:\Program Files (x86)\Java\jre7\bin

java org.antlr.v4.Tool -o antlr messageformat.g4 -Dlanguage=CSharp_v4_0
