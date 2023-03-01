using System.Reflection;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
            person.output();
            Console.WriteLine("Введите кол-во людей");
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] arr = new Person[n];
            for (int i = 0;i < arr.Length; i++)
            {
                arr[i] = new Person();
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].input();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].surname);
                Console.WriteLine(arr[i].name[0]);
                Console.WriteLine(arr[i].age());
                if (arr[i].Gender == '1')
                {
                    Console.WriteLine($"Пол : мужской");
                }
                if (arr[i].Gender == '2')
                {
                    Console.WriteLine($"Пол : женский");
                }
                Console.WriteLine();

            }
        }
        class Person
        {
            public string surname { get; set; }
            public string name { get; set; }
            public DateTime dateTime { get; set; } = new DateTime();
            private char _gender;
            public char Gender
            {
                get { return _gender; }
                set
                {
                    if ((value == '1')||(value == '2'))
                    {
                        _gender = value;
                    };
                }
            }


            public Person()
            {
                surname = "Mozharova";
                name = "Ksusha";
                dateTime = new DateTime(2004, 7, 4);
                Gender = '2';
            }
            public Person(string surname, string name, DateTime dateTime, char Gender)
            {
                this.surname = surname;
                this.name = name;
                this.dateTime = dateTime;
                this.Gender = Gender;
            }


            public void input()
            {
                Console.WriteLine("Введите фамилию");
                surname = Console.ReadLine();
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения в формате год, месяц, день");
                dateTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите пол(1 - мужской;2 - женский)");
                Gender = (char)Console.Read();
            }
            public void output()
            {
                Console.WriteLine($"Фамилия: {surname}");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Возраст: {age()}");
                if (Gender == '1')
                {
                    Console.WriteLine($"Пол : мужской");
                }
                if (Gender == '2')
                {
                    Console.WriteLine($"Пол : женский");
                }
            }
            public override string ToString()
            {
                if (Gender == '1')
                {
                    return "Person: " + surname + " " + name + " " + dateTime + " " + " мужской";
                }
                else
                    return "Person: " + surname + " " + name + " " + dateTime + " " + "женский";
            }
            public int age()
            {
            //    DateTime dateTimeNow = new DateTime();
            //    Console.WriteLine("Введите сегодняшнюю дату в порядке год,месяц,число");
            //    dateTimeNow = DateTime.Parse(Console.ReadLine());
            //    Console.WriteLine(dateTimeNow);
                int k = 0;

                if (DateTime.Today.Month>= dateTime.Month)
                {
                    if (DateTime.Today.Day >= dateTime.Day)
                    {
                        k = DateTime.Today.Year - dateTime.Year;
                        return k;
                    }

                }
                else
                    k = DateTime.Today.Year - dateTime.Year - 1;
                return k;
            }

        }
    }
}