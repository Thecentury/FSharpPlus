#nowarn "3186"
#r @"../../../bin/net45/FSharpPlus.dll"

open FSharpPlus

let lst   = {Head = 1; Tail = [2;3;4;5]}
let elem1 = extract   lst
let tails = duplicate lst
let lst'  = extend extract lst