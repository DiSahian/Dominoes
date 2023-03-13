class Dominoes
{
    //Declaración de parámetros
    private int d1;

    private int d2;

    //Asignación de parametros a la Clase
    public Dominoes(int d1, int d2)
    {
        this.d1=d1; this.d2=d2;
    }

    public static int operator +(Dominoes a, Dominoes b)
    {
        int suma=a.d1+a.d2+b.d1+b.d2;
        return suma;
    }
    private static void Main(string[] args)
    {
        Dominoes d1=new Dominoes(0,1);
        Dominoes d2=new Dominoes(2,3);
        int total= d1+d2;
        Console.WriteLine(total);
    }
}