using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserJsonCsvToXml.JsonFile
{
    // Этот класс описывает модель десериализации файла TypeDescs.json.
    public class RootSrc
    {
        public HashSet<TypeDesc> TypeDescs { get; set; }

    }

}
