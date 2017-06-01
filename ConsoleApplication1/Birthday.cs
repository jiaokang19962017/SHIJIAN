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
    public delegate void BirthdayDelegate(string message);
    class Birthday
    {
        /// <summary>
        /// 定义一个事件(过生日)
        /// </summary>
        public event BirthdayDelegate Eventbirthday;
        /// <summary>
        /// 发布事件的方法
        /// </summary>
        public void onBirthday(string message)
        {
            Eventbirthday(message);
        }
    }
}
