using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HousingManagementSystemForAIUBStudents.Views
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }


        /**
         * Check the Email if it's valid or not
         * 
         * @return boolean
         */

        private bool _IsEmailValid()
        {
            string email = tbLoginEmail.Text.Trim();
            return (email.Length != 0 && Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$"));
        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckEmailValidation()
        {
            string errorMessage = "";
            string email = tbLoginEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid\n";
            }

            this._ShowErrorMessage(Inputs.Email, ref errMsgEmail, ref errorMessage);

            this._SetLoginButtonEnableProperties();
        }


        /**
         * Check the Passwrod if it's valid or not
         * 
         * @return boolean
         */

        private bool _IsPasswordValid()
        {
            string password = tbLoginPassword.Text.Trim();
            return (password.Length != 0);
        }


        /**
         * Check the Passwrod
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckPasswordValidation()
        {
            string errorMessage = "";
            string password = tbLoginPassword.Text.Trim();

            if (password.Length == 0)
            {
                errorMessage += "Password can't be empty\n";
            }

            this._ShowErrorMessage(Inputs.Password, ref errMsgPassword, ref errorMessage);
            

            this._SetLoginButtonEnableProperties();
        }


        /**
         * Set the Enable properties of Login Button
         * depending on the validation
         * if the all the inputs are
         * valid then Enable properties set to True
         * otherwise False
         * 
         * @return void
         */

        private void _SetLoginButtonEnableProperties()
        {
            btnLogin.Enabled = (this._IsEmailValid() && this._IsPasswordValid());
        }


        /**
         * Show the Error message on inputs
         * bellow if any error message have
         * 
         * @return void
         */

        private void _ShowErrorMessage(Inputs input, ref Label errLable, ref string errorMessage)
        {
            switch (input)
            {
                case Inputs.Email:

                    if (this._IsEmailValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.Password:

                    if (this._IsPasswordValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
            }

        }

        private void tbLoginEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckEmailValidation();
        }

        private void tbLoginPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckPasswordValidation();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this._IsEmailValid() || !this._IsPasswordValid())
            {
                this._CheckEmailValidation();
                this._CheckPasswordValidation();

                return;
            }

            //start Database login 
        }
    }
}

