using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    //汽車
    public class AutoMobile: Car
    {
        public override string Run() 
        {
            return "時速可達100公里";
        }

        public override string Navigation()
        {
            //return base.Navigation();
            return "使用CarPlay 導航功能";
        }
    }
}
