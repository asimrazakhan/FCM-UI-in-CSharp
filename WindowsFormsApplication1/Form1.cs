using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


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

        // Registration Tokens
        string[] tokenIDs;


        // checking to disable or enable send button
        public void Check()
        {
            send.Enabled = (checkNotification.Checked == true || checkData.Checked == true) ? true : false;
        }

        // form loading
        private async void Form1_Load(object sender, EventArgs e)
        {
            
            // checking status of check boxes.
            Check();
            comboDriver.Enabled = false;

            // getting data from database
            await fdb.GetDataAsync();

            // setting default values on combo boxes.
            comboPriority.Text = "High";
            comboBadge.Text = "1";
            comboSound.Text = "Default";
            comboOffices.Items.Clear();


            // Showing Office Keys from database to the comboBox
            comboOffices.Items.AddRange(fdb.values.Keys.ToArray());

            //// Adding string key and value to be passed to the 'to' property when all drivers is selected
            fdb.values.Add("Selected All Drivers", new Dictionary<string, string>() { { "All", "" } });
            fdb.values.Add("Selected All Drivers", new Dictionary<string, string>() { { "All", "" } });

            // Adding string key and value to be passed to the 'to' property when all drivers is selected
            fdb.values[comboOffices.Text].Add(comboDriver.Text, "");

        }

        private void comboOffices_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDriver.Items.Clear();
            comboDriver.Items.Add("Select All Drivers");
            comboDriver.Items.AddRange(fdb.values[comboOffices.Text].Keys.ToArray());
            comboDriver.Enabled = true;
        }

        private void comboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enabled the type of message field
            groupBoxTypeOfMessage.Enabled = true;

            if (comboDriver.Text == "Select All Drivers")
            {
                tokenIDs = fdb.values[comboOffices.Text].Values.ToArray();

                //try 
                //{
                //    // Adding string key and value to be passed to the 'to' property when all drivers is selected
                //    fdb.values[comboOffices.Text].Add(comboDriver.Text, "");
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show("Error" + ex);
                //}
                
            }
        }

        private void checkData_MouseClick(object sender, MouseEventArgs e)
        {
            Check();
        }

        private void checkNotification_CheckedChanged(object sender, EventArgs e)
        {
            // enabling or disabiling field relates to the notification check box
            groupBoxNotification.Enabled = (checkNotification.Checked) ? true : false;
        }

        private void checkData_CheckedChanged(object sender, EventArgs e)
        {
            // enabling or disabiling field relates to the data check box
            groupBoxMessage.Enabled = (checkData.Checked) ? true : false;
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

            dataObject.FcmPropertieValues(collapsKey, comboPriority, timeToLive, checkAvailablity, checkDelay, tokenIDs, fdb.values[comboOffices.Text][comboDriver.Text]);

            // Pushing into FCM
            AndroidFCMPushNotification FCM = new AndroidFCMPushNotification();
            string responseFromServer = FCM.SendNotification(dataObject);

            MessageBox.Show("Succes: " + responseFromServer[46] + "\n Failure: " + responseFromServer[58]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public void Submit() 
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CYP_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox_NBT_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }    
 }