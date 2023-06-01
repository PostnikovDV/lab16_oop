using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace laba16_OOP
{
    internal class Loader
    {
        static public circulardoublelist<Person> BinaryLoad(circulardoublelist<Person> list, BinaryFormatter reader, string filter)
        {
            circulardoublelist<Person> newPersons = new circulardoublelist<Person>();
            Stream stream;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    newPersons = (circulardoublelist<Person>)reader.Deserialize(stream);
                    stream.Close();
                }
            }
            return newPersons;
        }
        static public circulardoublelist<Person> JsonLoad(circulardoublelist<Person> list, string filter)
        {
            circulardoublelist<Person>? newPersons = new circulardoublelist<Person>();
            Stream stream;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    newPersons = JsonSerializer.Deserialize<circulardoublelist<Person>>(stream);
                    stream.Close();
                }
            }
            return newPersons;
        }
        static public circulardoublelist<Person> XmlLoad(circulardoublelist<Person> list, string filter)
        {
            circulardoublelist<Person> newPersons = new circulardoublelist<Person>();
            Stream stream;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.RestoreDirectory = true;
            var serializer = new XmlSerializer(typeof(circulardoublelist<Person>));

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    newPersons = (circulardoublelist<Person>)serializer.Deserialize(stream);
                    stream.Close();
                }
            }
            return newPersons;
        }
    }
}
