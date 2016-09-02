open canopy
open runner
open System

//start an instance of the firefox browser
start firefox
let userName="//input[@type='email']"
let password="//input[@type='password']"


//this is how you define a test
"taking canopy for a spin" &&& fun _ ->
    //this is an F# function body, it's whitespace enforced

    //go to url

    url "http://sophiafiori.azurewebsites.net/#/"
    click userName
    userName  << "faisal@foothillsolutions.com"
    click password 
    password << "foobar"
    click "Login"
    click "User"


//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()
