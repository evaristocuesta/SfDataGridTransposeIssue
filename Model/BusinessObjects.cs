#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HorizontalOrientation
{
    public class BusinessObjects : INotifyPropertyChanged
    {
        #region private members

        private int _eid;
        private string _ename;
        private string _edesignation;
        private int _eage;
        private string _earea;
        private string _egender;
        private double _esalary;
        private int _ContactID;
        private int _LoginID;
        private int _ManagerID;
        private DateTime _HireDate;
        private int _SickLeaveHours;
        private DateTime _BirthDate;

        #endregion

        # region Public properties

        public int EmployeeId
        {
            get { return _eid; }
            set
            {
                _eid = value;
                OnPropertyChanged("EmployeeId");
            }
        }

        public string EmployeeName
        {
            get { return _ename; }
            set
            {
                _ename = value;
                OnPropertyChanged("EmployeeName");
            }
        }

        public string EmployeeDesignation
        {
            get { return _edesignation; }
            set
            {
                _edesignation = value;
                OnPropertyChanged("EmployeeDesignation");
            }
        }

        public int EmployeeAge
        {
            get { return _eage; }
            set
            {
                _eage = value;
                OnPropertyChanged("EmployeeAge");
            }
        }

        public string EmployeeArea
        {
            get { return _earea; }
            set
            {
                _earea = value;
                OnPropertyChanged("EmployeeArea");
            }
        }

        public string EmployeeGender
        {
            get { return _egender; }
            set
            {
                _egender = value;
                OnPropertyChanged("EmployeeGender");
            }
        }

        public double EmployeeSalary
        {
            get { return _esalary; }
            set
            {
                _esalary = value;
                OnPropertyChanged("EmployeeSalary");
            }
        }

        public int ContactID
        {
            get { return this._ContactID; }
            set
            {
                this._ContactID = value;
                this.OnPropertyChanged("ContactID");
            }
        }

        public DateTime BirthDate
        {
            get { return this._BirthDate; }
            set
            {
                this._BirthDate = value;
                this.OnPropertyChanged("BirthDate");
            }
        }

        public DateTime HireDate
        {
            get { return this._HireDate; }
            set
            {
                this._HireDate = value;
                this.OnPropertyChanged("HireDate");
            }
        }

        public int SickLeaveHours
        {
            get { return this._SickLeaveHours; }
            set
            {
                this._SickLeaveHours = value;
                this.OnPropertyChanged("SickLeaveHours");
            }
        }

        public int LoginID
        {
            get { return _LoginID; }
            set
            {
                _LoginID = value;
                this.OnPropertyChanged("LoginID");
            }
        }

        public int ManagerID
        {
            get { return _ManagerID; }
            set
            {
                _ManagerID = value;
                this.OnPropertyChanged("ManagerID");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
