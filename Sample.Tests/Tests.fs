namespace Sample.Tests

open System
open Sample
open FsCheck
open FsCheck.Xunit

module tests =

    [<Property>]
    let ``square should be positive`` (x:float) = 
        let isNaN = Double.IsNaN x
        not isNaN ==> (MathFunctions.Square x >= 0.0)
