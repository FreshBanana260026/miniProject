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
    | Coffee of string
    | Soda of string
    | Other of string

type Drink = {DrinkType: DrinkType; Form: Form; Size: Size}

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

let ViaVAT (n:int) (x:float) =
    let per = ((x+ 100.0)/100.0)
    float n * per

type CanteenMessage = 
    | OrderDrink of Drink * int
    | LeaveAComment of string

let taxer (d:Drink) =
    match d.DrinkType with
     | Coffee c -> ViaVAT (price d) 30.0
     | _ -> float (price d)

let bcssCanteenDrinkAgent = MailboxProcessor<CanteenMessage>.Start(fun inbox->
    let rec msgLoop= async{ 
        let! (msg:CanteenMessage) = inbox.Receive()
        match msg with
         | OrderDrink(d,qty) -> printfn "The price for your %i drink/drinks is: %1.2f DKK." qty ((float qty) * (taxer d))
         | LeaveAComment(c) -> printf "The comment for the canteen oeprators has been received with the following content: %s" c
        return! msgLoop
    }
    msgLoop)

//program test
let c = LeaveAComment("Aloha")
bcssCanteenDrinkAgent.Post(c)


let latte = {DrinkType = Coffee("Latte"); Form = Cup; Size = Medium};;
let o = OrderDrink(latte, 3)
bcssCanteenDrinkAgent.Post(o)