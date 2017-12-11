using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInterface
{
    public static class Baglanti
    {
        private static string _baglantiCumlecigi = "Server=.;Database=404Hotel;integrated Security=true";
        private static string _baglantiCumlecigiMARS = "Server=.;Database=404Hotel;integrated Security=true;MultipleActiveResultSets=true";
        public static string BaglantiCumlecigiMARS
        {
            get { return Baglanti._baglantiCumlecigiMARS; }
        }
        public static string BaglantiCumlecigi
        {
            get { return Baglanti._baglantiCumlecigi; }
            
        }

    }
}