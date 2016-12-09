using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace app_timed_shutdown
{
    class ShutdownTimer
    {
        static private readonly string XML_TIMERS = "ShutdownTimer.xml";

        static public List<ShutdownTimer> Timers = new List<ShutdownTimer>();

        public string Name = string.Empty;
        public DateTime Time = DateTime.MaxValue;
        public bool Repeat = false;
        
        static public void LoadAll()
        {
            if(File.Exists(XML_TIMERS) == false)
            {
                return;
            }

            // Get rid of existing timers.
            // Timers.Clear();
            return;
        }

        static public void SaveAll()
        {
            if(Timers.Count <= 0)
            {
                return;
            }

            if(File.Exists(XML_TIMERS) == false)
            {
                File.Create(XML_TIMERS);
            }
            return;
        }
        
        static public bool Add(ShutdownTimer timer)
        {
            if(Timers.Contains(timer) == true)
            {
                return false;
            }

            foreach(ShutdownTimer t in Timers)
            {
                if(timer.Name == t.Name)
                {
                    return false;
                }
            }
            
            Timers.Add(timer);
            return true;
        }

        static public bool Remove(ShutdownTimer timer)
        {
            if(Timers.Contains(timer) == false)
            {
                return false;
            }

            Timers.Remove(timer);
            return true;
        }

        public ShutdownTimer()
        {

        }
    }
}
