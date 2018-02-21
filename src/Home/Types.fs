module Home.Types

type Model = string list

type Msg =
  | AddStr
  | DeleteStr of int
  | ChangeStr of int * string
