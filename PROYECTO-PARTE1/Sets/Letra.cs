using System.Text.RegularExpressions;

namespace Sets
{
    public class Letra
    {
        public static void VerificaLetra(string line, int num)
        {
            var pattern = @"^SETS$";
            var pattern2 = @"^(\s\t)*([a-zA-Z_]+)(\s|\t)*=(\s|\t)*((('[a-zA-Z]')((\s|\t)*\.\.(\s|\t)*('[a-zA-Z]'))?)|('[_]'))?((\s|\t)*\+(\s|\t)*((('[a-zA-Z]')((\s|\t)*\.\.(\s|\t)*('[a-zA-Z]'))?)|('[_]')))*(\s|\t)*$";
            var pattern3 = @"^(\s\t)*([a-zA-Z_]+)(\s|\t)*=(\s|\t)*(('[0-9]')((\s|\t)*\.\.(\s|\t)*('[0-9]')))$";

            int lineNumber = num++;
            if (Regex.IsMatch(line.Trim(), pattern))
            {
                Console.WriteLine("SET valido en la línea " + lineNumber);
            }
            else if (Regex.IsMatch(line.Trim(), pattern2))
            {
                Console.WriteLine("SET valido en la línea " + lineNumber);
            }
            else if (Regex.IsMatch(line.Trim(), pattern3))
            {
                Console.WriteLine("SET valido en la línea " + lineNumber);
            }
            else
            {
                Console.WriteLine("ERROR en la línea " + lineNumber);
            }
        }

        public static void Placa(string line, int num)
        {
            var pattern = @"^(\s\t)*([a-zA-Z_]+)$";
            var pattern2 = @"^(\s\t)*([A-Z])([0-9][0-9][0-9]([A-Z][A-Z][A-Z]))$";

            int lineNumber = num++;
            if (Regex.IsMatch(line.Trim(), pattern))
            {
                Console.WriteLine("Placa valdia en la línea " + lineNumber);
            }
            else if (Regex.IsMatch(line.Trim(), pattern2))
            {
                Console.WriteLine("Placa valdia en la línea " + lineNumber);
            }
            else
            {
                Console.WriteLine("ERROR en la línea " + lineNumber);
            }
        }
        public static void Fecha(string line)
        {
            var pattern = @"^(([0-9][0-9]?)/([0-9][0-2]?)/([1-9][0-9][0-9][0-9]))?(([0-9][0-9]?)-([0-9][0-2]?)-([1-9][0-9][0-9][0-9]))?$";

            if (Regex.IsMatch(line, pattern))
            {
                Console.WriteLine("FECHA valdia");
            }
            else
            {
                Console.WriteLine("ERROR en la FECHA");
            }
        }
    }
}
