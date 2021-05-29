
namespace DyingLightTool
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GenerateDideMod = new MetroFramework.Controls.MetroButton();
            this.GenerateVideo = new MetroFramework.Controls.MetroButton();
            this.ClearJunk = new MetroFramework.Controls.MetroButton();
            this.VSync = new MetroFramework.Controls.MetroCheckBox();
            this.PakNameBox = new MetroFramework.Controls.MetroTextBox();
            this.Logs = new MetroFramework.Controls.MetroCheckBox();
            this.Dump = new MetroFramework.Controls.MetroCheckBox();
            this.FolderPathBox = new MetroFramework.Controls.MetroTextBox();
            this.ExtraFOVBox = new MetroFramework.Controls.MetroTextBox();
            this.Borderless = new MetroFramework.Controls.MetroCheckBox();
            this.Fullscreen = new MetroFramework.Controls.MetroCheckBox();
            this.LowSettings = new MetroFramework.Controls.MetroCheckBox();
            this.ExtraFOVLabel = new MetroFramework.Controls.MetroLabel();
            this.ResolutionLabel = new MetroFramework.Controls.MetroLabel();
            this.HighSettings = new MetroFramework.Controls.MetroCheckBox();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LogsLabel = new MetroFramework.Controls.MetroLabel();
            this.FocusLabel = new MetroFramework.Controls.MetroLabel();
            this.MotionBlur = new MetroFramework.Controls.MetroCheckBox();
            this.AntiAliasing = new MetroFramework.Controls.MetroCheckBox();
            this.AmbientOcclusion = new MetroFramework.Controls.MetroCheckBox();
            this.FolderPathLabel = new MetroFramework.Controls.MetroLabel();
            this.PakNameLabel = new MetroFramework.Controls.MetroLabel();
            this.Add = new MetroFramework.Controls.MetroButton();
            this.CountLabel = new MetroFramework.Controls.MetroLabel();
            this.CountNumber = new MetroFramework.Controls.MetroLabel();
            this.DLPathBox = new MetroFramework.Controls.MetroTextBox();
            this.DLPathLabel = new MetroFramework.Controls.MetroLabel();
            this.DLPathApply = new MetroFramework.Controls.MetroButton();
            this.DLPathReset = new MetroFramework.Controls.MetroButton();
            this.CrossOrCheckMarkOfFOLDER = new MetroFramework.Controls.MetroLabel();
            this.FolderExists = new MetroFramework.Controls.MetroLabel();
            this.FileExists = new MetroFramework.Controls.MetroLabel();
            this.CrossOrCheckMarkOfFILE = new MetroFramework.Controls.MetroLabel();
            this.Reset = new MetroFramework.Controls.MetroButton();
            this.HBAO = new MetroFramework.Controls.MetroCheckBox();
            this.DOF = new MetroFramework.Controls.MetroCheckBox();
            this.PCSS = new MetroFramework.Controls.MetroCheckBox();
            this.ResolutionWidth = new MetroFramework.Controls.MetroTextBox();
            this.ResolutionHeight = new MetroFramework.Controls.MetroTextBox();
            this.ResolutionXLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // GenerateDideMod
            // 
            this.GenerateDideMod.Location = new System.Drawing.Point(23, 65);
            this.GenerateDideMod.Name = "GenerateDideMod";
            this.GenerateDideMod.Size = new System.Drawing.Size(160, 34);
            this.GenerateDideMod.TabIndex = 0;
            this.GenerateDideMod.TabStop = false;
            this.GenerateDideMod.Text = "Generate dide_mod";
            this.GenerateDideMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GenerateDideMod.UseSelectable = true;
            this.GenerateDideMod.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // GenerateVideo
            // 
            this.GenerateVideo.Location = new System.Drawing.Point(23, 174);
            this.GenerateVideo.Name = "GenerateVideo";
            this.GenerateVideo.Size = new System.Drawing.Size(159, 34);
            this.GenerateVideo.TabIndex = 1;
            this.GenerateVideo.TabStop = false;
            this.GenerateVideo.Text = "Generate video.scr";
            this.GenerateVideo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GenerateVideo.UseSelectable = true;
            this.GenerateVideo.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ClearJunk
            // 
            this.ClearJunk.Location = new System.Drawing.Point(207, 174);
            this.ClearJunk.Name = "ClearJunk";
            this.ClearJunk.Size = new System.Drawing.Size(159, 34);
            this.ClearJunk.TabIndex = 2;
            this.ClearJunk.TabStop = false;
            this.ClearJunk.Text = "Clear junk";
            this.ClearJunk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ClearJunk.UseSelectable = true;
            this.ClearJunk.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // VSync
            // 
            this.VSync.AutoSize = true;
            this.VSync.Location = new System.Drawing.Point(22, 328);
            this.VSync.Name = "VSync";
            this.VSync.Size = new System.Drawing.Size(55, 15);
            this.VSync.Style = MetroFramework.MetroColorStyle.White;
            this.VSync.TabIndex = 6;
            this.VSync.TabStop = false;
            this.VSync.Text = "VSync";
            this.VSync.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VSync.UseSelectable = true;
            // 
            // PakNameBox
            // 
            // 
            // 
            // 
            this.PakNameBox.CustomButton.Image = null;
            this.PakNameBox.CustomButton.Location = new System.Drawing.Point(485, 1);
            this.PakNameBox.CustomButton.Name = "";
            this.PakNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PakNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PakNameBox.CustomButton.TabIndex = 1;
            this.PakNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PakNameBox.CustomButton.UseSelectable = true;
            this.PakNameBox.CustomButton.Visible = false;
            this.PakNameBox.Lines = new string[] {
        "Enter pak name"};
            this.PakNameBox.Location = new System.Drawing.Point(210, 118);
            this.PakNameBox.MaxLength = 32767;
            this.PakNameBox.Name = "PakNameBox";
            this.PakNameBox.PasswordChar = '\0';
            this.PakNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PakNameBox.SelectedText = "";
            this.PakNameBox.SelectionLength = 0;
            this.PakNameBox.SelectionStart = 0;
            this.PakNameBox.ShortcutsEnabled = true;
            this.PakNameBox.Size = new System.Drawing.Size(507, 23);
            this.PakNameBox.Style = MetroFramework.MetroColorStyle.White;
            this.PakNameBox.TabIndex = 7;
            this.PakNameBox.TabStop = false;
            this.PakNameBox.Text = "Enter pak name";
            this.PakNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PakNameBox.UseSelectable = true;
            this.PakNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PakNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PakNameBox.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            // 
            // Logs
            // 
            this.Logs.AutoSize = true;
            this.Logs.Location = new System.Drawing.Point(206, 218);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(48, 15);
            this.Logs.Style = MetroFramework.MetroColorStyle.White;
            this.Logs.TabIndex = 11;
            this.Logs.TabStop = false;
            this.Logs.Text = "Logs";
            this.Logs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Logs.UseSelectable = true;
            // 
            // Dump
            // 
            this.Dump.AutoSize = true;
            this.Dump.Location = new System.Drawing.Point(280, 218);
            this.Dump.Name = "Dump";
            this.Dump.Size = new System.Drawing.Size(56, 15);
            this.Dump.Style = MetroFramework.MetroColorStyle.White;
            this.Dump.TabIndex = 12;
            this.Dump.TabStop = false;
            this.Dump.Text = "Dump";
            this.Dump.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Dump.UseSelectable = true;
            // 
            // FolderPathBox
            // 
            // 
            // 
            // 
            this.FolderPathBox.CustomButton.Image = null;
            this.FolderPathBox.CustomButton.Location = new System.Drawing.Point(485, 1);
            this.FolderPathBox.CustomButton.Name = "";
            this.FolderPathBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FolderPathBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FolderPathBox.CustomButton.TabIndex = 1;
            this.FolderPathBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FolderPathBox.CustomButton.UseSelectable = true;
            this.FolderPathBox.CustomButton.Visible = false;
            this.FolderPathBox.Lines = new string[] {
        "Enter path to folder"};
            this.FolderPathBox.Location = new System.Drawing.Point(210, 65);
            this.FolderPathBox.MaxLength = 32767;
            this.FolderPathBox.Name = "FolderPathBox";
            this.FolderPathBox.PasswordChar = '\0';
            this.FolderPathBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FolderPathBox.SelectedText = "";
            this.FolderPathBox.SelectionLength = 0;
            this.FolderPathBox.SelectionStart = 0;
            this.FolderPathBox.ShortcutsEnabled = true;
            this.FolderPathBox.Size = new System.Drawing.Size(507, 23);
            this.FolderPathBox.Style = MetroFramework.MetroColorStyle.White;
            this.FolderPathBox.TabIndex = 14;
            this.FolderPathBox.TabStop = false;
            this.FolderPathBox.Text = "Enter path to folder";
            this.FolderPathBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FolderPathBox.UseSelectable = true;
            this.FolderPathBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FolderPathBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FolderPathBox.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // ExtraFOVBox
            // 
            // 
            // 
            // 
            this.ExtraFOVBox.CustomButton.Image = null;
            this.ExtraFOVBox.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.ExtraFOVBox.CustomButton.Name = "";
            this.ExtraFOVBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ExtraFOVBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ExtraFOVBox.CustomButton.TabIndex = 1;
            this.ExtraFOVBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ExtraFOVBox.CustomButton.UseSelectable = true;
            this.ExtraFOVBox.CustomButton.Visible = false;
            this.ExtraFOVBox.Lines = new string[] {
        "55"};
            this.ExtraFOVBox.Location = new System.Drawing.Point(23, 237);
            this.ExtraFOVBox.MaxLength = 32767;
            this.ExtraFOVBox.Name = "ExtraFOVBox";
            this.ExtraFOVBox.PasswordChar = '\0';
            this.ExtraFOVBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExtraFOVBox.SelectedText = "";
            this.ExtraFOVBox.SelectionLength = 0;
            this.ExtraFOVBox.SelectionStart = 0;
            this.ExtraFOVBox.ShortcutsEnabled = true;
            this.ExtraFOVBox.Size = new System.Drawing.Size(159, 23);
            this.ExtraFOVBox.Style = MetroFramework.MetroColorStyle.White;
            this.ExtraFOVBox.TabIndex = 20;
            this.ExtraFOVBox.TabStop = false;
            this.ExtraFOVBox.Text = "55";
            this.ExtraFOVBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExtraFOVBox.UseSelectable = true;
            this.ExtraFOVBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ExtraFOVBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ExtraFOVBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeypress);
            // 
            // Borderless
            // 
            this.Borderless.AutoSize = true;
            this.Borderless.Location = new System.Drawing.Point(22, 368);
            this.Borderless.Name = "Borderless";
            this.Borderless.Size = new System.Drawing.Size(77, 15);
            this.Borderless.Style = MetroFramework.MetroColorStyle.White;
            this.Borderless.TabIndex = 23;
            this.Borderless.TabStop = false;
            this.Borderless.Text = "Borderless";
            this.Borderless.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Borderless.UseSelectable = true;
            this.Borderless.CheckStateChanged += new System.EventHandler(this.metroCheckBox4_CheckedChanged);
            // 
            // Fullscreen
            // 
            this.Fullscreen.AutoSize = true;
            this.Fullscreen.Location = new System.Drawing.Point(22, 348);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(76, 15);
            this.Fullscreen.Style = MetroFramework.MetroColorStyle.White;
            this.Fullscreen.TabIndex = 24;
            this.Fullscreen.TabStop = false;
            this.Fullscreen.Text = "Fullscreen";
            this.Fullscreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Fullscreen.UseSelectable = true;
            this.Fullscreen.CheckStateChanged += new System.EventHandler(this.metroCheckBox5_CheckedChanged);
            // 
            // LowSettings
            // 
            this.LowSettings.AutoSize = true;
            this.LowSettings.Location = new System.Drawing.Point(22, 410);
            this.LowSettings.Name = "LowSettings";
            this.LowSettings.Size = new System.Drawing.Size(76, 15);
            this.LowSettings.Style = MetroFramework.MetroColorStyle.White;
            this.LowSettings.TabIndex = 26;
            this.LowSettings.TabStop = false;
            this.LowSettings.Text = "Potato PC";
            this.LowSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LowSettings.UseSelectable = true;
            this.LowSettings.CheckedChanged += new System.EventHandler(this.metroCheckBox6_CheckedChanged);
            // 
            // ExtraFOVLabel
            // 
            this.ExtraFOVLabel.AutoSize = true;
            this.ExtraFOVLabel.Location = new System.Drawing.Point(23, 214);
            this.ExtraFOVLabel.Name = "ExtraFOVLabel";
            this.ExtraFOVLabel.Size = new System.Drawing.Size(68, 19);
            this.ExtraFOVLabel.TabIndex = 29;
            this.ExtraFOVLabel.Text = "Extra FOV";
            this.ExtraFOVLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(22, 265);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(69, 19);
            this.ResolutionLabel.TabIndex = 30;
            this.ResolutionLabel.Text = "Resolution";
            this.ResolutionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // HighSettings
            // 
            this.HighSettings.AutoSize = true;
            this.HighSettings.Location = new System.Drawing.Point(22, 389);
            this.HighSettings.Name = "HighSettings";
            this.HighSettings.Size = new System.Drawing.Size(70, 15);
            this.HighSettings.Style = MetroFramework.MetroColorStyle.White;
            this.HighSettings.TabIndex = 31;
            this.HighSettings.TabStop = false;
            this.HighSettings.Text = "Good PC";
            this.HighSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HighSettings.UseSelectable = true;
            this.HighSettings.CheckedChanged += new System.EventHandler(this.metroCheckBox7_CheckedChanged);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.LogBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LogBox.Location = new System.Drawing.Point(280, 287);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(446, 170);
            this.LogBox.TabIndex = 32;
            this.LogBox.TabStop = false;
            this.LogBox.Text = "";
            // 
            // LogsLabel
            // 
            this.LogsLabel.AutoSize = true;
            this.LogsLabel.Location = new System.Drawing.Point(280, 265);
            this.LogsLabel.Name = "LogsLabel";
            this.LogsLabel.Size = new System.Drawing.Size(36, 19);
            this.LogsLabel.TabIndex = 33;
            this.LogsLabel.Text = "Logs";
            this.LogsLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FocusLabel
            // 
            this.FocusLabel.AutoSize = true;
            this.FocusLabel.Location = new System.Drawing.Point(325, 338);
            this.FocusLabel.Name = "FocusLabel";
            this.FocusLabel.Size = new System.Drawing.Size(0, 0);
            this.FocusLabel.TabIndex = 34;
            this.FocusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MotionBlur
            // 
            this.MotionBlur.AutoSize = true;
            this.MotionBlur.Location = new System.Drawing.Point(22, 431);
            this.MotionBlur.Name = "MotionBlur";
            this.MotionBlur.Size = new System.Drawing.Size(86, 15);
            this.MotionBlur.Style = MetroFramework.MetroColorStyle.White;
            this.MotionBlur.TabIndex = 37;
            this.MotionBlur.TabStop = false;
            this.MotionBlur.Text = "Motion Blur";
            this.MotionBlur.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MotionBlur.UseSelectable = true;
            // 
            // AntiAliasing
            // 
            this.AntiAliasing.AutoSize = true;
            this.AntiAliasing.Location = new System.Drawing.Point(113, 328);
            this.AntiAliasing.Name = "AntiAliasing";
            this.AntiAliasing.Size = new System.Drawing.Size(87, 15);
            this.AntiAliasing.Style = MetroFramework.MetroColorStyle.White;
            this.AntiAliasing.TabIndex = 38;
            this.AntiAliasing.TabStop = false;
            this.AntiAliasing.Text = "AntiAliasing";
            this.AntiAliasing.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AntiAliasing.UseSelectable = true;
            // 
            // AmbientOcclusion
            // 
            this.AmbientOcclusion.AutoSize = true;
            this.AmbientOcclusion.Location = new System.Drawing.Point(113, 348);
            this.AmbientOcclusion.Name = "AmbientOcclusion";
            this.AmbientOcclusion.Size = new System.Drawing.Size(125, 15);
            this.AmbientOcclusion.Style = MetroFramework.MetroColorStyle.White;
            this.AmbientOcclusion.TabIndex = 39;
            this.AmbientOcclusion.TabStop = false;
            this.AmbientOcclusion.Text = "Ambient Occlusion";
            this.AmbientOcclusion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AmbientOcclusion.UseSelectable = true;
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Location = new System.Drawing.Point(210, 43);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(47, 19);
            this.FolderPathLabel.TabIndex = 41;
            this.FolderPathLabel.Text = "Folder";
            this.FolderPathLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PakNameLabel
            // 
            this.PakNameLabel.AutoSize = true;
            this.PakNameLabel.Location = new System.Drawing.Point(210, 96);
            this.PakNameLabel.Name = "PakNameLabel";
            this.PakNameLabel.Size = new System.Drawing.Size(66, 19);
            this.PakNameLabel.TabIndex = 42;
            this.PakNameLabel.Text = "Pak name";
            this.PakNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(23, 113);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(43, 34);
            this.Add.TabIndex = 43;
            this.Add.TabStop = false;
            this.Add.Text = "Add";
            this.Add.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Add.UseSelectable = true;
            this.Add.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(121, 118);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(47, 19);
            this.CountLabel.TabIndex = 44;
            this.CountLabel.Text = "Count:";
            this.CountLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CountNumber
            // 
            this.CountNumber.AutoSize = true;
            this.CountNumber.Location = new System.Drawing.Point(167, 118);
            this.CountNumber.Name = "CountNumber";
            this.CountNumber.Size = new System.Drawing.Size(16, 19);
            this.CountNumber.TabIndex = 45;
            this.CountNumber.Text = "0";
            this.CountNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DLPathBox
            // 
            // 
            // 
            // 
            this.DLPathBox.CustomButton.Image = null;
            this.DLPathBox.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.DLPathBox.CustomButton.Name = "";
            this.DLPathBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DLPathBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DLPathBox.CustomButton.TabIndex = 1;
            this.DLPathBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DLPathBox.CustomButton.UseSelectable = true;
            this.DLPathBox.CustomButton.Visible = false;
            this.DLPathBox.Lines = new string[0];
            this.DLPathBox.Location = new System.Drawing.Point(387, 174);
            this.DLPathBox.MaxLength = 32767;
            this.DLPathBox.Name = "DLPathBox";
            this.DLPathBox.PasswordChar = '\0';
            this.DLPathBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DLPathBox.SelectedText = "";
            this.DLPathBox.SelectionLength = 0;
            this.DLPathBox.SelectionStart = 0;
            this.DLPathBox.ShortcutsEnabled = true;
            this.DLPathBox.Size = new System.Drawing.Size(330, 23);
            this.DLPathBox.Style = MetroFramework.MetroColorStyle.White;
            this.DLPathBox.TabIndex = 46;
            this.DLPathBox.TabStop = false;
            this.DLPathBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLPathBox.UseSelectable = true;
            this.DLPathBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DLPathBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DLPathLabel
            // 
            this.DLPathLabel.AutoSize = true;
            this.DLPathLabel.Location = new System.Drawing.Point(387, 152);
            this.DLPathLabel.Name = "DLPathLabel";
            this.DLPathLabel.Size = new System.Drawing.Size(145, 19);
            this.DLPathLabel.TabIndex = 47;
            this.DLPathLabel.Text = "Dying Light Folder Path";
            this.DLPathLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DLPathApply
            // 
            this.DLPathApply.Location = new System.Drawing.Point(387, 203);
            this.DLPathApply.Name = "DLPathApply";
            this.DLPathApply.Size = new System.Drawing.Size(90, 34);
            this.DLPathApply.TabIndex = 48;
            this.DLPathApply.TabStop = false;
            this.DLPathApply.Text = "Apply";
            this.DLPathApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLPathApply.UseSelectable = true;
            this.DLPathApply.Click += new System.EventHandler(this.metroButton5_Click_1);
            // 
            // DLPathReset
            // 
            this.DLPathReset.Enabled = false;
            this.DLPathReset.Location = new System.Drawing.Point(483, 203);
            this.DLPathReset.Name = "DLPathReset";
            this.DLPathReset.Size = new System.Drawing.Size(90, 34);
            this.DLPathReset.TabIndex = 49;
            this.DLPathReset.TabStop = false;
            this.DLPathReset.Text = "Reset";
            this.DLPathReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLPathReset.UseSelectable = true;
            this.DLPathReset.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // CrossOrCheckMarkOfFOLDER
            // 
            this.CrossOrCheckMarkOfFOLDER.AutoSize = true;
            this.CrossOrCheckMarkOfFOLDER.Location = new System.Drawing.Point(690, 43);
            this.CrossOrCheckMarkOfFOLDER.Name = "CrossOrCheckMarkOfFOLDER";
            this.CrossOrCheckMarkOfFOLDER.Size = new System.Drawing.Size(28, 19);
            this.CrossOrCheckMarkOfFOLDER.TabIndex = 50;
            this.CrossOrCheckMarkOfFOLDER.Text = "✖";
            this.CrossOrCheckMarkOfFOLDER.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FolderExists
            // 
            this.FolderExists.AutoSize = true;
            this.FolderExists.Location = new System.Drawing.Point(606, 43);
            this.FolderExists.Name = "FolderExists";
            this.FolderExists.Size = new System.Drawing.Size(84, 19);
            this.FolderExists.TabIndex = 51;
            this.FolderExists.Text = "Folder exists:";
            this.FolderExists.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FileExists
            // 
            this.FileExists.AutoSize = true;
            this.FileExists.Location = new System.Drawing.Point(509, 43);
            this.FileExists.Name = "FileExists";
            this.FileExists.Size = new System.Drawing.Size(66, 19);
            this.FileExists.TabIndex = 52;
            this.FileExists.Text = "File exists:";
            this.FileExists.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CrossOrCheckMarkOfFILE
            // 
            this.CrossOrCheckMarkOfFILE.AutoSize = true;
            this.CrossOrCheckMarkOfFILE.Location = new System.Drawing.Point(575, 43);
            this.CrossOrCheckMarkOfFILE.Name = "CrossOrCheckMarkOfFILE";
            this.CrossOrCheckMarkOfFILE.Size = new System.Drawing.Size(28, 19);
            this.CrossOrCheckMarkOfFILE.TabIndex = 53;
            this.CrossOrCheckMarkOfFILE.Text = "✖";
            this.CrossOrCheckMarkOfFILE.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(72, 113);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(43, 34);
            this.Reset.TabIndex = 54;
            this.Reset.TabStop = false;
            this.Reset.Text = "Reset";
            this.Reset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Reset.UseSelectable = true;
            this.Reset.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // HBAO
            // 
            this.HBAO.AutoSize = true;
            this.HBAO.Location = new System.Drawing.Point(113, 369);
            this.HBAO.Name = "HBAO";
            this.HBAO.Size = new System.Drawing.Size(64, 15);
            this.HBAO.Style = MetroFramework.MetroColorStyle.White;
            this.HBAO.TabIndex = 55;
            this.HBAO.TabStop = false;
            this.HBAO.Text = "HBAO+";
            this.HBAO.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HBAO.UseSelectable = true;
            this.HBAO.CheckedChanged += new System.EventHandler(this.metroCheckBox11_CheckedChanged);
            // 
            // DOF
            // 
            this.DOF.AutoSize = true;
            this.DOF.Location = new System.Drawing.Point(113, 390);
            this.DOF.Name = "DOF";
            this.DOF.Size = new System.Drawing.Size(46, 15);
            this.DOF.Style = MetroFramework.MetroColorStyle.White;
            this.DOF.TabIndex = 56;
            this.DOF.TabStop = false;
            this.DOF.Text = "DOF";
            this.DOF.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DOF.UseSelectable = true;
            this.DOF.CheckedChanged += new System.EventHandler(this.metroCheckBox12_CheckedChanged);
            // 
            // PCSS
            // 
            this.PCSS.AutoSize = true;
            this.PCSS.Location = new System.Drawing.Point(113, 411);
            this.PCSS.Name = "PCSS";
            this.PCSS.Size = new System.Drawing.Size(50, 15);
            this.PCSS.Style = MetroFramework.MetroColorStyle.White;
            this.PCSS.TabIndex = 57;
            this.PCSS.TabStop = false;
            this.PCSS.Text = "PCSS";
            this.PCSS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PCSS.UseSelectable = true;
            this.PCSS.CheckedChanged += new System.EventHandler(this.metroCheckBox13_CheckedChanged);
            // 
            // ResolutionWidth
            // 
            // 
            // 
            // 
            this.ResolutionWidth.CustomButton.Image = null;
            this.ResolutionWidth.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.ResolutionWidth.CustomButton.Name = "";
            this.ResolutionWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ResolutionWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ResolutionWidth.CustomButton.TabIndex = 1;
            this.ResolutionWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResolutionWidth.CustomButton.UseSelectable = true;
            this.ResolutionWidth.CustomButton.Visible = false;
            this.ResolutionWidth.Lines = new string[] {
        "1920"};
            this.ResolutionWidth.Location = new System.Drawing.Point(22, 287);
            this.ResolutionWidth.MaxLength = 32767;
            this.ResolutionWidth.Name = "ResolutionWidth";
            this.ResolutionWidth.PasswordChar = '\0';
            this.ResolutionWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ResolutionWidth.SelectedText = "";
            this.ResolutionWidth.SelectionLength = 0;
            this.ResolutionWidth.SelectionStart = 0;
            this.ResolutionWidth.ShortcutsEnabled = true;
            this.ResolutionWidth.Size = new System.Drawing.Size(69, 23);
            this.ResolutionWidth.Style = MetroFramework.MetroColorStyle.White;
            this.ResolutionWidth.TabIndex = 58;
            this.ResolutionWidth.TabStop = false;
            this.ResolutionWidth.Text = "1920";
            this.ResolutionWidth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResolutionWidth.UseSelectable = true;
            this.ResolutionWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ResolutionWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeypress);
            // 
            // ResolutionHeight
            // 
            // 
            // 
            // 
            this.ResolutionHeight.CustomButton.Image = null;
            this.ResolutionHeight.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.ResolutionHeight.CustomButton.Name = "";
            this.ResolutionHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ResolutionHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ResolutionHeight.CustomButton.TabIndex = 1;
            this.ResolutionHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResolutionHeight.CustomButton.UseSelectable = true;
            this.ResolutionHeight.CustomButton.Visible = false;
            this.ResolutionHeight.Lines = new string[] {
        "1080"};
            this.ResolutionHeight.Location = new System.Drawing.Point(112, 287);
            this.ResolutionHeight.MaxLength = 32767;
            this.ResolutionHeight.Name = "ResolutionHeight";
            this.ResolutionHeight.PasswordChar = '\0';
            this.ResolutionHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ResolutionHeight.SelectedText = "";
            this.ResolutionHeight.SelectionLength = 0;
            this.ResolutionHeight.SelectionStart = 0;
            this.ResolutionHeight.ShortcutsEnabled = true;
            this.ResolutionHeight.Size = new System.Drawing.Size(69, 23);
            this.ResolutionHeight.Style = MetroFramework.MetroColorStyle.White;
            this.ResolutionHeight.TabIndex = 59;
            this.ResolutionHeight.TabStop = false;
            this.ResolutionHeight.Text = "1080";
            this.ResolutionHeight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResolutionHeight.UseSelectable = true;
            this.ResolutionHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ResolutionHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKeypress);
            // 
            // ResolutionXLabel
            // 
            this.ResolutionXLabel.AutoSize = true;
            this.ResolutionXLabel.Location = new System.Drawing.Point(94, 287);
            this.ResolutionXLabel.Name = "ResolutionXLabel";
            this.ResolutionXLabel.Size = new System.Drawing.Size(15, 19);
            this.ResolutionXLabel.TabIndex = 60;
            this.ResolutionXLabel.Text = "x";
            this.ResolutionXLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(741, 467);
            this.Controls.Add(this.ResolutionXLabel);
            this.Controls.Add(this.ResolutionHeight);
            this.Controls.Add(this.ResolutionWidth);
            this.Controls.Add(this.PCSS);
            this.Controls.Add(this.DOF);
            this.Controls.Add(this.HBAO);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.CrossOrCheckMarkOfFILE);
            this.Controls.Add(this.FileExists);
            this.Controls.Add(this.FolderExists);
            this.Controls.Add(this.CrossOrCheckMarkOfFOLDER);
            this.Controls.Add(this.DLPathReset);
            this.Controls.Add(this.DLPathApply);
            this.Controls.Add(this.DLPathLabel);
            this.Controls.Add(this.DLPathBox);
            this.Controls.Add(this.CountNumber);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PakNameLabel);
            this.Controls.Add(this.FolderPathLabel);
            this.Controls.Add(this.AmbientOcclusion);
            this.Controls.Add(this.AntiAliasing);
            this.Controls.Add(this.MotionBlur);
            this.Controls.Add(this.FocusLabel);
            this.Controls.Add(this.LogsLabel);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.HighSettings);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.ExtraFOVLabel);
            this.Controls.Add(this.LowSettings);
            this.Controls.Add(this.Fullscreen);
            this.Controls.Add(this.Borderless);
            this.Controls.Add(this.ExtraFOVBox);
            this.Controls.Add(this.FolderPathBox);
            this.Controls.Add(this.Dump);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.PakNameBox);
            this.Controls.Add(this.VSync);
            this.Controls.Add(this.ClearJunk);
            this.Controls.Add(this.GenerateVideo);
            this.Controls.Add(this.GenerateDideMod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Dying Light Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton GenerateDideMod;
        private MetroFramework.Controls.MetroButton GenerateVideo;
        private MetroFramework.Controls.MetroButton ClearJunk;
        private MetroFramework.Controls.MetroCheckBox VSync;
        private MetroFramework.Controls.MetroTextBox PakNameBox;
        private MetroFramework.Controls.MetroCheckBox Logs;
        private MetroFramework.Controls.MetroCheckBox Dump;
        private MetroFramework.Controls.MetroTextBox FolderPathBox;
        private MetroFramework.Controls.MetroTextBox ExtraFOVBox;
        private MetroFramework.Controls.MetroCheckBox Borderless;
        private MetroFramework.Controls.MetroCheckBox Fullscreen;
        private MetroFramework.Controls.MetroCheckBox LowSettings;
        private MetroFramework.Controls.MetroLabel ExtraFOVLabel;
        private MetroFramework.Controls.MetroLabel ResolutionLabel;
        private MetroFramework.Controls.MetroCheckBox HighSettings;
        private System.Windows.Forms.RichTextBox LogBox;
        private MetroFramework.Controls.MetroLabel LogsLabel;
        private MetroFramework.Controls.MetroLabel FocusLabel;
        private MetroFramework.Controls.MetroCheckBox MotionBlur;
        private MetroFramework.Controls.MetroCheckBox AntiAliasing;
        private MetroFramework.Controls.MetroCheckBox AmbientOcclusion;
        private MetroFramework.Controls.MetroLabel FolderPathLabel;
        private MetroFramework.Controls.MetroLabel PakNameLabel;
        private MetroFramework.Controls.MetroButton Add;
        private MetroFramework.Controls.MetroLabel CountLabel;
        private MetroFramework.Controls.MetroLabel CountNumber;
        private MetroFramework.Controls.MetroTextBox DLPathBox;
        private MetroFramework.Controls.MetroLabel DLPathLabel;
        private MetroFramework.Controls.MetroButton DLPathApply;
        private MetroFramework.Controls.MetroButton DLPathReset;
        private MetroFramework.Controls.MetroLabel CrossOrCheckMarkOfFOLDER;
        private MetroFramework.Controls.MetroLabel FolderExists;
        private MetroFramework.Controls.MetroLabel FileExists;
        private MetroFramework.Controls.MetroLabel CrossOrCheckMarkOfFILE;
        private MetroFramework.Controls.MetroButton Reset;
        private MetroFramework.Controls.MetroCheckBox HBAO;
        private MetroFramework.Controls.MetroCheckBox DOF;
        private MetroFramework.Controls.MetroCheckBox PCSS;
        private MetroFramework.Controls.MetroTextBox ResolutionWidth;
        private MetroFramework.Controls.MetroTextBox ResolutionHeight;
        private MetroFramework.Controls.MetroLabel ResolutionXLabel;
    }
}

