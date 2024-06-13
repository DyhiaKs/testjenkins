using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo01
{
    public class ReadData
    {
        public string file_name;
        public string jsonStr;
        public Client client;

        public Client ReadDataFromJson()
        {
            file_name = @"C:\Users\dyhia\source\repos\Exo01\Exo01\Data.json";

            using (StreamReader r = new StreamReader(file_name))
            {
                jsonStr = r.ReadToEnd();
                client = JsonConvert.DeserializeObject<Client>(jsonStr);
            }
            return client;
        }
    }
}
