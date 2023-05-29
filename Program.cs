using Prog_test_3;

int c=0;
int a=0;

int p = 0;
int val;
Console.WriteLine("Spelare 1 börjar och är x");

Board B1 = new Board();

//Val av ruta som inte är upptagen, spelare 1 (x) börjar
do {
B1.GB();
val = int.Parse(Console.ReadLine());
//Ser till att valet är mellan 1-9
if(0 < val && val <10)
{
//kollar så rutan inte är upptagen samt draget
if (!B1.Occupied(val))
{
    if (p % 2 == 0)
    {
        B1.Pos(val, 'X');
        p++;
    }
    else
    {
        B1.Pos(val, 'O');
        p++;
    }
}
else
{
    Console.WriteLine("Rutan är upptagen");
    c=c+1;
}
//räknar antal drag i spelet
c=c+B1.Win();

//kollar för vinst eller oavgjort
if(B1.Win()=='X')
{
    Console.WriteLine("Spelare 1 vann");
    a=1;
}
else if(B1.Win()=='O')
{
    Console.WriteLine("Spelare 2 vann");
    a=1;
}
else if(c==267)
{
    Console.WriteLine("Oavgjort");
    a=1;
}
}
else
{
    Console.WriteLine("Rutan finns inte, skriv ett mellan 1-9");
}
Console.WriteLine("c: "+c);
}
while(a!=1);

B1.GB();