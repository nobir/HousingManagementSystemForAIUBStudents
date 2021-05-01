﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    public partial class RenterForm : Form
    {
        public RenterForm()
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
            switch (inputs)
            {
                case Inputs.RenterEditButton:

                    btn.Enabled = (this._IsRenterEditNameValid() && this._IsEmailValid(tbRenterEditEmail) && this._IsRenterEditPhoneValid());

                    break;
                case Inputs.RenterSearchHouseButton:

                    btn.Enabled = (this._IsHouseIdValid(tbRenterViewHouseId));

                    break;
                case Inputs.RenterAddHouseButton:

                    btn.Enabled = (this._IsRenterAddHouseNameValid() && this._IsRenterAddHouseNumberValid() && this._IsRenterAddHouseSectorValid() && this._IsRenterAddHousePrizeValid());

                    break;
                case Inputs.RenterDeleteHouseButton:

                    btn.Enabled = (this._IsHouseIdValid(tbRenterDeleteHouseId));

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
                case Inputs.RenterEditName:

                    if (this._IsRenterEditNameValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterEditEmail:

                    if (this._IsEmailValid(tbRenterEditEmail))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterEditPhone:

                    if (this._IsRenterEditPhoneValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterViewHouseId:

                    if (this._IsHouseIdValid(tbRenterViewHouseId))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterAddHouseName:

                    if (this._IsRenterAddHouseNameValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterAddHouseNumber:

                    if (this._IsRenterAddHouseNumberValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterAddHouseSector:

                    if (this._IsRenterAddHouseSectorValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterAddHousePrize:

                    if (this._IsRenterAddHousePrizeValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.RenterDeleteHouseId:

                    if (this._IsHouseIdValid(tbRenterDeleteHouseId))
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

        /**
         * Is House ID valid or not
         * Condition -> not empty, numeric
         * Tried on
         * @link https://regexr.com/5s15f
         * 
         * @return boolean
         */

        private bool _IsHouseIdValid(TextBox tb)
        {
            string houseId = tb.Text.Trim();
            return (houseId.Length != 0 && Regex.IsMatch(houseId, @"^[0-9]+$"));
        }


        #region Edit Profile

        ///////////////////////////////////////////
        ////        Edit Profile Form          ////
        ///////////////////////////////////////////


        /**
         * Is Name valid or not
         * Condition -> not empty, larger than 2 char, alphanumeric with -, _
         * Tried on
         * @link https://regexr.com/5rvjm
         * 
         * @return boolean
         */

        private bool _IsRenterEditNameValid()
        {
            string name = tbRenterEditName.Text.Trim();
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

        private bool _IsRenterEditPhoneValid()
        {
            string phone = tbRenterEditPhone.Text.Trim();
            return (phone.Length != 0 && Regex.IsMatch(phone, @"^(\+8801[2-9]\d{1}[0-9]\d{6})$"));
        }


        /**
         * Check the Name
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterEditNameValidation()
        {
            string errorMessage = "";
            string name = tbRenterEditName.Text.Trim();

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

            this._ShowErrorMessage(Inputs.RenterEditName, ref errMsgRenterEditName, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterEditProfile, Inputs.RenterEditButton);
        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterEditEmailValidation()
        {
            string errorMessage = "";
            string email = tbRenterEditEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid e.g admin@admin.com\n";
            }

            this._ShowErrorMessage(Inputs.RenterEditEmail, ref errMsgRenterEditEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterEditProfile, Inputs.RenterEditButton);
        }


        /**
         * Check the Phone
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterEditPhoneValidation()
        {
            string errorMessage = "";
            string phone = tbRenterEditPhone.Text.Trim();

            if (phone.Length == 0)
            {
                errorMessage += "Phone Number can't be empty\n";
            }

            if (!Regex.IsMatch(phone, @"^(\+8801[2-9]\d{1}[0-9]\d{6})$") && phone.Length != 0)
            {
                errorMessage += "Phone Number is not valid e.g +8801628769304\n";
            }

            this._ShowErrorMessage(Inputs.RenterEditPhone, ref errMsgRenterEditPhone, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterEditProfile, Inputs.RenterEditButton);
        }

        private void tbRenterEditName_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterEditNameValidation();
        }

        private void tbRenterEditEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterEditEmailValidation();
        }

        private void tbRenterEditPhone_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterEditPhoneValidation();
        }

        private void btnRenterEditProfile_Click(object sender, EventArgs e)
        {
            if (!this._IsRenterEditNameValid() || !this._IsEmailValid(tbRenterEditEmail) || !this._IsRenterEditPhoneValid())
            {
                this._CheckRenterEditNameValidation();
                this._CheckRenterEditEmailValidation();
                this._CheckRenterEditPhoneValidation();

                return;
            }

            // Start Database Editing process
        }

        #endregion


        #region View House

        /////////////////////////////////////////
        ////        View House Form          ////
        /////////////////////////////////////////


        /**
         * Check the View House ID
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterViewHouseIdValidation()
        {
            string errorMessage = "";
            string houseId = tbRenterViewHouseId.Text.Trim();

            if (houseId.Length == 0)
            {
                errorMessage += "House ID can't be empty\n";
            }

            if (!Regex.IsMatch(houseId, @"^[0-9]+$") && houseId.Length != 0)
            {
                errorMessage += "House ID must be Numeric\n";
            }

            this._ShowErrorMessage(Inputs.RenterViewHouseId, ref errMsgRenterViewHouseId, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterViewHouse, Inputs.RenterSearchHouseButton);
        }

        private void tbRenterViewHouseId_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterViewHouseIdValidation();
        }

        private void btnRenterViewHouse_KeyUp(object sender, KeyEventArgs e)
        {
            if (this._IsHouseIdValid(tbRenterViewHouseId))
            {
                this._CheckRenterViewHouseIdValidation();

                return;
            }

            // Start Database Searching process
        }

        #endregion


        #region Add House

        ////////////////////////////////////////
        ////        Add House Form          ////
        ////////////////////////////////////////


        /**
         * Is House Name valid or not
         * Condition -> not empty, larger than 2 char, alphanumeric with -, _
         * Tried on
         * @link https://regexr.com/5rvjm
         * 
         * @return boolean
         */

        private bool _IsRenterAddHouseNameValid()
        {
            string houseName = tbRenterAddHouseName.Text.Trim();
            return (houseName.Length > 2 && Regex.IsMatch(houseName, @"^[a-zA-Z0-9-_]+$"));
        }

        /**
         * Is House Number valid or not
         * Condition -> not empty, numeric
         * Tried on
         * @link https://regexr.com/5s15f
         * 
         * @return boolean
         */

        private bool _IsRenterAddHouseNumberValid()
        {
            string houseNumber = tbRenterAddHouseNumber.Text.Trim();
            return (houseNumber.Length != 0 && Regex.IsMatch(houseNumber, @"^[0-9]+$"));
        }

        /**
         * Is House Number valid or not
         * Condition -> not empty, numeric
         * Tried on
         * @link https://regexr.com/5s15f
         * 
         * @return boolean
         */

        private bool _IsRenterAddHouseSectorValid()
        {
            string houseSector = tbRenterAddHouseSector.Text.Trim();
            return (houseSector.Length != 0 && Regex.IsMatch(houseSector, @"^[0-9]+$"));
        }

        /**
         * Is House Number valid or not
         * Condition -> not empty, formate eg 2343.34, 3453453453.23
         * Tried on
         * @link https://regexr.com/5s1im
         * 
         * @return boolean
         */

        private bool _IsRenterAddHousePrizeValid()
        {
            string housePrize = tbRenterAddHousePrize.Text.Trim();
            return (housePrize.Length != 0 && Regex.IsMatch(housePrize, @"^([0-9]+(\.[0-9]\d{1}))$"));
        }


        /**
         * Check the House Name
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterAddHouseNameValidation()
        {
            string errorMessage = "";
            string houseName = tbRenterAddHouseName.Text.Trim();

            if (houseName.Length == 0)
            {
                errorMessage += "House Name can't be empty\n";
            }

            if (houseName.Length < 3 && houseName.Length != 0)
            {
                errorMessage += "House Name must be larger than 2 character\n";
            }

            if (!Regex.IsMatch(houseName, @"^([a-zA-Z0-9-_])+$") && houseName.Length != 0)
            {
                errorMessage += "House Name must be alphaneumeric, dash(-) and underscore(_) \n";
            }

            this._ShowErrorMessage(Inputs.RenterAddHouseName, ref errMsgRenterAddHouseName, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterAddHouse, Inputs.RenterAddHouseButton);
        }


        /**
         * Check the Add House Number
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterAddHouseNumberValidation()
        {
            string errorMessage = "";
            string houseNumber = tbRenterAddHouseNumber.Text.Trim();

            if (houseNumber.Length == 0)
            {
                errorMessage += "House Number can't be empty\n";
            }

            if (!Regex.IsMatch(houseNumber, @"^[0-9]+$") && houseNumber.Length != 0)
            {
                errorMessage += "House Number must be Numeric\n";
            }

            this._ShowErrorMessage(Inputs.RenterAddHouseNumber, ref errMsgRenterAddHouseNumber, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterAddHouse, Inputs.RenterAddHouseButton);
        }


        /**
         * Check the Add House Sector
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterAddHouseSectorValidation()
        {
            string errorMessage = "";
            string houseSector = tbRenterAddHouseSector.Text.Trim();

            if (houseSector.Length == 0)
            {
                errorMessage += "House Sector can't be empty\n";
            }

            if (!Regex.IsMatch(houseSector, @"^[0-9]+$") && houseSector.Length != 0)
            {
                errorMessage += "House Sector must be Numeric\n";
            }

            this._ShowErrorMessage(Inputs.RenterAddHouseSector, ref errMsgRenterAddHouseSector, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterAddHouse, Inputs.RenterAddHouseButton);
        }


        /**
         * Check the Add House Prize
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterAddHousePrizeValidation()
        {
            string errorMessage = "";
            string housePrize = tbRenterAddHousePrize.Text.Trim();

            if (housePrize.Length == 0)
            {
                errorMessage += "House Prize can't be empty\n";
            }

            if (!Regex.IsMatch(housePrize, @"^([0-9]+(\.[0-9]\d{1}))$") && housePrize.Length != 0)
            {
                errorMessage += "House Prize is not valid e.g 1000.00\n";
            }

            this._ShowErrorMessage(Inputs.RenterAddHousePrize, ref errMsgRenterAddHousePrize, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterAddHouse, Inputs.RenterAddHouseButton);
        }

        private void tbRenterAddHouseName_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterAddHouseNameValidation();
        }

        private void tbRenterAddHouseNumber_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterAddHouseNumberValidation();
        }

        private void tbRenterAddHouseSector_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterAddHouseSectorValidation();
        }

        private void tbRenterAddHousePrize_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterAddHousePrizeValidation();
        }

        private void btnRenterAddHouse_Click(object sender, EventArgs e)
        {
            if (!this._IsRenterAddHouseNameValid() || !this._IsRenterAddHouseNumberValid() || !this._IsRenterAddHouseSectorValid() || !this._IsRenterAddHousePrizeValid())
            {
                this._CheckRenterAddHouseNameValidation();
                this._CheckRenterAddHouseNumberValidation();
                this._CheckRenterAddHouseSectorValidation();
                this._CheckRenterAddHousePrizeValidation();

                return;
            }

            // Start Database Addding process
        }

        #endregion


        #region Delete House

        /////////////////////////////////////////
        ////        View House Form          ////
        /////////////////////////////////////////


        /**
         * Check the Delete House ID
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRenterDeleteHouseIdValidation()
        {
            string errorMessage = "";
            string houseId = tbRenterDeleteHouseId.Text.Trim();

            if (houseId.Length == 0)
            {
                errorMessage += "House ID can't be empty\n";
            }

            if (!Regex.IsMatch(houseId, @"^[0-9]+$") && houseId.Length != 0)
            {
                errorMessage += "House ID must be Numeric\n";
            }

            this._ShowErrorMessage(Inputs.RenterDeleteHouseId, ref errMsgRenterDeleteHouseId, ref errorMessage);

            this._SetButtonEnableProperties(btnRenterDeleteHouse, Inputs.RenterDeleteHouseButton);
        }

        private void tbRenterDeleteHouseId_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRenterDeleteHouseIdValidation();
        }

        private void btnRenterDeleteHouse_Click(object sender, EventArgs e)
        {
            if (this._IsHouseIdValid(tbRenterDeleteHouseId))
            {
                this._CheckRenterDeleteHouseIdValidation();

                return;
            }

            // Start Database Searching process
        }

        #endregion
    }
}
