/*
double radie=2.4;
Console.WriteLine("Cirkelns omkrets: "+CirkelOmkrets(radie));
Console.WriteLine("Cirkelns area: "+ CirkelArea(radie));


double CirkelOmkrets(double radie) {
    return radie*2*Math.PI;
}

double CirkelArea(double radie) {
    return Math.PI*radie*radie;
}
*/


/*
Console.WriteLine(beräknaMedel(22, 123, 34));
double beräknaMedel (double tal1, double tal2, double tal3)
{
    return ((tal1 + tal2 + tal3) /3);
}
*/


static void Main()   {
    int a=10, b=20;
    BytPlats (ref b, a);
    //Här ska a ha värdet 20 och b värdet 10.
    Console.WriteLine(a+" "+b);
}

static void BytPlats(ref int b)   {
    
}