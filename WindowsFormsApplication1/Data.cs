using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   // Sending this to DCM
    public class Data
    {
        public string message { get; set; }
        public string time { get; set; }

    }


        public class Notification
        {
            public string title { get; set; }
            public string body { get; set; }
            public string sound { get; set; }
            public int badge { get; set; }
            public string icon { get; set; }

        }

        public class RootObject
        {
            public string[] registration_ids { get; set; }
            public string collapse_key { get; set; }
            public string priority { get; set; }
            public bool content_available { get; set; }
            public bool delay_while_idle { get; set; }
            public int time_to_live { get; set; }
            public Data data { get; set; }
            public Notification notification { get; set; }
            

            public void AssigningDataValues(TextBox message)
            {
                Data data = new Data();
                data.message = message.Text;
                data.time = DateTime.Now.ToString();
                this.data = data;
            }


            public void AssigningNotificationValues(TextBox text, TextBox body, ComboBox sound, ComboBox badge)
            {
                Notification notification = new Notification();
                notification.title = text.Text.ToString();
                notification.body = body.Text.ToString();
                notification.sound = (sound.Text == "") ? "Default" : sound.Text;
                notification.badge = (badge.Text == "") ? 0 : Convert.ToInt32(badge.Text);
                this.notification = notification;
            }



            public void FcmPropertieValues(TextBox collapsKey, ComboBox comboPriority, TextBox timeToLive, CheckBox checkDelay, CheckBox checkAvailablity, string[] tokenIDs)
            {
                this.registration_ids = tokenIDs;
                this.collapse_key = collapsKey.Text;
                this.priority = comboPriority.Text;
                this.time_to_live = Convert.ToInt32(timeToLive.Text);
                this.content_available = checkAvailablity.Checked;
                this.delay_while_idle = checkDelay.Checked;

            }
        }
    }




