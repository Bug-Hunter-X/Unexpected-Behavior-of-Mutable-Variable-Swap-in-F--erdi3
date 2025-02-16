let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

let mutable a = 1
let mutable b = 2
swap a b
printf "%d %d" a b //This will print 1 2, not 2 1 as expected.