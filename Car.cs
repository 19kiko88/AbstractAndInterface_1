using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public abstract class Car
    {
        private string name = string.Empty;

        public string Name { get { return name; } set { name = value; } }

        public Car(string paraName)
        {
            name = paraName;
        }

        public abstract string Run();

        //導航
        public virtual string Navigation() { return "紙本地圖導航"; }
    }
}
