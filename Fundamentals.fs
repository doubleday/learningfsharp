module Fundamentals

module Primitives =

    let printSome =
        let planet = "world"
        printfn "hello %s" planet

    let conversion =
        let anInt = -1
        let anUInt = uint32 anInt
        printfn "an uint: %x" anUInt

    let bitwise =
        printfn "%x" (1 ||| 2)
        3 &&& 1 |> printfn "%x"

    let comparison =
        let vals = [
            1 < 2,
            4.0 <= 4.0,
            1 <> 2
            ]

        printfn "%O" vals

module Functions =

    let add x y = x + y
    printfn "%f" <| add 1.0 3.0

    let add1 = add 1.0
    printfn "%f" <| add1 3.

    let printGeneric a =
        printfn "%O" a

    printGeneric "test"
    printGeneric 123


