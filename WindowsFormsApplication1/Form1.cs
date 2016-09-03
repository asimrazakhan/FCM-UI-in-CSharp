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


        // database offices token stroe globaly to access any where
        string[] Offices;

        //Instance of FirebaseDatabase
        FirebaseDatabase fdb = new FirebaseDatabase();
        
        // Making instance of the main data Objet
        RootObject dataObject = new RootObject();

       // Dictionary<string, Dictionary<string, string>> val;
      
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            
            // checking check boxes.
            Check();

            // getting data from database
            await fdb.GetDataAsync();

            comboDriver.Enabled = false;

            // setting default values on combo boxes.
            comboPriority.Text = "High";
            comboBadge.Text = "1";
            comboSound.Text = "Default";
            checkData.Enabled = false;
            checkNotification.Enabled = false;

            // Getting Office Keys from database
            Offices = fdb.values.Keys.ToArray();

            comboUser.Items.AddRange(Offices);

        }

        
        
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
        string[] tokenIDs;
           
 

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboUser.Text) {

                case "CYP":
                    checkBox1.Visible = true;
                    checkBox_NBT.Visible = false;
                    checkBox_CYP.Visible = false;
                    checkBox_NBT.Checked = false;
                    checkBox_CYP.Checked = false;
                    checkNotification.Enabled = true;
                    checkData.Enabled = true;

                    break;

                case "NBT":
                    checkBox_NBT.Visible = true;
                    checkBox1.Visible = false;
                    checkBox_CYP.Visible = false;
                    checkBox1.Checked = false;
                    checkBox_CYP.Checked = false;
                    checkNotification.Enabled = true;
                    checkData.Enabled = true;
                    break;

                case "NBA":
                    checkBox_NBT.Visible = false;
                    checkBox1.Visible = false;
                    checkBox_CYP.Visible = true;
                    checkBox_NBT.Checked = false;
                    checkBox1.Checked = false;
                    checkNotification.Enabled = true;
                    checkData.Enabled = true;
                    break;

                default:
                    break;
            }

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

            dataObject.FcmPropertieValues(collapsKey, comboPriority, timeToLive, checkAvailablity, checkDelay, tokenIDs, fdb.values["Selected All Drivers"]["All"]);
            
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

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboDriver.Text == "Select All Drivers") {
                tokenIDs = fdb.values[comboUser.Text].Values.ToArray();
                fdb.values.Add("Selected All Drivers", new Dictionary<string, string>() { { "All", "" } });


                //var dictionary = new Dictionary<int, Dictionary<int, int>>();
                //dictionary.Add(5, new Dictionary<int, int>() {{ 8, 1 }});

            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked)
                {
                    comboDriver.Items.AddRange(fdb.values[comboUser.Text].Keys.ToArray());
                    comboDriver.Enabled = true;

                }
                else
                {
                    comboDriver.Items.Clear();
                    comboDriver.Items.Add("Select All Drivers");
                }
            
        }

        private void checkBox_CYP_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox_CYP.Checked)
                {
                    comboDriver.Items.AddRange(fdb.values[comboUser.Text].Keys.ToArray());
                    comboDriver.Enabled = true;
                }
                else
                {
                    comboDriver.Items.Clear();
                    comboDriver.Items.Add("Select All Drivers");
                }
            
        }

        private void checkBox_NBT_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox_NBT.Checked)
                {
                    comboDriver.Items.AddRange(fdb.values[comboUser.Text].Keys.ToArray());
                    comboDriver.Enabled = true;
                }
                else
                {
                    comboDriver.Items.Clear();
                    comboDriver.Items.Add("Select All Drivers");
                }
            
        }
    }    
 }