using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.com.sinlgleton
{


    public class Logger
    {

        private static Logger logger;
        private Logger() 
        {
        
        }

        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }

            return logger;
        }
    }

    
}
