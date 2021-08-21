
namespace NameMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbVoices = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbLength2 = new System.Windows.Forms.RadioButton();
            this.rbLength3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("微软雅黑", 92F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(758, 300);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "无名氏";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("黑体", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(706, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0";
            this.button1.Text = "▶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbVoices
            // 
            this.cmbVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoices.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.cmbVoices.FormattingEnabled = true;
            this.cmbVoices.Location = new System.Drawing.Point(52, 385);
            this.cmbVoices.Name = "cmbVoices";
            this.cmbVoices.Size = new System.Drawing.Size(718, 23);
            this.cmbVoices.TabIndex = 2;
            this.cmbVoices.SelectedIndexChanged += new System.EventHandler(this.cmbVoices_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.txtLastName.Location = new System.Drawing.Point(54, 319);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 60);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Text = "东方";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓氏";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbRandom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbRandom.Location = new System.Drawing.Point(180, 353);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(95, 26);
            this.rbRandom.TabIndex = 5;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "随机长度";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbLength2
            // 
            this.rbLength2.AutoSize = true;
            this.rbLength2.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbLength2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbLength2.Location = new System.Drawing.Point(286, 353);
            this.rbLength2.Name = "rbLength2";
            this.rbLength2.Size = new System.Drawing.Size(63, 26);
            this.rbLength2.TabIndex = 6;
            this.rbLength2.Text = "单名";
            this.rbLength2.UseVisualStyleBackColor = true;
            // 
            // rbLength3
            // 
            this.rbLength3.AutoSize = true;
            this.rbLength3.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbLength3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbLength3.Location = new System.Drawing.Point(360, 353);
            this.rbLength3.Name = "rbLength3";
            this.rbLength3.Size = new System.Drawing.Size(79, 26);
            this.rbLength3.TabIndex = 7;
            this.rbLength3.Text = "双字名";
            this.rbLength3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "语音";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "语速";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(52, 414);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(718, 24);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = -1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbLength3);
            this.Controls.Add(this.rbLength2);
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.cmbVoices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "姓名生成器";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbVoices;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbLength2;
        private System.Windows.Forms.RadioButton rbLength3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

