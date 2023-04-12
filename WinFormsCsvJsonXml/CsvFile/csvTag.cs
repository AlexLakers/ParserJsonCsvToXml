using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ParserJsonCsvToXml.CsvFile
{
    // Этот класс описывает модель для десериализации файла Init.csv.
    public class csvTag
    {
        public csvTag(string _tag, string _type, string _address) { Varble = _tag; Type = _type; Addr = _address; }

        [DisplayName("Переменная")]
        public string Varble { get; set; }
        [DisplayName("Тип")]
        public string Type { get; set; }
        [DisplayName("Адрес")]
        public string Addr { get; set; }


    }
}
