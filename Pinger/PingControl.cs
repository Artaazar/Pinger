using System;
using System.Text;
using System.Windows.Forms;

namespace Pinger
{
    public partial class PingControl : UserControl
    {
        public PingControl()
        {
            InitializeComponent();
        }

        private readonly PingAsync _pingAsyncs = new PingAsync();

        private void PingButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PingTargetBox.Text))
            {
                PingResponseLabel.Text = @"Введите IP";
                return;
            }

            if (_pingAsyncs != null && _pingAsyncs.Active == 1)
            {
                PingButton.Text = @"Start";
                _pingAsyncs.Deactivate();
            }
            else
            {
                PingButton.Text = @"Stop";
                Activate();
            }

        }

        private void Activate()
        {
            _pingAsyncs.Target = PingTargetBox.Text;
            _pingAsyncs.OnPingStatusChanged += delegate(int successful, int failed, string message)
            {
                var sb = new StringBuilder("Succesed: ");
                sb.Append(successful);
                sb.Append(" Failed: ");
                sb.Append(failed);
                sb.Append(" Message: ");
                sb.Append(message);
                PingResponseLabel.Text = sb.ToString();
            };
            _pingAsyncs.Activate();
        }

        private void DeletePingButton_Click(object sender, EventArgs e)
        {
            if (OnDelete != null)
                OnDelete(this);
            _pingAsyncs.Deactivate();
            Dispose();
        }

        public event Action<PingControl> OnDelete;
    }
}
