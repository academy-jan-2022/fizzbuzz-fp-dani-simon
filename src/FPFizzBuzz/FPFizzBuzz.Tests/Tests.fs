module Tests

open Xunit

[<Theory>]
[<InlineData("1", 1)>]
[<InlineData("2", 2)>]
let ``convert input to string`` (expected: string, input: int) =
    let result = FizzBuzz.convert input
    Assert.Equal(expected, result)
