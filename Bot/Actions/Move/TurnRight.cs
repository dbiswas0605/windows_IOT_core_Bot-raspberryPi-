using Bot.Device.RaspberryPi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Actions
{
    class TurnRight : ICommand
    {
        private RaspberryPiDevice device;

        internal TurnRight(RaspberryPiDevice _device)
        {
            this.device = _device;
        }

        public void Execute()
        {
            device.turnRight();
        }
    }
}
