// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#r "../Sample/bin/debug/Sample.dll"
#r "../packages/FsCheck.2.1.0/lib/net45/FsCheck.dll"
#r "../packages/FsCheck.Xunit.2.1.0/lib/net45/FsCheck.Xunit.dll"
#r "../packages/xunit.extensibility.core.2.1.0/lib/dotnet/xunit.core.dll"
#load "Tests.fs"

open System
open Sample.Tests.tests
open FsCheck

// Define your library scripting code here

// For some reason, there is an error when property is decorated with Property attribute 
Check.Quick ``square should be positive``