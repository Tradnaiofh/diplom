﻿using Data;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oprForm
{
    public partial class AddIssueForm : Form
    {
        private DBManager db = new DBManager();

        public AddIssueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.Connect();
            string[] fields = { "name", "description" };

            // Менять кавычки
            string[] values = { DBUtil.AddQuotes(nameTB.Text), DBUtil.AddQuotes(descrTB.Text) };

            int id = db.InsertToBD("issues", fields, values);

            //Issue issue = new Issue(id, nameTB.Text, descrTB.Text, DateTime.Now, calcSeries);
            //issuesLB.Items.Add(issue);

            db.Disconnect();

            this.Close();
        }
    }
}
