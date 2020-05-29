﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm frm = new EmployeeInfoForm();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void companyMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfoForm frm = new CompanyInfoForm();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void goodsPurchaseMenuItem_Click(object sender, EventArgs e)
        {
            JhGoodsForm jhGoodsForm = new JhGoodsForm("YH");
            jhGoodsForm.Owner = this;
            jhGoodsForm.ShowDialog();
        }

        private void GoodsInfoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SellGoodsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReturnGoodsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsFind frm = new GoodsFind();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void 库存报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsWarning frm = new GoodsWarning();
            frm.Owner = this;
            frm.ShowDialog();
        }



        private void DataBackupMenuItem_Click(object sender, EventArgs e)
        {
            DataBackupForm frm = new DataBackupForm();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void DataRecoveryMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
