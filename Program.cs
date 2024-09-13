Random randomerare = new Random();
int tal = randomerare.Next(1, 100);
int giss = 0;
int tur = 0;
bool start1 = false;
Console.WriteLine("To start enter ! ");
string start = Console.ReadLine();
if(start == "!")
{
   start1 = true;
}
while(start1)
{ 
    tur++;
    if(tur == 1)
    {
        Console.WriteLine("Jag tänker på ett tal mellan 1 och 100, Gissa! ");
    }
    Console.Write("Gissning "+ tur + ": ");
    giss = Convert.ToInt32(Console.ReadLine());
    if(giss == tal)
    {
        Console.Write("Du vann!");
        Console.Write("Det tog "+ tur +" gissningar");
        break;
    }
    else if(giss < tal){
        Console.WriteLine("Din gissning är för låg");
    }
    else if(giss > tal){
        Console.WriteLine("Din gissning är för hög");
    }
}
