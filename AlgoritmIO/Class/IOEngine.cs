using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmIO.Class
{

    /// <summary>
    /// Базовый движок для работы с приложением
    /// </summary>
    public class IOEngine
    {

        #region CONSTANTS

        public const string CONFIG_DIR = "config/"; // Базовый путь конфигурации
        public const string DATA_DIR = "data/"; // Базовый путь данных
        public const string CLASS_DIR = "bin/"; // Базоввый путь сериализованных классов

        #endregion

        /// <summary>
        /// Экземпляр движка
        /// </summary>
        static private IOEngine Instance;
        /// <summary>
        /// Конфигурация движка
        /// </summary>
        private List<object> config;


        /// <summary>
        /// Получить экземпляр движка
        /// </summary>
        /// <returns></returns>
        public static IOEngine GetInstance()
        {
            return Instance;
        }
    }
}
