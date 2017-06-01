using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            dEMO np = new dEMO();

            //实例化朋友对象(准备发送)
            Friends f1 = new Friends("张三");
            Friends f2 = new Friends("李四");
            Friends f3 = new Friends("王五");
            Friends f4 = new Friends("赵刘");

            //注册订阅事件(确定的名单)
           // np.EventMarry += new MarryDelegate(f1.SendMessage);
            np.EventMarry += f1.SendMessage;
            np.EventMarry += f2.SendMessage;
            np.EventMarry += f3.SendMessage;
            np.EventMarry -= f4.SendMessage;

            //发布事件(发出)

            string strMessage = Console.ReadLine();
            np.onMarryComing(strMessage);

            //另一个事件
            Birthday br = new Birthday();
            br.Eventbirthday += f1.SendMessage;
            br.onBirthday("生日快乐");
            
        }
    }
}
