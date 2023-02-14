using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{    
    public class MotorCycle : Car, ICar
    {
        public override string Run()
        {
            return "時速可達70公里";
        }

        //public string Navigation()
        //{
        //    return "使用手機GoogleMap導航功能";
        //}

        public string Reverse()
        {
            return "後退";
        }
    }
}
