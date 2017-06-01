using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 自定义委托
    /// </summary>
    /// <param name="message"></param>
    public delegate void MarryDelegate(string message);
  
    /// <summary>
    /// 新郎官类,用来发布事件
    /// </summary>
    class dEMO
    {
        /// <summary>
        /// 定义一个事件(结婚)
        /// //使用自定义委托类型
        /// </summary>
        public event EventHandler EventMarry;

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="message"></param>
        public void onMarryComing(string message)
        {
            Console.WriteLine(message);
            EventMarry(this,new EventArgs());
        }
    }
}
