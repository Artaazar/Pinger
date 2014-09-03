using System;
using System.Net.NetworkInformation;
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

        public event Action<int, int, string> OnPingStatusChanged;

        private async void DoStuff()
        {
            var successful = 0;
            var failed = 0;
            while (Active == 1)
            {
                var response = await new Ping().SendPingAsync(Target);

                if (response.Status == IPStatus.Success)
                    successful++;
                else
                    failed++;

                if (OnPingStatusChanged != null)
                {
                    OnPingStatusChanged(successful, failed, response.Status.ToString());
                }

                await Task.Delay(1000);
            }
        }


    }
}
