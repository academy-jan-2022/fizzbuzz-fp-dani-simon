module Tests

open Xunit

[<Theory>]
[<InlineData("1", 1)>]
[<InlineData("2", 2)>]
let ``convert input to string`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
    
    
[<Theory>]
[<InlineData("Fizz", 3)>]
[<InlineData("Fizz", 6)>]
let ``convert input to fizz`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
    
    
[<Theory>]
[<InlineData("Buzz", 5)>]
[<InlineData("Buzz", 10)>]
let ``convert input to buzz`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
    
[<Theory>]
[<InlineData("FizzBuzz", 15)>]
[<InlineData("FizzBuzz", 30)>]

let ``convert input to fizzbuzz`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
