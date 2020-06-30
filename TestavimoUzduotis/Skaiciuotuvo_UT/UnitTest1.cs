using System;
using TestavimoUzduotis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Skaiciuotuvo_UT
{
    [TestClass]
    public class Skaiciuotuvas_UT
    {
        [TestMethod]
        
        public void SudetiesMetodoTestavimas_SkaiciuSudetis_ExpectedIsTrue()
        {
            Skaiciuotuvas test1 = new Skaiciuotuvas();
            double a=1.2425;
            double b=1.2425;

            var result =double.TryParse(Convert.ToString(test1.Sudeti(a, b)),out _);
            
            Assert.IsTrue(result);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AtimtiesBetSiaipDalybostestavimas_DalybaIsNulio_ExpectedException()
        {
            Skaiciuotuvas test2 = new Skaiciuotuvas();
            double a = 2;
            double b = 0;

            var result = test2.Atimti(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LimituTestas1_KaiXMazesnisUzLimita_ExpectedException()
        {
            Skaiciuotuvas test3 = new Skaiciuotuvas();
            double a = 1;
            double b = 12;
            double c = 3;
            double d = 14;

            var result = test3.PridetiLimitus(a, b,c,d);
        }
    }
}
