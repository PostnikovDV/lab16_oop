using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace laba16_OOP
{
    internal class Printer
    {
        static public void BinarySave(circulardoublelist<Person> list, BinaryFormatter printer, string filter)
        {
            Stream stream;
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    printer.Serialize(stream, list);
                    stream.Close();
                }
            }
        }
        static public void JsonSave(circulardoublelist<Person> list, string filter)
        {
            Stream stream;
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    JsonSerializer.Serialize(stream, list, new JsonSerializerOptions() { WriteIndented = true, IncludeFields = true });
                    stream.Close();
                }
            }
        }
        static public void XmlSave(circulardoublelist<Person> list, string filter)
        {
            Stream stream;
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;

            var serializer = new XmlSerializer(typeof(circulardoublelist<Person>));

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    serializer.Serialize(stream, list);
                    stream.Close();
                }
            }
        }
    }
}
