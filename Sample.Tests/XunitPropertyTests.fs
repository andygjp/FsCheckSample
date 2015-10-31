namespace Sample.Tests

open System.Linq
open Sample
open FsCheck
open FsCheck.Xunit

type StateMachineGenerator =
    static member StateMachine() = 
        StateMachine
        |> Gen.fresh
        |> Arb.fromGen

[<Arbitrary(typeof<StateMachineGenerator>)>]
module ``when initializing StateMachine`` =

    [<Property>]
    let ``it will have correct state`` (sm:StateMachine) =
        sm.Initialize()
        sm.State = State.Initialised

    [<Property>]
    let ``history will be empty`` (sm:StateMachine) =
        sm.Initialize()
        not (sm.History.Any())

type StateMachineFixture =
    static member StateMachine() = 
        let setup = fun() -> 
                        let x = new StateMachine()
                        x.Initialize()
                        x
        setup
        |> Gen.fresh
        |> Arb.fromGen

module ``when initializing StateMachine - using fixture`` =

    [<Property(Arbitrary = [|typeof<StateMachineFixture>|] )>]
    let ``it will have correct state`` (sm:StateMachine) =
        sm.State = State.Initialised
