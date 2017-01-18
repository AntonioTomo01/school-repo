using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housePRice
{
    class Program
    {
        static void Main(string[] args)
        {
            double naiMalkaStaya = double.Parse(Console.ReadLine());
            double kuhnya = double.Parse(Console.ReadLine());
            double cenaKvadratenMetur = double.Parse(Console.ReadLine());

            double banya = naiMalkaStaya / 2;
            double vtoraStaya = (naiMalkaStaya / 100) * 110;
            double tretaStaya = (vtoraStaya / 100) * 110;
            double obshtaPlosht = naiMalkaStaya + kuhnya + banya + vtoraStaya + tretaStaya;
            double obshtaPloshtSkoridor = (obshtaPlosht / 100) * 105;

            double cena = cenaKvadratenMetur * obshtaPloshtSkoridor;

            Console.WriteLine("{0:F2}", cena);
        }
    }
}
