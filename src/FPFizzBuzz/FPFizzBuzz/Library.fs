module FizzBuzz

let convert =
    function 
    | input when input % 15 = 0 -> "FizzBuzz"
    | input when input % 5 = 0 -> "Buzz"
    | input when input % 3 = 0 -> "Fizz"
    | input -> $"{input}"
