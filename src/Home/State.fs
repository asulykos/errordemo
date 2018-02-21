module Home.State

open Elmish
open Types

let init () : Model * Cmd<Msg> =
  [], []

let update msg model : Model * Cmd<Msg> =
  match msg with
  | AddStr ->
      ""::model, []
  | DeleteStr indexToRemove ->
    let filteredList = model |> List.mapi(fun index x -> index, x) |> List.filter(fun (index, _) -> index <> indexToRemove) |> List.map(fun (_,x) -> x)
    filteredList, []
  | ChangeStr (indexToMod, str) ->
    let modList = model |> List.mapi(fun index x -> if indexToMod = index then str else x)
    modList, []
