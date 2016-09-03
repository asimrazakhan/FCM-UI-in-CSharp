using System;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;



namespace WindowsFormsApplication1
{
    // FCM Push Notification and Data Message
    public class AndroidFCMPushNotification
    {
        public string SendNotification(object dataObject)
        {

            string SERVER_API_KEY = "AIzaSyAXLVMgSayO6JuVAbwkhkxDtiW61t_RrX0";
            string SENDER_ID = "820346256279";


            // for plan text
            // var value = message; 

            WebRequest tRequest;
            tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";

            // using plan text [multicast not supported]
            // tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";

            // using json [multicasting]
            tRequest.ContentType = " application/json";

            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            // for plan test.
            //string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceIDs + "";
            //Console.WriteLine(postData);
            //Byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            //var  = new Rabbit.SerializationMaster.Web.JavaScriptSerializationStrategy();
            string json = JsonConvert.SerializeObject(dataObject);
            //var json = serializer.Serialize(dataObject);


            Byte[] byteArray = Encoding.UTF8.GetBytes(json);

            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);


      string sResponseFromServer = tReader.ReadToEnd();


            tReader.Close();
            dataStream.Close();
            tResponse.Close();

            return sResponseFromServer;
        }
    }
}
