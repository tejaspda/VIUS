﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLib.Model.Entity
{
    [Serializable]
    public class ApiResponse
    {
        private bool _successful;
        private string _data;

        public ApiResponse()
        {
            this._data = string.Empty;
            this._successful = false;
        }

        public string Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }

        public bool IsSuccessful
        {
            get
            {
                return this._successful;
            }
            set
            {
                this._successful = value;
            }
        }
    }
}
