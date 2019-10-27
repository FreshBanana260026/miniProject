module Part1

open System.Text
open System.Text

//type Form =
//    {   Can: string
//        Cup: string
//        Bottle: string
//    }

type Form =
    | Bottle
    | Cup
    | Can;;

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

//type DrinkType =
//    | Latte
//    | Cappuccino
//    | Cortado
//    | Monster
//    | Redbull
//    | Tuborg
//    | Smoothie
//    | Drikkeyoghurt
//    | Sodavand;;

type Drink = {name: string; Form: Form; Size: Size}

let packingPricce (form: Form) =
    match form with
    | Bottle -> 3
    | Cup -> 2
    | Can -> 1;;

let price (drink: Drink) =
    let pricecOfContainer = packingPricce drink.Form
    match drink.Size with
     | Large -> 20 + pricecOfContainer
     | Medium -> 15 + pricecOfContainer
     | Small -> 10 + pricecOfContainer;;
