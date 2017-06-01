using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 朋友类(事件的订阅者)
    /// </summary>
    class Friends
    {
        public string Name { get; set; }
        public Friends(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// 响应事件
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(this.Name+":收到!over!");
        }
        public void SendMessage(object sender,EventArgs e)
        {
            Console.WriteLine(this.Name + ":收到!over!");
        }
    }
}
