Console.WriteLine("Hello, ez egy egyszerű számológép");

Console.WriteLine("írd be az első számot");
string numberOneText = Console.ReadLine();
int numberOne = int.Parse(numberOneText);
Console.WriteLine("írd be a második számot");
string numberTwoText = Console.ReadLine();
int numberTwo = int.Parse(numberTwoText);
Console.WriteLine("Összeadáshoz nyomd meg az O betűt");
Console.WriteLine("Kivonáshoz nyomd meg a K betűt");
Console.WriteLine("Szorzáshoz nyomd meg az S betűt");
Console.WriteLine("Osztáshoz nyomd meg az U betűt");
string egyenletParancs = Console.ReadLine();
OsszeadasKivonasSzorzasOsztas(egyenletParancs, numberOne, numberTwo);

Console.WriteLine("A bezáráshoz nyomj meg egy gombot (lehetőleg ne a számítógép kikapcsológombját)");
Console.ReadKey();



void OsszeadasKivonasSzorzasOsztas(string BemenetBetu, int BemenetSzam, int BemenetSzam2)
{


    
    if (nagyEsKisO(BemenetBetu))
    {
        int Osszeg = BemenetSzam + BemenetSzam2;
        Console.WriteLine($"{BemenetSzam} + {BemenetSzam2} = {Osszeg}");
    }
    else if (nagyEsKisK(BemenetBetu))
    {
        int Kivonas = BemenetSzam - BemenetSzam2;
        Console.WriteLine($"{BemenetSzam} - {BemenetSzam2} = {Kivonas}");
    }
    else if (nagyEsKisS(BemenetBetu))
    {
        int Szorzat = BemenetSzam * BemenetSzam2;
        Console.WriteLine($"{BemenetSzam} * {BemenetSzam2} = {Szorzat}");
    }
    else if (nagyEsKisU(BemenetBetu))
    {
        int Osztas = BemenetSzam / BemenetSzam2;
        Console.WriteLine($"{BemenetSzam} / {BemenetSzam2} = {Osztas}");
    }
    else
    {
        Console.WriteLine("Rossz betűt adtál meg");
    }
}

bool nagyEsKisO(string oksu)
{
    if(oksu == "o")
    {
        return true;
    }
    else if (oksu == "O")
    {
        return true; 
    }
    return false;
}
bool nagyEsKisK(string oksu)
{
    if (oksu == "k")
    {
        return true;
    }
    else if (oksu == "K")
    {
        return true;
    }
    return false;
}
bool nagyEsKisS(string oksu)
{
    if (oksu == "s")
    {
        return true;
    }
    else if (oksu == "S")
    {
        return true;
    }
    return false;
}
bool nagyEsKisU(string oksu)
{
    if (oksu == "u")
    {
        return true;
    }
    else if (oksu == "U")
    {
        return true;
    }
    return false;
}
