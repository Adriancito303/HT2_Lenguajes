using System.Text.RegularExpressions;

namespace Sets
{
    public class Letra
    {
        public static void VerificaLetra(string line, int num)
        {
            var pattern = @"^\s*([a-zA-Z_]+)\s*=\s*((('[a-zA-Z]')(\s*\.\.\s*('[a-zA-Z]'))?)|('[_]'))(\s*\+\s*((('[a-zA-Z]')(\s*\.\.\s*('[a-zA-Z]'))?)|('[_]')))*\s*$";

            // \s* -> espacio en blanco
            // * a lo mejor podria haber algo, y si hay algo podria ser infinito 
            // \. busca una unica aparicion del separador decimal
            // el operador de asignacion (=) permite espacios alrededor
            // + por lo menos tiene que haber algo de lo que especifico , por lo menos una infinito
            int lineNumber = num++;
            if (Regex.IsMatch(line.Trim(), pattern))
            {
                Console.WriteLine("SET valido en la línea " + lineNumber);
            }
            else
            {
                Console.WriteLine("No es correcto, error en la línea: " + lineNumber);
            }
        }
    }
}
