namespace LogExport
{
    partial class frmLogExport
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCollect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dtEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTargetDir = new System.Windows.Forms.Button();
            this.lblTargetPath = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.btnSourceDir = new System.Windows.Forms.Button();
            this.btnCollectZIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(280, 184);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(42, 23);
            this.btnCollect.TabIndex = 0;
            this.btnCollect.Text = "추출";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(406, 58);
            this.textBox1.TabIndex = 1;
            // 
            // dtStartDatePicker
            // 
            this.dtStartDatePicker.Location = new System.Drawing.Point(12, 50);
            this.dtStartDatePicker.Name = "dtStartDatePicker";
            this.dtStartDatePicker.Size = new System.Drawing.Size(200, 21);
            this.dtStartDatePicker.TabIndex = 2;
            this.dtStartDatePicker.ValueChanged += new System.EventHandler(this.dtStartDatePicker_ValueChanged);
            // 
            // dtEndDatePicker
            // 
            this.dtEndDatePicker.Location = new System.Drawing.Point(218, 50);
            this.dtEndDatePicker.Name = "dtEndDatePicker";
            this.dtEndDatePicker.Size = new System.Drawing.Size(200, 21);
            this.dtEndDatePicker.TabIndex = 3;
            this.dtEndDatePicker.ValueChanged += new System.EventHandler(this.dtEndDatePicker_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "경로지정";
            // 
            // btnTargetDir
            // 
            this.btnTargetDir.Location = new System.Drawing.Point(353, 83);
            this.btnTargetDir.Name = "btnTargetDir";
            this.btnTargetDir.Size = new System.Drawing.Size(65, 23);
            this.btnTargetDir.TabIndex = 5;
            this.btnTargetDir.Text = "경로지정";
            this.btnTargetDir.UseVisualStyleBackColor = true;
            this.btnTargetDir.Click += new System.EventHandler(this.btnTargetDir_Click);
            // 
            // lblTargetPath
            // 
            this.lblTargetPath.AutoSize = true;
            this.lblTargetPath.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTargetPath.Location = new System.Drawing.Point(9, 74);
            this.lblTargetPath.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblTargetPath.Name = "lblTargetPath";
            this.lblTargetPath.Size = new System.Drawing.Size(37, 15);
            this.lblTargetPath.TabIndex = 6;
            this.lblTargetPath.Text = "경로";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSourcePath.Location = new System.Drawing.Point(9, 19);
            this.lblSourcePath.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(45, 15);
            this.lblSourcePath.TabIndex = 7;
            this.lblSourcePath.Text = "label2";
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(351, 19);
            this.btnSourceDir.Name = "btnSourceDir";
            this.btnSourceDir.Size = new System.Drawing.Size(65, 23);
            this.btnSourceDir.TabIndex = 8;
            this.btnSourceDir.Text = "변경..";
            this.btnSourceDir.UseVisualStyleBackColor = true;
            this.btnSourceDir.Click += new System.EventHandler(this.btnSourceDir_Click);
            // 
            // btnCollectZIP
            // 
            this.btnCollectZIP.Location = new System.Drawing.Point(328, 184);
            this.btnCollectZIP.Name = "btnCollectZIP";
            this.btnCollectZIP.Size = new System.Drawing.Size(88, 23);
            this.btnCollectZIP.TabIndex = 9;
            this.btnCollectZIP.Text = "추출 및 압축";
            this.btnCollectZIP.UseVisualStyleBackColor = true;
            this.btnCollectZIP.Click += new System.EventHandler(this.btnCollectZIP_Click);
            // 
            // frmLogExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(428, 223);
            this.Controls.Add(this.btnCollectZIP);
            this.Controls.Add(this.btnSourceDir);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.lblTargetPath);
            this.Controls.Add(this.btnTargetDir);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtEndDatePicker);
            this.Controls.Add(this.dtStartDatePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCollect);
            this.Name = "frmLogExport";
            this.Text = "LogExport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtStartDatePicker;
        private System.Windows.Forms.DateTimePicker dtEndDatePicker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTargetDir;
        private System.Windows.Forms.Label lblTargetPath;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Button btnSourceDir;
        private System.Windows.Forms.Button btnCollectZIP;
    }
}

