using System.Text;

namespace FileHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo[] d = DriveInfo.GetDrives();
            foreach (DriveInfo di in d)
            {
                comboBox1.Items.Add(di.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DriveInfo di = new DriveInfo(comboBox1.Text);
                txtDriveProperties.Text = di.Name + "\t Free Space: " + Convert.ToString(di.TotalFreeSpace) + "\t Total Size:" + di.TotalSize + "\t" + di.RootDirectory + "\t" + di.DriveType + "\t" + di.DriveFormat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(txtEnterFileName.Text);
                MessageBox.Show("Directory Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(txtEnterFileName.Text + "/" + EnterSubDirectory.Text);
            MessageBox.Show("Sub Directory created");
        }

        private void btnShowDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo a = new DirectoryInfo(EnterSubDirectory.Text);
                cmbShowSub.Items.Add(a.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.Create(txtCreateFileNameWithPath.Text));
            sw.WriteLine(txtWriteSomething.Text);
            sw.Close();
            MessageBox.Show("Write Successfully");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(txtCreateFileNameWithPath.Text);
                txtReadFile.Text = sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Read Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                File.AppendAllText(txtCreateFileNameWithPath.Text, txtAddContent.Text);
                MessageBox.Show("Add Content Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindWord_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fr = new FileStream(txtCreateFileNameWithPath.Text, FileMode.Open, FileAccess.Read);
                StreamReader s = new StreamReader(fr);
                String str = s.ReadToEnd();
                int i = (str.IndexOf(txtFindWord.Text, 0));
                if (i > -1)
                {
                    MessageBox.Show("This word is present");
                }
                else
                {
                    MessageBox.Show("Word not present");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvertToBinary_Click(object sender, EventArgs e)
        {
            // Get the path of the text file to convert
            string filePath = txtCreateFileNameWithPath.Text;

            // Create a binary file with the same name as the text file
            string binaryFilePath = Path.ChangeExtension(filePath, ".bin");

            // Open the text file for reading
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Create a binary file for writing
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(binaryFilePath)))
                {
                    // Read each line from the text file and write it to the binary file
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(line);
                        writer.Write(buffer.Length);
                        writer.Write(buffer);
                    }
                }
            }

            MessageBox.Show("File converted to binary successfully!");
        }

        private void btnConvertToText_Click(object sender, EventArgs e)
        {
            // Get the path of the binary file to convert
            string binaryFilePath = txtCreateFileNameWithPath.Text;

            // Create a text file with the same name as the binary file
            string textFilePath = Path.ChangeExtension(binaryFilePath, ".txt");

            // Open the binary file for reading
            using (BinaryReader reader = new BinaryReader(File.OpenRead(binaryFilePath)))
            {
                // Create a text file for writing
                using (StreamWriter writer = new StreamWriter(textFilePath))
                {
                    // Read each line from the binary file and write it to the text file
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        int length = reader.ReadInt32();
                        byte[] buffer = reader.ReadBytes(length);
                        string line = Encoding.UTF8.GetString(buffer);
                        writer.Write(line);
                        writer.Write(Environment.NewLine);
                    }
                }
            }

            MessageBox.Show("File converted to text successfully!");
        }

    }
}