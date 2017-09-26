using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientControl_LagunaDelMar.VModel
{
    class VMLog
    {
        public Stack<VMLogItem> items { get; set; }
        public int maxCapacity { get; set;}

        public VMLog()
        {
            this.items = new Stack<VMLogItem>();
            this.maxCapacity = 20;
        }
        public VMLog(int capacity)
        {
            this.items = new Stack<VMLogItem>();
            this.maxCapacity = capacity;
        }

        public void agregarNuevoMensaje(string newMessage)
        {
            this.items.Push(new VMLog.VMLogItem(newMessage));
        }

        public void clearLog()
        {
            this.items.Clear();
        }

        public override string ToString()
        {
            string res = string.Empty;
            this.items.ToList().ForEach(item => res += item + "\r\n");
            return res;
        }

        public class VMLogItem
        {
            public DateTime timestamp { get; set; }
            public string text { get; set; }

            public VMLogItem() { }
            public VMLogItem(string text, DateTime timestamp)
            {
                this.timestamp = timestamp;
                this.text = text;
            }
            public VMLogItem(string text)
            {
                this.timestamp = DateTime.Now;
                this.text = text;
            }

            public override string ToString()
            {
                return String.Format("{0} | {1}",timestamp.ToString("HH:mm:ss"),this.text);
            }
        }
    }
}
