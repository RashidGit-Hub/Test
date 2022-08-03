﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RestService_Test
{
    public partial class Form1 : Form
    {
        Rest_ServiceReference.Rest_Service1Client rest_sr = new Rest_ServiceReference.Rest_Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rest_ServiceReference.AccessFileNames accessInfo = new Rest_ServiceReference.AccessFileNames();

            accessInfo.GroupId = "980";

            accessInfo.AccessFile = "Group980";

            accessInfo.VersionNo = "980";


            Rest_ServiceReference.groupdt gdt = new Rest_ServiceReference.groupdt();
            //string result = rest_sr.InsertAccessFileName(accessInfo);

            string result = rest_sr.GetData(100);
            
            label1.Text = result; //gdt.AccessFnm;
             gdt = JsonConvert.DeserializeObject<Rest_ServiceReference.groupdt>(result);

            label1.Text = gdt.AccessFnm;
            
            
            rest_sr.Close();

            
        }

        
    }
}
