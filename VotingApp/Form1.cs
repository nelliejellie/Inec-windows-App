using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.Services;
using Core.DTOs;
using Core.Contracts;
using Data;

namespace VotingApp
{
    public partial class Form1 : Form
    {
        private readonly IRegisteration _registerationService;
        private readonly Database _database;
        public Form1(IRegisteration registerationService, Database database)
        {
            InitializeComponent();
            _registerationService = registerationService;
            _database = database;
        }

        public Form1()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddeName_TextChanged(object sender, EventArgs e)
        {

        }
        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var voterDetails = new VoterRegDTO()
            {
                FirstName = FirstName.Text,
                MiddleName = MiddeName.Text,
                LastName = LastName.Text,
                DateOfBirth = DateOfBirth.Text
            };
            _registerationService.RegisterNewVoter(voterDetails);
            ClearAllTexts();
            allVoters.Text = "";
            foreach (var v in _database.VoterTable)
            {
                allVoters.Text += v.FirstName + v.LastName + Environment.NewLine;
            }
            MessageBox.Show("new voter has been added");
        }

        public void ClearAllTexts()
        {
            FirstName.Text = "";
            MiddeName.Text = "";
            LastName.Text = "";
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gender.Text == "Female")
            {
                female.Visible = true;
                male.Visible = false;
            }
                
            if (gender.Text == "Male")
            {
                male.Visible = true;
                female.Visible = false;
            }
               
                
        }
    }
}