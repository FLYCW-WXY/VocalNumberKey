namespace vocalkey
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.timerReloadHook = new System.Windows.Forms.Timer(this.components);
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVoiceConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxChineseAcent = new System.Windows.Forms.CheckBox();
            this.comboBoxVoicePackSelect = new System.Windows.Forms.ComboBox();
            this.groupBoxKeyConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxDot = new System.Windows.Forms.CheckBox();
            this.checkBoxNum0 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum3 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum2 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum1 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum6 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum5 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum4 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum9 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum8 = new System.Windows.Forms.CheckBox();
            this.checkBoxNum7 = new System.Windows.Forms.CheckBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁用语音播报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxVoiceConfig.SuspendLayout();
            this.groupBoxKeyConfig.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerReloadHook
            // 
            this.timerReloadHook.Enabled = true;
            this.timerReloadHook.Interval = 1000;
            this.timerReloadHook.Tick += new System.EventHandler(this.timerReloadHook_Tick);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(186, 185);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(65, 27);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.Text = "关于";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(257, 185);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(71, 27);
            this.buttonBackground.TabIndex = 0;
            this.buttonBackground.Text = "后台运行";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(121, 21);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(85, 30);
            this.buttonSwitch.TabIndex = 1;
            this.buttonSwitch.Text = "启用/禁用";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "播报语音包";
            // 
            // groupBoxVoiceConfig
            // 
            this.groupBoxVoiceConfig.Controls.Add(this.checkBoxChineseAcent);
            this.groupBoxVoiceConfig.Controls.Add(this.comboBoxVoicePackSelect);
            this.groupBoxVoiceConfig.Controls.Add(this.label1);
            this.groupBoxVoiceConfig.Location = new System.Drawing.Point(186, 12);
            this.groupBoxVoiceConfig.Name = "groupBoxVoiceConfig";
            this.groupBoxVoiceConfig.Size = new System.Drawing.Size(219, 91);
            this.groupBoxVoiceConfig.TabIndex = 3;
            this.groupBoxVoiceConfig.TabStop = false;
            this.groupBoxVoiceConfig.Text = "语音设置";
            // 
            // checkBoxChineseAcent
            // 
            this.checkBoxChineseAcent.AutoSize = true;
            this.checkBoxChineseAcent.Location = new System.Drawing.Point(17, 58);
            this.checkBoxChineseAcent.Name = "checkBoxChineseAcent";
            this.checkBoxChineseAcent.Size = new System.Drawing.Size(168, 16);
            this.checkBoxChineseAcent.TabIndex = 4;
            this.checkBoxChineseAcent.Text = "将\"一\"读作\"幺\"(针对中文)";
            this.checkBoxChineseAcent.UseVisualStyleBackColor = true;
            // 
            // comboBoxVoicePackSelect
            // 
            this.comboBoxVoicePackSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoicePackSelect.FormattingEnabled = true;
            this.comboBoxVoicePackSelect.Location = new System.Drawing.Point(85, 24);
            this.comboBoxVoicePackSelect.Name = "comboBoxVoicePackSelect";
            this.comboBoxVoicePackSelect.Size = new System.Drawing.Size(121, 20);
            this.comboBoxVoicePackSelect.TabIndex = 3;
            this.comboBoxVoicePackSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoicePackSelect_SelectedIndexChanged);
            // 
            // groupBoxKeyConfig
            // 
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxDot);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum0);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum3);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum2);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum1);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum6);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum5);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum4);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum9);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum8);
            this.groupBoxKeyConfig.Controls.Add(this.checkBoxNum7);
            this.groupBoxKeyConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKeyConfig.Name = "groupBoxKeyConfig";
            this.groupBoxKeyConfig.Size = new System.Drawing.Size(162, 200);
            this.groupBoxKeyConfig.TabIndex = 4;
            this.groupBoxKeyConfig.TabStop = false;
            this.groupBoxKeyConfig.Text = "发声键位开关";
            // 
            // checkBoxDot
            // 
            this.checkBoxDot.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDot.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxDot.Location = new System.Drawing.Point(105, 148);
            this.checkBoxDot.Name = "checkBoxDot";
            this.checkBoxDot.Size = new System.Drawing.Size(37, 35);
            this.checkBoxDot.TabIndex = 0;
            this.checkBoxDot.Text = ".";
            this.checkBoxDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDot.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum0
            // 
            this.checkBoxNum0.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum0.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum0.Location = new System.Drawing.Point(19, 148);
            this.checkBoxNum0.Name = "checkBoxNum0";
            this.checkBoxNum0.Size = new System.Drawing.Size(80, 35);
            this.checkBoxNum0.TabIndex = 0;
            this.checkBoxNum0.Text = "0";
            this.checkBoxNum0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum0.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum3
            // 
            this.checkBoxNum3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum3.Location = new System.Drawing.Point(105, 107);
            this.checkBoxNum3.Name = "checkBoxNum3";
            this.checkBoxNum3.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum3.TabIndex = 0;
            this.checkBoxNum3.Text = "3";
            this.checkBoxNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum3.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum2
            // 
            this.checkBoxNum2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum2.Location = new System.Drawing.Point(62, 107);
            this.checkBoxNum2.Name = "checkBoxNum2";
            this.checkBoxNum2.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum2.TabIndex = 0;
            this.checkBoxNum2.Text = "2";
            this.checkBoxNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum2.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum1
            // 
            this.checkBoxNum1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum1.Location = new System.Drawing.Point(19, 107);
            this.checkBoxNum1.Name = "checkBoxNum1";
            this.checkBoxNum1.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum1.TabIndex = 0;
            this.checkBoxNum1.Text = "1";
            this.checkBoxNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum1.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum6
            // 
            this.checkBoxNum6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum6.Location = new System.Drawing.Point(105, 66);
            this.checkBoxNum6.Name = "checkBoxNum6";
            this.checkBoxNum6.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum6.TabIndex = 0;
            this.checkBoxNum6.Text = "6";
            this.checkBoxNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum6.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum5
            // 
            this.checkBoxNum5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum5.Location = new System.Drawing.Point(62, 66);
            this.checkBoxNum5.Name = "checkBoxNum5";
            this.checkBoxNum5.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum5.TabIndex = 0;
            this.checkBoxNum5.Text = "5";
            this.checkBoxNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum5.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum4
            // 
            this.checkBoxNum4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum4.Location = new System.Drawing.Point(19, 66);
            this.checkBoxNum4.Name = "checkBoxNum4";
            this.checkBoxNum4.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum4.TabIndex = 0;
            this.checkBoxNum4.Text = "4";
            this.checkBoxNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum4.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum9
            // 
            this.checkBoxNum9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum9.Location = new System.Drawing.Point(105, 25);
            this.checkBoxNum9.Name = "checkBoxNum9";
            this.checkBoxNum9.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum9.TabIndex = 0;
            this.checkBoxNum9.Text = "9";
            this.checkBoxNum9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum9.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum8
            // 
            this.checkBoxNum8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum8.Location = new System.Drawing.Point(62, 25);
            this.checkBoxNum8.Name = "checkBoxNum8";
            this.checkBoxNum8.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum8.TabIndex = 0;
            this.checkBoxNum8.Text = "8";
            this.checkBoxNum8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum8.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum7
            // 
            this.checkBoxNum7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNum7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNum7.Location = new System.Drawing.Point(19, 25);
            this.checkBoxNum7.Name = "checkBoxNum7";
            this.checkBoxNum7.Size = new System.Drawing.Size(37, 35);
            this.checkBoxNum7.TabIndex = 0;
            this.checkBoxNum7.Text = "7";
            this.checkBoxNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxNum7.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelStatus);
            this.groupBoxStatus.Controls.Add(this.buttonSwitch);
            this.groupBoxStatus.Location = new System.Drawing.Point(186, 111);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(219, 66);
            this.groupBoxStatus.TabIndex = 5;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "运行状态";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus.Location = new System.Drawing.Point(16, 26);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(93, 20);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "语音播报启用";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(334, 185);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(71, 27);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FLY Vocal Number Key";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示面板ToolStripMenuItem,
            this.禁用语音播报ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 98);
            // 
            // 显示面板ToolStripMenuItem
            // 
            this.显示面板ToolStripMenuItem.Name = "显示面板ToolStripMenuItem";
            this.显示面板ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.显示面板ToolStripMenuItem.Text = "显示面板";
            this.显示面板ToolStripMenuItem.Click += new System.EventHandler(this.显示面板ToolStripMenuItem_Click);
            // 
            // 禁用语音播报ToolStripMenuItem
            // 
            this.禁用语音播报ToolStripMenuItem.Name = "禁用语音播报ToolStripMenuItem";
            this.禁用语音播报ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.禁用语音播报ToolStripMenuItem.Text = "禁用语音播报";
            this.禁用语音播报ToolStripMenuItem.Click += new System.EventHandler(this.禁用语音播报ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 224);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxKeyConfig);
            this.Controls.Add(this.groupBoxVoiceConfig);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.buttonAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLY Vocal Number Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.formMain_SizeChanged);
            this.groupBoxVoiceConfig.ResumeLayout(false);
            this.groupBoxVoiceConfig.PerformLayout();
            this.groupBoxKeyConfig.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerReloadHook;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxVoiceConfig;
        private System.Windows.Forms.CheckBox checkBoxChineseAcent;
        private System.Windows.Forms.ComboBox comboBoxVoicePackSelect;
        private System.Windows.Forms.GroupBox groupBoxKeyConfig;
        private System.Windows.Forms.CheckBox checkBoxDot;
        private System.Windows.Forms.CheckBox checkBoxNum0;
        private System.Windows.Forms.CheckBox checkBoxNum3;
        private System.Windows.Forms.CheckBox checkBoxNum2;
        private System.Windows.Forms.CheckBox checkBoxNum1;
        private System.Windows.Forms.CheckBox checkBoxNum6;
        private System.Windows.Forms.CheckBox checkBoxNum5;
        private System.Windows.Forms.CheckBox checkBoxNum4;
        private System.Windows.Forms.CheckBox checkBoxNum9;
        private System.Windows.Forms.CheckBox checkBoxNum8;
        private System.Windows.Forms.CheckBox checkBoxNum7;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示面板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 禁用语音播报ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

