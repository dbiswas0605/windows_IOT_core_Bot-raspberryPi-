using Bot.Device.RaspberryPi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Actions
{
    class Stop
    {
        private RaspberryPiDevice device;

        internal Stop(RaspberryPiDevice _device)
        {
            this.device = _device;
        }

        public void Execute()
        {
            device.stop();
        }
    }
}
