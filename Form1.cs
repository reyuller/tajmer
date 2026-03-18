namespace tajmer
{
    public partial class Form1 : Form
    {
        int allseconds = 0;
        int stopy = 0;
        public Form1()
        {
            InitializeComponent();
            minutnik.Interval = 1000;
            stoper.Interval = 1000;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void minuty_Click(object sender, EventArgs e)
        {

        }

        private void sekundy_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int minutes))
            {
                if (int.TryParse(textBox2.Text, out int seconds))
                {
                    allseconds = minutes * 60 + seconds;
                    tajmer.Text = TimeSpan.FromSeconds(allseconds).ToString(@"mm\:ss");

                }
            }
            else
            {
                MessageBox.Show("nieodpowiedni format czasu");
                return;
            }
             
        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        private void tajmer_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void startstoper_Click(object sender, EventArgs e)
        {
            stoper.Start();
        }

        private void stopstopy_Click(object sender, EventArgs e)
        {
            stoper.Stop();
        }

        private void tajmerstoper_Click(object sender, EventArgs e)
        {

        }
    }
}
