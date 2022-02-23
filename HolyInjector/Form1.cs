using WeAreDevs_API;

namespace HolyInjector
{
    public partial class HolyInjector : Form
    {
        ExploitAPI api = new ExploitAPI();

        public HolyInjector()
        {
            InitializeComponent();
        }



        private void HolyInjector_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Point lastPoint;


        
        private void panel1_Paint(object sender, EventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void inject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();

        }

        private void scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./scripts/{scripts.SelectedItem}");

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            scripts.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(scripts, "./scripts", "*.txt");
            Functions.PopulateListBox(scripts, "./scripts", "*.lua");
        }

        private void execute_Click(object sender, EventArgs e)
        {
            api.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
    }
    }
}