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

        private void _SetButtonEnableProperties(Button btn, Inputs inputs)
        {
            switch(inputs) {
                case Inputs.LoginButton:

                    btn.Enabled = (this._IsEmailValid(tbLoginEmail) && this._IsLoginPasswordValid());

                    break;
                case Inputs.RegButton:

                    btn.Enabled = (this._IsRegistrationNameValid() && this._IsEmailValid(tbRegEmail) && this._IsRegistrationPhoneValid() && this._IsRegistrationPasswordValid() && this._IsRegistrationConfirmPasswordValid());

                    break;
            }
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
                case Inputs.Name:

                    if (this._IsRegistrationNameValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.LoginEmail:
                case Inputs.RegEmail:

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
                case Inputs.LoginPassword:

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

                case Inputs.Phone:

                    if (this._IsRegistrationPhoneValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RegPassword:

                    if (this._IsRegistrationPasswordValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                    
                case Inputs.ConfirmPassword:

                    if (this._IsRegistrationConfirmPasswordValid())
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

            this._ShowErrorMessage(Inputs.LoginEmail, ref errMsgLoginEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnLogin, Inputs.LoginButton);
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

            this._ShowErrorMessage(Inputs.LoginPassword, ref errMsgLoginPassword, ref errorMessage);


            this._SetButtonEnableProperties(btnLogin, Inputs.LoginButton);
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
         * Tried on
         * @link https://regexr.com/5rvjm
         * 
         * @return boolean
         */

        private bool _IsRegistrationNameValid()
        {
            string name = tbRegName.Text.Trim();
            return (name.Length > 2 && Regex.IsMatch(name, @"^[a-zA-Z0-9-_]+$"));
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
            string phone = tbRegPhone.Text.Trim();
            return (phone.Length != 0 && Regex.IsMatch(phone,@"^(\+8801[2-9]\d{1}[0-9]\d{6})$"));
        }


        /**
         * Is Password valid or not
         * Condition -> not empty, larger than 7 char,
         * include at least one char !, @, #, $, % 
         * Tried on
         * @link https://regexr.com/5rvj1
         * 
         * @return boolean
         */

        private bool _IsRegistrationPasswordValid()
        {
            string password = tbRegPassword.Text.Trim();
            return (password.Length != 0 && password.Length > 7 && Regex.IsMatch(password, @"[!@#$%]+"));
        }


        /**
         * Is Confirm Password valid or not
         * Condition -> not empty, equal to Password
         * 
         * @return boolean
         */

        private bool _IsRegistrationConfirmPasswordValid()
        {
            string password = tbRegPassword.Text.Trim();
            string confirmPassword = tbRegConfirmPassword.Text.Trim();
            return (confirmPassword.Length != 0 && confirmPassword.Equals(password));
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
            string errorMessage = "";
            string name = tbRegName.Text.Trim();

            if (name.Length == 0)
            {
                errorMessage += "Name can't be empty\n";
            }

            if (name.Length < 3 && name.Length != 0)
            {
                errorMessage += "Name must be larger than 2 character\n";
            }

            if (!Regex.IsMatch(name, @"^([a-zA-Z0-9-_])+$") && name.Length != 0)
            {
                errorMessage += "Name must be alphaneumeric, dash(-) and underscore(_) \n";
            }

            this._ShowErrorMessage(Inputs.Name, ref errMsgRegName, ref errorMessage);

            this._SetButtonEnableProperties(btnRegistration, Inputs.RegButton);
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
            string errorMessage = "";
            string email = tbRegEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid e.g admin@admin.com\n";
            }

            this._ShowErrorMessage(Inputs.RegEmail, ref errMsgRegEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnRegistration, Inputs.RegButton);
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
            string errorMessage = "";
            string phone = tbRegPhone.Text.Trim();

            if (phone.Length == 0)
            {
                errorMessage += "Phone Number can't be empty\n";
            }

            if (!Regex.IsMatch(phone, @"^(\+8801[2-9]\d{1}[0-9]\d{6})$") && phone.Length != 0)
            {
                errorMessage += "Phone Number is not valid e.g +8801628769304\n";
            }

            this._ShowErrorMessage(Inputs.Phone, ref errMsgRegPhone, ref errorMessage);

            this._SetButtonEnableProperties(btnRegistration, Inputs.RegButton);
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
            string errorMessage = "";
            string password = tbRegPassword.Text.Trim();

            if (password.Length == 0)
            {
                errorMessage += "Password can't be empty\n";
            }
            if (password.Length < 8 && password.Length != 0)
            {
                errorMessage += "Password must be larger then 8 characters\n";
            }

            if (!Regex.IsMatch(password, @"[!@#$%]+") && password.Length != 0)
            {
                errorMessage += "Password must include at least one special characters (!, @, #, $, %)\n";
            }

            this._ShowErrorMessage(Inputs.RegPassword, ref errMsgRegPassword, ref errorMessage);

            this._SetButtonEnableProperties(btnRegistration, Inputs.RegButton);
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
            
            string errorMessage = "";
            string password = tbRegPassword.Text.Trim();
            string confirmPassword = tbRegConfirmPassword.Text.Trim();

            if (confirmPassword.Length == 0)
            {
                errorMessage += "Confirm Password can't be empty\n";
            }

            if (!confirmPassword.Equals(password))
            {
                errorMessage += "Confirm Password must match Password\n";
            }

            this._ShowErrorMessage(Inputs.ConfirmPassword, ref errMsgRegConfirmPassword, ref errorMessage);

            this._SetButtonEnableProperties(btnRegistration, Inputs.RegButton);
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