using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserJsonCsvToXml.JsonFile
{
    // Этот класс описывает модель десериализации файла TypeDescs.json.
    public class TypeDesc
    {
        public string TypeVal { get; set; }
        public Dictionary<string, string> Props { get; set; }

    }

}
