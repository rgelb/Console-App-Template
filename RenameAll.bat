@echo off

set projectName=BreakPadLifeCalculator

REM rename text in all files
fart -r -n *.csproj ConsoleApp %projectName%
fart -r -n *.sln ConsoleApp %projectName%
fart -r -n *.cs ConsoleApp %projectName%


REM rename files
REN ConsoleApp.csproj %projectName%.csproj
REN ConsoleAppTemplate.sln %projectName%.sln
