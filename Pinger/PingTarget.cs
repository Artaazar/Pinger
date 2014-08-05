using System;
using System.Windows.Forms;

namespace Pinger
{
    public partial class PingTarget : UserControl
    {
        public PingTarget()
        {
            InitializeComponent();
        }

        private PingAsync _pingAsyncs;

        private void PingButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PingTargetBox.Text)) return;
            if (_pingAsyncs == null)
            {
                _pingAsyncs = new PingAsync();
                ConstructPingAsync();
                _pingAsyncs.Activate();
            }
            else
            {
                if (_pingAsyncs.Active == 1)
                {
                    _pingAsyncs.Deactivate();
                }
                if (_pingAsyncs.Active == 0)
                {
                    ConstructPingAsync();
                    _pingAsyncs.Activate();
                }
            }
        }


        private void ConstructPingAsync()
        {
            _pingAsyncs.Target = PingTargetBox.Text;
            _pingAsyncs.PingStatus += delegate(string msg)
            {
                PingResponseLabel.Text = msg;
            };
        }

        private void DeletePingButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public event Action<PingTarget> Whendeleted;

        ~PingTarget()
        {
            Whendeleted(this);
        }
    }
}
