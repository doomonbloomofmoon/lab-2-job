using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_indTask
{
    internal class Worker : Person
    {
        /// <summary>
        /// Поля + геттеры-сеттеры
        /// </summary>
        public List<string> Positions = new List<string>();
        private int workExperience = 0;
        public int WorkExperience
        {
            get
            {
                return workExperience;
            }
            set
            {
                if (workExperience < 0)
                {
                    workExperience = 0;
                }
                else
                {
                    workExperience = value;
                }
            }
        }

        /// <summary>
        /// Методы
        /// </summary>
        public override void OutInfo()
        {
            base.OutInfo();
            OutWorkExperience();
            OutPositions();
        }
        public void OutWorkExperience()
        {
            Console.WriteLine("Стаж работы: " + WorkExperience);
        }
        public void OutPositions()
        {
            Console.Write("Должности: ");
            bool isEmpty = Positions.Count == 0 ? true : false;
            if (isEmpty)
            {
                Console.WriteLine("отсутствуют");
            }
            else 
            {
                Positions.ForEach(x => Console.Write(x + "  "));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Worker() { }
        public Worker(int _age) : base(_age) { }
        public Worker(string _surname, string _name, string _patronymic) : base(_surname, _name, _patronymic) { }
        public Worker(string _surname, string _name, string _patronymic, int _age) : base(_surname, _name, _patronymic, _age) { }
    }
}

