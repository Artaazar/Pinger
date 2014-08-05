using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _pingtarget = new PingTarget();
            PingModels.Add(new PingModel() { PingTarget = new PingTarget(), Target = "" });
            GenerateControlList(PingModels);
            PingModels.CollectionChanged += PingModels_CollectionChanged;
            InitializeComponent();

        }

        void PingModels_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private PingTarget _pingtarget;

        private void button1_Click(object sender, EventArgs e)
        {
            PingModels.Add(new PingModel(){ PingTarget = _pingtarget,Target = ""});

            GenerateControlList(PingModels);
        }

        public void PingDeleted(PingTarget target)
        {
            var model = PingModels.FirstOrDefault(x => x.PingTarget == target);
            PingModels.Remove(model);
            Controls.Clear();
            GenerateControlList(PingModels);
        }

        private void GenerateControlList(ObservableCollection<PingModel> pingModels)
        {
            var yparam = 15;
            foreach (var pingmodel in pingModels)
            {
                pingmodel.PingTarget.Location = new Point(15, yparam);
                Controls.Add(pingmodel.PingTarget);
                yparam += 45;
            }
        }

        public ObservableCollection<PingModel> PingModels = new ObservableCollection<PingModel>();
    }

    public class PingModel
    {
        public string Target { get; set; }

        public PingTarget PingTarget { get; set; }


    }




}
