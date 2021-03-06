﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRS
{
    public partial class studentView : Form
    {
        public studentView()
        {
            InitializeComponent();
            
        }

        private void hideTabs()
        {
            patHigPan.Visible = false;
            labsAndImaTabs.Visible = false;
            mARTabs.Visible = false;
            assDataTabs.Visible = false;
            notTabs.Visible = false;
            ordTabs.Visible = false;
        }

        private void hideAssSubCat()
        {
            genSurSubCatPan.Visible = false;
            hEENTSubCatPan.Visible = false;
            uppExtSubCatPan.Visible = false;
            pulSubCatPan.Visible = false;
            carSubCatPan.Visible = false;
            abdSubCatPan.Visible = false;
            lowExtSubCatPan.Visible = false;
        }

        private void hideSafCheSubCat()
        {
            braScaSubCatPan.Visible = false;
            braScaResPan.Visible = false;
            morScaSubCatPan.Visible = false;
            morScaResSubCatPan.Visible = false;
        }
        private void hideHomeButtons()
        {
            patHigBtn.Visible = false;
            labsAndImaBtn.Visible = false;
            mARBtn.Visible = false;
            assDataBtn.Visible = false;
            notBtn.Visible = false;
            ordBtn.Visible = false;
        }
        private void showButtons()
        {
            patHigBtn.Visible = true;
            labsAndImaBtn.Visible = true;
            mARBtn.Visible = true;
            assDataBtn.Visible = true;
            notBtn.Visible = true;
            ordBtn.Visible = true;
        }
        private void userMenuItem_Click(object sender, EventArgs e)
        {
            addUser addUserForm = new addUser();
            addUserForm.Show();
        }

        private void setMenuItem_Click(object sender, EventArgs e)
        {
            adminSet adminSetForm = new adminSet();
            adminSetForm.Show();
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hide();
                logOut logOutForm = new logOut();
                logOutForm.Show();
            }
        }


        private void sideButtonEnabled()
        {
            buttonMAR.Enabled = true;
            buttonPH.Enabled = true;
            buttonMAR.Enabled = true;
            buttonLI.Enabled = true;
            buttonAD.Enabled = true;
            buttonNotes.Enabled = true;
            buttonOrders.Enabled = true;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            hideTabs();
            showButtons();
            selectionMenu.Visible = false;
            sideButtonEnabled();
        }

        private void buttonPH_Click(object sender, EventArgs e)
        {
            hideTabs();
            sideButtonEnabled();
            buttonPH.Enabled = false;
            selectionMenu.Visible = true;
            patHigPan.Visible = true;
        }

        private void buttonMAR_Click(object sender, EventArgs e)
        {
            hideTabs();
            sideButtonEnabled();
            buttonMAR.Enabled = false;
            selectionMenu.Visible = true;
            mARTabs.Visible = true;
        }

        private void buttonLI_Click(object sender, EventArgs e)
        {
            hideTabs();
            sideButtonEnabled();
            buttonLI.Enabled = false;
            selectionMenu.Visible = true;
            labsAndImaTabs.Visible = true;
        }

        private void buttonAD_Click(object sender, EventArgs e)
        {
            hideTabs();
            sideButtonEnabled();
            buttonAD.Enabled = false;
            selectionMenu.Visible = true;
            assDataTabs.Visible = true;
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            hideTabs();
            sideButtonEnabled();
            buttonNotes.Enabled = false;
            selectionMenu.Visible = true;
            notTabs.Visible = true;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            hideTabs();
            sideButtonEnabled();
            buttonOrders.Enabled = false;
            selectionMenu.Visible = true;
            ordTabs.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void patientDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patientDropDown.Text == "Patient 1")
            {
                mRNMaskTxtBox.Text = "14234634-346-6444";
                sexMaskTxtBox.Text = "M";
                ageMaskTxtBox.Text = "56";
                birthMaskTxtBox.Text = "10/27/1993";
                allMaskTxtBox.Text = "Penicillin";
                infPreMaskTxtBox.Text = "N/A";
                //groupBox1.Visible = true;
                patHigBtn.Enabled = true;
                labsAndImaBtn.Enabled = true;
                mARBtn.Enabled = true;
                assDataBtn.Enabled = true;
                notBtn.Enabled = true;
                ordBtn.Enabled = true;
            }
            else
            {
                mRNMaskTxtBox.Text = "";
                sexMaskTxtBox.Text = "";
                ageMaskTxtBox.Text = "";
                birthMaskTxtBox.Text = "";
                allMaskTxtBox.Text = "";
                infPreMaskTxtBox.Text = "";
                //groupBox1.Visible = true;
                patHigBtn.Enabled = false;
                labsAndImaBtn.Enabled = false;
                mARBtn.Enabled = false;
                assDataBtn.Enabled = false;
                notBtn.Enabled = false;
                ordBtn.Enabled = false;
            }

        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void authorizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
                saveToolStripMenuItem1.Enabled = true;
                
        }

        //Assessment buttons
        private void genSurSubCatBtn_Click(object sender, EventArgs e)
        {
            hideAssSubCat();
            genSurSubCatPan.Visible = true;
        }

        private void hEENTSubCatBtn_Click(object sender, EventArgs e)
        {
            hideAssSubCat();
            hEENTSubCatPan.Visible = true;
        }

        private void uppExtSubCatBtn_Click(object sender, EventArgs e)
        {
            hideAssSubCat();
            uppExtSubCatPan.Visible = true;
        }

        private void pulSubCatBtn_Click(object sender, EventArgs e)
        {
            hideAssSubCat();
            pulSubCatPan.Visible = true;
        }

        private void carSubCatBtn_Click(object sender, EventArgs e)
        {

            hideAssSubCat();
            carSubCatPan.Visible = true;
        }

        private void abdSubCatBtn_Click(object sender, EventArgs e)
        {
            hideAssSubCat();
            abdSubCatPan.Visible = true;
        }

        private void lowExtSubCatBtn_Click(object sender, EventArgs e)
        {
            hideAssSubCat();
            lowExtSubCatPan.Visible = true;
        }

        // Safety Check Sub Category Buttons
        private void braScaSubCatBtn_Click(object sender, EventArgs e)
        {
            hideSafCheSubCat();
            braScaSubCatPan.Visible = true;
        }

        private void braScaResSubCatBtn_Click(object sender, EventArgs e)
        {
            hideSafCheSubCat();
            braScaResPan.Visible = true;
        }

        private void morScaSubCatBtn_Click(object sender, EventArgs e)
        {
            hideSafCheSubCat();
            morScaSubCatPan.Visible = true;
        }

        private void morScaResSubCatBtn_Click(object sender, EventArgs e)
        {
            hideSafCheSubCat();
            morScaResSubCatPan.Visible = true;
        }

        // Main Categories Buttons
        private void mARBtn_Click_2(object sender, EventArgs e)
        {
            //hideTabs();
            buttonMAR.Enabled = false;
            mARTabs.Visible = true;
            selectionMenu.Visible = true;
            hideHomeButtons();
        }

        private void patHigBtn_Click(object sender, EventArgs e)
        {
            // hideTabs();
            buttonPH.Enabled = false;
            selectionMenu.Visible = true;
            hideHomeButtons();
            patHigPan.Visible = true;
        }

        private void labsAndImaBtn_Click(object sender, EventArgs e)
        {
           // hideTabs();
            buttonLI.Enabled = false;
            selectionMenu.Visible = true;
            hideHomeButtons();
            labsAndImaTabs.Visible = true;
        }

        private void assDataBtn_Click(object sender, EventArgs e)
        {
            //hideTabs();
            buttonAD.Enabled = false;
            selectionMenu.Visible = true;
            hideHomeButtons();
            assDataTabs.Visible = true;
        }

        private void notBtn_Click(object sender, EventArgs e)
        {
            //hideTabs();
            buttonNotes.Enabled = false;
            selectionMenu.Visible = true;
            hideHomeButtons();
            notTabs.Visible = true;
        }

        private void ordBtn_Click(object sender, EventArgs e)
        {
            //hideTabs();
            buttonOrders.Enabled = false;
            selectionMenu.Visible = true;
            hideHomeButtons();
            ordTabs.Visible = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
            }
        }


      

        
       
   
     

       
       

       
        

        

        

       

       
    }
}

