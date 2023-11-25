using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2_indTask
{
    internal abstract class Person
    {
        /// <summary>
        /// Поля + геттеры-сеттеры
        /// </summary>
        private Dictionary<string, string> FullName = new Dictionary<string, string>()
        {
            { "Фамилия", "не указано" },
            { "Имя", "не указано" },
            { "Отчество", "не указано" }
        };
        private int age = 0;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        /// <summary>
        /// Методы (в т.ч. и виртуальный)
        /// </summary>
        public virtual void OutInfo()
        {
            OutFullName();
            OutAge();
        }
        public void OutFullName()
        {
            foreach (KeyValuePair<string, string> entry in FullName)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
        public void OutAge()
        {
            Console.WriteLine("Возраст: " + Age);
        }
        public void SetOrReplaceName(string surname, string name, string patronymic)
        {
            FullName["Фамилия"] = surname;
            FullName["Имя"] = name;
            FullName["Отчество"] = patronymic;
        }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Person() { }
        public Person(int _age)
        {
            this.Age = _age;
        }
        public Person(string _surname, string _name, string _patronymic)
        {
            this.SetOrReplaceName(_surname, _name, _patronymic);
        }
        public Person(string _surname, string _name, string _patronymic, int _age)
        {
            this.SetOrReplaceName(_surname, _name, _patronymic);
            this.Age = _age;
        }
    }
}
