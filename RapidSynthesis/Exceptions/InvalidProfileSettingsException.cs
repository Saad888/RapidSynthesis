﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidSynthesis
{
    class InvalidProfileSettingsException : Exception
    {
        public InvalidProfileSettingsException() { }
        public InvalidProfileSettingsException(string msg) : base(msg) { }
    }
}
