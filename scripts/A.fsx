#r "nuget:Newtonsoft.Json"

open Newtonsoft.Json

{| A = 100; B = 200 |}
|> JsonConvert.SerializeObject
|> printfn "%s"
