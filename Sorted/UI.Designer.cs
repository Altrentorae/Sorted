namespace Sorted {
    partial class UI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox_vArray = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_GenerateNew = new System.Windows.Forms.Button();
            this.button_Sort = new System.Windows.Forms.Button();
            this.comboBox_SortMethod = new System.Windows.Forms.ComboBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_seedInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_newThread = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_vArray
            // 
            this.listBox_vArray.FormattingEnabled = true;
            this.listBox_vArray.Location = new System.Drawing.Point(12, 12);
            this.listBox_vArray.Name = "listBox_vArray";
            this.listBox_vArray.Size = new System.Drawing.Size(120, 524);
            this.listBox_vArray.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(138, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1084, 524);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button_GenerateNew
            // 
            this.button_GenerateNew.Location = new System.Drawing.Point(1123, 542);
            this.button_GenerateNew.Name = "button_GenerateNew";
            this.button_GenerateNew.Size = new System.Drawing.Size(99, 38);
            this.button_GenerateNew.TabIndex = 2;
            this.button_GenerateNew.Text = "New";
            this.button_GenerateNew.UseVisualStyleBackColor = true;
            this.button_GenerateNew.Click += new System.EventHandler(this.button_GenerateNew_Click);
            // 
            // button_Sort
            // 
            this.button_Sort.Enabled = false;
            this.button_Sort.Location = new System.Drawing.Point(1023, 542);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(94, 38);
            this.button_Sort.TabIndex = 3;
            this.button_Sort.Text = "Sort";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // comboBox_SortMethod
            // 
            this.comboBox_SortMethod.FormattingEnabled = true;
            this.comboBox_SortMethod.Items.AddRange(new object[] {
            "BubbleSort",
            "InsertSort",
            "BogoSort",
            "CountingSort"});
            this.comboBox_SortMethod.Location = new System.Drawing.Point(892, 564);
            this.comboBox_SortMethod.Name = "comboBox_SortMethod";
            this.comboBox_SortMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SortMethod.TabIndex = 8;
            this.comboBox_SortMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox_SortMethod_SelectedIndexChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(590, 542);
            this.trackBar2.Maximum = 100000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(157, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackbar_arrSize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(553, 555);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(31, 13);
            this.sizeLabel.TabIndex = 6;
            this.sizeLabel.Text = "1000";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(12, 556);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(33, 13);
            this.label_time.TabIndex = 9;
            this.label_time.Text = "TIME";
            // 
            // textBox_seedInput
            // 
            this.textBox_seedInput.Location = new System.Drawing.Point(892, 538);
            this.textBox_seedInput.Name = "textBox_seedInput";
            this.textBox_seedInput.Size = new System.Drawing.Size(121, 20);
            this.textBox_seedInput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Algorithm";
            // 
            // checkbox_newThread
            // 
            this.checkbox_newThread.AutoSize = true;
            this.checkbox_newThread.Location = new System.Drawing.Point(753, 566);
            this.checkbox_newThread.Name = "checkbox_newThread";
            this.checkbox_newThread.Size = new System.Drawing.Size(82, 17);
            this.checkbox_newThread.TabIndex = 11;
            this.checkbox_newThread.Text = "Preserve UI";
            this.checkbox_newThread.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 589);
            this.Controls.Add(this.checkbox_newThread);
            this.Controls.Add(this.textBox_seedInput);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.comboBox_SortMethod);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_GenerateNew);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox_vArray);
            this.Name = "UI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_vArray;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_GenerateNew;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.ComboBox comboBox_SortMethod;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox textBox_seedInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbox_newThread;
    }
}

