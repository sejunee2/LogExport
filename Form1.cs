using System.Windows.Forms;
using System.IO;
using System;
using System.IO.Compression;
using System.Net.Http.Headers;

namespace LogExport
{
    public partial class frmLogExport : Form
    {
        int nStartDate, nEndDate, nTargetDate;
        string strTargetPath;
        string strSourcePath = "C://전세준//03.참고//LogExport//01.raw//Mirae HMI//History";

        public frmLogExport()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dtStartDate = dtStartDatePicker.Value;
            DateTime dtEndDate = dtEndDatePicker.Value;

            String strStartDate = dtStartDate.ToString("yyMMdd");
            String strEndDate = dtEndDate.ToString("yyMMdd");

            nStartDate = int.Parse(strStartDate);
            nEndDate = int.Parse(strEndDate);

            lblSourcePath.Text = strSourcePath;

            textBox1.Text += "추출 파일 목록 :";
        }
        private void CopyFile()
        {
            DirectoryInfo diSourceDirectory = new DirectoryInfo(strSourcePath);
            try
            {
                DirectoryInfo diTargetDirectory = new DirectoryInfo(strTargetPath);
                if (diTargetDirectory.Exists == false)
                {
                    diTargetDirectory.Create();
                }
            }
            catch
            {
                MessageBox.Show("경로를 지정해 주십시오");
                return;
            }
            foreach (var getDir in diSourceDirectory.GetDirectories())
            {
                string strDirectoryName = getDir.Name;
                DirectoryInfo diDirectoryFiles = new DirectoryInfo(Path.Combine(strSourcePath, strDirectoryName));

                foreach (var file in diDirectoryFiles.GetFiles())
                {
                    string strFileName = Path.GetFileNameWithoutExtension(file.Name);
                    ConvertFileName(strFileName);

                    if (nTargetDate >= nStartDate && nTargetDate <= nEndDate)
                    {
                        DirectoryInfo diCheckDirectory = new DirectoryInfo(Path.Combine(strTargetPath, nTargetDate.ToString()));
                        if (diCheckDirectory.Exists == false)
                        {
                            diCheckDirectory.Create();
                        }
                        File.Copy(Path.Combine(strSourcePath, strDirectoryName, file.Name), Path.Combine(strTargetPath, nTargetDate.ToString(), file.Name), true);
                        textBox1.Text += file.Name + " ";
                    }
                    else
                    { 
                        continue; 
                    }
                }
            }
        }
        private void ConvertFileName(string _name)
        {
            try
            {
                if (_name.Length == 6) 
                { 
                    nTargetDate = int.Parse(_name); 
                }
                else
                { 
                    nTargetDate= int.Parse(_name.Substring(1, 7)); 
                }
            }
            catch
            { 
                MessageBox.Show("잘못된 형식의 파일이 들어있습니다.");
            };
        }
       
        private void btnSourceDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdDialog = new FolderBrowserDialog();
            fdDialog.ShowDialog();
            string strSelPath = fdDialog.SelectedPath;

            try
            {
                if (strSelPath.Substring(strSelPath.Length - 7) == "History" || 
                    strSelPath.Substring(strSelPath.Length - 7) == "history") 
                { 
                    strSourcePath = strSelPath; 
                    lblSourcePath.Text = strSourcePath;
                }
                else
                { 
                    MessageBox.Show("History 폴더를 선택해 주셔야 합니다."); 
                }
            }
            catch
            {
                MessageBox.Show("History 폴더를 선택해 주셔야 합니다.");
            }
        }

        private void btnTargetDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            fbDialog.ShowDialog();

            strTargetPath = fbDialog.SelectedPath;
            lblTargetPath.Text = strTargetPath;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += "추출 파일 목록 :";
        }

        private void dtStartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtStartDate = dtStartDatePicker.Value;
            nStartDate = int.Parse(dtStartDate.ToString("yyMMdd"));
        }
        private void dtEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtEndDate = dtEndDatePicker.Value;
            nEndDate = int.Parse(dtEndDate.ToString("yyMMdd"));
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtStartDatePicker.Value, dtEndDatePicker.Value) == 1)
            {
                MessageBox.Show("날짜가 잘못 선택 되었습니다.\r\n" + dtStartDatePicker.Value + dtEndDatePicker.Value);

                return;
            }
            CopyFile();
        }

        private void btnCollectZIP_Click(object sender, EventArgs e)
        {
            CopyFile();
            try
            {
                ZipFile.CreateFromDirectory(strTargetPath, strTargetPath + ".zip");
            }
            catch
            {
                return;
            }
            
        }
    }
}
