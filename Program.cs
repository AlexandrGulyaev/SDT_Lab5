using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    class Program
    {
        /// <summary>
        /// Вывод информации о текущем состоянии игрока
        /// </summary>
        public static void TreatmentInfo()
        {
            Console.WriteLine("Текущие показатели:");
            Console.WriteLine("Здоровье " + Treatment.hp + "/" + Treatment.maxhp);
            if (Treatment.infection != 0) Console.WriteLine("Заражен на " + Treatment.infection + "%");
            if (Treatment.bleeding) Console.WriteLine("У вас кровотечение");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Treatment.hp = 21;
            Treatment.maxhp = 87;
            Treatment.infection = 80;
            Treatment.bleeding = true;
            try { 
            TreatmentInfo();

            Console.WriteLine("Введите, что нужно применить: бинт, мазь, таблетку, аптечку.");
            string measure = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            measure = measure.Replace("у", "а");

            switch (measure.ToLower())
            {
                case "бинт":
                    new Treatment(new BandageTreatmentState()).Request();
                    break;
                case "мазь":
                    new Treatment(new OintmentTreatmentState()).Request();
                    break;
                case "таблетка":
                    new Treatment(new TabletTreatmentState()).Request();
                    break;
                case "аптечка":
                    new Treatment(new MedpackTreatmentState()).Request();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Персонаж погиб. Спасибо за внимание.");
                    Console.ReadLine();
                    return;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            TreatmentInfo();
            Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла оибка");
            }
        }
    }
}
