using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tajmer
{
	public partial class Form1 : Form
	{
		int allseconds = 0;
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
			allseconds--;

			if (allseconds <= 0)
			{
				minutnik.Stop();
				taimer67.Text = "00:00";
				MessageBox.Show("Koniec czasu!");
				return;
			}

			UpdateLabel();
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
			int minutes, seconds;

			if (!int.TryParse(textBox1.Text, out minutes))
				minutes = 0;

			if (!int.TryParse(textBox2.Text, out seconds))
				seconds = 0;

			allseconds = minutes * 60 + seconds;

			if (allseconds <= 0)
			{
				MessageBox.Show("Podaj poprawny czas!");
				return;
			}

			UpdateLabel();
			minutnik.Start();

		}

		private void stop_Click(object sender, EventArgs e)
		{
			minutnik.Stop();
		}

		private void tajmer_Click(object sender, EventArgs e)
		{

		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			stoper.Stop();
			allseconds = 0;
			UpdateLabel();
		}

		private void startstoper_Click(object sender, EventArgs e)
		{
			stoper.Start();
		}

		private void stopstopy_Click(object sender, EventArgs e)
		{
			stoper.Stop();
			allseconds = 0;
		}

		private void tajmerstoper_Click(object sender, EventArgs e)
		{
			allseconds++;
		}
		private void UpdateLabel()
		{
			int min = allseconds / 60;
			int sec = allseconds % 60;

			taimer67.Text = min.ToString("00") + ":" + sec.ToString("00");
		}

		private void stoper_Tick(object sender, EventArgs e)
		{
			allseconds++;

			int min = allseconds / 60;
			int sec = allseconds % 60;

			tajmerstoper.Text = min.ToString("00") + ":" + sec.ToString("00");
		}
	}
}