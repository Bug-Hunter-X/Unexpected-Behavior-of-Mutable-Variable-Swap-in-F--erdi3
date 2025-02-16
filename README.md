# Unexpected Behavior of Mutable Variable Swap in F# 

This example demonstrates a common pitfall when working with mutable variables in F#.  The `swap` function, while seemingly correct, doesn't swap the values of `a` and `b` as expected. This is because F# mutable variables are passed by reference, not by value.  The solution shows how to correctly swap the values using a tuple.

## Setup 

No special setup needed. Just run the code. 

## Usage

Run `bug.fs` and `bugSolution.fs` to see the difference in behavior. 