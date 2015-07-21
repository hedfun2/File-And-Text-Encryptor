using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Encryption;
using System.Threading;
using System.Collections;

namespace Encryptor
{
    public partial class mainWindow : Form
    {
        AESEncryption aes = new AESEncryption();
        delegate void LabelDecryptDel(string text);
        private delegate ListView.ListViewItemCollection GetItems(ListView lstview);
        int currentEncryptItem = 0;
        int currentDecryptItem = 0;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void buttonChooseFilesEncrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.Multiselect = true;

            String[] files = { };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                files = fileDialog.FileNames;
                string alreadyEncrypted = "";
                string alreadyAdded = "";
                bool foundSame = false;
                foreach (String filePath in files)
                {
                    foundSame = false;
                    foreach (ListViewItem lvi in listViewEncrypt.Items)
                    {
                        if (lvi.SubItems[1].Text == filePath)
                        {
                            alreadyAdded += filePath + "\n";
                            foundSame = true;
                            break;
                        }

                    }
                    if (filePath.Substring(filePath.LastIndexOf('.') + 1) == "encrypted" && !foundSame)
                    {
                        alreadyEncrypted += filePath + "\n";
                        continue;
                    }
                    if (!foundSame)
                        addFileToList(listViewEncrypt, filePath);
                }
                if (alreadyAdded != "")
                    MessageBox.Show("Files excluded because they are already added:\n\n" + alreadyAdded);
                if (alreadyEncrypted != "")
                    MessageBox.Show("Files excluded because they are already encrypted:\n\n" + alreadyEncrypted);
            }

        }

        private void buttonRemoveFilesEncrypt_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listViewEncrypt.SelectedItems)
            {
                lvi.Remove();
            }
        }

        private void buttonChooseFilesDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Encrypted Files (*.encrypted)|*.encrypted";
            fileDialog.Multiselect = true;

            String[] files = { };
            string alreadyAdded = "";
            bool foundSame = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                files = fileDialog.FileNames;
                foreach (String filePath in files)
                {
                    foundSame = false;
                    foreach (ListViewItem lvi in listViewDecrypt.Items)
                    {
                        if (lvi.SubItems[1].Text == filePath)
                        {
                            alreadyAdded += filePath + "\n";
                            foundSame = true;
                            break;
                        }
                    }
                    if (!foundSame)
                        addFileToList(listViewDecrypt, filePath);
                }
                if (alreadyAdded != "")
                    MessageBox.Show("Files excluded because they are already added:\n\n" + alreadyAdded);
            }
        }

        private void buttonRemoveFilesDecrypt_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listViewDecrypt.SelectedItems)
            {
                lvi.Remove();
            }
        }

        private void addFileToList(ListView listView, string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            bool isEncrypted;
            if (filePath.Substring(filePath.LastIndexOf('.') + 1) == "encrypted")
            {
                isEncrypted = true;
            }
            else
            {
                isEncrypted = false;
            }
            ListViewItem lvi = new ListViewItem(fileName);
            lvi.SubItems.Add(filePath);
            if (isEncrypted)
                lvi.SubItems.Add("Encrypted");
            else
                lvi.SubItems.Add("Not Encrypted");
            lvi.SubItems.Add("Queued");
            listView.Items.Add(lvi);
        }

        private void listViewEncrypt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                buttonRemoveFilesEncrypt_Click(sender, e);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (listViewEncrypt.Items.Count == 0)
            {
                MessageBox.Show("You don't have any files selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPasswordEncrypt.Text == "")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPasswordEncrypt.Text != textBoxConfirmEncrypt.Text)
            {
                MessageBox.Show("Passwords Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string filePath = listViewEncrypt.Items[currentEncryptItem].SubItems[1].Text;

            if (filePath.Substring(filePath.LastIndexOf('.') + 1) == "encrypted")
            {
                listViewEncrypt.Items[currentEncryptItem].SubItems[3].Text = "File Already Encrypted";
                currentEncryptItem++;
                if (listViewEncrypt.Items.Count > currentEncryptItem)
                    buttonEncrypt_Click(sender, e);
                else
                {
                    currentEncryptItem = 0;
                    labelEncryptStatus.Text = "Status: Not Encrypting";
                }
            }
            else
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(textBoxPasswordEncrypt.Text);

                labelEncryptStatus.Text = "Status: Encrypting";
                bwEncrypt.RunWorkerAsync(new EncryptData(currentEncryptItem, filePath, passwordBytes));
                textBoxConfirmDecrypt.Enabled = false;
                textBoxConfirmEncrypt.Enabled = false;
                textBoxPasswordDecrypt.Enabled = false;
                textBoxPasswordEncrypt.Enabled = false;
                buttonChooseFilesDecrypt.Enabled = false;
                buttonChooseFilesEncrypt.Enabled = false;
                buttonDecrypt.Enabled = false;
                buttonEncrypt.Enabled = false;
                buttonRemoveFilesDecrypt.Enabled = false;
                buttonRemoveFilesEncrypt.Enabled = false;
            }


        }

        private void bwEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            EncryptData data = (EncryptData)e.Argument;
            string filePath = data.filePathData;
            byte[] passwordBytes = data.passwordBytesData;

            aes.EncryptFile(filePath, filePath + ".encrypted", passwordBytes);


        }

        private void bwEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListViewItem lvi = listViewEncrypt.Items[currentEncryptItem];

            if (e.Error != null)
            {
                if (e.Error is FileLoadException || e.Error is FieldAccessException)
                {
                    lvi.SubItems[3].Text = "Unable To Access File";
                }
                else if (e.Error is FileNotFoundException)
                {
                    lvi.SubItems[3].Text = "File Not Found";
                }
                else if (e.Error is IOException)
                {
                    lvi.SubItems[3].Text = "Encrypted Version Already Exists";
                }

            }
            else
            {
                File.Delete(lvi.SubItems[1].Text);
                lvi.SubItems[0].Text = lvi.SubItems[0].Text + ".encrypted";
                lvi.SubItems[1].Text = lvi.SubItems[1].Text + ".encrypted";
                lvi.SubItems[2].Text = "Encrypted";
                lvi.SubItems[3].Text = "Successful";
            }
            currentEncryptItem++;

            if (listViewEncrypt.Items.Count > currentEncryptItem)
            {
                string filePath = listViewEncrypt.Items[currentEncryptItem].SubItems[1].Text;
                byte[] passwordBytes = Encoding.UTF8.GetBytes(textBoxPasswordEncrypt.Text);
                bwEncrypt.RunWorkerAsync(new EncryptData(currentEncryptItem, filePath, passwordBytes));
            }
            else
            {
                textBoxConfirmDecrypt.Enabled = true;
                textBoxConfirmEncrypt.Enabled = true;
                textBoxPasswordDecrypt.Enabled = true;
                textBoxPasswordEncrypt.Enabled = true;
                buttonChooseFilesDecrypt.Enabled = true;
                buttonChooseFilesEncrypt.Enabled = true;
                buttonDecrypt.Enabled = true;
                buttonEncrypt.Enabled = true;
                buttonRemoveFilesDecrypt.Enabled = true;
                buttonRemoveFilesEncrypt.Enabled = true;
                currentEncryptItem = 0;
                updateListViewDecrypt();
                labelEncryptStatus.Text = "Status: Not Encrypting";
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (listViewDecrypt.Items.Count == 0)
            {
                MessageBox.Show("You don't have any files selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPasswordDecrypt.Text == "")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPasswordDecrypt.Text != textBoxConfirmDecrypt.Text)
            {
                MessageBox.Show("Passwords Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = listViewDecrypt.Items[currentDecryptItem].SubItems[1].Text;

            if (filePath.Substring(filePath.LastIndexOf('.') + 1) != "encrypted")
            {
                listViewDecrypt.Items[currentDecryptItem].SubItems[3].Text = "File Not Encrypted";
                currentDecryptItem++;
                if (listViewDecrypt.Items.Count > currentDecryptItem)
                    buttonDecrypt_Click(sender, e);
                else
                {
                    currentDecryptItem = 0;
                    labelDecryptStatus.Text = "Status: Not Decrypting";
                }
            }
            else
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(textBoxPasswordDecrypt.Text);

                labelDecryptStatus.Text = "Status: Decrypting";
                bwDecrypt.RunWorkerAsync(new EncryptData(currentDecryptItem, filePath, passwordBytes));
                textBoxConfirmDecrypt.Enabled = false;
                textBoxConfirmEncrypt.Enabled = false;
                textBoxPasswordDecrypt.Enabled = false;
                textBoxPasswordEncrypt.Enabled = false;
                buttonChooseFilesDecrypt.Enabled = false;
                buttonChooseFilesEncrypt.Enabled = false;
                buttonDecrypt.Enabled = false;
                buttonEncrypt.Enabled = false;
                buttonRemoveFilesDecrypt.Enabled = false;
                buttonRemoveFilesEncrypt.Enabled = false;
            }
        }

        private void bwDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            EncryptData data = (EncryptData)e.Argument;
            string filePath = data.filePathData;
            byte[] passwordBytes = data.passwordBytesData;

            aes.DecryptFile(filePath.Substring(0, filePath.LastIndexOf('.')), filePath, passwordBytes);
        }

        private void bwDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListViewItem lvi = listViewDecrypt.Items[currentDecryptItem];

            if (e.Error != null)
            {
                if (e.Error is FileLoadException || e.Error is FieldAccessException)
                {
                    lvi.SubItems[3].Text = "Unable To Access File";
                }
                else if (e.Error is FileNotFoundException)
                {
                    lvi.SubItems[3].Text = "File Not Found";
                }
                else if (e.Error is IOException)
                {
                    lvi.SubItems[3].Text = "Decrypted Version Already Exists";
                }
                else if (e.Error is System.Security.Cryptography.CryptographicException)
                {
                    if (lvi.SubItems[1].Text.Substring(lvi.SubItems[1].Text.LastIndexOf('.') + 1) != "encrypted")
                        lvi.SubItems[3].Text = "File Not Encrypted";
                    else
                    {
                        lvi.SubItems[3].Text = "Invalid Password";
                        if (File.Exists(lvi.SubItems[1].Text.Substring(0, lvi.SubItems[1].Text.LastIndexOf('.'))))
                            File.Delete(lvi.SubItems[1].Text.Substring(0, lvi.SubItems[1].Text.LastIndexOf('.')));
                    }  
                }
            }
            else
            {
                File.Delete(lvi.SubItems[1].Text);

                lvi.SubItems[0].Text = lvi.SubItems[0].Text.Substring(0, lvi.SubItems[0].Text.LastIndexOf('.'));
                lvi.SubItems[1].Text = lvi.SubItems[1].Text.Substring(0, lvi.SubItems[1].Text.LastIndexOf('.'));
                lvi.SubItems[2].Text = "Not Encrypted";
                lvi.SubItems[3].Text = "Successful";
            }
            currentDecryptItem++;

            if (listViewDecrypt.Items.Count > currentDecryptItem)
            {
                string filePath = listViewDecrypt.Items[currentDecryptItem].SubItems[1].Text;
                byte[] passwordBytes = Encoding.UTF8.GetBytes(textBoxPasswordDecrypt.Text);
                bwDecrypt.RunWorkerAsync(new EncryptData(currentDecryptItem, filePath, passwordBytes));
            }
            else
            {
                textBoxConfirmDecrypt.Enabled = true;
                textBoxConfirmEncrypt.Enabled = true;
                textBoxPasswordDecrypt.Enabled = true;
                textBoxPasswordEncrypt.Enabled = true;
                buttonChooseFilesDecrypt.Enabled = true;
                buttonChooseFilesEncrypt.Enabled = true;
                buttonDecrypt.Enabled = true;
                buttonEncrypt.Enabled = true;
                buttonRemoveFilesDecrypt.Enabled = true;
                buttonRemoveFilesEncrypt.Enabled = true;
                currentDecryptItem = 0;
                updateListViewEncrypt();
                labelDecryptStatus.Text = "Status: Not Decrypting";
            }
        }

        private void updateListViewEncrypt()
        {
            foreach (ListViewItem lviDecrypt in listViewDecrypt.Items)
            {
                foreach (ListViewItem lviEncrypt in listViewEncrypt.Items)
                {
                    if (lviEncrypt.SubItems[1].Text.Contains(lviDecrypt.SubItems[1].Text))
                    {
                        lviEncrypt.SubItems[0].Text = lviDecrypt.SubItems[0].Text;
                        lviEncrypt.SubItems[1].Text = lviDecrypt.SubItems[1].Text;
                        lviEncrypt.SubItems[2].Text = lviDecrypt.SubItems[2].Text;
                        lviEncrypt.SubItems[3].Text = "Queued";
                    }
                }
            }
        }

        private void updateListViewDecrypt()
        {
            foreach (ListViewItem lviEncrypt in listViewEncrypt.Items)
            {
                foreach (ListViewItem lviDecrypt in listViewDecrypt.Items)
                {
                    if ((lviDecrypt.SubItems[1].Text + ".encrypted") == lviEncrypt.SubItems[1].Text)
                    {
                        lviDecrypt.SubItems[0].Text = lviEncrypt.SubItems[0].Text;
                        lviDecrypt.SubItems[1].Text = lviEncrypt.SubItems[1].Text;
                        lviDecrypt.SubItems[2].Text = lviEncrypt.SubItems[2].Text;
                        lviDecrypt.SubItems[3].Text = "Queued";
                    }
                }
            }
        }





        private ListView.ListViewItemCollection getListViewItems(ListView lstview)
        {
            ListView.ListViewItemCollection temp = new ListView.ListViewItemCollection(new ListView());
            if (!lstview.InvokeRequired)
            {
                MessageBox.Show("yolo");
                foreach (ListViewItem item in lstview.Items)
                    temp.Add((ListViewItem)item.Clone());
                return temp;
            }
            else
                return (ListView.ListViewItemCollection)this.Invoke(new GetItems(getListViewItems), new object[] { lstview });
        }

        private void listViewEncrypt_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listViewEncrypt.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewEncrypt_ColumnClick);
            listViewEncrypt.ListViewItemSorter = new ListViewItemComparer(e.Column);
            listViewEncrypt.Sort();
        }

        private void buttonEncryptText_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordText.Text == "")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxEncrypt.Text == "")
            {
                MessageBox.Show("Encrypt Text Box Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxDecrypt.Text = aes.EncryptString(textBoxEncrypt.Text, textBoxPasswordText.Text);
        }

        private void buttonDecryptText_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordText.Text == "")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxDecrypt.Text == "")
            {
                MessageBox.Show("Decrypt Text Box Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                textBoxEncrypt.Text = aes.DecryptString(textBoxDecrypt.Text, textBoxPasswordText.Text);
            }
            catch (Exception c)
            {
                if (c is System.Security.Cryptography.CryptographicException) 
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(c is FormatException)
                    MessageBox.Show("Invalid Encryption", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    class EncryptData
    {
        public int currentItemData { get; set; }
        public string filePathData { get; set; }
        public byte[] passwordBytesData { get; set; }

        public EncryptData(int currentItem, string filePath, byte[] passwordBytes)
        {
            this.filePathData = filePath;
            this.passwordBytesData = passwordBytes;
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
            ((ListViewItem)y).SubItems[col].Text);
            return returnVal;
        }
    }
}
