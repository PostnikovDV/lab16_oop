using laba16_OOP;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace laba16_OOP
{
    internal static class Program
    {
        public static circulardoublelist<Person> list = new circulardoublelist<Person>();
        public static int grouping = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static void PrintCollection(circulardoublelist<Person> persons, Form1 form)
        {
            int age = 0;
            int count = 1;
            IEnumerable<Person> ans = new List<Person>();
            switch ((Enums.AddMenu)grouping)
            {
                case Enums.AddMenu.Person:
                    {
                        ans = from person in persons where person is Person select person;
                        break;
                    }
                case Enums.AddMenu.Student:
                    {
                        ans = from person in persons where person is Student select person;
                        break;
                    }
                case Enums.AddMenu.ParttimeStudent:
                    {
                        ans = from person in persons where person is ParttimeStudent select person;
                        break;
                    }
                case Enums.AddMenu.SchoolBoy:
                    {
                        ans = from person in persons where person is Schoolboy select person;
                        break;
                    }
                default:
                    {
                        ans = from person in persons select person;
                        break;
                    }
            }
            if (IsInt(form.AgeFilter.Text))
            {
                age = Int32.Parse(form.AgeFilter.Text);
                ans = from person in ans where new Regex("^" + age.ToString()).IsMatch(person.Age.ToString()) select person;
            }
            if (form.sorting.Checked == true)
            {
                ans = ans.OrderBy(x => x.Age);
            }
            form.mainTextBox.Clear();
            form.mainTextBox.Text = "[\r\n";
            foreach (var person in ans)
            {
                form.mainTextBox.Text += "  " + list.FindIndex((Person t1, Person t2) => t1 == t2, person) + "\t" + person.ToString() + "\r\n";
                count++;
            }
            form.mainTextBox.Text += "]\r\n";
        }
        public static bool IsInt(string line)
        {
            Regex reg = new Regex("^[1234567890]+$");
            if (reg.IsMatch(line))
            {
                return true;
            }
            return false;
        }
    }
}