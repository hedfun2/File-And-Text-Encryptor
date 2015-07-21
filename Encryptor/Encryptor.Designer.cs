namespace Encryptor
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.labelEncryptStatus = new System.Windows.Forms.Label();
            this.buttonRemoveFilesEncrypt = new System.Windows.Forms.Button();
            this.buttonChooseFilesEncrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelFilesToEncrypt = new System.Windows.Forms.Label();
            this.listViewEncrypt = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEncrypted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelConfirmEncrypt = new System.Windows.Forms.Label();
            this.textBoxConfirmEncrypt = new System.Windows.Forms.TextBox();
            this.labelPasswordEncrypt = new System.Windows.Forms.Label();
            this.textBoxPasswordEncrypt = new System.Windows.Forms.TextBox();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.labelDecryptStatus = new System.Windows.Forms.Label();
            this.buttonRemoveFilesDecrypt = new System.Windows.Forms.Button();
            this.buttonChooseFilesDecrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelFilesToDecrypt = new System.Windows.Forms.Label();
            this.listViewDecrypt = new System.Windows.Forms.ListView();
            this.columnFileNameDecrypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilePathDecrypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEncryptedDecrypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatusDecrypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelConfirmDecrypt = new System.Windows.Forms.Label();
            this.textBoxConfirmDecrypt = new System.Windows.Forms.TextBox();
            this.labelPasswordDecrypt = new System.Windows.Forms.Label();
            this.textBoxPasswordDecrypt = new System.Windows.Forms.TextBox();
            this.tabText = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasswordText = new System.Windows.Forms.TextBox();
            this.buttonEncryptText = new System.Windows.Forms.Button();
            this.buttonDecryptText = new System.Windows.Forms.Button();
            this.textBoxDecrypt = new System.Windows.Forms.RichTextBox();
            this.textBoxEncrypt = new System.Windows.Forms.RichTextBox();
            this.bwEncrypt = new System.ComponentModel.BackgroundWorker();
            this.bwDecrypt = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.tabDecrypt.SuspendLayout();
            this.tabText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabEncrypt);
            this.tabControl1.Controls.Add(this.tabDecrypt);
            this.tabControl1.Controls.Add(this.tabText);
            this.tabControl1.ItemSize = new System.Drawing.Size(75, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 435);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.tabEncrypt.Controls.Add(this.labelEncryptStatus);
            this.tabEncrypt.Controls.Add(this.buttonRemoveFilesEncrypt);
            this.tabEncrypt.Controls.Add(this.buttonChooseFilesEncrypt);
            this.tabEncrypt.Controls.Add(this.buttonEncrypt);
            this.tabEncrypt.Controls.Add(this.labelFilesToEncrypt);
            this.tabEncrypt.Controls.Add(this.listViewEncrypt);
            this.tabEncrypt.Controls.Add(this.labelConfirmEncrypt);
            this.tabEncrypt.Controls.Add(this.textBoxConfirmEncrypt);
            this.tabEncrypt.Controls.Add(this.labelPasswordEncrypt);
            this.tabEncrypt.Controls.Add(this.textBoxPasswordEncrypt);
            this.tabEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(983, 409);
            this.tabEncrypt.TabIndex = 0;
            this.tabEncrypt.Text = "Encrypt";
            // 
            // labelEncryptStatus
            // 
            this.labelEncryptStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEncryptStatus.AutoSize = true;
            this.labelEncryptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEncryptStatus.Location = new System.Drawing.Point(583, 20);
            this.labelEncryptStatus.Name = "labelEncryptStatus";
            this.labelEncryptStatus.Size = new System.Drawing.Size(194, 24);
            this.labelEncryptStatus.TabIndex = 12;
            this.labelEncryptStatus.Text = "Status: Not Encrypting";
            // 
            // buttonRemoveFilesEncrypt
            // 
            this.buttonRemoveFilesEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveFilesEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveFilesEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoveFilesEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRemoveFilesEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveFilesEncrypt.Location = new System.Drawing.Point(834, 259);
            this.buttonRemoveFilesEncrypt.Name = "buttonRemoveFilesEncrypt";
            this.buttonRemoveFilesEncrypt.Size = new System.Drawing.Size(131, 33);
            this.buttonRemoveFilesEncrypt.TabIndex = 11;
            this.buttonRemoveFilesEncrypt.Text = "Remove Selected Files";
            this.buttonRemoveFilesEncrypt.UseVisualStyleBackColor = false;
            this.buttonRemoveFilesEncrypt.Click += new System.EventHandler(this.buttonRemoveFilesEncrypt_Click);
            // 
            // buttonChooseFilesEncrypt
            // 
            this.buttonChooseFilesEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFilesEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChooseFilesEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonChooseFilesEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonChooseFilesEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChooseFilesEncrypt.Location = new System.Drawing.Point(834, 220);
            this.buttonChooseFilesEncrypt.Name = "buttonChooseFilesEncrypt";
            this.buttonChooseFilesEncrypt.Size = new System.Drawing.Size(131, 33);
            this.buttonChooseFilesEncrypt.TabIndex = 10;
            this.buttonChooseFilesEncrypt.Text = "Choose Files / Folders";
            this.buttonChooseFilesEncrypt.UseVisualStyleBackColor = false;
            this.buttonChooseFilesEncrypt.Click += new System.EventHandler(this.buttonChooseFilesEncrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEncrypt.Location = new System.Drawing.Point(834, 358);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(131, 45);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelFilesToEncrypt
            // 
            this.labelFilesToEncrypt.AutoSize = true;
            this.labelFilesToEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFilesToEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilesToEncrypt.Location = new System.Drawing.Point(2, 20);
            this.labelFilesToEncrypt.Name = "labelFilesToEncrypt";
            this.labelFilesToEncrypt.Size = new System.Drawing.Size(142, 24);
            this.labelFilesToEncrypt.TabIndex = 6;
            this.labelFilesToEncrypt.Text = "Files to encrypt:";
            // 
            // listViewEncrypt
            // 
            this.listViewEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEncrypt.BackColor = System.Drawing.Color.White;
            this.listViewEncrypt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName,
            this.columnFilePath,
            this.columnEncrypted,
            this.columnStatus});
            this.listViewEncrypt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewEncrypt.GridLines = true;
            this.listViewEncrypt.Location = new System.Drawing.Point(6, 47);
            this.listViewEncrypt.Name = "listViewEncrypt";
            this.listViewEncrypt.Size = new System.Drawing.Size(771, 356);
            this.listViewEncrypt.TabIndex = 5;
            this.listViewEncrypt.UseCompatibleStateImageBehavior = false;
            this.listViewEncrypt.View = System.Windows.Forms.View.Details;
            this.listViewEncrypt.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewEncrypt_ColumnClick);
            this.listViewEncrypt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewEncrypt_KeyDown);
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "File Name";
            this.columnFileName.Width = 160;
            // 
            // columnFilePath
            // 
            this.columnFilePath.Text = "Location";
            this.columnFilePath.Width = 347;
            // 
            // columnEncrypted
            // 
            this.columnEncrypted.Text = "Encrypted";
            this.columnEncrypted.Width = 109;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 151;
            // 
            // labelConfirmEncrypt
            // 
            this.labelConfirmEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfirmEncrypt.AutoSize = true;
            this.labelConfirmEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConfirmEncrypt.Location = new System.Drawing.Point(834, 98);
            this.labelConfirmEncrypt.Name = "labelConfirmEncrypt";
            this.labelConfirmEncrypt.Size = new System.Drawing.Size(91, 13);
            this.labelConfirmEncrypt.TabIndex = 4;
            this.labelConfirmEncrypt.Text = "Confirm Password";
            // 
            // textBoxConfirmEncrypt
            // 
            this.textBoxConfirmEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfirmEncrypt.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxConfirmEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxConfirmEncrypt.Location = new System.Drawing.Point(834, 117);
            this.textBoxConfirmEncrypt.Name = "textBoxConfirmEncrypt";
            this.textBoxConfirmEncrypt.PasswordChar = '•';
            this.textBoxConfirmEncrypt.Size = new System.Drawing.Size(134, 25);
            this.textBoxConfirmEncrypt.TabIndex = 3;
            // 
            // labelPasswordEncrypt
            // 
            this.labelPasswordEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPasswordEncrypt.AutoSize = true;
            this.labelPasswordEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPasswordEncrypt.Location = new System.Drawing.Point(834, 41);
            this.labelPasswordEncrypt.Name = "labelPasswordEncrypt";
            this.labelPasswordEncrypt.Size = new System.Drawing.Size(81, 13);
            this.labelPasswordEncrypt.TabIndex = 2;
            this.labelPasswordEncrypt.Text = "Enter Password";
            // 
            // textBoxPasswordEncrypt
            // 
            this.textBoxPasswordEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPasswordEncrypt.BackColor = System.Drawing.Color.White;
            this.textBoxPasswordEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxPasswordEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPasswordEncrypt.Location = new System.Drawing.Point(834, 60);
            this.textBoxPasswordEncrypt.Name = "textBoxPasswordEncrypt";
            this.textBoxPasswordEncrypt.PasswordChar = '•';
            this.textBoxPasswordEncrypt.Size = new System.Drawing.Size(134, 25);
            this.textBoxPasswordEncrypt.TabIndex = 1;
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.tabDecrypt.Controls.Add(this.labelDecryptStatus);
            this.tabDecrypt.Controls.Add(this.buttonRemoveFilesDecrypt);
            this.tabDecrypt.Controls.Add(this.buttonChooseFilesDecrypt);
            this.tabDecrypt.Controls.Add(this.buttonDecrypt);
            this.tabDecrypt.Controls.Add(this.labelFilesToDecrypt);
            this.tabDecrypt.Controls.Add(this.listViewDecrypt);
            this.tabDecrypt.Controls.Add(this.labelConfirmDecrypt);
            this.tabDecrypt.Controls.Add(this.textBoxConfirmDecrypt);
            this.tabDecrypt.Controls.Add(this.labelPasswordDecrypt);
            this.tabDecrypt.Controls.Add(this.textBoxPasswordDecrypt);
            this.tabDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecrypt.Size = new System.Drawing.Size(983, 409);
            this.tabDecrypt.TabIndex = 1;
            this.tabDecrypt.Text = "Decrypt";
            // 
            // labelDecryptStatus
            // 
            this.labelDecryptStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDecryptStatus.AutoSize = true;
            this.labelDecryptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDecryptStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDecryptStatus.Location = new System.Drawing.Point(583, 20);
            this.labelDecryptStatus.Name = "labelDecryptStatus";
            this.labelDecryptStatus.Size = new System.Drawing.Size(194, 24);
            this.labelDecryptStatus.TabIndex = 22;
            this.labelDecryptStatus.Text = "Status: Not Decrypting";
            // 
            // buttonRemoveFilesDecrypt
            // 
            this.buttonRemoveFilesDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveFilesDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveFilesDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonRemoveFilesDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoveFilesDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRemoveFilesDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveFilesDecrypt.Location = new System.Drawing.Point(834, 259);
            this.buttonRemoveFilesDecrypt.Name = "buttonRemoveFilesDecrypt";
            this.buttonRemoveFilesDecrypt.Size = new System.Drawing.Size(131, 33);
            this.buttonRemoveFilesDecrypt.TabIndex = 21;
            this.buttonRemoveFilesDecrypt.Text = "Remove Selected Files";
            this.buttonRemoveFilesDecrypt.UseVisualStyleBackColor = false;
            this.buttonRemoveFilesDecrypt.Click += new System.EventHandler(this.buttonRemoveFilesDecrypt_Click);
            // 
            // buttonChooseFilesDecrypt
            // 
            this.buttonChooseFilesDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFilesDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChooseFilesDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonChooseFilesDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonChooseFilesDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonChooseFilesDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChooseFilesDecrypt.Location = new System.Drawing.Point(834, 220);
            this.buttonChooseFilesDecrypt.Name = "buttonChooseFilesDecrypt";
            this.buttonChooseFilesDecrypt.Size = new System.Drawing.Size(131, 33);
            this.buttonChooseFilesDecrypt.TabIndex = 20;
            this.buttonChooseFilesDecrypt.Text = "Choose Files / Folders";
            this.buttonChooseFilesDecrypt.UseVisualStyleBackColor = false;
            this.buttonChooseFilesDecrypt.Click += new System.EventHandler(this.buttonChooseFilesDecrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDecrypt.Location = new System.Drawing.Point(834, 358);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(131, 45);
            this.buttonDecrypt.TabIndex = 19;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelFilesToDecrypt
            // 
            this.labelFilesToDecrypt.AutoSize = true;
            this.labelFilesToDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFilesToDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilesToDecrypt.Location = new System.Drawing.Point(2, 20);
            this.labelFilesToDecrypt.Name = "labelFilesToDecrypt";
            this.labelFilesToDecrypt.Size = new System.Drawing.Size(142, 24);
            this.labelFilesToDecrypt.TabIndex = 18;
            this.labelFilesToDecrypt.Text = "Files to decrypt:";
            // 
            // listViewDecrypt
            // 
            this.listViewDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDecrypt.BackColor = System.Drawing.Color.White;
            this.listViewDecrypt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileNameDecrypt,
            this.columnFilePathDecrypt,
            this.columnEncryptedDecrypt,
            this.columnStatusDecrypt});
            this.listViewDecrypt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewDecrypt.GridLines = true;
            this.listViewDecrypt.Location = new System.Drawing.Point(6, 47);
            this.listViewDecrypt.Name = "listViewDecrypt";
            this.listViewDecrypt.Size = new System.Drawing.Size(771, 356);
            this.listViewDecrypt.TabIndex = 17;
            this.listViewDecrypt.UseCompatibleStateImageBehavior = false;
            this.listViewDecrypt.View = System.Windows.Forms.View.Details;
            // 
            // columnFileNameDecrypt
            // 
            this.columnFileNameDecrypt.Text = "File Name";
            this.columnFileNameDecrypt.Width = 160;
            // 
            // columnFilePathDecrypt
            // 
            this.columnFilePathDecrypt.Text = "Location";
            this.columnFilePathDecrypt.Width = 347;
            // 
            // columnEncryptedDecrypt
            // 
            this.columnEncryptedDecrypt.Text = "Encrypted";
            this.columnEncryptedDecrypt.Width = 109;
            // 
            // columnStatusDecrypt
            // 
            this.columnStatusDecrypt.Text = "Status";
            this.columnStatusDecrypt.Width = 151;
            // 
            // labelConfirmDecrypt
            // 
            this.labelConfirmDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfirmDecrypt.AutoSize = true;
            this.labelConfirmDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConfirmDecrypt.Location = new System.Drawing.Point(834, 98);
            this.labelConfirmDecrypt.Name = "labelConfirmDecrypt";
            this.labelConfirmDecrypt.Size = new System.Drawing.Size(91, 13);
            this.labelConfirmDecrypt.TabIndex = 16;
            this.labelConfirmDecrypt.Text = "Confirm Password";
            // 
            // textBoxConfirmDecrypt
            // 
            this.textBoxConfirmDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfirmDecrypt.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxConfirmDecrypt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxConfirmDecrypt.Location = new System.Drawing.Point(834, 117);
            this.textBoxConfirmDecrypt.Name = "textBoxConfirmDecrypt";
            this.textBoxConfirmDecrypt.PasswordChar = '•';
            this.textBoxConfirmDecrypt.Size = new System.Drawing.Size(134, 25);
            this.textBoxConfirmDecrypt.TabIndex = 15;
            // 
            // labelPasswordDecrypt
            // 
            this.labelPasswordDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPasswordDecrypt.AutoSize = true;
            this.labelPasswordDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPasswordDecrypt.Location = new System.Drawing.Point(834, 41);
            this.labelPasswordDecrypt.Name = "labelPasswordDecrypt";
            this.labelPasswordDecrypt.Size = new System.Drawing.Size(81, 13);
            this.labelPasswordDecrypt.TabIndex = 14;
            this.labelPasswordDecrypt.Text = "Enter Password";
            // 
            // textBoxPasswordDecrypt
            // 
            this.textBoxPasswordDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPasswordDecrypt.BackColor = System.Drawing.Color.White;
            this.textBoxPasswordDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxPasswordDecrypt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPasswordDecrypt.Location = new System.Drawing.Point(834, 60);
            this.textBoxPasswordDecrypt.Name = "textBoxPasswordDecrypt";
            this.textBoxPasswordDecrypt.PasswordChar = '•';
            this.textBoxPasswordDecrypt.Size = new System.Drawing.Size(134, 25);
            this.textBoxPasswordDecrypt.TabIndex = 13;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.label1);
            this.tabText.Controls.Add(this.textBoxPasswordText);
            this.tabText.Controls.Add(this.buttonEncryptText);
            this.tabText.Controls.Add(this.buttonDecryptText);
            this.tabText.Controls.Add(this.textBoxDecrypt);
            this.tabText.Controls.Add(this.textBoxEncrypt);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Size = new System.Drawing.Size(983, 409);
            this.tabText.TabIndex = 2;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(336, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // textBoxPasswordText
            // 
            this.textBoxPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPasswordText.Location = new System.Drawing.Point(439, 188);
            this.textBoxPasswordText.Name = "textBoxPasswordText";
            this.textBoxPasswordText.PasswordChar = '•';
            this.textBoxPasswordText.Size = new System.Drawing.Size(149, 29);
            this.textBoxPasswordText.TabIndex = 4;
            // 
            // buttonEncryptText
            // 
            this.buttonEncryptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEncryptText.Location = new System.Drawing.Point(861, 185);
            this.buttonEncryptText.Name = "buttonEncryptText";
            this.buttonEncryptText.Size = new System.Drawing.Size(119, 38);
            this.buttonEncryptText.TabIndex = 3;
            this.buttonEncryptText.Text = "Encrypt";
            this.buttonEncryptText.UseVisualStyleBackColor = true;
            this.buttonEncryptText.Click += new System.EventHandler(this.buttonEncryptText_Click);
            // 
            // buttonDecryptText
            // 
            this.buttonDecryptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDecryptText.Location = new System.Drawing.Point(3, 185);
            this.buttonDecryptText.Name = "buttonDecryptText";
            this.buttonDecryptText.Size = new System.Drawing.Size(119, 38);
            this.buttonDecryptText.TabIndex = 2;
            this.buttonDecryptText.Text = "Decrypt";
            this.buttonDecryptText.UseVisualStyleBackColor = true;
            this.buttonDecryptText.Click += new System.EventHandler(this.buttonDecryptText_Click);
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(3, 241);
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.Size = new System.Drawing.Size(979, 165);
            this.textBoxDecrypt.TabIndex = 1;
            this.textBoxDecrypt.Text = "Enter text to be decrypted here";
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(4, 4);
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.Size = new System.Drawing.Size(979, 165);
            this.textBoxEncrypt.TabIndex = 0;
            this.textBoxEncrypt.Text = "Enter text to be encrypted here";
            // 
            // bwEncrypt
            // 
            this.bwEncrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwEncrypt_DoWork);
            this.bwEncrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwEncrypt_RunWorkerCompleted);
            // 
            // bwDecrypt
            // 
            this.bwDecrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDecrypt_DoWork);
            this.bwDecrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDecrypt_RunWorkerCompleted);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1015, 459);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(597, 438);
            this.Name = "mainWindow";
            this.Text = "Encryptor";
            this.tabControl1.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.tabEncrypt.PerformLayout();
            this.tabDecrypt.ResumeLayout(false);
            this.tabDecrypt.PerformLayout();
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.Label labelPasswordEncrypt;
        private System.Windows.Forms.TextBox textBoxPasswordEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.Button buttonRemoveFilesEncrypt;
        private System.Windows.Forms.Button buttonChooseFilesEncrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelFilesToEncrypt;
        private System.Windows.Forms.ListView listViewEncrypt;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.ColumnHeader columnFilePath;
        private System.Windows.Forms.ColumnHeader columnEncrypted;
        private System.Windows.Forms.Label labelConfirmEncrypt;
        private System.Windows.Forms.TextBox textBoxConfirmEncrypt;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.Button buttonRemoveFilesDecrypt;
        private System.Windows.Forms.Button buttonChooseFilesDecrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelFilesToDecrypt;
        private System.Windows.Forms.ListView listViewDecrypt;
        private System.Windows.Forms.ColumnHeader columnFileNameDecrypt;
        private System.Windows.Forms.ColumnHeader columnFilePathDecrypt;
        private System.Windows.Forms.ColumnHeader columnEncryptedDecrypt;
        private System.Windows.Forms.Label labelConfirmDecrypt;
        private System.Windows.Forms.TextBox textBoxConfirmDecrypt;
        private System.Windows.Forms.Label labelPasswordDecrypt;
        private System.Windows.Forms.TextBox textBoxPasswordDecrypt;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnStatusDecrypt;
        private System.Windows.Forms.Label labelEncryptStatus;
        private System.Windows.Forms.Label labelDecryptStatus;
        private System.ComponentModel.BackgroundWorker bwEncrypt;
        private System.ComponentModel.BackgroundWorker bwDecrypt;
        private System.Windows.Forms.Button buttonEncryptText;
        private System.Windows.Forms.Button buttonDecryptText;
        private System.Windows.Forms.RichTextBox textBoxDecrypt;
        private System.Windows.Forms.RichTextBox textBoxEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswordText;
    }
}

