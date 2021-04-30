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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
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

        private void _SetLoginButtonEnableProperties(Button btn, Inputs input)
        {
            switch(input)
            {
                case Inputs.SearchUserEmail:

                    btn.Enabled = (this._IsEmailValid(tbSearchUserEmail));

                    break;
                case Inputs.DeleteUserEmail:

                    btn.Enabled = (this._IsEmailValid(tbDeleteUserEmail));

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
                case Inputs.SearchUserEmail:

                    if (this._IsEmailValid(tbSearchUserEmail))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.DeleteUserEmail:

                    if (this._IsEmailValid(tbDeleteUserEmail))
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


        #region Search User

        ///////////////////////////////////////////
        ////        Search User Form          /////
        ///////////////////////////////////////////


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckSearchUserEmailValidation()
        {
            string errorMessage = "";
            string email = tbSearchUserEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid\n";
            }

            this._ShowErrorMessage(Inputs.SearchUserEmail, ref errMsgSearchUserEmail, ref errorMessage);

            this._SetLoginButtonEnableProperties(btnSearchUser, Inputs.SearchUserEmail);
        }


        private void tbSearchUserEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckSearchUserEmailValidation();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (!this._IsEmailValid(tbSearchUserEmail))
            {
                this._CheckSearchUserEmailValidation();

                return;
            }

            // Start Database Searching process
        }

        #endregion

        #region Delete User

        ///////////////////////////////////////////
        ////        Delete User Form          /////
        ///////////////////////////////////////////


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckDeleteUserEmailValidation()
        {
            string errorMessage = "";
            string email = tbDeleteUserEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid\n";
            }

            this._ShowErrorMessage(Inputs.DeleteUserEmail, ref errMsgDeleteUserEmail, ref errorMessage);

            this._SetLoginButtonEnableProperties(btnDeleteUser, Inputs.DeleteUserEmail);
        }

        private void tbDeleteUserEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckDeleteUserEmailValidation();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (!this._IsEmailValid(tbDeleteUserEmail))
            {
                this._CheckDeleteUserEmailValidation();

                return;
            }

            // Start Database Deleting process
        }

        #endregion
    }
}
