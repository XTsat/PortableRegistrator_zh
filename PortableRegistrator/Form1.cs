using PortableRegistrator.Controls;
using PortableRegistratorCommon;
using PortableRegistratorCommon.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PortableRegistrator
{
    public partial class Form1 : Form
    {
        // PRIVATES
        private Configuration _config;
        private AppType _selectedAppType;
        private bool _removePortableSuffix = false;

        // CONSTRUCTOR
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            // 英文
            // System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();

            try
            {
                SetProductVersion();
                _config = Configuration.Load();
                DetectPortables();
                SetProgramTypes();
                CanRegister();
                CanUnregister();
            }
            catch (Exception ex)
            {
                ProcessError(ex);
            }
        }

        #region METHODS

        private void SetProductVersion()
        {
            var v = new Version(Application.ProductVersion);
            Text += $" v{v.Major}.{v.Minor}";
        }
        private void SetProgramTypes()
        {
            cbProgramType.Items.Clear();
            foreach (var appType in _config.AppTypes.OrderBy(a => a.Name).ToList())
            {
                cbProgramType.Items.Add(appType);
            }
            // Select first item of program type if wanted
            // cbProgramType.SelectedIndex = 0;
            UpdateProgramTypeInfo();
        }
        private void UpdateProgramTypeInfo()
        {
            _selectedAppType = (AppType)cbProgramType.SelectedItem;
            if (_selectedAppType != null)
            {
                lblFileAssociations.Text = _selectedAppType.GetFileAssociations();
                lblURLAssociations.Text = _selectedAppType.GetURLAssociations();

                if (_selectedAppType.OpenParameters == null)
                    lblOpenParameters.Text = "(null)";
                else
                    lblOpenParameters.Text = _selectedAppType.OpenParameters;

                if (_selectedAppType.PropertiesParameter == null)
                    lblPropertiesParameter.Text = "(null)";
                else
                    lblPropertiesParameter.Text = _selectedAppType.PropertiesParameter;
            }
            else
            {
                lblFileAssociations.Text = "-";
                lblURLAssociations.Text = "-";
                lblOpenParameters.Text = "-";
                lblPropertiesParameter.Text = "-";
            }
        }

        private void DetectPortables()
        {
            cbRegisteredPortables.Items.Clear();
            foreach (var portableApp in RegistryHelper.GetPortableApps())
            {
                cbRegisteredPortables.Items.Add(portableApp);
            }
        }

        private void SelectExecutable()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxPortablePath.Text = openFileDialog1.FileName;
                tbxProgramName.Text = Path.GetFileNameWithoutExtension(tbxPortablePath.Text)
                    .Replace("Portable", "").Replace("portable", "").Replace("PORTABLE", "").Trim();
            }
        }
        private void UpdateProgramName()
        {
            var programName = Path.GetFileNameWithoutExtension(tbxPortablePath.Text)
                .Replace("Portable", "").Replace("portable", "").Replace("Portable", "").Trim();
            tbxProgramName.Text = programName;
        }
        private void Reset()
        {
            try
            {
                _config = Configuration.Load();
                SetProgramTypes();

                tbxPortablePath.Text = null;
                cbProgramType.SelectedIndex = -1;
                tbxProgramName.Text = null;
                cbRegisteredPortables.SelectedIndex = -1;

                CanRegister();
                CanUnregister();
            }
            catch (Exception ex)
            {
                ProcessError(ex);
            }

        }
        private void OpenConfig()
        {
            MessageBoxEx.Show(this,
                PortableRegistrator.Properties.Resources.msgHINTS1 + Environment.NewLine + Environment.NewLine +
                PortableRegistrator.Properties.Resources.msgHINTS2 + Environment.NewLine +
                PortableRegistrator.Properties.Resources.msgHINTS3 + Environment.NewLine +
                PortableRegistrator.Properties.Resources.msgHINTS4 + Environment.NewLine + Environment.NewLine +
                PortableRegistrator.Properties.Resources.msgHINTS5 + Environment.NewLine + Environment.NewLine +
                PortableRegistrator.Properties.Resources.msgHINTS6,
                PortableRegistrator.Properties.Resources.msgHINTS,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Process.Start(_config.ConfigFile);
        }

        private void CanRegister()
        {
            if (!string.IsNullOrWhiteSpace(tbxPortablePath.Text)
                && (cbProgramType.SelectedItem != null)
                && (!string.IsNullOrWhiteSpace(tbxProgramName.Text)
               ))
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }
        private void Register()
        {
            try
            {
                List<string> errors = null;

                if (_removePortableSuffix)
                {
                    errors = RegistryHelper.Register(_selectedAppType, tbxPortablePath.Text, tbxProgramName.Text);
                }
                else
                {
                    errors = RegistryHelper.Register(_selectedAppType, tbxPortablePath.Text, tbxProgramName.Text + " Portable");
                }

                if (errors.Count == 0)
                {
                    // 从.resx读取固定多语言文本
                    string msg1 = PortableRegistrator.Properties.Resources.msgRegister1;
                    string msg2 = PortableRegistrator.Properties.Resources.msgRegister2;
                    string msgTitle = PortableRegistrator.Properties.Resources.msgRegister;

                    // 拼接最终弹窗文本
                    string message = $"{tbxProgramName.Text}{msg1}{Environment.NewLine}{msg2}";

                    // 显示弹窗
                    MessageBoxEx.Show(this,
                        message,
                        msgTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // 读取资源文本
                    string msg3 = PortableRegistrator.Properties.Resources.msgRegister3;
                    string msg4 = PortableRegistrator.Properties.Resources.msgRegister4;
                    string msgTitle = PortableRegistrator.Properties.Resources.msgRegister;

                    string errorList = string.Join(Environment.NewLine, errors.ToArray());
                    string message = $"{string.Format(msg3, tbxProgramName.Text)}{Environment.NewLine}{msg4}{Environment.NewLine}{errorList}";

                    // 显示弹窗
                    MessageBoxEx.Show(this, 
                        message, 
                        msgTitle, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }

                DetectPortables();
            }
            catch (Exception ex)
            {
                ProcessError(ex);
            }

        }
        private void CanUnregister()
        {
            if (cbRegisteredPortables.SelectedIndex == -1)
            {
                btnUnregister.Enabled = false;
            }
            else
            {
                btnUnregister.Enabled = true;
            }
        }
        private void Unregister()
        {
            try
            {
                var errors = RegistryHelper.Unregister(cbRegisteredPortables.Text);
                DetectPortables();

                if (errors.Count == 0)
                {
                    string msg1 = PortableRegistrator.Properties.Resources.msgUnRegister1;
                    string msgTitle = PortableRegistrator.Properties.Resources.msgUnRegister;

                    string message = $"{tbxProgramName.Text}{msg1}";

                    MessageBoxEx.Show(this,
                        message,
                        msgTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    string msg2 = PortableRegistrator.Properties.Resources.msgUnRegister2;
                    string msgTitle = PortableRegistrator.Properties.Resources.msgUnRegister;

                    string message = $"{msg2}{tbxProgramName.Text}{Environment.NewLine}{string.Join(Environment.NewLine, errors.ToArray())}";

                    MessageBoxEx.Show(this,
                        message,
                        msgTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                ProcessError(ex);
            }
        }

        private void ProcessError(Exception ex)
        {
            var msg = ex.Message + Environment.NewLine + ex.StackTrace;
            string error = PortableRegistrator.Properties.Resources.msgErrorOccurred;
            SimpleLogger.Instance.Error(msg);
            MessageBox.Show(
                msg, 
                error, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
                );
        }
        #endregion

        #region EVENTS

        // EVENTS - BUTTONS
        private void btnSelectExe_Click(object sender, EventArgs e)
        {
            SelectExecutable();
            CanRegister();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenConfig();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dialog = new DialogAdd())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _config.AppTypes.Add(dialog.AppType);
                    _config.Save();
                    string msg = PortableRegistrator.Properties.Resources.msgNewProgramType;
                    string Success = PortableRegistrator.Properties.Resources.msgSuccess;

                    string message = $"{msg}{dialog.AppType}";

                    MessageBoxEx.Show(
                        message,
                        Success,
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                        );
                    SetProgramTypes();
                }
            }
        }
        private void btnRemoveAppType_Click(object sender, EventArgs e)
        {
            if (cbProgramType.SelectedItem != null &&
                !String.IsNullOrWhiteSpace(cbProgramType.SelectedItem.ToString()))
            {
                var progType = cbProgramType.SelectedItem.ToString();

                string msg = PortableRegistrator.Properties.Resources.msgDeleteProgramType1;
                string msgTitle = PortableRegistrator.Properties.Resources.msgDeleteProgramType;

                string message = $"{msg}{Environment.NewLine}{progType}?";

                DialogResult dialogResult = MessageBoxEx.Show(this,
                    message,
                    msgTitle,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var item = _config.AppTypes.FirstOrDefault(a => a.Name == progType);
                    _config.AppTypes.Remove(item);
                    _config.Save();
                    SetProgramTypes();
                }
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }
        private void btnUnregister_Click(object sender, EventArgs e)
        {
            string msg = PortableRegistrator.Properties.Resources.msgUnRegister3;
            string msgTitle = PortableRegistrator.Properties.Resources.msgUnRegister;

            string message = $"{msg}{Environment.NewLine}{cbRegisteredPortables.Text}";
            DialogResult dialogResult = MessageBoxEx.Show(this,
                msg,
                msgTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Unregister();
            }
        }

        // EVENTS - COMBOBOXES
        private void cbProgramType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgramTypeInfo();
            CanRegister();
        }
        private void cbRegisteredPortables_SelectedIndexChanged(object sender, EventArgs e)
        {
            CanUnregister();
        }

        // EVENTS - TEXTBOXES
        private void tbxProgramName_TextChanged(object sender, EventArgs e)
        {
            CanRegister();
        }
        private void tbxPortablePath_TextChanged(object sender, EventArgs e)
        {
            UpdateProgramName();
        }

        // EVENTS - LINKLABEL
        private void llGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sil3nc3/PortableRegistrator");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/XTsat/PortableRegistrator_zh");
        }

        // EVENTS - PORTABLE Suffix checkbox
        private void cbRemoveSuffix_CheckedChanged(object sender, EventArgs e)
        {
            _removePortableSuffix = cbRemoveSuffix.Checked;

            if (_removePortableSuffix)
            {
                string msg1 = PortableRegistrator.Properties.Resources.msgSuffix1;
                string msg2 = PortableRegistrator.Properties.Resources.msgSuffix2;
                string msg3 = PortableRegistrator.Properties.Resources.msgSuffix3;
                string msg4 = PortableRegistrator.Properties.Resources.msgSuffix4;
                string msgTitle = PortableRegistrator.Properties.Resources.msgSuffix;

                string message = $"{msg1}{Environment.NewLine}{msg2}{Environment.NewLine}{Environment.NewLine}{msg3}{Environment.NewLine}{msg4}";

                DialogResult dialogResult = MessageBoxEx.Show(this,
                    message,
                    msgTitle,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _removePortableSuffix = true;

                }
                else if (dialogResult == DialogResult.No)
                {
                    _removePortableSuffix = false;
                }
            }

            if (_removePortableSuffix) // If it is still checked
            {
                labelPortableSuffix.Text = "\"";
            }
            else
            {
                labelPortableSuffix.Text = PortableRegistrator.Properties.Resources.PortableSuffix;
                cbRemoveSuffix.Checked = false;
            }

        }


        #endregion

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelPortableSuffix_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblURLAssociations_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblPropertiesParameter_Click(object sender, EventArgs e)
        {

        }

        private void lblOpenParameters_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFileAssociations_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
