﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApplicationDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyService" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        List<MessageTable> GetAllMessage();
    }


    [DataContract]
    public class MessageTables
    {
        [DataMember]
        public int MessageId { get; set; }
        [DataMember]
        public string MessageString { get; set; }
    }

}
