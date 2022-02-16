module FizzBuzz

open Microsoft.FSharp.Core


let (|IsMultipleOf|_|) multiple input =
    match (input % multiple) with
    | 0 -> Some()
    | _ -> None

let convert =
    function 
    | IsMultipleOf 15 -> "FizzBuzz"
    | IsMultipleOf 5 -> "Buzz"
    | IsMultipleOf 3 -> "Fizz"
    | input -> $"{input}"

