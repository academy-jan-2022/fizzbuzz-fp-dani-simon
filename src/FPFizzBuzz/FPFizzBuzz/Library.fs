module FizzBuzz

let convert input =
    match input with 
    | 3 -> "Fizz"
    | 5 -> "Buzz"
    | 15 -> "FizzBuzz"
    | _ -> $"{input}"
