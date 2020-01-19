using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bot.Actions;
using Bot.Device.RaspberryPi;

namespace Bot.RemoteController
{
    class IOTHUB
    {
        RaspberryPiDevice piDevice = new RaspberryPiDevice();
        List<ICommand> commands = new List<ICommand>();

        public void AddCommandSequence(ICommand command)
        {
            commands.Add(command);
        }

        public void execute()
        {
            foreach(var command in commands)
            {
                command.Execute();
            }
        }

    }

}
