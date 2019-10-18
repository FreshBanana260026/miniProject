module Part1

open System.Text
open System.Text

type Form =
    | Bottle
    | Cup
    | Can;;

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

let x = {Name= Latte; Form = Cup; Size = Medium};;