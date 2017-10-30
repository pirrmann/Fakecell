module Fakecell.Exercise

(*
//If you want to execute part of this file in the REPL, you must first load the following files:
#load "../Blank.fs"

#r "../../packages/NUnit/lib/nunit.framework.dll"
#load "../../paket-files/forki/FsUnit/FsUnit.fs"
*)

open System

type Test = NUnit.Framework.TestAttribute
open FsUnit

// You can write tests and/or work with the REPL
let [<Test>] ``Whatever comes to mind`` () =
    1 |> shouldBeGreaterThan 0

// this run function is called in Program.fs if you execute the application
let run () =
    printfn "Hello world"