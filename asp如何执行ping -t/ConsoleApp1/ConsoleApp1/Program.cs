using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Process p = new Process())
            {
                Console.WriteLine("开始执行。。。。");
                p.StartInfo.FileName = @"cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();//启动程序

                //向cmd窗口写入命令
                p.StandardInput.WriteLine(@"ping -t 127.0.0.1 > z:\1.txt");
               // p.StandardInput.WriteLine("exit");
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
                Console.WriteLine(output);

                //Ping ping = new Ping();
                //            Console.WriteLine(ping.Send("192.168.0.33").Status);
                //             Console.Read();
            }

        }
    }
}
