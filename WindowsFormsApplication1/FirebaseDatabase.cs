using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace WindowsFormsApplication1
{
    class FirebaseDatabase
    {
        public async Task GetDataAsync()
        {
            var client = new HttpClient();

            // Get the response.
            var response = await client.GetByteArrayAsync("https://buzybeez-184bf.firebaseio.com/OfficeName.json");
            //  string [] res = response.Split(',');
            //MessageBox.Show("ResponseData"+ response);
            //  var responceContent = JsonConvert.DeserializeObject(response);

        }
    }
}
