using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using clickmonitor;
using System.Threading;
using System.Xml;
using System.IO;
using System.Collections;

namespace vocalkey
{
    public partial class formMain : Form
    {
        bool isEnabled = true;
        string currentDirectory = Environment.CurrentDirectory;
        string voicePackName;
        KeyboardHook k_hook = new KeyboardHook();
        //sound api functions
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        [DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool PlaySound(
            string pszSound,
            IntPtr hMod,
            SoundFlags sf);

        // Flags for playing sounds.  For this example, we are reading
        // the sound from a filename, so we need only specify
        // SND_FILENAME | SND_ASYNC

        [Flags]
        public enum SoundFlags : int
        {
            SND_SYNC = 0x0000,  // play synchronously (default)
            SND_ASYNC = 0x0001,  // play asynchronously
            SND_NODEFAULT = 0x0002,  // silence (!default) if sound not found
            SND_MEMORY = 0x0004,  // pszSound points to a memory file
            SND_LOOP = 0x0008,  // loop the sound until next sndPlaySound
            SND_NOSTOP = 0x0010,  // don't stop any currently playing sound
            SND_PURGE = 0x40, // <summary>Stop Playing Wave</summary>
            SND_NOWAIT = 0x00002000, // don't wait if the driver is busy
            SND_ALIAS = 0x00010000, // name is a registry alias
            SND_ALIAS_ID = 0x00110000, // alias is a predefined ID
            SND_FILENAME = 0x00020000, // name is file name
            SND_RESOURCE = 0x00040004  // name is resource name or atom
        }


        public formMain()
        {
            InitializeComponent();
            try
            {
                k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下
                k_hook.Start();//安装键盘钩子
            }
            catch
            {
                MessageBox.Show("安装键盘Hook失败！请将本程序添加至安全软件信任列表", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("vnkConfig.xml") == false)
            {
                FileStream f2 = new FileStream("vnkConfig.xml", FileMode.Create, FileAccess.Write);
                StreamWriter fs2 = new StreamWriter(f2);
                fs2.Write(Properties.Resources.defaultConfig);
                fs2.Close();
                f2.Close();
            }
            loadConfig();
            string[] voicePackDirs = Directory.GetDirectories(currentDirectory + @"\voice");
            if (voicePackDirs.Length == 0)
            {
                MessageBox.Show("未找到任何语音包", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            ArrayList voicePacks = new ArrayList();
            foreach (string voicePackDir in voicePackDirs)
            {
                string[] path = voicePackDir.Split('\\');
                comboBoxVoicePackSelect.Items.Add(path[path.Length - 1]);
                voicePacks.Add(path[path.Length - 1]);
                Debug.WriteLine(path);
            }
            comboBoxVoicePackSelect.SelectedIndex = Array.IndexOf(voicePacks.ToArray(), voicePackName);

        }
        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxMainkey.Checked)
            {
                switch (e.KeyValue)
                {
                    case (int)Keys.D1:
                        if (checkBoxNum1.Checked)
                        {
                            if (checkBoxChineseAcent.Checked)
                            {
                                playSound(currentDirectory + @"\voice\" + voicePackName + @"\yao.wav");
                            }
                            else
                            {
                                playSound(currentDirectory + @"\voice\" + voicePackName + @"\1.wav");
                            }
                        }
                        break;
                    case (int)Keys.D2:
                        if (checkBoxNum2.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\2.wav"); };
                        break;
                    case (int)Keys.D3:
                        if (checkBoxNum3.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\3.wav"); };
                        break;
                    case (int)Keys.D4:
                        if (checkBoxNum4.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\4.wav"); };
                        break;
                    case (int)Keys.D5:
                        if (checkBoxNum5.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\5.wav"); };
                        break;
                    case (int)Keys.D6:
                        if (checkBoxNum6.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\6.wav"); };
                        break;
                    case (int)Keys.D7:
                        if (checkBoxNum7.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\7.wav"); };
                        break;
                    case (int)Keys.D8:
                        if (checkBoxNum8.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\8.wav"); };
                        break;
                    case (int)Keys.D9:
                        if (checkBoxNum9.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\9.wav"); };
                        break;
                    case (int)Keys.D0:
                        if (checkBoxNum0.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\0.wav"); };
                        break;
                    case 190:
                        if (checkBoxNum0.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\dot.wav"); };
                        break;
                }
                
           
            }
            if(checkBoxNumkey.Checked)
            {
                switch (e.KeyValue)
                {
                    case (int)Keys.NumPad1:
                        if (checkBoxNum1.Checked)
                        {
                            if (checkBoxChineseAcent.Checked)
                            {
                                playSound(currentDirectory + @"\voice\" + voicePackName + @"\yao.wav");
                            }
                            else
                            {
                                playSound(currentDirectory + @"\voice\" + voicePackName + @"\1.wav");
                            }
                        }
                        break;
                    case (int)Keys.NumPad2:
                        if (checkBoxNum2.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\2.wav"); };
                        break;
                    case (int)Keys.NumPad3:
                        if (checkBoxNum3.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\3.wav"); };
                        break;
                    case (int)Keys.NumPad4:
                        if (checkBoxNum4.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\4.wav"); };
                        break;
                    case (int)Keys.NumPad5:
                        if (checkBoxNum5.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\5.wav"); };
                        break;
                    case (int)Keys.NumPad6:
                        if (checkBoxNum6.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\6.wav"); };
                        break;
                    case (int)Keys.NumPad7:
                        if (checkBoxNum7.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\7.wav"); };
                        break;
                    case (int)Keys.NumPad8:
                        if (checkBoxNum8.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\8.wav"); };
                        break;
                    case (int)Keys.NumPad9:
                        if (checkBoxNum9.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\9.wav"); };
                        break;
                    case (int)Keys.NumPad0:
                        if (checkBoxNum0.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\0.wav"); };
                        break;
                    case (int)Keys.Decimal:
                        if (checkBoxDot.Checked) { playSound(currentDirectory + @"\voice\" + voicePackName + @"\dot.wav"); };
                        break;
                }
            }

        }
        private void playSound(string path)
        {
            ParameterizedThreadStart ts = new ParameterizedThreadStart(PlayThread);
            Thread WorkerThread = new Thread(ts);
            WorkerThread.Start(path);
        }
        private void PlayThread(object path)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            string FileName = path.ToString();
            string TrackName = random.Next().ToString();
            mciSendString("open \"" + FileName + "\" type waveaudio alias " + TrackName, null, 0, IntPtr.Zero);
            mciSendString("play " + TrackName, null, 0, IntPtr.Zero);
            Thread.Sleep(2000);
            mciSendString("stop " + TrackName, null, 0, IntPtr.Zero);
            mciSendString("close " + TrackName, null, 0, IntPtr.Zero);
            sb = null;
            random = null;
        }
        private void loadConfig()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("vnkConfig.xml");
            checkBoxMainkey.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("Mainkey").ToString()) == "true" ? true : false;
            checkBoxNumkey.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("Numkey").ToString()) == "true" ? true : false;
            checkBoxNum0.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n0").ToString()) == "true" ? true : false;
            checkBoxNum1.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n1").ToString()) == "true" ? true : false;
            checkBoxNum2.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n2").ToString()) == "true" ? true : false;
            checkBoxNum3.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n3").ToString()) == "true" ? true : false;
            checkBoxNum4.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n4").ToString()) == "true" ? true : false;
            checkBoxNum5.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n5").ToString()) == "true" ? true : false;
            checkBoxNum6.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n6").ToString()) == "true" ? true : false;
            checkBoxNum7.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n7").ToString()) == "true" ? true : false;
            checkBoxNum8.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n8").ToString()) == "true" ? true : false;
            checkBoxNum9.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("n9").ToString()) == "true" ? true : false;
            checkBoxDot.Checked = (((XmlElement)(xml.GetElementsByTagName("VocalKeys")[0])).GetAttribute("Dot").ToString()) == "true" ? true : false;
            checkBoxChineseAcent.Checked = (((XmlElement)(xml.GetElementsByTagName("Voice")[0])).GetAttribute("ChineseAccent").ToString()) == "true" ? true : false;
            voicePackName = ((XmlElement)(xml.GetElementsByTagName("Voice")[0])).GetAttribute("PackName").ToString();
        }
        private void saveConfig()
        {
            XmlDocument xml = new XmlDocument();
            XmlDeclaration dec = xml.CreateXmlDeclaration("1.0", "utf-8", null);
            xml.AppendChild(dec);
            XmlElement Config = xml.CreateElement("Config");
            xml.AppendChild(Config);

            XmlElement voice = xml.CreateElement("Voice");
            voice.SetAttribute("PackName", voicePackName);
            voice.SetAttribute("ChineseAccent", checkBoxChineseAcent.Checked == true ? "true" : "false");
            Config.AppendChild(voice);

            XmlElement vocalkeys = xml.CreateElement("VocalKeys");
            vocalkeys.SetAttribute("Mainkey", checkBoxMainkey.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("Numkey", checkBoxNumkey.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n0", checkBoxNum0.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n0", checkBoxNum0.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n1", checkBoxNum1.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n2", checkBoxNum2.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n3", checkBoxNum3.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n4", checkBoxNum4.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n5", checkBoxNum5.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n6", checkBoxNum6.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n7", checkBoxNum7.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n8", checkBoxNum8.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("n9", checkBoxNum9.Checked == true ? "true" : "false");
            vocalkeys.SetAttribute("Dot", checkBoxDot.Checked == true ? "true" : "false");


            Config.AppendChild(vocalkeys);

            xml.Save("vnkConfig.xml");
        }
        private void timerReloadHook_Tick(object sender, EventArgs e)
        {
            try
            {
                k_hook.Stop();
                k_hook.Start();
            }
            catch
            {
                MessageBox.Show("安装键盘Hook失败！请将本程序添加至安全软件信任列表", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void comboBoxVoicePackSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            voicePackName = comboBoxVoicePackSelect.SelectedItem.ToString();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            switchStatus();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            formAbout formAbout = new formAbout();
            formAbout.ShowDialog();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            this.Hide();   //隐藏窗体
            notifyIcon.ShowBalloonTip(1000, "已最小化至系统托盘", "程序将在后台运行", ToolTipIcon.Info);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfig();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void formMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                this.Hide();   //隐藏窗体
                notifyIcon.ShowBalloonTip(1000, "已最小化至系统托盘", "程序将在后台运行", ToolTipIcon.Info);
            }
        }

        private void 显示面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void switchStatus()
        {
            if (isEnabled)
            {
                labelStatus.Text = "语音播报禁用";
                禁用语音播报ToolStripMenuItem.Text = "启用语音播报";
                timerReloadHook.Stop();
                k_hook.Stop();
                isEnabled = false;
            }
            else
            {
                labelStatus.Text = "语音播报启用";
                禁用语音播报ToolStripMenuItem.Text = "禁用语音播报";
                timerReloadHook.Start();
                k_hook.Start();
                isEnabled = true;
            }
        }

        private void 禁用语音播报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchStatus();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    }

