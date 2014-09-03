using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pinger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            PingModels.CollectionChanged += PingModels_CollectionChanged;
            InitializeComponent();
        }

        void PingModels_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPingTarget();
        }

        public void PingDeleted(PingControl target)
        {
            var model = PingModels.FirstOrDefault(x => x.PingTarget == target);
            PingModels.Remove(model);
            GenerateControlList(PingModels);
        }

        private void GenerateControlList(ObservableCollection<PingModel> pingModels)
        {
            var yparam = 15;
            foreach (var pingmodel in pingModels)
            {
                pingmodel.PingTarget.Location = new Point(15, yparam);
                PingBox.Controls.Add(pingmodel.PingTarget);
                yparam += 45;
            }
        }

        public static ObservableCollection<PingModel> PingModels = new ObservableCollection<PingModel>();

        private void AddPingTarget()
        {
            var pingTarget = new PingControl();
            pingTarget.OnDelete += PingDeleted;
            PingModels.Add(new PingModel { PingTarget = pingTarget, Target = "" });
            GenerateControlList(PingModels);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddPingTarget();
        }
    }

    public class PingModel
    {
        public string Target { get; set; }

        public PingControl PingTarget { get; set; }


    }




}
