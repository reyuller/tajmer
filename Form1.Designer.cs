namespace tajmer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tajmer = new Label();
            stop = new Button();
            start = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            sekundy = new Label();
            minuty = new Label();
            tabPage2 = new TabPage();
            reset = new Button();
            stopstopy = new Button();
            startstoper = new Button();
            tajmerstoper = new Label();
            minutnik = new System.Windows.Forms.Timer(components);
            stoper = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(42, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(710, 410);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tajmer);
            tabPage1.Controls.Add(stop);
            tabPage1.Controls.Add(start);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(sekundy);
            tabPage1.Controls.Add(minuty);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(702, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "minutnik";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tajmer
            // 
            tajmer.BackColor = Color.LightSeaGreen;
            tajmer.Font = new Font("Segoe UI", 68F);
            tajmer.Location = new Point(230, 210);
            tajmer.Name = "tajmer";
            tajmer.Size = new Size(271, 121);
            tajmer.TabIndex = 6;
            tajmer.Text = "00.00";
            tajmer.Click += tajmer_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.Red;
            stop.ForeColor = SystemColors.ControlLightLight;
            stop.Location = new Point(414, 169);
            stop.Name = "stop";
            stop.Size = new Size(75, 23);
            stop.TabIndex = 5;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = false;
            stop.Click += stop_Click;
            // 
            // start
            // 
            start.BackColor = Color.GreenYellow;
            start.Location = new Point(218, 169);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 4;
            start.Text = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // sekundy
            // 
            sekundy.AutoSize = true;
            sekundy.Location = new Point(416, 63);
            sekundy.Name = "sekundy";
            sekundy.Size = new Size(51, 15);
            sekundy.TabIndex = 1;
            sekundy.Text = "sekundy";
            sekundy.Click += sekundy_Click;
            // 
            // minuty
            // 
            minuty.AutoSize = true;
            minuty.Location = new Point(248, 63);
            minuty.Name = "minuty";
            minuty.Size = new Size(45, 15);
            minuty.TabIndex = 0;
            minuty.Text = "minuty";
            minuty.Click += minuty_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(reset);
            tabPage2.Controls.Add(stopstopy);
            tabPage2.Controls.Add(startstoper);
            tabPage2.Controls.Add(tajmerstoper);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(702, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "stoper";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            reset.Location = new Point(330, 124);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 3;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += button1_Click;
            // 
            // stopstopy
            // 
            stopstopy.BackColor = Color.Red;
            stopstopy.ForeColor = SystemColors.Menu;
            stopstopy.Location = new Point(423, 124);
            stopstopy.Name = "stopstopy";
            stopstopy.Size = new Size(75, 23);
            stopstopy.TabIndex = 2;
            stopstopy.Text = "stop";
            stopstopy.UseVisualStyleBackColor = false;
            stopstopy.Click += stopstopy_Click;
            // 
            // startstoper
            // 
            startstoper.BackColor = Color.Chartreuse;
            startstoper.Location = new Point(230, 124);
            startstoper.Name = "startstoper";
            startstoper.Size = new Size(75, 23);
            startstoper.TabIndex = 1;
            startstoper.Text = "start";
            startstoper.UseVisualStyleBackColor = false;
            startstoper.Click += startstoper_Click;
            // 
            // tajmerstoper
            // 
            tajmerstoper.BackColor = Color.Tomato;
            tajmerstoper.Font = new Font("Segoe UI", 67F);
            tajmerstoper.ForeColor = SystemColors.Desktop;
            tajmerstoper.Location = new Point(230, 210);
            tajmerstoper.Name = "tajmerstoper";
            tajmerstoper.Size = new Size(268, 124);
            tajmerstoper.TabIndex = 0;
            tajmerstoper.Text = "00.00";
            tajmerstoper.Click += tajmerstoper_Click;
            // 
            // minutnik
            // 
            minutnik.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button stop;
        private Button start;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label sekundy;
        private Label minuty;
        private TabPage tabPage2;
        private System.Windows.Forms.Timer minutnik;
        private Label tajmer;
        private Label tajmerstoper;
        private Button startstoper;
        private Button stopstopy;
        private Button reset;
        private System.Windows.Forms.Timer stoper;
    }
}
