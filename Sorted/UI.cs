using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorted {
    public partial class UI : Form {
        public UI() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            comboBox_SortMethod.SelectedIndex = 0;
            trackBar2.Value = 1000;
        }

        int[] Unsorted;
        private void button_GenerateNew_Click(object sender, EventArgs e) {
            Unsorted = new int[arrSize];
            Tuple<int, int> GBounds = new Tuple<int, int>(0, 1000);

            button_Sort.Enabled = true;
            Random RNG = new Random(textBox_seedInput.Text == "" ? DateTime.Now.Millisecond : textBox_seedInput.Text.GetHashCode());
            for (int i = 0; i < Unsorted.Length; i++) {
                Unsorted[i] = RNG.Next(GBounds.Item1, GBounds.Item2);
            }
            BindToUI(Unsorted);
        }

        private Color ColorFromValue(Color target, int value, int upperBound = 100) {
            decimal pct = (decimal)value / (decimal)upperBound;
            int R, G, B;
            R = (int)(target.R * pct);
            G = (int)(target.G * pct);
            B = (int)(target.B * pct);
            return Color.FromArgb(R,G,B);
            
        }

        private void BindToUI(int[] source) {
            
            //Chart
            chart1.Series.Clear();
            chart1.Series.Add("Values");
            for(int i=0; i < source.Length; i++) {
                chart1.Series["Values"].Points.AddXY(i,source[i]);
                chart1.Series["Values"].Points[i].Color = ColorFromValue(Color.Red, source[i], 1000);
            }
            chart1.Update();

            //ListBox
            listBox_vArray.DataSource = null;
            listBox_vArray.Items.Clear();
            listBox_vArray.DataSource = source;
            listBox_vArray.Update();
        }
        
        private void InterfaceControlsEnabled(bool Enabled) {
            
            button_GenerateNew.Enabled = Enabled;
            button_Sort.Enabled = Enabled;
            trackBar1.Enabled = Enabled;
            trackBar2.Enabled = Enabled;
            textBox_seedInput.Enabled = Enabled;
            comboBox_SortMethod.Enabled = Enabled;
        }
        
        private async void button_Sort_Click(object sender, EventArgs e) {
            //await Task.Run(() => Sort());
            Sort();
        }

        private void Sort() {
            InterfaceControlsEnabled(false);

            //First switch is just to get passes under automatic pass count
            if (checkBox_AutoPasses.Checked) {
                switch (SM) {
                    case SortMethod.BubbleSort: passes = Unsorted.Length; break;
                    case SortMethod.InsertSort:
                    case SortMethod.BogoSort:
                    case SortMethod.CountingSort: passes = 1; break;
                }
                trackBar1.Value = passes;
            }
            DateTime dt = DateTime.Now;

            for (int i = 0; i < passes; i++) {
                switch (SM) {
                    case SortMethod.BubbleSort:

                    Unsorted = BubbleSort(Unsorted);
                    BindToUI(Unsorted); break; //Bind to UI is only supported for predictable sorts, all others are handled in-method
                    case SortMethod.InsertSort:
                    Unsorted = InsertSort(Unsorted, chart1);
                    //BindToUI(Unsorted); 
                    break;
                    case SortMethod.BogoSort:
                    if (checkBox_AutoPasses.Checked) {
                        while (!IsSorted(Unsorted)) {
                            Unsorted = BogoSort(Unsorted);
                            BindToUI(Unsorted);
                            chart1.Update();
                        }
                    }
                    else {
                        if (!IsSorted(Unsorted)) {
                            Unsorted = BogoSort(Unsorted);
                        }
                    }
                    break;
                    case SortMethod.CountingSort:
                    CountingSort(Unsorted);
                    break;
                }
            }

            label_time.Text = (DateTime.Now - dt).ToString();
            InterfaceControlsEnabled(true);
        }
        

        private enum SortMethod : byte {
            BubbleSort = 0,
            InsertSort = 1,
            BogoSort = 2,
            CountingSort = 3
        }

        int passes = 0;
        private void trackBar1_Scroll(object sender, EventArgs e) {
            passes = trackBar1.Value;
            label_passes.Text = trackBar1.Value.ToString();
        }

        
        private void checkBox_AutoPasses_CheckedChanged(object sender, EventArgs e) {
            trackBar1.Enabled = !checkBox_AutoPasses.Checked;
            label_passes.Text = checkBox_AutoPasses.Checked ? "AUTO" : trackBar1.Value.ToString();
        }

        SortMethod SM;
        private void comboBox_SortMethod_SelectedIndexChanged(object sender, EventArgs e) {
            SM = (SortMethod)comboBox_SortMethod.SelectedIndex;
        }

        int arrSize = 1000;
        private void trackbar_arrSize(object sender, EventArgs e) {
            sizeLabel.Text = trackBar2.Value.ToString();
            arrSize = trackBar2.Value;
        }

        private bool IsSorted(int[] source) {
            for(int i = 0; i < source.Length; i++) {
                for(int j = 0; j < source.Length; j++) {
                    if(source[i] > source[j] && i < j) {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int[] BubbleSort(int[] source) {
            int temp = 0;
            for (int i = 0; i < source.Length - 1; i++) {

                if (source[i] > source[i + 1]) {
                    temp = source[i];
                    source[i] = source[i + 1];
                    source[i + 1] = temp;
                }
            }
            return source;
        }

        public int[] InsertSort(int[] source, Control Chart = null) {
            List<int> Li = new List<int>(source);
            for (int i = 0; i < Li.Count-1; i++) {
                for(int j = 1; j<Li.Count; j++) {
                    if(Li[j] < Li[i] && i < j) {
                        Li.Insert(i, Li[j]);
                        Li.RemoveAt(j+1);

                        if(Chart != null) { 
                            Chart.Update();
                            BindToUI(Li.ToArray());
                        }
                    }
                }
            }
            return Li.ToArray();
        }

        public int[] BogoSort(int[] source) {
            int temp = 0;
            int r = 0;
            Random RNG = new Random();
            for(int i = 0; i < source.Length-1; i++) {
                r = RNG.Next(0, source.Length);
                temp = source[i];
                source[i] = source[r];
                source[r] = temp;
            }
            return source;
        }

        public int[] CountingSort(int[] source) {
            Dictionary<int, int> vps = new Dictionary<int, int>();
            List<int> @new = new List<int>();
            foreach(int i in source) {
                if (!vps.ContainsKey(i)) {
                    vps.Add(i, 1);
                }
                else {
                    vps[i]++;
                }
            }

            int c = source.Min();
            while(@new.Count!=source.Length) {
                if (vps.ContainsKey(c)) {
                    for(int j = 0; j < vps[c]; j++) {
                        @new.Add(c);
                        BindToUI(@new.ToArray());
                        chart1.Update();
                    }
                    
                }
                c++;
            }
            return @new.ToArray();
        }
    }
}