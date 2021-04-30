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
         * Set the Enable properties of Login Button
         * depending on the validation
         * if the all the inputs are
         * valid then Enable properties set to True
         * otherwise False
         * 
         * @return void
         */

        private void _SetLoginButtonEnableProperties(Button btn)
        {
            btn.Enabled = (this._IsEmailValid(tbLoginEmail) && this._IsLoginPasswordValid());
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

                    if (this._IsEmailValid(tbLoginEmail))
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

                    if (this._IsLoginPasswordValid())
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


        /**
         * Check the Email if it's valid or not
         * Tried on
         * @link https://regexr.com/5r0tf
         * 
         * @return boolean
         */

        private bool _IsEmailValid(TextBox tb)
        {
            string email = tb.Text.Trim();
            return (email.Length != 0 && Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$"));
        }


        #region Login Form

        /////////////////////////////////////
        ////        Login Form          /////
        /////////////////////////////////////


        /**
         * Check the Passwrod if it's valid or not
         * Condition -> not empty
         * 
         * @return boolean
         */

        private bool _IsLoginPasswordValid()
        {
            string password = tbLoginPassword.Text.Trim();
            return (password.Length != 0);
        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckLoginEmailValidation()
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

            this._ShowErrorMessage(Inputs.Email, ref errMsgLoginEmail, ref errorMessage);

            this._SetLoginButtonEnableProperties(btnLogin);
        }


        /**
         * Check the Passwrod
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckLoginPasswordValidation()
        {
            string errorMessage = "";
            string password = tbLoginPassword.Text.Trim();

            if (password.Length == 0)
            {
                errorMessage += "Password can't be empty\n";
            }

            this._ShowErrorMessage(Inputs.Password, ref errMsgLoginPassword, ref errorMessage);
            

            this._SetLoginButtonEnableProperties(btnLogin);
        }

        private void tbLoginEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckLoginEmailValidation();
        }

        private void tbLoginPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckLoginPasswordValidation();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this._IsEmailValid(tbLoginEmail) || !this._IsLoginPasswordValid())
            {
                this._CheckLoginEmailValidation();
                this._CheckLoginPasswordValidation();

                return;
            }

            // Start Database Login process
        }

        #endregion

        #region Registration Form

        ////////////////////////////////////////////
        ////        Registration Form          /////
        ////////////////////////////////////////////


        /**
         * Is Name valid or not
         * Condition -> not empty, larger than 2 char, alphanumeric with -, _
         * 
         * @return boolean
         */

        private bool _IsRegistrationNameValid()
        {
            return false;
        }


        /**
         * Is Phone valid or not
         * Condition -> not empty, valid bd phone
         * Tried on
         * @link https://regexr.com/5rvf6
         * 
         * @return boolean
         */

        private bool _IsRegistrationPhoneValid()
        {
            return false;
        }


        /**
         * Is Password valid or not
         * Condition -> not empty, larger than 7 char,
         * include at least one char !, @, #, $, % 
         * 
         * @return boolean
         */

        private bool _IsRegistrationPasswordValid()
        {
            return false;
        }


        /**
         * Is Confirm Password valid or not
         * Condition -> not empty, equal to Password
         * 
         * @return boolean
         */

        private bool _IsRegistrationConfirmPasswordValid()
        {
            return false;
        }


        /**
         * Check the Name
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationNameValidation()
        {

        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationEmailValidation()
        {

        }


        /**
         * Check the Phone
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationPhoneValidation()
        {

        }


        /**
         * Check the Password
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationPasswordValidation()
        {

        }


        /**
         * Check the Confirm Password
         * and show the Error message
         * also check Password and Confirm Password equal or not
         * show error message in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationConfirmPasswordValidation()
        {

        }

        private void tbRegName_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationNameValidation();
        }

        private void tbRegEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationEmailValidation();
        }

        private void tbRegPhone_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationPhoneValidation();
        }

        private void tbRegPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationPasswordValidation();
        }

        private void tbRegConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationConfirmPasswordValidation();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (!this._IsRegistrationNameValid() || !this._IsEmailValid(tbRegEmail) || !this._IsRegistrationPhoneValid() || !this._IsRegistrationPasswordValid() || !this._IsRegistrationConfirmPasswordValid())
            {
                this._CheckRegistrationNameValidation();
                this._CheckRegistrationEmailValidation();
                this._CheckRegistrationPhoneValidation();
                this._CheckRegistrationPasswordValidation();
                this._CheckRegistrationConfirmPasswordValidation();

                return;
            }

            // Start Database Registration process
        }

        #endregion
    }
}