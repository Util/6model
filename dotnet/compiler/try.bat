@copy ..\runtime\bin\Debug\RakudoRuntime.dll .
@copy ..\runtime\bin\Debug\RakudoRuntime.pdb .
@nmake /NOLOGO
@parrot compile.pir %1 > x.cs
@csc x.cs /reference:RakudoRuntime.dll
@echo ---
@x

