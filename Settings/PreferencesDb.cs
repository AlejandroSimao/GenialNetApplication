using GenialNetApplication.Settings.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace GenialNetApplication.Settings
{
    public class PreferencesDb
    {
        private static readonly string _key= "configuration.db";

        //Salvar as preferências no arquivo tempórario
        public static void SetPreferenceBD(ConectionModels conectionModels)
        {           
            var preferenceJson = JsonConvert.SerializeObject(conectionModels, Formatting.Indented);
            File.WriteAllText(_key, preferenceJson);           
        }

        //Pesquisa no arquivo tempórario
        public static ConectionModels GetConnectionModels()
        {
            if (File.Exists(_key))
            {
                var preferencesJson = File.ReadAllText(_key);
                return JsonConvert.DeserializeObject<ConectionModels>(preferencesJson);              
            }
            return null;          

        }
    }
}
