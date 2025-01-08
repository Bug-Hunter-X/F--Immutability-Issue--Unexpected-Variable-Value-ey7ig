let mutable x = ref 0
let y = !x + 1
x := 1
printf "%d" y

//Alternative solution using a mutable variable and ensuring correct sequence of operations
let mutable x2 = 0
let y2 = x2 + 1
x2 <- 1
printf "%d %d" y2 x2