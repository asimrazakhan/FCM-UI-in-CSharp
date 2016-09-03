using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;
using System.Collections.Generic;
namespace WindowsFormsApplication1
{

    class FirebaseDatabase
    {
        // Awaited for firebase database values
        public Dictionary<string, Dictionary<string, string>> values;

        public async Task<bool> GetDataAsync()
        {

            var client = new HttpClient();

            // Get the response.
            string response = await client.GetStringAsync("https://buzybeez-184bf.firebaseio.com/.json");
            this.values = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(response);
            return true;

        }
    }
}















 //public async Task<Dictionary<string, string>> GetDataAsync() //string[] drivers ,string[] tokens)
 //       {

 //           var client = new HttpClient();

 //           // Get the response.
 //           string response = await client.GetStringAsync("https://buzybeez-184bf.firebaseio.com/higherVisibility.json");
 //           Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(response);

      



 //           return values;


 //           //drivers  = new string[values.Keys.Count];
 //           //values.Keys.CopyTo(drivers, 0);
           
            
            
 //           //tokens   = new string[values.Values.Count];

 //           //values.Values.CopyTo(tokens, 0);

           
 //       }
      

//string json = @"{
//  'Name': 'Bad Boys',
//  'ReleaseDate': '1995-4-7T00:00:00',
//  'Genres': [
//    'Action',
//    'Comedy'
//  ]
//}";

//Movie m = JsonConvert.DeserializeObject<Movie>(json);

//string name = m.Name;
//// Bad Boys