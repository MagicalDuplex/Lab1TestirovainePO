using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace laba1
{
    [TestFixture]
    class HRDfunctionsTest
    {
        [Test]
        public void DataAboutWorkerAddTest()
        {
            string name = "Имя";
            string secondname = "Фамилия";
            string age = "25";
            string monthsWorkedOut = "7";
            string[] dataAboutWorker = { "Имя","Фамилия","252222","7"};
            Assert.AreNotEqual(dataAboutWorker, HumanResourcesDepartmentFunctions.DataAboutWorkerAdd(name, secondname, age, monthsWorkedOut));
        }

        [Test]
        public void ExistPersonTest()
        {
            long pasportSeriesAndNumber = 2727899067;
            List<long> bdWorkers = new List<long>() { 2729898212, 2927785656, 2727899067 };
            Assert.IsTrue(HumanResourcesDepartmentFunctions.ExistPerson(pasportSeriesAndNumber, bdWorkers));
        }

        [Test]
        public void SalaryForDayTest()
        {
            int hours = 8;
            int priceForHour = 100;
            int position = 3;
            int salary = 1112;
            Assert.AreEqual(salary, HumanResourcesDepartmentFunctions.SalaryForDay(hours, priceForHour, position));
        }

        [Test]
        public void UpdateWorkedoutHoursesTest()
        {
            int LastWorkedTime = 26;
            int AddWorkedTime = 8;
            int UpdateWorkedTime = 34;
            Assert.AreEqual(UpdateWorkedTime, HumanResourcesDepartmentFunctions.UpdateWorkedoutHourses(LastWorkedTime, AddWorkedTime));
        }

        [Test]
        public void DataAboutSelectedWorkerTest()
        {
            int id = 1;
            string[][] bdWorkers = new string[3][];
            bdWorkers[0] = new string[4] { "Имя1","Фамилия1","24","7"};
            bdWorkers[1] = new string[4] { "Имя2", "Фамилия2", "31", "12" };
            bdWorkers[2] = new string[4] { "Имя3", "Фамилия3", "26", "6" };
            string data = "Имя = Имя2, Фамилия = Фамилия2, Возраст = 31, Число отработанных месяцев = 12.";
            Assert.AreEqual(data, HumanResourcesDepartmentFunctions.DataAboutSelectedWorker(id, bdWorkers));
        }
    }
}
