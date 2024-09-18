//Main

string enjoymentLevel = "";
while(enjoymentLevel != "5"){
    DisplayMenu();
    enjoymentLevel = GetEnjoymentLevel();
    RouteEm(enjoymentLevel);
    var (stadium, game) = GetStadiumRecommendation(enjoymentLevel);
    if(enjoymentLevel != "5"){
        DisplayStadiumDetails(stadium, game);
        Pause();
    }
    else{
        SayBye();

        }
}

//End Main


static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Please enter your desired enjoyment level from the following choices:\n\t1. Boring\n\t2. Average\n\t3. Fun\n\t4. Epic\n\t5. Exit Program");
}

static string GetEnjoymentLevel(){
    return Console.ReadLine();
}

static void RouteEm(string enjoymentLevel){
    switch (enjoymentLevel){
        case "1":
        case "Boring":
        case "2":   
        case "Average":
        case "3":
        case "Fun":
        case "4":
        case "Epic":
            break;
        case "5":
        case "Exit Program":
            break;
        default:
            BadInput();
            break;
        }
}

static void BadInput(){
    System.Console.WriteLine("Invalid input. Try again!");
}

static void SayBye(){
    System.Console.WriteLine("You are now leaving the program. Goodbye!");
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static (string stadium, string game) GetStadiumRecommendation(string enjoymentLevel){
    string stadium = "";
    string game = "";
    
    switch(enjoymentLevel){
        case "1":
            stadium = "Neyland Stadium";
            game = "vs Kent State";
            break;
        case "2":
            stadium = "Jordan-Hare Stadium";
            game = "vs Kentucky";
            break;
        case "3":
            stadium = "Tiger Stadium";
            game = "vs Alabama";
            break;
        case "4":
            stadium = "Saban Field at Bryant-Denny Stadium";
            game = "vs Auburn";
            break;
        case "5":
            break;
        default:
            System.Console.WriteLine("Invalid input. Try again!");
            break;
    }
    return (stadium, game);
        
}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"Recommended stadium and game: {stadium} {game}");
}