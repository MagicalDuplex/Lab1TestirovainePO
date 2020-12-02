using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace laba1
{
    class HumanResourcesDepartmentFunctions
    {
        public string name { get; set; }
        public string secondname { get; set; }
        public string age { get; set; }
        public string monthsWorkedOut { get; set; }
        public long pasportSeriesAndNumber { get; set; }
        public List<long> bdWorkers { get; set; }
        public int hours { get; set; }
        public int priceForHour { get; set; }
        public int position { get; set; }
        public int LastWorkedTime { get; set; }
        public int AddWorkedTime { get; set; }
        public int id { get; set; }
        public string[][] bdWorkerss { get; set; }

        // Метод, заносящий данные о работнике в массив
        public string[] DataAboutWorkerAdd()
        {
            string[] dataAboutWorker = new string[4];
            dataAboutWorker[0] = name;
            dataAboutWorker[1] = secondname;
            dataAboutWorker[2] = age;
            dataAboutWorker[3] = monthsWorkedOut;

            return dataAboutWorker;
        }

        // Данный метод проверяет существование человека по паспорту в БД рабочих
        public bool ExistPerson()
        {
            if (bdWorkers.Contains(pasportSeriesAndNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Метод, считающий заработную плату за день
        // position - должностной ранг
        public int SalaryForDay()
        {
            int salary = 0;
            switch (position)
            {
                case 1:
                    salary = hours * priceForHour;
                    break;
                case 2:
                    salary = (int)(hours * priceForHour * 1.28);
                    break;
                case 3:
                    salary = (int)(hours * priceForHour * 1.39);
                    break;
                case 4:
                    salary = (int)(hours * priceForHour * 1.6);
                    break;
                default:
                    salary = 0;
                    break;
            }
            return salary;
        }

        // Метод, осуществляющий обновление учтенного отработанного врмени
        public int UpdateWorkedoutHourses()
        {
            int UpdateWorkedTime = LastWorkedTime + AddWorkedTime;
            return UpdateWorkedTime;
        }

        // Метод осуществляющий вывод данных о рабочем
        public string DataAboutSelectedWorker()
        {
            string data = "Имя = " + bdWorkerss[id][0] +
                ", Фамилия = "+ bdWorkerss[id][1] +
                ", Возраст = "+ bdWorkerss[id][2] +
                ", Число отработанных месяцев = "+bdWorkerss[id][3]+".";
            return data;
        }
    }
}
