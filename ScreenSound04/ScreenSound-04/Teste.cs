using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04
{
    public class Teste
    {
        public static void Main() 
        {
            try
            {
                for (int i = 3; i >= 0; i--)
                {
                    Console.WriteLine($"{10 / i}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tivemos um problema: {ex.Message}");
            }

        }
    }
}
