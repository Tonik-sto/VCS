using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_testing_1
{
    public class Class1
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not even");
        }
        [Test]
        public static void TestNowIs18()
        {
            DateTime CurrentTime = DateTime.Now;
            //Assert.AreEqual(19, CurrentTime.Hour, "Dabar yra 18 valanda");
            Assert.IsTrue(CurrentTime.Hour.Equals(19), "Dabar ne 19 valanda");
        }

        // Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        [Test]
        public static void TestIf995IsDivideBy3()
        {
            int isDevide = 995 % 3;
            Assert.AreEqual(2, isDevide, "Sakicius 995 nesidalina is 3 be liekanos");
        }
        // Testas “žalias” jeigu šiandien pirmadienis(DayOfWeek.Monday)
        [Test]
        public static void TestTodayIsMonday()
        {
            DateTime todayDay = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Monday, todayDay.DayOfWeek, "Siandien yra pirmadienis.");
        }

        // Testas “žalias” po to kai “palaukia” 5 sekundes
        [Test]
        public static void TestWait5Sec()
        {
            Thread.Sleep(5000);
        }


    }
}
