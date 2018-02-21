module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import
open Fable.Import.React

open Types

let root model dispatch =
  div
    [ ]
    [
      button[OnClick (fun _ -> dispatch AddStr)][str "+"]

      model
          |> List.mapi(fun index txt ->
                            div [] [
                              sprintf "#%d. %s" index txt |> str
                              input[
                                DefaultValue txt
                                OnChange (fun ev -> dispatch (ChangeStr (index, (!!ev.target?value))))
                              ]
                              button [ OnClick (fun _ -> DeleteStr index |> dispatch )][ str "Delete me!"]
                              ])
          |> ofList
    ]