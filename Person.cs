
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace laba16_OOP
{
    [Serializable]
    [JsonDerivedType(typeof(Person), typeDiscriminator: "Person")]
    [JsonDerivedType(typeof(Student), typeDiscriminator: "Student")]
    [JsonDerivedType(typeof(ParttimeStudent), typeDiscriminator: "ParttimeStudent")]
    [JsonDerivedType(typeof(Schoolboy), typeDiscriminator: "Schoolboy")]
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Schoolboy))]
    public class Person : IRandomInit, IComparable, ICloneable<Person>
    {
        protected string FirstName;
        protected string LastName;
        protected int age;
        public static Random rnd = new Random();
  
        protected string[] firstnames = { "Данил", "Николай", "Артем", "Михаил" };
        protected string[] lastnames = { "Мальцев", "Ильин", "Постников", "Маркушев" };
        public Person(string firstName, string lastName, int age)
        {
            Firstname = firstName;
            Lastname = lastName;
            this.age = age;
        }
        public Person(int age)
        {
            Firstname = firstnames[rnd.Next(0, firstnames.Length)];
            Lastname = lastnames[rnd.Next(0, lastnames.Length)];
            this.age = age;
         

        }
        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string Lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(Person person)
        {
            this.age = person.age;
         
        }
        public Person()
        {
         
        }
        virtual public void Show()
        {
            Console.WriteLine($"Name: {Firstname} {Lastname} Age: {age} ");
        }
        public int CompareTo(Object? obj)
        {
            if (obj is Person other)
                return this.Age.CompareTo(other.Age);
            else
                throw new ArgumentException("Object is not an Person");
        }
        public virtual Person RandomInit()
        {
            this.Firstname = firstnames[IRandomInit.rnd.Next(0, firstnames.Length)];
            this.Lastname = lastnames[IRandomInit.rnd.Next(0, lastnames.Length)];
            this.Age = IRandomInit.rnd.Next(10, 100);
            return this;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{this.GetType().Name}:\tage: {Age} year");
        }
        public override string ToString()
        {
            return $"Имя: {FirstName} {LastName},Возраст: {Age}";
        }
        public virtual Person Clone()
        {
            var temp = new Person(this.Age);
            return temp;
        }
        public object ShallowCopy()
        {
            return MemberwiseClone();
        }

    }
    [Serializable]
    [XmlInclude(typeof(ParttimeStudent))]
    public class Student : Person
    {

        protected string group;
        protected int yearofstudy;
       
        protected string[] groups = { "РИС-21-1Б", "РИС-21-2Б", "ИВТ-21-2","МИР-21", "ИВТ-21-1" };
        public int counter(int cours)
        {
            if (this.yearofstudy == cours)
                return 1;
            else return 0;
        }

        public int YearOfStudy
        {
            get
            {
                return yearofstudy;
            }
            set { yearofstudy = value; }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set { group = value; }
        }
        public string Name
        {
            get
            {
                return FirstName;
            }
        }
        public Student(int age, int tmp) : base(age)
        {
            this.YearOfStudy = tmp;
            group = groups[rnd.Next(0, groups.Length)];
        }
        public Student() : base()
        {
            group = groups[1];
            yearofstudy = 1;
        }


        public Student(string firstname, string lastname, string group, int yearOfStudy, int age) : base(firstname, lastname, age)
        {
            this.group = group;
            this.yearofstudy = yearOfStudy;

        }

        public override Person Clone()
        {
            var temp = new Student(this.Age, this.YearOfStudy);
            return temp;
        }


      
        public override Person RandomInit()
        {
            base.RandomInit();
            this.Group = groups[IRandomInit.rnd.Next(0, groups.Length)];
            return this;
        }
        public override string ToString()
        {
            return $"Имя: {Firstname} {Lastname}, Возраст: {Age},Курс: {YearOfStudy}, Група: {group}";
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Name: {FirstName} {LastName} group: {group} cours: {yearofstudy}");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Группа: {group}\nКурс: {YearOfStudy}");
        }

    }
    [Serializable]
    public class ParttimeStudent : Student
    {
        private bool PartTime;
        public ParttimeStudent(string firstname, string lastname, string group, bool PartTime, int yearOfStudy, int age) : base(firstname, lastname, group, yearOfStudy, age)
        {
            this.PartTime = PartTime;
        }
        public ParttimeStudent() : base()
        {
            PartTime = true;
        }
        public ParttimeStudent(int age, int tmp) : base(age, tmp)
        {
            PartTime = true;
        }
        public override void Show()
        {
            base.Show();
            if (PartTime)
            {
                Console.WriteLine("Форма обучение: заочное");
            }
        }
        public override Person Clone()
        {
            var temp = new ParttimeStudent(this.Age, this.yearofstudy);
           
            return temp;
        }
        public override string ToString()
        {
            if (PartTime)
                return $"Имя: {Firstname} {Lastname}, Возраст: {Age}, Курс: {YearOfStudy}, Группа: {group}, заочное";
            else return $"Имя: {Firstname} {Lastname}, Возраст: {Age}, Курс: {YearOfStudy}, Группа: {group}";
        }
        public override Person RandomInit()
        {
            base.RandomInit();
            this.PartTime = true;
            return this;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();

            if (PartTime)
            {
                Console.WriteLine("Форма обучение: заочное");
            }
        }

    }
    [Serializable]
    public class Schoolboy : Person
    {
        private int Class;

        public int Klass
        {
            get { return Class; }
            set { Class = value; }
        }
        public Schoolboy(string firstname, string lastname, int Class, int age) : base(firstname, lastname, age)
        {
            this.Class = Class;
        }
        public static Random rnd = new Random();

        public Schoolboy() : base()
        {
            Class = 11;
        }
        public Schoolboy(int age, int klas) : base(age)
        {
            Class = klas;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Name: {FirstName} {LastName} Age: {Age} Class: {Class}");
        }
        public override Person Clone()
        {
            var temp = new Schoolboy(this.Age, this.Class);
        
            return temp;
        }
        public override Person RandomInit()
        {
            base.RandomInit();
            Class = IRandomInit.rnd.Next(1, 11);
            return this;
        }
        public override string ToString()
        {
            return $"Имя: {FirstName} {LastName}, Возраст: {Age}, Класс: {Class}";
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Класс: {Class}");
        }


    }
}
