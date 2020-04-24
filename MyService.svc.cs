using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApplicationDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        public void DoWork()
        {
        }

        public List<MessageTable> GetAllMessage()
        {
            List<MessageTable> list = new List<MessageTable>();
            MVCWcfDbEntities entity = new MVCWcfDbEntities();
            var msgList = from k in entity.MessageTables select k;
            foreach (var item in msgList)
            {
                MessageTable msg = new MessageTable();
                msg.MessageId = item.MessageId;
                msg.MessageString = item.MessageString;
                list.Add(msg);

            }

            return list;
        }
    }
}
