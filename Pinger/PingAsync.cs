using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pinger
{
    class PingAsync
    {

        public byte Active = 0;

        public void Activate()
        {
            Active = 1;
            DoStuff();
        }

        public void Deactivate()
        {
            Active = 0;
        }


        public string Target;

        public event Action<string> PingStatus;

        private async void DoStuff()
        {
            while (Active == 1)
            {
                var response = await new Ping().SendPingAsync(Target);

                if (PingStatus != null)
                {
                    PingStatus(response.Status.ToString());
                }

                await Task.Delay(1000);
            }
        }


    }
}
