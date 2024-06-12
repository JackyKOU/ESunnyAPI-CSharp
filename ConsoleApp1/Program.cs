using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIG_CSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var m_QuoteCtrl = new QuoteController();

            int iInitAPIRst = m_QuoteCtrl.InitQuoteAPI();
            if (0 != iInitAPIRst)
            {
                Console.WriteLine("初始化行情API失败，错误码：" + iInitAPIRst);
                return;
            }
            else
            {
                Console.WriteLine("chushi");
            }
            string ip = "61.163.243.173";
            ushort port = 7171;
            string username = "ESUNNY";
            string password = "Es123456";

            bool ret =  m_QuoteCtrl.Login(ip, port, username, password);
            Console.WriteLine("login:" + ret);
            Console.ReadKey();
        }
    }
}
