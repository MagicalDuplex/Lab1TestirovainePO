using System.Collections.Generic;
using NUnit.Framework;
using static laba1.HumanResourcesDepartmentFunctions;

namespace laba1
{
    [TestFixture]
    public class HRDfunctionsTest
    {
        HumanResourcesDepartmentFunctions hrdf;
        [SetUp]
        public void SetUp()
        {
            hrdf = new HumanResourcesDepartmentFunctions();
            Dictionary<long, Worker> workers = new Dictionary<long, Worker>();
            workers.Add(1000050000, new Worker { name = "name1", secondname = "sn1", age = 22, monthsWorkedOut = 14, position = 1 });
            workers.Add(1000050001, new Worker { name = "name2", secondname = "sn2", age = 27, monthsWorkedOut = 18, position = 2 });
            workers.Add(1000050002, new Worker { name = "name3", secondname = "sn3", age = 26, monthsWorkedOut = 7, position = 1 });
            workers.Add(1000050003, new Worker { name = "name4", secondname = "sn4", age = 32, monthsWorkedOut = 27, position = 4 });
            workers.Add(1000050004, new Worker { name = "name5", secondname = "sn5", age = 30, monthsWorkedOut = 22, position = 3 });

            foreach (var worker in workers)
            {
                hrdf.AddNewWorker(worker.Key, worker.Value);
            }
        }

        [Test]
        public void UpdateWorkedoutHoursesTest()
        {
            Assert.IsTrue(hrdf.UpdateWorkedoutHourses(1000050000, 15));
            Assert.IsTrue(hrdf.UpdateWorkedoutHourses(1000050001, 18));
        }

        [Test]
        public void DataAboutSelectedWorkerTest()
        {
            string data1 = "Имя = name1, Фамилия = sn1, Возраст = 22, Число отработанных месяцев = 14, Должностной ранг = 1.";
            string data2 = "Имя = name2, Фамилия = sn1, Возраст = 28, Число отработанных месяцев = 14, Должностной ранг = 1.";
            Assert.AreEqual(data1, hrdf.DataAboutSelectedWorker(1000050000));
            Assert.AreNotEqual(data2, hrdf.DataAboutSelectedWorker(1000050000));
        }

        [Test]
        public void AddNewWorkerTest()
        {
            Assert.AreEqual(true, hrdf.AddNewWorker(1000050005, new Worker { name = "name6", secondname = "sn6", age = 27, monthsWorkedOut = 0, position = 1 }));
            Assert.IsFalse(hrdf.AddNewWorker(1000, new Worker { name = "name7", secondname = "sn7", age = 23, monthsWorkedOut = 0, position = 1 }));
        }

        [Test]
        public void DeleteWorkerTest()
        {
            Assert.IsTrue(hrdf.DeleteWorker(1000050003));
            Assert.IsFalse(hrdf.DeleteWorker(0));
            Assert.IsFalse(hrdf.DeleteWorker(10000000));
        }

        [Test]
        public void ExistWorkerTest()
        {
            Assert.IsTrue(hrdf.ExistWorker(1000050000));
            Assert.IsFalse(hrdf.ExistWorker(1000050010));
            Assert.IsFalse(hrdf.ExistWorker(1000050011));
        }

        [Test]
        public void SalaryForDayTest()
        {
            Assert.AreEqual(800, hrdf.SalaryForDay(1000050000, 100, 8));
            Assert.AreEqual(1280, hrdf.SalaryForDay(1000050003, 100, 8));
            Assert.AreNotEqual(1270, hrdf.SalaryForDay(1000050003, 100, 8));
        }
    }
}
