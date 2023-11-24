type Coach = {
    Name: string
    FormerPlayer: bool
}

type stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    stats: stats
}


let tm = [
    {Name = "Chicago Bulls"; Coach = {Name = "Billy Donovan"; FormerPlayer= true } ; stats = { Wins= 2344;Losses= 2254 }}
    {Name = "Indiana Pacers"; Coach = {Name = "Rick Carlisle"; FormerPlayer= true } ; stats = { Wins= 1883;Losses= 1903 }}
    {Name = "Toronto Raptors"; Coach = {Name = "Darko Rajakovic"; FormerPlayer= true } ; stats = { Wins= 1071;Losses= 1157 }}
    {Name = "Brooklyn Nets"; Coach = {Name = "Jacque Vaughn"; FormerPlayer= true } ; stats = { Wins= 1622;Losses= 2164 }}
    {Name = "Atlanta Hawks"; Coach = {Name = "Quin Snyder"; FormerPlayer= true } ; stats = { Wins= 2891;Losses= 2964}}
]

let topteam = tm |> List.filter (fun tm -> tm.stats.Wins > tm.stats.Losses)

//printfn "%A" topteam

topteam |> List.iter (fun tm -> printfn "tm Name: %s" tm.Name)
topteam |> List.iter (fun tm -> printfn "tm wins: %d" tm.stats.Wins)

let calculateSuccessPercentage tm =  float tm.stats.Wins / float ( tm.stats.Wins + tm.stats.Losses ) * 100.0

let successPercentages = topteam |> List.map calculateSuccessPercentage 

let avg = List.average successPercentages 

printfn "The Percentage of Team %f" avg


type Cuisine = 
    | Korean 
    | Turkish

type MovieType = 
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks 
    | IMAXWithSnacks
    | DBOXWithSnacks

type Activity = 
    | BoardGAme 
    | Chill 
    |Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int* float
