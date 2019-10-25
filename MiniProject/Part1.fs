module Part1

open System.Text
open System.Text

type Form =
    {   Can: string
        Cup: string
        Bottle: string
    }

//
//let formRecord = {Can = "Can"; Cup = "Cup"; Bottle = "Bottle"}
//
//let evaluateForm (form: Form) =
//    match form with
//    | { Can = "Can" } -> printf "This is canned drink"
//    | { Cup = "Cup" } -> printf "This is cupped drink"
//    | { Bottle = "Bottle"} -> printf "this is bottled drink"
//
//evaluateForm { Can = "Can" }

type Size =
    | Large
    | Medium
    | Small;;

type DrinkType =
    | Latte
    | Cappuccino
    | Cortado
    | Monster
    | Redbull
    | Tuborg
    | Smoothie
    | Drikkeyoghurt
    | Sodavand;;

type Drink = {Name: DrinkType; Form: Form; Size: Size}

let price (drink: Drink) =
    match drink.Size with
     | Large -> 20
     | Medium -> 15
     | Small -> 10;;
