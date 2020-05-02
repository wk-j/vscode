#r "nuget:Newtonsoft.Json"

open Newtonsoft.Json

let a = {| A = 100; B = 200 |}

a
|> JsonConvert.SerializeObject
|> printfn "%A"
