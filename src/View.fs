module App.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open App.Types

let view model dispatch =
    div 
        [] 
        [
            label []
                [
                    model |> getCounterStr |> str
                ]
            
            br []

            button [OnClick (fun _ -> CounterMsg Increment |> dispatch)]
                [
                    str "Incrementar"
                ]

            button [OnClick (fun _ -> CounterMsg Decrement |> dispatch)]
                [
                    str "Decrementar"
                ]

            button [OnClick (fun _ -> CounterMsg Reset |> dispatch)]
                [
                    str "Limpiar"
                ]
        ]