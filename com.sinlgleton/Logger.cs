
namespace ConsoleApp1.com.sinlgleton
{


    public class Logger
    {

        private static Logger? instance;
        private Logger()
        {

        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }

            //public static Logger GetInstance()
            //{
            //    if (logger == null)
            //    {
            //        logger = new Logger();
            //    }

            //    return logger;
            //}


        }

    }
}
