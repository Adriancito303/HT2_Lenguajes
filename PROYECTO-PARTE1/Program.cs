using System;
using System.IO;
using Sets;

string filePath = "C:\\Users\\julio\\Downloads\\GRAMATICA.txt";
int lineNumber = 0;

foreach (string line in File.ReadLines(filePath))
{
    lineNumber++; //Incrementa el contador de lineas

    //ignoralas lineas vacias o que solo contienen espacios en blanco
    if (string.IsNullOrWhiteSpace(line))
    {
        continue; //Pasa a la siguiente línea
    }
    Letra.VerificaLetra(line, lineNumber);
}