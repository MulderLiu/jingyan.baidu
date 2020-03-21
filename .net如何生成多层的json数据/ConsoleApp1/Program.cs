using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            datalevel1 l1 = new datalevel1();
            l1.levelName = "第一层";

            l1.l2 = new datalevel2() {
                level2Name= "第二层",
                l23 = new datalevel3() {
                    level3Name = "第二层中的第三层",
                }
            };

            l1.l3 = new datalevel3()
            {
                level3Name = "第三层",
            };

            string jsonstr = JsonConvert.SerializeObject(l1);
            Console.Write(jsonstr);
        }
    }

    public class datalevel1
    {
        public string  levelName { get; set; }
        public datalevel2 l2 { get; set; }
        public datalevel3 l3 { get; set; }
    }

    public class datalevel2
    {
        public string level2Name { get; set; }
        public datalevel3 l23 { get; set; }
    }

    public class datalevel3
    {
        public string level3Name { get; set; }
    }
}
