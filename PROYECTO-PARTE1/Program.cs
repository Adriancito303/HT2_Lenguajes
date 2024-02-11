using System;
using System.IO;
using Sets;

int val = 1;
string filePath = "";
int lineNumber = 0;
while (val == 1)
{
    try
    {
        string pro;
        Console.WriteLine("Selecciones Una opcion");
        Console.WriteLine("1. Problema 1 Placas");
        Console.WriteLine("2. Problemas 2 Fecha");
        Console.WriteLine("3. Problema 3 Sets");
        Console.WriteLine("0. salir");
        pro = Console.ReadLine();
        switch (pro)
        {
            case "0":
                Environment.Exit(0);
                break;
            case "1":
                Console.WriteLine("Problema 1 Placas");
                Console.WriteLine("Inserte direccion de la ubicacion del archivo");
                //C:\Users\cadri\OneDrive\Escritorio\PRUEBA.txt
                filePath = Console.ReadLine();
                foreach (string line in File.ReadLines(filePath))
                {
                    lineNumber++; //Incrementa el contador de lineas

                    //ignoralas lineas vacias o que solo contienen espacios en blanco
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue; //Pasa a la siguiente linea
                    }
                    Letra.Placa(line, lineNumber);
                }
                Console.ReadKey();
                Console.Clear();
                break;
            case "2":
                Console.WriteLine("Problemas 2 Fecha");
                Console.WriteLine("Inserte fecha");
                string fecha;
                fecha = Console.ReadLine();
                Letra.Fecha(fecha);
                Console.ReadKey();
                Console.Clear();
                break;
            case "3":
                //C:\Users\cadri\OneDrive\Escritorio\PRUEBA.txt
                Console.WriteLine("Problema 3 Sets");
                Console.WriteLine("Inserte direccion de la ubicacion del archivo");
                filePath = Console.ReadLine();
                foreach (string line in File.ReadLines(filePath))
                {
                    lineNumber++; //Incrementa el contador de lineas

                    //ignoralas lineas vacias o que solo contienen espacios en blanco
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue; //Pasa a la siguiente linea
                    }
                    Letra.VerificaLetra(line, lineNumber);
                }
                Console.ReadKey();
                Console.Clear();
                break;
        }
        Console.Clear();
    }
    catch
    {
        Console.WriteLine("Error");
        Console.ReadKey();
        Console.Clear();    
    }
}