using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Rootobject
    {
        public string rtnCode { get; set; }
        public string rtnMsg { get; set; }
        public int amount { get; set; }
        public Payee payee { get; set; }
        public Payer payer { get; set; }
        public Message message { get; set; }
        public DateTime transferCompleteTime { get; set; }
    }

    public class Payee
    {
        public string referenceNo { get; set; }
        public string nickName { get; set; }
    }

    public class Payer
    {
        public string referenceNo { get; set; }
        public string nickName { get; set; }
    }

    public class Message
    {
        public string note { get; set; }
        public string metadata { get; set; }
        public string imgUrl { get; set; }
    }

}
