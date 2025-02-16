let swap x y =
    let temp = x
    x <- y
    y <- temp

let swapTuple (x, y) = (y, x)

let mutable a = 1
let mutable b = 2

swap a b
printf "%d %d" a b //This prints 1 2

let (a', b') = swapTuple (a, b) // Correct way to swap
printf "%d %d" a' b' // This prints 2 1