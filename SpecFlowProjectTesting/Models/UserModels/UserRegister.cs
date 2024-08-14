using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTesting.Models.UserModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class UserRegister
    {
        public string email { get; set; }
        public string username { get; set; }
        public string knownAs { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string password { get; set; }
    }


}
