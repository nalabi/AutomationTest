using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTesting.Models.UserModels
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class UserLogin
        {
            public string username { get; set; }
            public string password { get; set; }
        }


    }

