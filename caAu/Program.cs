using System;

class Program
{
    public static int menuAccion;
    public static int dineroTotal = 0;
    public static int dineroIngresado = 0;
    public static int dineroRetirado = 0;
    public static bool ejecucion = true;

    static void Main()
    {
        menuCajero();
    }

    static void menuCajero()
    {
        while (ejecucion)
        {
            Console.WriteLine("Bienvenidos a CityBank");
            Console.WriteLine("Ingrese una Opción (1)Depositar (2)Retirar (3)Consultar (4)Salir");

            try
            {
                menuAccion = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine();
            }

            switch (menuAccion)
            {
                case 1:
                    Depositar();
                    break;
                case 2:
                    Retirar();
                    break;
                case 3:
                    Consultar();
                    break;
                case 4:
                    Salir();
                    break;
                default:
                    Console.WriteLine("Opción no valida.\n");
                    break;
            }

        }
    }

    static void Depositar()
    {
        Console.WriteLine();
        Console.WriteLine("Ingrese la cantidad de dinero:");

        try
        {
            dineroIngresado = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nIngrese un valor númerico.\n");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("\nIngrese un valor númerico más pequeño.\n");
        }

        if (dineroIngresado > 0)
        {
            dineroTotal += dineroIngresado;

            Console.WriteLine($"\nSe ingreso {dineroIngresado}$ al banco. \n");
        }
    }

    static void Retirar()
    {
        Console.WriteLine();
        Console.WriteLine("Ingrese la cantidad de dinero:");

        try
        {
            dineroRetirado = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nIngrese un valor númerico.\n");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("\nIngrese un valor númerico más pequeño.\n");
        }

        if (dineroRetirado > 0)
        {
            if (dineroTotal >= dineroRetirado)
            {
                dineroTotal = dineroTotal - dineroRetirado;

                Console.WriteLine();
                Console.WriteLine($"Se retiro {dineroRetirado}$ del banco. \n");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No hay saldo suficiente. \n");
            }

        }
    }

    static void Consultar()
    {
        Console.WriteLine();
        Console.WriteLine($"Saldo total de {dineroTotal}$ \n");
    }

    static void Salir()
    {
        ejecucion = false;
    }
}