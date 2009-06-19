﻿/*
 *  f1livetiming - Part of the Live Timing Library for .NET
 *  Copyright (C) 2009 Liam Lowey
 *  
 *      http://livetiming.turnitin.co.uk/
 *
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  you may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at 
 *  
 *      http://www.apache.org/licenses/LICENSE-2.0 
 *  
 *  Unless required by applicable law or agreed to in writing, software 
 *  distributed under the License is distributed on an "AS IS" BASIS, 
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
 *  See the License for the specific language governing permissions and 
 *  limitations under the License. 
 */

using System.IO;
using F1.Enums;
using F1.Data.Packets;

namespace F1.Messages.System
{
    /// <summary>
    /// This is an artificial message used to communicate when the session is over, and the
    /// internal components will exit.
    /// </summary>
    class EndOfSession : IMessage
    {
        #region IMessage members
        public Packet CreatePacketType(Header header, Stream rawStream, Stream decryptStream)
        {
            return null;
        }

        public void Deserialise(Header header, Packet payload)
        {

        }

        public SystemPacketType Type
        {
            get { return SystemPacketType.EndOfSession; }
        }
        #endregion

        public override string ToString()
        {
            return "SystemMessage: EndOfSessoin";
        }
    }
}