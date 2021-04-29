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
            return false;
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

        }


        /**
         * Check the Passwrod if it's valid or not
         * 
         * @return boolean
         */

        private bool _IsPasswordValid()
        {
            return false;
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

        }

        private void tbEmail_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
