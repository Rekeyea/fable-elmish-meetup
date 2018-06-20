module App.State

open Elmish
open App.Types

let init () : CounterModel * Cmd<Msg>=
  CounterState 0, []

let updateCounter msg model =
  let counter = getCounter model
  
  match msg with
  | Increment ->
      CounterState (counter + 1), []
  | Decrement ->
      CounterState (counter - 1), []
  | Reset ->
      CounterState 0, []

let update msg model =
  match msg with
  | CounterMsg msg ->
      let (counterState, counterCmd) = updateCounter msg model
      counterState, Cmd.map CounterMsg counterCmd
