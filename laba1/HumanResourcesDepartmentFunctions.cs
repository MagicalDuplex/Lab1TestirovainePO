﻿using System.Collections.Generic;

namespace laba1
{
    class HumanResourcesDepartmentFunctions
    {

        // ключ - серия и номер паспорта
        private Dictionary<long, Worker> Workers { get; set; }

        public HumanResourcesDepartmentFunctions()
        {
            Workers = new Dictionary<long, Worker>();
        }

        public struct Worker
        {
            public string firstname { get; set; }
            public string secondname { get; set; }
            public int age { get; set; }
            public int monthsWorkedOut { get; set; }
            public int position { get; set; }
        }

        // Добавление новго работника
        public bool AddNewWorker(long pasport, Worker worker)
        {
            if (!ExistWorker(pasport))
            {
                string pasportLenght = pasport.ToString();
                if (pasportLenght.Length != 10)
                    return false;
                else
                {
                    Workers.Add(pasport, worker);
                    return true;
                }
            }
            else
                return false;
        }

        // Удаление работника
        public bool DeleteWorker(long pasport)
        {
            if (ExistWorker(pasport))
            {
                Workers.Remove(pasport);
                return true;
            }
            else
                return false;
        }

        // Проверка существования работника
        public bool ExistWorker(long pasport)
        {
            if (Workers.ContainsKey(pasport))
                return true;
            else
                return false;
        }

        // Метод, считающий заработную плату за день
        // position - должностной ранг
        public int SalaryForDay(long pasport, int priceForHour, int hours)
        {
            int position = -1;
            if (ExistWorker(pasport))
                position = Workers[pasport].position;
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
        public bool UpdateWorkedoutHourses(long pasport, int newMonthsWorkedOut)
        {
            if (ExistWorker(pasport) && newMonthsWorkedOut > -1 && newMonthsWorkedOut < 1000)
            {
                var worker = Workers[pasport];
                worker.monthsWorkedOut = newMonthsWorkedOut;
                Workers[pasport] = worker;
                return true;
            }
            else
                return false;
        }

        // Метод осуществляющий вывод данных о рабочем
        public string DataAboutSelectedWorker(long pasport)
        {
            string data = "Данного работника не существует!";
            if (ExistWorker(pasport))
            {
                string name = Workers[pasport].firstname;
                string secondname = Workers[pasport].secondname;
                string age = Workers[pasport].age.ToString();
                string monthsWorkedOut = Workers[pasport].monthsWorkedOut.ToString();
                string position = Workers[pasport].position.ToString();
                data = "Имя = " + name +
                    ", Фамилия = "+ secondname +
                    ", Возраст = "+ age +
                    ", Число отработанных месяцев = "+monthsWorkedOut+
                    ", Должностной ранг = "+position+".";
            }
            return data;
        }
    }
}
