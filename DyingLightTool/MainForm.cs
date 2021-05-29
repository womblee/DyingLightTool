using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyingLightTool
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {    
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        string dlpath = "";
        private bool dlpathenabled;
        private bool fcheckboxstatus;
        private bool scheckboxstatus;
        
        private void HandleKeypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        string basedata;
        List<dynamic> data = new List<dynamic>();

        private void metroButton4_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();
            
            if (fcheckboxstatus == true && scheckboxstatus == true)
            {
                data.Add("\n" + FolderPathBox.Text + @"\" + PakNameBox.Text + ".pak=1");
                int parsed = Int16.Parse(CountNumber.Text);
                CountNumber.Text = (parsed + 1).ToString();
            }
            else
            {
                MessageBox.Show("Both check marks must be checked to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void metroButton7_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();

            data.Clear();
            CountNumber.Text = "0";
            PakNameBox.Text = "";
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            FocusLabel.Focus();

            if (!data.Any())
            {
                MessageBox.Show("Nothing to generate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogBox.AppendText("Nothing to generate" + "\n");
                return;
            }
            if (!dlpathenabled)
            {
                MessageBox.Show("No path applied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogBox.AppendText("No path applied" + "\n");
                return;
            }
            if (!fcheckboxstatus == true && !scheckboxstatus == true)
            {
                MessageBox.Show("Both check marks must be checked to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(dlpath))
            {
                MessageBox.Show("Seems that this folder doesn't exist anymore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            basedata =
                    "[General]"
                    +
                    "\n"
                    +
                    "EnableMod = 1"
                    +
                    "\n"
                    +
                    "EnableLogging = 0"
                    +
                    "\n"
                    +
                    "LogFile = dide_mod_log.ini"
                    +
                    "\n\n"
                    +
                    "[Features]"
                    +
                    "\n"
                    +
                    "DeveloperMenu = 0"
                    +
                    "\n"
                    +
                    "CustomPak = 1"
                    +
                    "\n\n"
                    +
                    "[CustomPak]";

            foreach (string i in data)
            {
                basedata = basedata + i;
            }

            File.WriteAllText(dlpath+@"\dide_mod.ini", basedata);
            LogBox.AppendText("dide_mod.ini has been generated in " + dlpath + @"\dide_mod.ini" + "\n");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();

            if (!Logs.Checked && !Dump.Checked)
            {
                MessageBox.Show("You didn't check any of the checkboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string o = docpath + @"\DyingLight";
            if (!Directory.Exists(o))
            {
                MessageBox.Show("You don't have the Dying Light Folder in documents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string g = o + @"\out";
            string h = o + @"\out\logs";

            if (!Directory.Exists(g))
            {
                MessageBox.Show("You don't have the out folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(h))
            {
                MessageBox.Show("You don't have the logs folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LogBox.AppendText(g + "\n");
            LogBox.AppendText(h + "\n");


            if (Logs.Checked)
            {
                string[] crashfiles = Directory.GetFiles(h);

                foreach (string filePath in crashfiles)
                {
                    if (Dump.Checked)
                    {
                        if (filePath.Contains("crash"))
                        {
                            File.Delete(filePath);
                        }
                    }
                }
            }

            string[] files = Directory.GetFiles(g);

            foreach (string filePath in files)
            {
                if (Dump.Checked)
                {
                    if (filePath.Contains("plsdownload"))
                    {
                        File.Delete(filePath);
                    }
                }
            }
            Logs.Checked = false;
            Dump.Checked = false;

            LogBox.AppendText("Cleared everything" + "\n");

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();

            string finalres = ResolutionWidth.Text;
            string finalrestwo = ResolutionHeight.Text;

            string texquality = "Medium";
            int ambientoccstatus = 0;
            int motionblurstatus = 0;
            int aastatus = 0;
            int shadowmapsize = 512;
            int spotshadowmapsize = 512;
            string visrange = "1.0";
            string visrangeone = "1.0";
            int grassquality = 0;
            string fov = ExtraFOVBox.Text;
            bool hbao = HBAO.Checked;
            bool dof = DOF.Checked;
            bool pcss = PCSS.Checked;

            if (AntiAliasing.Checked)
            {
                aastatus = 1;
            }
            if (AmbientOcclusion.Checked)
            {
                ambientoccstatus = 1;
            }
            if (MotionBlur.Checked)
            {
                motionblurstatus = 1;
            }
            if (LowSettings.Checked)
            {
                texquality = "Low";
                grassquality = 2;
            }
            else if (HighSettings.Checked)
            {
                texquality = "High";
                grassquality = 0;
                shadowmapsize = 2048;
                spotshadowmapsize = 2048;
                visrange = "1.50";
                visrangeone = "1.50";
            }
            
            string tdata
                    =
                    "!Resolution(i, i)"
                    +
                    "\n"
                    +
                    "!WindowOffset(i, i)"
                    +
                    "\n"
                    +
                    "!Monitor(i)                    // -1 primary monitor"
                    +
                    "\n"
                    +
                    "!TextureQuality(s)             // Low, Medium, High"
                    +
                    "\n"
                    +
                    "!GammaFloat(f)"
                    +
                    "\n"
                    +
                    "!Shadows(s)                    // Low, High"
                    +
                    "\n"
                    +
                    "!ShadowMapSize(i)"
                    +
                    "\n"
                    +
                    "!SpotShadowMapSize(i)"
                    +
                    "\n"
                    +
                    "!Fullscreen()"
                    +
                    "\n"
                    +
                    "!Borderless()"
                    +
                    "\n"
                    +
                    "!MaxFPS(i)						// Max frame rate"
                    +
                    "\n"
                    +
                    "!VSync()                       // enable vertical sync"
                    +
                    "\n"
                    +
                    "!GrassQuality(i)               // lower is better"
                    +
                    "\n"
                    +
                    "!NvidiaEffects(i, i, i)          // enable extra nvidia effects(hbao+,dof,pcss)"
                    +
                    "\n"
                    +
                    "!ExtraGameFov(f)               // extra fov"
                    +
                    "\n"
                    +
                    "!VisRange(f, f)"
                    +
                    "\n"
                    +
                    "!OculusEnabled()               // enable support for Oculus"
                    +
                    "\n"
                    +
                    "!AmbientOcclusion(i)           // 1 - enable; 0 - disable"
                    +
                    "\n"
                    +
                    "!MotionBlur(i)                 // 1 - enable; 0 - disable"
                    +
                    "\n"
                    +
                    "!AntiAliasing(i)               // 1 - enable; 0 - disable"
                    +
                    "\n"
                    +
                    "!DisableDWM(i)                 // disables DWM when fullscreen"
                    +
                    "\n"
                    +
                    "!3dtvSettings(f, f)           // /3dtv ui depth, scene separation/offset (-0.15, 0.041, -0.00722)"
                    +
                    "\n"
                    +
                    "!Version(i)"
                    +
                    "\n\n"
                    +
                    "Resolution(" + finalres + ", " + finalrestwo + ")";
                    
                    if (Borderless.Checked && !Fullscreen.Checked)
                    {
                       tdata = tdata + "\nBorderless()";
                    }
                    if (Fullscreen.Checked && !Borderless.Checked)
                    {
                       tdata = tdata + "\nFullscreen()";
                    }          
            
              tdata =
                      tdata
                      +
                      "\n"
                      +
                      "Monitor(0)"
                      +
                      "\n"
                      +
                      "TextureQuality(" + @"""" + texquality + @"""" + ")"
                      +
                      "\n"
                      +
                      "VisRange("+visrange+", "+visrangeone+")"
                      +
                      "\n"
                      +
                      "ShadowMapSize(" + shadowmapsize + ")"
                      +
                      "\n"
                      +
                      "SpotShadowMapSize("+ spotshadowmapsize + ")"
                      +
                      "\n"
                      +
                      "GammaFloat(1.35)"
                      +
                      "\n"
                      +
                      "GrassQuality("
                      +
                      grassquality
                      + 
                      ")";
            tdata =
                     tdata;
                    
                     if (VSync.Checked)
                     {
                        tdata = tdata + "\nVSync()";
                     }
                     if (int.Parse(fov) > 0)
                     {
                         tdata =
                              tdata
                              +
                              "\n"
                              +
                              "ExtraGameFov(" + fov + ")";
                     }
                     if (ambientoccstatus == 1)
                     {
                        if (!HBAO.Checked && !DOF.Checked && !PCSS.Checked)
                        {
                           return;
                        }
                        int fst = 0;
                        int scnd = 0;
                        int thrd = 0;

                        if (hbao) fst = 1;
                        if (dof) scnd = 1;
                        if (pcss) thrd = 1;

                        string nvidia = "NvidiaEffects(" + fst + ", " + scnd + ", " + thrd + ")";

                        tdata = tdata + "\n" + nvidia;
                     }
              
            
           tdata =   
                    tdata
                    +
                    "\n"
                    +
                    "AmbientOcclusion("+ambientoccstatus+")"
                    +
                    "\n"
                    +
                    "MotionBlur("+motionblurstatus+")"
                    +
                    "\n"
                    +
                    "AntiAliasing("+aastatus+")"
                    +
                    "\n"
                    +
                    "DisableDWM(1)"
                    +
                    "\n"
                    +
                    "3dtvSettings(-0.150000, 0.000000)"
                    +
                    "\n"
                    +
                    "Version(1)\n ";                 

            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string o = docpath + @"\DyingLight";
            if (!Directory.Exists(o))
            {
                MessageBox.Show("You don't have the Dying Light Folder in documents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string g = o + @"\out\settings";
            if (!Directory.Exists(g))
            {
                MessageBox.Show("You don't have the settings folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            File.WriteAllText(g+@"\video.scr", tdata);

            LogBox.AppendText("Generated in " + g +"\n");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();
        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            Fullscreen.Checked = !Borderless.Checked;
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            Borderless.Checked = !Fullscreen.Checked;
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            FocusLabel.Focus();

            if (!Directory.Exists(DLPathBox.Text))
            {
                MessageBox.Show("That path doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogBox.AppendText("That path doesn't exist" + "\n");
                return;
            }
            dlpath = DLPathBox.Text;
            DLPathBox.ReadOnly = true;
            DLPathApply.Enabled = false;
            DLPathReset.Enabled = true;
            dlpathenabled = true;
            LogBox.AppendText("Enabled path: "+ dlpath + "\n");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FocusLabel.Focus();
            DLPathBox.ReadOnly = false;
            DLPathApply.Enabled = true;
            DLPathReset.Enabled = false;
            DLPathBox.Text = "";
            dlpathenabled = false;      
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(FolderPathBox.Text))
            {
                CrossOrCheckMarkOfFOLDER.Text = "✖";
                fcheckboxstatus = false;
            }
            else if (Directory.Exists(FolderPathBox.Text))
            {
                CrossOrCheckMarkOfFOLDER.Text = "✔";
                fcheckboxstatus = true;
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(FolderPathBox.Text))
            {
                CrossOrCheckMarkOfFILE.Text = "✖";
                scheckboxstatus = false;
                return; 
            }
            else if (Directory.Exists(FolderPathBox.Text))
            {
                if (File.Exists(FolderPathBox.Text + @"\" + PakNameBox.Text + ".pak"))
                {
                    CrossOrCheckMarkOfFILE.Text = "✔";
                    scheckboxstatus = true;
                }
                else
                {
                    CrossOrCheckMarkOfFILE.Text = "✖";
                    scheckboxstatus = false;
                }
            }
        }

        private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (!AmbientOcclusion.Checked)
            {
                AmbientOcclusion.Checked = true;
            }
            
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (!AmbientOcclusion.Checked)
            {
                AmbientOcclusion.Checked = true;
            }
        }

        private void metroCheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (!AmbientOcclusion.Checked)
            {
                AmbientOcclusion.Checked = true;
            }
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            LowSettings.Checked = !HighSettings.Checked;
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            HighSettings.Checked = !LowSettings.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
