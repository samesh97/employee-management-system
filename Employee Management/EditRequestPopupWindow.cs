﻿using Employee_Management.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class EditRequestPopupWindow : Form
    {

        sendRequest ob = new sendRequest();
        public EditRequestPopupWindow()
        {
            InitializeComponent();
        }

        private void EditRequestPopupWindow_Load(object sender, EventArgs e)
        {
            int id = RequestPortal.editRequestID;
            DataTable dt = ob.getRequestDetails(id);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["ReqID"].ToString();
                txtID.Text = row["EmpID"].ToString();

                dateTimePicker1.Text = "2018 / 09 / 05";

                txtHours.Text = row["LeaveHours"].ToString();
                txtDepartment.Text = row["Department"].ToString();
                txtDescription.Text = row["Description"].ToString();

            }

            

        }
    }
}