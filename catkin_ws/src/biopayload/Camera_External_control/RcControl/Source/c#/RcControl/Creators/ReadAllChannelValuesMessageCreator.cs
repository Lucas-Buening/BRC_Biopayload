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
using Sharpduino.Creators;
using Sharpduino.Exceptions;
using RcControl.Messages.Send;
using Sharpduino.Constants;
using RcControl.Constants;
#endregion

namespace RcControl.Creators
{
    public class ReadAllChannelValuesMessageCreator : BaseMessageCreator<ReadAllChannelValuesMessage>
    {
        public override byte[] CreateMessage(ReadAllChannelValuesMessage message)
        {
            if (message == null)
                throw new MessageCreatorException(
                    String.Format("This is not a valid {0} message",
                        this.GetType().Name));

            byte[] buffer = new byte[] 
            {
                MessageConstants.SYSEX_START,
                RcCommands.READ_ALL_CHANNEL_VALUES,
                MessageConstants.SYSEX_END
            };

            return buffer;
        }
    }
}
