namespace STAX_Mania
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.Status_Eqapo = new System.Windows.Forms.Label();
            this.Install_EQ = new System.Windows.Forms.Button();
            this.Apply_Restore = new System.Windows.Forms.Button();
            this.Apply_Monitor = new System.Windows.Forms.Button();
            this.Apply_Signature = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Status_Mode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Choose_EQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "EqualizerAPO : ";
            // 
            // Status_Eqapo
            // 
            this.Status_Eqapo.AutoSize = true;
            this.Status_Eqapo.Location = new System.Drawing.Point(101, 9);
            this.Status_Eqapo.Name = "Status_Eqapo";
            this.Status_Eqapo.Size = new System.Drawing.Size(73, 12);
            this.Status_Eqapo.TabIndex = 1;
            this.Status_Eqapo.Text = "찾을 수 없음";
            // 
            // Install_EQ
            // 
            this.Install_EQ.Location = new System.Drawing.Point(14, 151);
            this.Install_EQ.Name = "Install_EQ";
            this.Install_EQ.Size = new System.Drawing.Size(172, 23);
            this.Install_EQ.TabIndex = 2;
            this.Install_EQ.Text = "EqualizerAPO 설치";
            this.Install_EQ.UseVisualStyleBackColor = true;
            this.Install_EQ.Click += new System.EventHandler(this.Install_EQ_Click);
            // 
            // Apply_Restore
            // 
            this.Apply_Restore.Location = new System.Drawing.Point(14, 93);
            this.Apply_Restore.Name = "Apply_Restore";
            this.Apply_Restore.Size = new System.Drawing.Size(172, 23);
            this.Apply_Restore.TabIndex = 3;
            this.Apply_Restore.Text = "복원";
            this.Apply_Restore.UseVisualStyleBackColor = true;
            this.Apply_Restore.Click += new System.EventHandler(this.Apply_Restore_Click);
            // 
            // Apply_Monitor
            // 
            this.Apply_Monitor.Location = new System.Drawing.Point(14, 57);
            this.Apply_Monitor.Name = "Apply_Monitor";
            this.Apply_Monitor.Size = new System.Drawing.Size(83, 30);
            this.Apply_Monitor.TabIndex = 4;
            this.Apply_Monitor.Text = "Monitor";
            this.Apply_Monitor.UseVisualStyleBackColor = true;
            this.Apply_Monitor.Click += new System.EventHandler(this.Apply_Monitor_Click);
            // 
            // Apply_Signature
            // 
            this.Apply_Signature.Location = new System.Drawing.Point(103, 57);
            this.Apply_Signature.Name = "Apply_Signature";
            this.Apply_Signature.Size = new System.Drawing.Size(83, 30);
            this.Apply_Signature.TabIndex = 5;
            this.Apply_Signature.Text = "Signature";
            this.Apply_Signature.UseVisualStyleBackColor = true;
            this.Apply_Signature.Click += new System.EventHandler(this.Apply_Signature_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "현재 모드 :";
            // 
            // Status_Mode
            // 
            this.Status_Mode.AutoSize = true;
            this.Status_Mode.Location = new System.Drawing.Point(75, 30);
            this.Status_Mode.Name = "Status_Mode";
            this.Status_Mode.Size = new System.Drawing.Size(57, 12);
            this.Status_Mode.TabIndex = 7;
            this.Status_Mode.Text = "적용 안됨";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "STAX Mania v1.1 ⓒ 2019 Alteir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choose_EQ
            // 
            this.Choose_EQ.Location = new System.Drawing.Point(14, 122);
            this.Choose_EQ.Name = "Choose_EQ";
            this.Choose_EQ.Size = new System.Drawing.Size(172, 23);
            this.Choose_EQ.TabIndex = 9;
            this.Choose_EQ.Text = "EqualizerAPO 경로 지정";
            this.Choose_EQ.UseVisualStyleBackColor = true;
            this.Choose_EQ.Click += new System.EventHandler(this.Choose_EQ_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(200, 203);
            this.Controls.Add(this.Choose_EQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Status_Mode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apply_Signature);
            this.Controls.Add(this.Apply_Restore);
            this.Controls.Add(this.Status_Eqapo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Install_EQ);
            this.Controls.Add(this.Apply_Monitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAX Mania";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status_Eqapo;
        private System.Windows.Forms.Button Install_EQ;
        private System.Windows.Forms.Button Apply_Restore;
        private System.Windows.Forms.Button Apply_Monitor;
        private System.Windows.Forms.Button Apply_Signature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Status_Mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Choose_EQ;
        
    }
}

