﻿// -------------------------------------------------------------
// FirmataRC - Version 1.0 Copyright richard.prinz@min.at 2013
// This code is under Creative Commons License V3.0
// See:
// http://creativecommons.org/licenses/by/3.0/
// http://creativecommons.org/licenses/by/3.0/at/
//
// You are allowed to use and modify this code (private and 
// commercial) as long as you reference the origin of it in
// any end user documentation, EULA's etc.

#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RcControl.Constants;
#endregion

namespace RcControl.Messages.Receive
{
    public class ReadChannelValueMessageResponse : EventArgs
    {
        public byte Channel { get; set; }
        public byte Value { get; set; }
        public RcCommandStatus Status { get; set; }
    }
}
