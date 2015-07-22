module Paket.ReadPackagesConfigSpecs

open Paket
open Paket.PackagesConfigFile
open NUnit.Framework
open FsUnit
open Domain

[<Test>]
let ``can read xunit.visualstudio.packages.config``() = 
    let config = Read("PackagesConfig/xunit.visualstudio.packages.config") |> List.head

    config.Id |> shouldEqual "xunit.runner.visualstudio"
    config.TargetFramework |> shouldEqual None
    config.Version |> shouldEqual (SemVer.Parse "2.0.1")