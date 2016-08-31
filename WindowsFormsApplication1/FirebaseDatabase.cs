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
    class Office {

        List<string> token { get; set; }
    }

    class FirebaseDatabase
    {


        public async Task<Dictionary<string, string>> GetDataAsync()
        {

            var client = new HttpClient();

            // Get the response.
            string response = await client.GetStringAsync("https://buzybeez-184bf.firebaseio.com/higherVisibility.json");
            Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(response);
            return values;
        }
    }
}


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