using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void BirthdayDelegate(string message);
    class Birthday
    {
        public event BirthdayDelegate Eventbirthday;
        /// <summary>
        /// 发布事件
        /// </summary>
        public void onBirthday(string message)
        {
            Eventbirthday(message);
        }
    }
}
