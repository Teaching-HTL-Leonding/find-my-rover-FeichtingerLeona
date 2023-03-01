int westEast = 0, northSouth = 0;
double distance = 0;
string movements;
int summofmovement = 1;

void ControleMovementInput()
{
    bool isValid = true;
    do
    {

        for (int i = 0; i < movements.Length; i++)
        {
            switch (movements[i])
            {
                case '>': ControleMovementInputLevel2(); westEast -= summofmovement; break;
                case '<': ControleMovementInputLevel2(); westEast += summofmovement; break;
                case '^': ControleMovementInputLevel2(); northSouth += summofmovement; break;
                case 'v': ControleMovementInputLevel2(); northSouth -= summofmovement; break;
                default: isValid = false; break;
            }

        }

    }
    while (!isValid);

}

void CalculateLocation()
{

    int outputNorthSauth = 0;
    int outputEastWest = 0;

    if (northSouth > 0) { outputNorthSauth = northSouth; }
    else if (northSouth < 0) { outputNorthSauth = northSouth * (-1); }
    if (westEast > 0) { outputEastWest = westEast; }
    else if (westEast < 0) { outputEastWest = westEast * (-1); }

    if (northSouth >= 0) { System.Console.Write($"{outputNorthSauth}m North"); }
    else if (northSouth <= 0) { System.Console.Write($"{outputNorthSauth}m Sauth"); }
    if (westEast >= 0) { System.Console.Write($"{outputEastWest}m North"); }
    else if (westEast <= 0) { System.Console.Write($"{outputEastWest}m Sauth"); }
}

void CalculateDistance()
{
    distance = Math.Pow(westEast, 2) + Math.Pow(northSouth, 2);
    distance = Math.Sqrt(distance);
    if (distance == 0) { System.Console.WriteLine("Rover is in the base"); }
    else { System.Console.WriteLine($"the distance is {distance}"); }
}

void ControleMovementInputLevel2()
{
    bool isValid = false;


    int i = 0;
    do
    {
        switch (movements[i])
        {
            case '1': summofmovement = 1; isValid = true; break;
            case '2': summofmovement = 2; isValid = true; break;
            case '3': summofmovement = 3; isValid = true; break;
            case '4': summofmovement = 4; isValid = true; break;
            case '5': summofmovement = 5; isValid = true; break;
            case '6': summofmovement = 6; isValid = true; break;
            case '7': summofmovement = 7; isValid = true; break;
            case '8': summofmovement = 8; isValid = true; break;
            case '9': summofmovement = 9; isValid = true; break;
            default: summofmovement = 1; isValid = true; break;
        }
        i++;
    } while (!isValid);
    movements = movements.Substring(i);
}





System.Console.WriteLine("Enter Movements");
movements = Console.ReadLine()!;
ControleMovementInput();
CalculateLocation();
CalculateDistance();
