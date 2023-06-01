using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.Xml;

namespace laba16_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPerson_Click(object sender, EventArgs e)
        {
            var personType = new Random().Next(1, 5);
            switch ((Enums.AddMenu)personType)
            {
                case Enums.AddMenu.Person:
                    {
                        Program.list.Add(new Person().RandomInit());
                        break;
                    }
                case Enums.AddMenu.Student:
                    {
                        Program.list.Add(new Student().RandomInit());
                        break;
                    }
                case Enums.AddMenu.ParttimeStudent:
                    {
                        Program.list.Add(new ParttimeStudent().RandomInit());
                        break;
                    }
                case Enums.AddMenu.SchoolBoy:
                    {
                        Program.list.Add(new Schoolboy().RandomInit());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Program.PrintCollection(Program.list, this);
        }

        private void Sorting_CheckedChanged(object sender, EventArgs e)
        {
            Program.PrintCollection(Program.list, this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Program.grouping = 2;
            Program.PrintCollection(Program.list, this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.grouping = 1;
            Program.PrintCollection(Program.list, this);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Program.grouping = 3;
            Program.PrintCollection(Program.list, this);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Program.grouping = 4;
            Program.PrintCollection(Program.list, this);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Program.grouping = 0;
            Program.PrintCollection(Program.list, this);
        }

        private void AgeFilter_TextChanged_1(object sender, EventArgs e)
        {
            Program.PrintCollection(Program.list, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var deleteWindow = new DeleteForm();
            deleteWindow.ShowDialog();
            Program.PrintCollection(Program.list, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var alterForm = new AlterForm();
            alterForm.ShowDialog();
            Program.PrintCollection(Program.list, this);
        }

        private void XmlSaveButton_Click(object sender, EventArgs e)
        {
            Printer.XmlSave(Program.list, "xml files (*.xml)|*.xml");
        }

        private void binarySaveButton_Click(object sender, EventArgs e)
        {
            Printer.BinarySave(Program.list, new BinaryFormatter(), "bin files (*.bin)|*.bin");
        }

        private void jsonSaveButton_Click(object sender, EventArgs e)
        {
            Printer.JsonSave(Program.list, "json files (*.json)|*.json");
        }
        private void binaryLoadButton_Click(object sender, EventArgs e)
        {
            Program.list = Loader.BinaryLoad(Program.list, new BinaryFormatter(), "bin files (*.bin)|*.bin");
            Program.PrintCollection(Program.list, this);
        }

        private void jsonLoadButton_Click(object sender, EventArgs e)
        {
            Program.list = Loader.JsonLoad(Program.list, "json files (*.json)|*.json");
            Program.PrintCollection(Program.list, this);
        }

        private void XmlLoadButton_Click(object sender, EventArgs e)
        {
            Program.list = Loader.XmlLoad(Program.list, "xml files (*.xml)|*.xml");
            Program.PrintCollection(Program.list, this);
        }
    }
}