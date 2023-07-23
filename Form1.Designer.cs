namespace FileHandling
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
            label1 = new Label();
            panel1 = new Panel();
            btnShowDirectory = new Button();
            btnCreateSub = new Button();
            btnCreateDirectory = new Button();
            cmbShowSub = new ComboBox();
            EnterSubDirectory = new TextBox();
            txtEnterFileName = new TextBox();
            ShowSubDirectory = new Label();
            EnterSubDirectoryName = new Label();
            label2 = new Label();
            button2 = new Button();
            txtDriveProperties = new TextBox();
            btnSearch = new Button();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            btnConvertToText = new Button();
            btnConvertToBinary = new Button();
            btnFindWord = new Button();
            btnAdd = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            txtFindWord = new TextBox();
            txtAddContent = new TextBox();
            txtReadFile = new TextBox();
            lblAddContent = new Label();
            lblFindWord = new Label();
            lblReadFile = new Label();
            txtWriteSomething = new TextBox();
            lblWriteSomething = new Label();
            txtCreateFileNameWithPath = new TextBox();
            lblCreateFileName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 23);
            label1.TabIndex = 0;
            label1.Text = "FILE HANDLING APPLICATION ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btnShowDirectory);
            panel1.Controls.Add(btnCreateSub);
            panel1.Controls.Add(btnCreateDirectory);
            panel1.Controls.Add(cmbShowSub);
            panel1.Controls.Add(EnterSubDirectory);
            panel1.Controls.Add(txtEnterFileName);
            panel1.Controls.Add(ShowSubDirectory);
            panel1.Controls.Add(EnterSubDirectoryName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtDriveProperties);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(32, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 180);
            panel1.TabIndex = 1;
            // 
            // btnShowDirectory
            // 
            btnShowDirectory.BackColor = SystemColors.ActiveCaption;
            btnShowDirectory.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowDirectory.Location = new Point(611, 103);
            btnShowDirectory.Name = "btnShowDirectory";
            btnShowDirectory.Size = new Size(152, 24);
            btnShowDirectory.TabIndex = 12;
            btnShowDirectory.Text = "Show Directory";
            btnShowDirectory.UseVisualStyleBackColor = false;
            btnShowDirectory.Click += btnShowDirectory_Click;
            // 
            // btnCreateSub
            // 
            btnCreateSub.BackColor = SystemColors.ActiveCaption;
            btnCreateSub.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSub.Location = new Point(611, 59);
            btnCreateSub.Name = "btnCreateSub";
            btnCreateSub.Size = new Size(152, 24);
            btnCreateSub.TabIndex = 11;
            btnCreateSub.Text = "Create Sub Directory";
            btnCreateSub.UseVisualStyleBackColor = false;
            btnCreateSub.Click += btnCreateSub_Click;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.BackColor = SystemColors.ActiveCaption;
            btnCreateDirectory.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateDirectory.Location = new Point(611, 15);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(152, 25);
            btnCreateDirectory.TabIndex = 10;
            btnCreateDirectory.Text = "Create Directory";
            btnCreateDirectory.UseVisualStyleBackColor = false;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // cmbShowSub
            // 
            cmbShowSub.FormattingEnabled = true;
            cmbShowSub.Location = new Point(431, 104);
            cmbShowSub.Name = "cmbShowSub";
            cmbShowSub.Size = new Size(166, 23);
            cmbShowSub.TabIndex = 9;
            // 
            // EnterSubDirectory
            // 
            EnterSubDirectory.Location = new Point(431, 60);
            EnterSubDirectory.Name = "EnterSubDirectory";
            EnterSubDirectory.Size = new Size(166, 23);
            EnterSubDirectory.TabIndex = 8;
            // 
            // txtEnterFileName
            // 
            txtEnterFileName.Location = new Point(431, 16);
            txtEnterFileName.Name = "txtEnterFileName";
            txtEnterFileName.Size = new Size(166, 23);
            txtEnterFileName.TabIndex = 7;
            // 
            // ShowSubDirectory
            // 
            ShowSubDirectory.AutoSize = true;
            ShowSubDirectory.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowSubDirectory.Location = new Point(280, 108);
            ShowSubDirectory.Name = "ShowSubDirectory";
            ShowSubDirectory.Size = new Size(133, 19);
            ShowSubDirectory.TabIndex = 6;
            ShowSubDirectory.Text = "Show Sub Directory";
            // 
            // EnterSubDirectoryName
            // 
            EnterSubDirectoryName.AutoSize = true;
            EnterSubDirectoryName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterSubDirectoryName.Location = new Point(242, 64);
            EnterSubDirectoryName.Name = "EnterSubDirectoryName";
            EnterSubDirectoryName.Size = new Size(171, 19);
            EnterSubDirectoryName.TabIndex = 5;
            EnterSubDirectoryName.Text = "Enter Sub Directory Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 21);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 4;
            label2.Text = "Enter file name with path:\r\n";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(16, 121);
            button2.Name = "button2";
            button2.Size = new Size(202, 37);
            button2.TabIndex = 3;
            button2.Text = "Drive Properties";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtDriveProperties
            // 
            txtDriveProperties.Location = new Point(16, 46);
            txtDriveProperties.Multiline = true;
            txtDriveProperties.Name = "txtDriveProperties";
            txtDriveProperties.Size = new Size(202, 69);
            txtDriveProperties.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(143, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search Disk";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(btnConvertToText);
            panel2.Controls.Add(btnConvertToBinary);
            panel2.Controls.Add(btnFindWord);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnRead);
            panel2.Controls.Add(btnWrite);
            panel2.Controls.Add(txtFindWord);
            panel2.Controls.Add(txtAddContent);
            panel2.Controls.Add(txtReadFile);
            panel2.Controls.Add(lblAddContent);
            panel2.Controls.Add(lblFindWord);
            panel2.Controls.Add(lblReadFile);
            panel2.Controls.Add(txtWriteSomething);
            panel2.Controls.Add(lblWriteSomething);
            panel2.Controls.Add(txtCreateFileNameWithPath);
            panel2.Controls.Add(lblCreateFileName);
            panel2.Location = new Point(102, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 266);
            panel2.TabIndex = 13;
            // 
            // btnConvertToText
            // 
            btnConvertToText.BackColor = SystemColors.ActiveCaptionText;
            btnConvertToText.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertToText.ForeColor = Color.FromArgb(192, 0, 0);
            btnConvertToText.Location = new Point(533, 21);
            btnConvertToText.Name = "btnConvertToText";
            btnConvertToText.Size = new Size(91, 25);
            btnConvertToText.TabIndex = 23;
            btnConvertToText.Text = "Text";
            btnConvertToText.UseVisualStyleBackColor = false;
            btnConvertToText.Click += btnConvertToText_Click;
            // 
            // btnConvertToBinary
            // 
            btnConvertToBinary.BackColor = SystemColors.ActiveCaptionText;
            btnConvertToBinary.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertToBinary.ForeColor = Color.Red;
            btnConvertToBinary.Location = new Point(429, 21);
            btnConvertToBinary.Name = "btnConvertToBinary";
            btnConvertToBinary.Size = new Size(98, 26);
            btnConvertToBinary.TabIndex = 21;
            btnConvertToBinary.Text = "Binary";
            btnConvertToBinary.UseVisualStyleBackColor = false;
            btnConvertToBinary.Click += btnConvertToBinary_Click;
            // 
            // btnFindWord
            // 
            btnFindWord.BackColor = SystemColors.ActiveCaption;
            btnFindWord.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFindWord.Location = new Point(498, 215);
            btnFindWord.Name = "btnFindWord";
            btnFindWord.Size = new Size(69, 37);
            btnFindWord.TabIndex = 20;
            btnFindWord.Text = "Find";
            btnFindWord.UseVisualStyleBackColor = false;
            btnFindWord.Click += btnFindWord_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(350, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 37);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Append";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = SystemColors.ActiveCaption;
            btnRead.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRead.Location = new Point(198, 215);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 37);
            btnRead.TabIndex = 18;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.BackColor = SystemColors.ActiveCaption;
            btnWrite.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnWrite.Location = new Point(49, 215);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(74, 37);
            btnWrite.TabIndex = 17;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtFindWord
            // 
            txtFindWord.Location = new Point(470, 99);
            txtFindWord.Multiline = true;
            txtFindWord.Name = "txtFindWord";
            txtFindWord.Size = new Size(129, 110);
            txtFindWord.TabIndex = 14;
            // 
            // txtAddContent
            // 
            txtAddContent.Location = new Point(318, 99);
            txtAddContent.Multiline = true;
            txtAddContent.Name = "txtAddContent";
            txtAddContent.Size = new Size(129, 110);
            txtAddContent.TabIndex = 16;
            // 
            // txtReadFile
            // 
            txtReadFile.Location = new Point(172, 99);
            txtReadFile.Multiline = true;
            txtReadFile.Name = "txtReadFile";
            txtReadFile.Size = new Size(129, 110);
            txtReadFile.TabIndex = 15;
            // 
            // lblAddContent
            // 
            lblAddContent.AutoSize = true;
            lblAddContent.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddContent.Location = new Point(340, 79);
            lblAddContent.Name = "lblAddContent";
            lblAddContent.Size = new Size(83, 17);
            lblAddContent.TabIndex = 14;
            lblAddContent.Text = "Add Content";
            // 
            // lblFindWord
            // 
            lblFindWord.AutoSize = true;
            lblFindWord.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFindWord.Location = new Point(498, 79);
            lblFindWord.Name = "lblFindWord";
            lblFindWord.Size = new Size(69, 17);
            lblFindWord.TabIndex = 13;
            lblFindWord.Text = "Find Word";
            // 
            // lblReadFile
            // 
            lblReadFile.AutoSize = true;
            lblReadFile.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReadFile.Location = new Point(209, 79);
            lblReadFile.Name = "lblReadFile";
            lblReadFile.Size = new Size(64, 17);
            lblReadFile.TabIndex = 12;
            lblReadFile.Text = "Read File";
            // 
            // txtWriteSomething
            // 
            txtWriteSomething.Location = new Point(19, 99);
            txtWriteSomething.Multiline = true;
            txtWriteSomething.Name = "txtWriteSomething";
            txtWriteSomething.Size = new Size(129, 110);
            txtWriteSomething.TabIndex = 11;
            // 
            // lblWriteSomething
            // 
            lblWriteSomething.AutoSize = true;
            lblWriteSomething.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWriteSomething.Location = new Point(28, 79);
            lblWriteSomething.Name = "lblWriteSomething";
            lblWriteSomething.Size = new Size(105, 17);
            lblWriteSomething.TabIndex = 10;
            lblWriteSomething.Text = "Write Something";
            // 
            // txtCreateFileNameWithPath
            // 
            txtCreateFileNameWithPath.Location = new Point(198, 21);
            txtCreateFileNameWithPath.Name = "txtCreateFileNameWithPath";
            txtCreateFileNameWithPath.Size = new Size(201, 23);
            txtCreateFileNameWithPath.TabIndex = 9;
            // 
            // lblCreateFileName
            // 
            lblCreateFileName.AutoSize = true;
            lblCreateFileName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateFileName.Location = new Point(16, 21);
            lblCreateFileName.Name = "lblCreateFileName";
            lblCreateFileName.Size = new Size(176, 19);
            lblCreateFileName.TabIndex = 0;
            lblCreateFileName.Text = "Create File Name with path";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(868, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private TextBox txtDriveProperties;
        private Button btnSearch;
        private ComboBox comboBox1;
        private Label EnterSubDirectoryName;
        private Label label2;
        private Label ShowSubDirectory;
        private TextBox txtEnterFileName;
        private ComboBox cmbShowSub;
        private TextBox EnterSubDirectory;
        private Button btnShowDirectory;
        private Button btnCreateSub;
        private Button btnCreateDirectory;
        private Panel panel2;
        private TextBox txtCreateFileNameWithPath;
        private Label lblCreateFileName;
        private Label lblWriteSomething;
        private TextBox txtWriteSomething;
        private Label lblFindWord;
        private Label lblReadFile;
        private Button btnFindWord;
        private Button btnAdd;
        private Button btnRead;
        private Button btnWrite;
        private TextBox txtFindWord;
        private TextBox txtAddContent;
        private TextBox txtReadFile;
        private Label lblAddContent;
        private Button btnConvertToBinary;
        private Button btnConvertToText;
    }
}