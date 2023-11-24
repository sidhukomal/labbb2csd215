type Coach = {
    Name: String
    FormerPlayer: bool
}

type stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: String
    Coach: Coach
    Stats: stats
}


// Create a list of 5 teams 
let teams = [
    {Name = "Chicago Bulls"; Coach = {Name = "Billy Donovan"; FormerPlayer= true} ; stats = {Wins=2344 ;Losses=2254 }}
    {Name = "Indiana Pacers"; Coach = {Name = "Rick Carlisle"; FormerPlayer= true} ; stats = {Wins=1883 ;Losses=1903 }}
    {Name = "Toronto Raptors"; Coach = {Name = "Darko Rajakovic"; FormerPlayer= true} ; stats = {Wins=1071 ;Losses=1157 }}
    {Name = "Brooklyn Nets"; Coach = {Name = "Jacque Vaughn"; FormerPlayer= true} ; stats = {Wins=1622 ;Losses=2164 }}
    {Name = "Atlanta Hawks"; Coach = {Name = "Quin Snyder"; FormerPlayer= true} ; stats = {Wins= 2891 ;Losses=2964 }}
]