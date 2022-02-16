module FizzBuzz

open Microsoft.FSharp.Core


let (|IsMultipleOfFizz|_|) input =
    match (input % 3) with
    | 0 -> Some "Fizz"
    | _ -> None

let convert =
    function 
    | input when input % 15 = 0 -> "FizzBuzz"
    | input when input % 5 = 0 -> "Buzz"
    | IsMultipleOfFizz s -> s
    | input -> $"{input}"

