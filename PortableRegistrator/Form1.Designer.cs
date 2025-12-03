
namespace PortableRegistrator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSelectExe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxProgramName = new System.Windows.Forms.TextBox();
            this.labelPortableSuffix = new System.Windows.Forms.Label();
            this.cbRegisteredPortables = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPortablePath = new System.Windows.Forms.TextBox();
            this.cbProgramType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblURLAssociations = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPropertiesParameter = new System.Windows.Forms.Label();
            this.lblOpenParameters = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileAssociations = new System.Windows.Forms.TextBox();
            this.btnRemoveAppType = new System.Windows.Forms.Button();
            this.cbRemoveSuffix = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.llGithub = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = PortableRegistrator.Properties.Resources.PortableExecutable;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(613, 272);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(124, 34);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = PortableRegistrator.Properties.Resources.btnRegister;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSelectExe
            // 
            this.btnSelectExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectExe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectExe.Location = new System.Drawing.Point(712, 235);
            this.btnSelectExe.Name = "btnSelectExe";
            this.btnSelectExe.Size = new System.Drawing.Size(25, 25);
            this.btnSelectExe.TabIndex = 4;
            this.btnSelectExe.Text = "...";
            this.btnSelectExe.UseVisualStyleBackColor = true;
            this.btnSelectExe.Click += new System.EventHandler(this.btnSelectExe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = PortableRegistrator.Properties.Resources.ProgramType;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = PortableRegistrator.Properties.Resources.ProgramName;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxProgramName
            // 
            this.tbxProgramName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxProgramName.Location = new System.Drawing.Point(173, 275);
            this.tbxProgramName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProgramName.Name = "tbxProgramName";
            this.tbxProgramName.Size = new System.Drawing.Size(204, 29);
            this.tbxProgramName.TabIndex = 8;
            this.tbxProgramName.TextChanged += new System.EventHandler(this.tbxProgramName_TextChanged);
            // 
            // labelPortableSuffix
            // 
            this.labelPortableSuffix.AutoSize = true;
            this.labelPortableSuffix.Location = new System.Drawing.Point(381, 278);
            this.labelPortableSuffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPortableSuffix.Name = "labelPortableSuffix";
            this.labelPortableSuffix.Size = new System.Drawing.Size(88, 21);
            this.labelPortableSuffix.TabIndex = 14;
            this.labelPortableSuffix.Text = PortableRegistrator.Properties.Resources.PortableSuffix;
            this.labelPortableSuffix.Click += new System.EventHandler(this.labelPortableSuffix_Click);
            // 
            // cbRegisteredPortables
            // 
            this.cbRegisteredPortables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegisteredPortables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegisteredPortables.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbRegisteredPortables.FormattingEnabled = true;
            this.cbRegisteredPortables.Location = new System.Drawing.Point(173, 71);
            this.cbRegisteredPortables.Name = "cbRegisteredPortables";
            this.cbRegisteredPortables.Size = new System.Drawing.Size(384, 29);
            this.cbRegisteredPortables.TabIndex = 10;
            this.cbRegisteredPortables.SelectedIndexChanged += new System.EventHandler(this.cbRegisteredPortables_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(51, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = PortableRegistrator.Properties.Resources.RegisteredPortables;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnUnregister);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbRegisteredPortables);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 128);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUnregister
            // 
            this.btnUnregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnregister.Location = new System.Drawing.Point(613, 68);
            this.btnUnregister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(124, 34);
            this.btnUnregister.TabIndex = 34;
            this.btnUnregister.Text = PortableRegistrator.Properties.Resources.btnUnregister;
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(170, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = PortableRegistrator.Properties.Resources.UnregisterPortableApp;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "\"";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = PortableRegistrator.Properties.Resources.RegisterPortableApp;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbxPortablePath
            // 
            this.tbxPortablePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPortablePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPortablePath.Location = new System.Drawing.Point(173, 235);
            this.tbxPortablePath.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPortablePath.Name = "tbxPortablePath";
            this.tbxPortablePath.ReadOnly = true;
            this.tbxPortablePath.Size = new System.Drawing.Size(531, 25);
            this.tbxPortablePath.TabIndex = 3;
            this.tbxPortablePath.TextChanged += new System.EventHandler(this.tbxPortablePath_TextChanged);
            // 
            // cbProgramType
            // 
            this.cbProgramType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgramType.FormattingEnabled = true;
            this.cbProgramType.Location = new System.Drawing.Point(173, 65);
            this.cbProgramType.Name = "cbProgramType";
            this.cbProgramType.Size = new System.Drawing.Size(202, 29);
            this.cbProgramType.TabIndex = 6;
            this.cbProgramType.SelectedIndexChanged += new System.EventHandler(this.cbProgramType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(171, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = PortableRegistrator.Properties.Resources.FileAssociations;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(176, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = PortableRegistrator.Properties.Resources.URLAssociations;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblURLAssociations
            // 
            this.lblURLAssociations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLAssociations.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblURLAssociations.Location = new System.Drawing.Point(311, 155);
            this.lblURLAssociations.Name = "lblURLAssociations";
            this.lblURLAssociations.Size = new System.Drawing.Size(426, 17);
            this.lblURLAssociations.TabIndex = 27;
            this.lblURLAssociations.Text = "lblURLAssociations";
            this.lblURLAssociations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblURLAssociations.Click += new System.EventHandler(this.lblURLAssociations_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "exe files (*.exe)|*.exe";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.Location = new System.Drawing.Point(637, 13);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(100, 34);
            this.btnConfig.TabIndex = 28;
            this.btnConfig.Text = PortableRegistrator.Properties.Resources.btnConfig;
            this.toolTip1.SetToolTip(this.btnConfig, PortableRegistrator.Properties.Resources.ProgramTypes);
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(505, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = PortableRegistrator.Properties.Resources.btnReset;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(171, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = PortableRegistrator.Properties.Resources.OpenParameter;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(171, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = PortableRegistrator.Properties.Resources.PropertiesParameter;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblPropertiesParameter
            // 
            this.lblPropertiesParameter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertiesParameter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPropertiesParameter.Location = new System.Drawing.Point(311, 203);
            this.lblPropertiesParameter.Name = "lblPropertiesParameter";
            this.lblPropertiesParameter.Size = new System.Drawing.Size(426, 17);
            this.lblPropertiesParameter.TabIndex = 32;
            this.lblPropertiesParameter.Text = "lblPropertiesParameter";
            this.lblPropertiesParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPropertiesParameter.Click += new System.EventHandler(this.lblPropertiesParameter_Click);
            // 
            // lblOpenParameters
            // 
            this.lblOpenParameters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenParameters.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOpenParameters.Location = new System.Drawing.Point(311, 179);
            this.lblOpenParameters.Name = "lblOpenParameters";
            this.lblOpenParameters.Size = new System.Drawing.Size(426, 17);
            this.lblOpenParameters.TabIndex = 33;
            this.lblOpenParameters.Text = "lblOpenParameters";
            this.lblOpenParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOpenParameters.Click += new System.EventHandler(this.lblOpenParameters_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblFileAssociations);
            this.panel2.Controls.Add(this.btnRemoveAppType);
            this.panel2.Controls.Add(this.cbRemoveSuffix);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblOpenParameters);
            this.panel2.Controls.Add(this.labelPortableSuffix);
            this.panel2.Controls.Add(this.lblPropertiesParameter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSelectExe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblURLAssociations);
            this.panel2.Controls.Add(this.tbxPortablePath);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbxProgramName);
            this.panel2.Controls.Add(this.cbProgramType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 319);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblFileAssociations
            // 
            this.lblFileAssociations.BackColor = System.Drawing.SystemColors.Control;
            this.lblFileAssociations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFileAssociations.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFileAssociations.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileAssociations.Location = new System.Drawing.Point(311, 103);
            this.lblFileAssociations.Multiline = true;
            this.lblFileAssociations.Name = "lblFileAssociations";
            this.lblFileAssociations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblFileAssociations.Size = new System.Drawing.Size(426, 49);
            this.lblFileAssociations.TabIndex = 36;
            this.lblFileAssociations.Text = "lblFileAssociations";
            this.lblFileAssociations.TextChanged += new System.EventHandler(this.lblFileAssociations_TextChanged);
            // 
            // btnRemoveAppType
            // 
            this.btnRemoveAppType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAppType.Location = new System.Drawing.Point(376, 64);
            this.btnRemoveAppType.Name = "btnRemoveAppType";
            this.btnRemoveAppType.Size = new System.Drawing.Size(31, 31);
            this.btnRemoveAppType.TabIndex = 35;
            this.btnRemoveAppType.Text = PortableRegistrator.Properties.Resources.btnRemoveAppType;
            this.btnRemoveAppType.UseVisualStyleBackColor = true;
            this.btnRemoveAppType.Click += new System.EventHandler(this.btnRemoveAppType_Click);
            // 
            // cbRemoveSuffix
            // 
            this.cbRemoveSuffix.AutoSize = true;
            this.cbRemoveSuffix.Location = new System.Drawing.Point(482, 278);
            this.cbRemoveSuffix.Name = "cbRemoveSuffix";
            this.cbRemoveSuffix.Size = new System.Drawing.Size(97, 25);
            this.cbRemoveSuffix.TabIndex = 34;
            this.cbRemoveSuffix.Text = PortableRegistrator.Properties.Resources.RemoveSuffix;
            this.cbRemoveSuffix.UseVisualStyleBackColor = true;
            this.cbRemoveSuffix.CheckedChanged += new System.EventHandler(this.cbRemoveSuffix_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.llGithub);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(0, 519);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 45);
            this.panel3.TabIndex = 35;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // llGithub
            // 
            this.llGithub.AutoSize = true;
            this.llGithub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llGithub.Location = new System.Drawing.Point(288, 13);
            this.llGithub.Name = "llGithub";
            this.llGithub.Size = new System.Drawing.Size(175, 17);
            this.llGithub.TabIndex = 0;
            this.llGithub.TabStop = true;
            this.llGithub.Text = PortableRegistrator.Properties.Resources.GitHub1;
            this.llGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGithub_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(283, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = PortableRegistrator.Properties.Resources.AuthorRemarks;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(554, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = PortableRegistrator.Properties.Resources.GitHub2;
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = PortableRegistrator.Properties.Resources.AuthorRemarks2;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(170, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = PortableRegistrator.Properties.Resources.MainTitle;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnConfig);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 60);
            this.panel4.TabIndex = 36;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(571, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 34);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = PortableRegistrator.Properties.Resources.btnAdd;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(748, 14);
            this.panel5.TabIndex = 37;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(0, -1);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(160, 127);
            this.panel6.TabIndex = 38;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PortableRegistrator.Properties.Resources.Wallpaperfx_3d_Bluefx_Desktop_Usb;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(140, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 565);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = PortableRegistrator.Properties.Resources.SoftwareName;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSelectExe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxProgramName;
        private System.Windows.Forms.Label labelPortableSuffix;
        private System.Windows.Forms.ComboBox cbRegisteredPortables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPortablePath;
        private System.Windows.Forms.ComboBox cbProgramType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblURLAssociations;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPropertiesParameter;
        private System.Windows.Forms.Label lblOpenParameters;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llGithub;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbRemoveSuffix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveAppType;
        private System.Windows.Forms.TextBox lblFileAssociations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

