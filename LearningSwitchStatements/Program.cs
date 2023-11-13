

string firstName = "Justin";
int age = 33;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are younger then 18.");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job.");
        break;
    case > 66:
        Console.WriteLine("Hopefully you are retired.");
        break;
    default:
        Console.WriteLine("Age was not in expected range.");
        break;
}

//switch (firstName.ToLower())
//{
//    //case "amanda": this works fine
//    case "justin" or "amanda"://this also works fine
//        Console.WriteLine("Hello, learner.");
//        break;
//    case "tim":
//        Console.WriteLine("Hello, Tim");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}
