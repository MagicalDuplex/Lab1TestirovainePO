using System.Collections.Generic;
using NUnit.Framework;

namespace laba1
{
    [TestFixture]
    class HRDfunctionsTest
    {
        HumanResourcesDepartmentFunctions hrdf;
        [SetUp]
        public void SetUp()
        {
            hrdf = new HumanResourcesDepartmentFunctions();
        }

        [Test]
        public void DataAboutWorkerAddTest()
        {
            hrdf.name = "Имя";
            hrdf.secondname = "Фамилия";
            hrdf.age = "25";
            hrdf.monthsWorkedOut = "7";
            string[] dataAboutWorker = { "Имя","Фамилия","252222","7"};
            Assert.AreNotEqual(dataAboutWorker, hrdf.DataAboutWorkerAdd());
        }

        [Test]
        public void ExistPersonTest()
        {
            hrdf.pasportSeriesAndNumber = 2727899067;
            hrdf.bdWorkers = new List<long>() { 2729898212, 2927785656, 2727899067 };
            Assert.IsTrue(hrdf.ExistPerson());
        }

        [Test]
        public void SalaryForDayTest()
        {
            hrdf.hours = 8;
            hrdf.priceForHour = 100;
            hrdf.position = 3;
            int salary = 1112;
            Assert.AreEqual(salary, hrdf.SalaryForDay());
        }

        [Test]
        public void UpdateWorkedoutHoursesTest()
        {
            hrdf.LastWorkedTime = 26;
            hrdf.AddWorkedTime = 8;
            int UpdateWorkedTime = 34;
            Assert.AreEqual(UpdateWorkedTime, hrdf.UpdateWorkedoutHourses());
        }

        [Test]
        public void DataAboutSelectedWorkerTest()
        {
            hrdf.id = 1;
            hrdf.bdWorkerss = new string[3][];
            hrdf.bdWorkerss[0] = new string[4] { "Имя1","Фамилия1","24","7"};
            hrdf.bdWorkerss[1] = new string[4] { "Имя2", "Фамилия2", "31", "12" };
            hrdf.bdWorkerss[2] = new string[4] { "Имя3", "Фамилия3", "26", "6" };
            string data = "Имя = Имя2, Фамилия = Фамилия2, Возраст = 31, Число отработанных месяцев = 12.";
            Assert.AreEqual(data, hrdf.DataAboutSelectedWorker());
        }
    }
}
