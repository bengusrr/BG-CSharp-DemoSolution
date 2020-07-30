using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUI
{
    public partial class EmployedEntryUI : Form
    {
        public EmployedEntryUI()
        {
            InitializeComponent();
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                EmployeeModel model = new EmployeeModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    mobilePhoneValue.Text);

                GlobalConfig.Connections.CreateEmployee(model);

                IdLabel.Text = model.Id.ToString();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                mobilePhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool validation = true;


            #region "number values validations example"
            //int number = 0;
            //bool validNumber = int.TryParse(numberValue.Text, out number);

            //if (validNumber == false)
            //{
            //    validation = false;
            //}

            //if (number < 1)
            //{
            //    validation = false;
            //}
            #endregion

            if (firstNameValue.Text.Length == 0)
            {
                validation = false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                validation = false;
            }

            if (emailValue.Text.Length == 0)
            {
                validation = false;
            }

            if (mobilePhoneValue.Text.Length == 0)
            {
                validation = false;
            }

            return validation;
        }
    }
}
