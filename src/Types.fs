module App.Types

type CounterMessage =
  | Increment
  | Decrement
  | Reset

type CounterModel = CounterState of int

type Msg =
  | CounterMsg of CounterMessage

let getCounter model = 
  match model with
    | CounterState x -> x

let getCounterStr model =
  getCounter model |> string
