using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketStore
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Calculadora
            Console.WriteLine("Elige una opción\n" +
            "\n1. Suma" + "\n2. Resta" +
            "\n3. Multiplicación" + "\n4. División" +
            "\n5. Salir");

            String s1 = null;
            s1 = Console.ReadKey().ToString();
            switch (s1)
            {
                case "1":
                    Console.WriteLine("Opción Suma");
                    break;
                case "2":
                    Console.WriteLine("Opción Resta");
                    break;
                case "3":
                    Console.WriteLine("Opción Multiplicación");
                    break;
                case "4":
                    Console.WriteLine("Opción Dvisión");
                    break;
            }

        }
    }

}
