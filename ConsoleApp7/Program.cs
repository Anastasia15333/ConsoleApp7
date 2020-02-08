using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp7
{
    class Delo
    {
        private string dobavlenie;
        private int time;
        private bool vypolnenie;
        public Delo()
        {
        }
        public Delo(string dobavlenie, int time, bool vypolnenie)
        {
            this.dobavlenie = dobavlenie;
            this.time = time;
            this.vypolnenie = vypolnenie;
        }
        public string Dobavlenie
        {
            get
            {
                return dobavlenie;
            }

            set
            {
                dobavlenie = value;
            }
        }
        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }

        }
        public bool Vypolnenie
        {
            get
            {
                return vypolnenie;
            }

            set
            {
                vypolnenie = value;
            }
        }
        public void ShowDelo()
        {
            Console.WriteLine("Дело: {0}, Время: {1}, Выполнение: {0}", Dobavlenie, Time, Vypolnenie);
        }
    }

    class SpisokDel
    {
        private List<Delo> delos = new List<Delo>();
        public SpisokDel()
        {
        }
        public void AddDelo()
        {
            Console.Write("Введите дело: ");
            string Delo = Convert.ToString(Console.ReadLine());
            Console.Write("Введите время: ");
            int Time = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выполнено/не выполнено: ");
            bool Vypolnenie = Convert.ToBoolean(Console.ReadLine());
            delos.Add(new Delo(Delo, Time, Vypolnenie));
        }
        public void Show()
        {
            foreach (var delo in delos)
            {
                Console.WriteLine(delo.Dobavlenie.ToString() + " " + delo.Time.ToString() + " " + delo.Vypolnenie.ToString());
            }
        }
        public Delo Nevup()
        {
            foreach (Delo z in delos)
            {
                if (z.Vypolnenie == true)
                {
                    delos.Remove(z);
                    return z;
                }

            }
            return null;
        }

        public void Menu()
        {
            int control = 0;
            while (control != 4)
            {
                Console.WriteLine("Сделайте выбор: 1 - Добавить дело, 2 - Вывести дело, 3 - Удалить дело, 4 - Выход.");
                control = Convert.ToInt32(Console.ReadLine());
                switch (control)
                {
                    case 1:
                        AddDelo();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Nevup();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                SpisokDel sp = new SpisokDel();
                sp.Menu();
            }
        }
    }
}

