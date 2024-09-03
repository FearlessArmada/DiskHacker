using System.Text;

namespace DiskHacker
{
    public partial class Form1 : Form
    {
        private byte[] rawdata;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get all present drives and put them into the combo box
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            comboBox1.DataSource = allDrives;

            // Calculate the amount of sectors on the drive
            long size = ((DriveInfo)comboBox1.SelectedItem).TotalSize;
            int sectors = (int)(size / 512);

            // Set textBox1 to the amount of sectors
            textBox1.Text = sectors.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Remove last two chars from the end of the string
            string selected = comboBox1.SelectedItem.ToString().Remove(comboBox1.SelectedItem.ToString().Length - 2);

            // Get value from numericUpDown1
            int sector = (int)numericUpDown1.Value;

            rawdata = ReadDisk.Read(selected, sector);

            // Convert the byte array to a hex string with a space between two bytes
            StringBuilder sb = new StringBuilder();
            foreach (byte b in rawdata)
            {
                sb.Append(b.ToString("X2") + " ");
            }

            richTextBox1.Text = sb.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if rawdata is null
            if (rawdata == null)
            {
                MessageBox.Show("Please read a sector first.");
                return;
            }

            // Remove last two chars from the end of the string
            string selected = comboBox1.SelectedItem.ToString().Remove(comboBox1.SelectedItem.ToString().Length - 2);

            // Get value from numericUpDown1
            int sector = (int)numericUpDown1.Value;

            WriteDisk.Write(selected, sector, rawdata);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Load a file into rawdata
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Binary files (*.bin)|*.bin";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Check if the file is exactly 512 bytes long
                if (new FileInfo(ofd.FileName).Length != 512)
                {
                    MessageBox.Show("File must be exactly 512 bytes long.");
                    return;
                }
                rawdata = File.ReadAllBytes(ofd.FileName);

                // Convert the byte array to a hex string with a space between two bytes
                StringBuilder sb = new StringBuilder();
                foreach (byte b in rawdata)
                {
                    sb.Append(b.ToString("X2") + " ");
                }

                richTextBox1.Text = sb.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if rawdata is null
            if (rawdata == null)
            {
                MessageBox.Show("Please read a sector first.");
                return;
            }

            // Make sure rawdata is exactly 512 bytes long
            if (rawdata.Length != 512)
            {
                MessageBox.Show("Data must be exactly 512 bytes long.");
                return;
            }

            // Dump the rawdata to a file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Binary files (*.bin)|*.bin";

            // Suggest file name as drive[driveletter]_sector[sectornumber]_data.bin
            sfd.FileName = $"drive{comboBox1.SelectedItem.ToString().Remove(comboBox1.SelectedItem.ToString().Length - 2)}_sector{numericUpDown1.Value}_data.bin";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Write to file
                File.WriteAllBytes(sfd.FileName, rawdata);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Set new Sector value based on the new calculated disk size
            long size = ((DriveInfo)comboBox1.SelectedItem).TotalSize;
            int sectors = (int)(size / 512);

            // Set textBox1 to the amount of sectors
            textBox1.Text = sectors.ToString();
        }
    }
}