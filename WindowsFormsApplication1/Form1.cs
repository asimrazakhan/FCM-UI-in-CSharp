using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Instance of FirebaseDatabase
        FirebaseDatabase fdb = new FirebaseDatabase();
        

        // Making instance of the main data Objet
        RootObject dataObject = new RootObject();

        // checking input values
        public void Check() {
            if (checkNotification.Checked == true || checkData.Checked == true)
            {
                send.Enabled = true;
            }
            else
            {
                send.Enabled = false;
            }
        }

  
        // Registration Tokens
         string[] tokenIDs = new string[] 
            {
            
             // Android Devices
         
            "dS_cw7JzNGo:APA91bGr6Z6gnW_YywMp1Qu4afVQ0l2VY3Zh9XpFR6oiPSyUkBOGWFkgyOO_PO8FF10TvUOaSWKosAV-9vsTPXHYFEeOkLEJh79AUDeo2ShrLele9ocJGOWqwjQ5XYzpeOZ4CrsmzVax",

             //iOS Devices
            "f9UTn00fGt0:APA91bEQ6zZ5zP5untj-XNoUQ9ocBfePs_x6Kab39emLViQbdkxBrOrNPdb3dUiDcKnKTJd64GrUVwI3gCnBHamQgEHbJ6yGLqhYqNQ5TeBsrKlQMjJL7k4Bnjs-wbVe_6InfIw5Gy2R"
            };
 

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string item = comboUser.Text;
            fdb.GetDataAsync(item);
            comboDriver.Enabled = (comboUser.Focused) ? true : false;
            comboDriver.Items.Add(fdb.values.Keys);
            
        }

        private void comboPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkNotification_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNotification.Enabled = (checkNotification.Checked) ? true : false; 
        }

        private void checkData_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMessage.Enabled = (checkData.Checked) ? true : false;
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void title_Enter(object sender, EventArgs e)
        {

        }


        private void body_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSound_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBadge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // initlizating data

            if (checkNotification.Checked)
            {
                dataObject.AssigningNotificationValues(title, body, comboSound, comboBadge);
                dataObject.data = null;
            }

            if (checkData.Checked)
            {
                dataObject.AssigningDataValues(message);
                if (!checkNotification.Checked)
                {
                    dataObject.notification = null;
                }
            }

            dataObject.FcmPropertieValues(collapsKey,comboPriority,timeToLive,checkAvailablity,checkDelay,tokenIDs, fdb.values[comboDriver.Text]);
            
            // Pushing into FCM
            AndroidFCMPushNotification FCM = new AndroidFCMPushNotification();       
            string  responseFromServer = FCM.SendNotification(dataObject);

            MessageBox.Show("Succes: " + responseFromServer[46] +"\n Failure: "+responseFromServer[58]);

        }

        public void Submit() {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkData_MouseClick(object sender, MouseEventArgs e)
        {
            Check(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // checking check boxes.
            Check();

            comboDriver.Enabled = false;

         
            //  Getting tokens from firebase
            
           //try {

           //    if (fdb.GetDataAsync()) {
           //        comboDriver.Items.Add(fdb.values.Keys);
           //    }
    
           // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex);
            //}

        }

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textToken_TextChanged(object sender, EventArgs e)
        {
            tokenIDs = null;
        }

        private void comboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDriver.Text == "Select All Drivers") {
                tokenIDs = fdb.values.Values.ToArray();
                
                fdb.values = null;
            } 
        }
    }    
 }

    


