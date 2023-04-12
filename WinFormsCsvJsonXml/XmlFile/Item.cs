using System;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Data;
using System.IO;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;
using System.Xml;

namespace ParserJsonCsvToXml.XmlFile
{
    // Этот класс описывает модель сериализации файла  res.xml.
    public class Item
    {

        [XmlElement("node")]
        public string node { get; set; }
        [XmlElement("addr")]
        public string address { get; set; }
    }


}
