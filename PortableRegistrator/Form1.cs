using PortableRegistrator.Controls;
using PortableRegistratorCommon;
using PortableRegistratorCommon.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
                "您可以在此处设置所使用的程序类型。" + Environment.NewLine + Environment.NewLine +
                "更改配置后请重新启动程序！" + Environment.NewLine +
                "还要考虑再次注册您的便携式设备。" + Environment.NewLine +
                "配置时要非常小心，否则可能会弄乱注册表。" + Environment.NewLine + Environment.NewLine +
                "如果您需要新的配置文件，只需将其删除并重新启动该工具即可。" + Environment.NewLine + Environment.NewLine +
                "来自开发者的问候 :)",
                "HINTS",
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
                    MessageBoxEx.Show(this,
                        $"{tbxProgramName.Text} successfully registered!{Environment.NewLine}" +
                        $"Have fun and enjoy. ;)",
                        "REGISTER",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show(this,
                        $"Registration of '{tbxProgramName.Text}' unsuccessful!{Environment.NewLine}" +
                        $"Errors: {Environment.NewLine}" +
                        $"{string.Join(Environment.NewLine, errors.ToArray())}",
                        "REGISTER",
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
                    MessageBoxEx.Show(this,
                        $"{tbxProgramName.Text} got successfully unregistered.",
                        "UNREGISTER",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show(this,
                        $"Deleting registration of '{tbxProgramName.Text}' unsuccessful. See Errors: {Environment.NewLine}" +
                        $"{string.Join(Environment.NewLine, errors.ToArray())}",
                        "UNREGISTER",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            SimpleLogger.Instance.Error(msg);
            MessageBox.Show(msg, "An Error occurred :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBoxEx.Show($"新程序类型 '{dialog.AppType}' 已创建.", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult dialogResult = MessageBoxEx.Show(this,
                    "您确实要永久删除程序类型： " + Environment.NewLine + $"'{progType}' ?",
                    "删除程序类型",
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
            DialogResult dialogResult = MessageBoxEx.Show(this,
                $"Are you sure to delete the registration for {Environment.NewLine}" +
                $"'{cbRegisteredPortables.Text}'?",
                "UNREGISTER",
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

        // EVENTS - PORTABLE Suffix checkbox
        private void cbRemoveSuffix_CheckedChanged(object sender, EventArgs e)
        {
            _removePortableSuffix = cbRemoveSuffix.Checked;

            if (_removePortableSuffix)
            {
                DialogResult dialogResult = MessageBoxEx.Show(this,
                    "此选项从注册条目中删除“PORTABLE”后缀。" + Environment.NewLine +
                    "然后 PortableRegistrator 无法再检测到该注册表项！ " + Environment.NewLine + Environment.NewLine +
                    "如果您是高级用户，请保留此选项！" + Environment.NewLine +
                    "不建议默认使用！",
                    "!!!注意!!!",
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
                labelPortableSuffix.Text = "PORTABLE\"";
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/XTsat/PortableRegistrator_zh");
        }
    }
}
