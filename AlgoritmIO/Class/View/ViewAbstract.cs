using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmIO.Class.View
{
    public abstract class ViewAbstract
    {


        private Dictionary<string, object> config;
        /// <summary>
        /// Конфигурация отображения
        /// </summary>
        public Dictionary<string, object> Config { get { return config; } set { config = value; } }


    }
}
