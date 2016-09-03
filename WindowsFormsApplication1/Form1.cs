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


        private void Form1_Load(object sender, EventArgs e)
        {
            // checking check boxes.
            Check();
           
            comboDriver.Enabled = false;


            // setting default values on combo boxes.
            comboPriority.Text = "High";
            comboBadge.Text = "1";
            comboSound.Text = "Default";


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
            
                case "NBA":
                    checkBox1.Visible = true;
                    checkBox_NBT.Visible = false;
                    checkBox_CYP.Visible = false;
                    checkBox_NBT.Checked = false;
                    checkBox_CYP.Checked = false;

                    break;

                case "NBT":
                    checkBox_NBT.Visible = true;
                    checkBox1.Visible = false;
                    checkBox_CYP.Visible = false;
                    checkBox1.Checked = false;
                    checkBox_CYP.Checked = false;

                    break;

                case "CYP":
                    checkBox_NBT.Visible = false;
                    checkBox1.Visible = false;
                    checkBox_CYP.Visible = true;
                    checkBox_NBT.Checked = false;
                    checkBox1.Checked = false;

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

            dataObject.FcmPropertieValues(collapsKey,comboPriority,timeToLive,checkAvailablity,checkDelay,tokenIDs,fdb.values[comboDriver.Text]);
            
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
                tokenIDs = fdb.values.Values.ToArray();
                fdb.values["Select All Drivers"] = "";
            } 
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked)
            {
                bool result = await fdb.GetDataAsync(comboUser.Text);
                comboDriver.Items.AddRange(fdb.values.Keys.ToArray());
                comboDriver.Enabled = true;
                
            }
            else
            {
                comboDriver.Items.Clear();
                comboDriver.Items.Add("Select All Drivers");


            }
        }

        private async void checkBox_CYP_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox_CYP.Checked)
            {
                bool result = await fdb.GetDataAsync(comboUser.Text);
                comboDriver.Items.AddRange(fdb.values.Keys.ToArray());
                comboDriver.Enabled = true;
            }
            else
            {

                    comboDriver.Items.Clear();
                    comboDriver.Items.Add("Select All Drivers"); 
            }
        }

        private async void checkBox_NBT_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_NBT.Checked)
            {
                bool result = await fdb.GetDataAsync(comboUser.Text);
                comboDriver.Items.AddRange(fdb.values.Keys.ToArray());
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