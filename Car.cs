using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public abstract class Car
    {       
        public abstract string Run();

        //導航
        public virtual string Navigation() { return "紙本地圖導航"; }
    }
}
