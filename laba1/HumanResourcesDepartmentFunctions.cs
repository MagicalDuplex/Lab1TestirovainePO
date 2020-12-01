using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace laba1
{
    class HumanResourcesDepartmentFunctions
    {

        // Метод, заносящий данные о работнике в массив
        public static string[] DataAboutWorkerAdd(string name,string secondname, string age, string monthsWorkedOut)
        {
            string[] dataAboutWorker = new string[4];
            dataAboutWorker[0] = name;
            dataAboutWorker[1] = secondname;
            dataAboutWorker[2] = age;
            dataAboutWorker[3] = monthsWorkedOut;

            return dataAboutWorker;
        }

        // Данный метод проверяет существование человека по паспорту в БД рабочих
        public static bool ExistPerson(long pasportSeriesAndNumber, List<long> bdWorkers)
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
        public static int SalaryForDay(int hours,int priceForHour,int position)
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
        public static int UpdateWorkedoutHourses(int LastWorkedTime, int AddWorkedTime)
        {
            int UpdateWorkedTime = LastWorkedTime + AddWorkedTime;
            return UpdateWorkedTime;
        }

        // Метод осуществляющий вывод данных о рабочем
        public static string DataAboutSelectedWorker(int id, string[][] bdWorkers)
        {
            string data = "Имя = " + bdWorkers[id][0] +
                ", Фамилия = "+ bdWorkers[id][1] +
                ", Возраст = "+ bdWorkers[id][2] +
                ", Число отработанных месяцев = "+bdWorkers[id][3]+".";
            return data;
        }
    }
}
