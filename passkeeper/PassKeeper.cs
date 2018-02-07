using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Data.Common;

namespace passkeeper
{
    public partial class PassKeeper : Form
    {
        bool debug = false;

        /// <summary>
        /// List containing the data and constructing classes
        /// </summary>
        List<Data> datapwList = new List<Data>();
        //Data datapwClass = new Data();
        DesEncrytion encryption = new DesEncrytion();
        AddPassword adpw;
        Random rnd;

        Settings settings = new Settings();

        /// <summary>
        /// Creating a list which will be a copy of datapwlist
        /// </summary>
        ListViewItem[] itemsC;

        /// <summary>
        /// Some static settings
        /// </summary>
        static string EncryptionPassword = "oU$#@S!@#SaMa123";
        string correctUsername = "admin";
        string correctPassword = "1234";
        int generatedPwLength = 0;

        bool searchAll = true;
        bool searchPassword = true;
        bool searchDomain = true;
        bool searchUsername = true;

        HashSet <int> indeces;
        string pattern;

        bool formMaximised = false;

        string dataPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string settingsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        string dataFileName = @"/testhoor.xml";
        string settingsFileName = @"/settingsApp.xml";

        string fullDataPathAndName;
        string fullSettingsPathAndName;

        public PassKeeper()
        {
            InitializeComponent();

            fullDataPathAndName = dataPath + dataFileName;
            fullSettingsPathAndName = settingsPath + settingsFileName;
            

            initLoad();

            debugState(debug);
        }

        /// <summary>
        /// Load data initially and do some other things to the form when loading up
        /// </summary>
        private void initLoad()
        {
            adpw = new AddPassword(lvPasswords, EncryptionPassword);

            MakeOrLoadSettingsFile();

            MakeOrLoadDataFile();



            #region making the tabcontrol tabs invisible
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            #endregion

        }

        /// <summary>
        /// Loads the data file if it can find it. If there is no file found for the data, it creates a new one.
        /// </summary>
        private void MakeOrLoadDataFile()
        {
            if (File.Exists(fullDataPathAndName))
                LoadData();
            else
                XmlSave.SaveData(datapwList, fullDataPathAndName);
        }


        /// <summary>
        /// Loads the settings file if one can be found. If there is no file found for te settings, it will create a new one.
        /// </summary>
        private void MakeOrLoadSettingsFile()
        {
            if (File.Exists(settingsPath + settingsFileName))
                LoadSettings();
            else
            {
                settings.username = encryption.EncryptString(correctUsername, EncryptionPassword);
                settings.password = encryption.EncryptString(correctPassword, EncryptionPassword);
                settings.genlength = generatedPwLength;
                settings.path = fullDataPathAndName;
                XmlSave.SaveData(datapwList, fullSettingsPathAndName);

                correctUsername = encryption.EncryptString(correctUsername, EncryptionPassword);
                correctPassword = encryption.EncryptString(correctPassword, EncryptionPassword);
                fullDataPathAndName = settings.path;
                generatedPwLength = settings.genlength;

            }
        }


        /// <summary>
        /// Setting the debug state! if debug is true than you dont need to login
        /// </summary>
        /// <param name="_debug"></param>
        private void debugState(bool _debug = false)
        {
            if (_debug)
            {
                tabControl1.SelectedIndex = 0;
                sidePanel.Visible = true;
            }
            else
            {
                tabControl1.SelectedIndex = 2;
                sidePanel.Visible = false;
            }
        }


        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates the counter with the amount of passwords
        /// </summary>
        public void updateCounter()
        {
            if (sliderCounter.Value != 100)
            {
                sliderCounter.Value = datapwList.Count;
            }
        }

  
        private void btnFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        
        /// <summary>
        /// Not used anymore as it gave responsiveness isseues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormMaxCon_Click(object sender, EventArgs e)
        {
            if (!formMaximised)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MinimumSize = this.Size;
                this.MaximumSize = this.Size;
                formMaximised = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.MinimumSize = this.Size;
                this.MaximumSize = this.Size;
                formMaximised = false;
            }

        }

        /// <summary>
        /// Resize Window
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
                    {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
                    {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
                };

                if (this.WindowState != FormWindowState.Maximized)
                {
                    foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                    {
                        if (hitBox.Value.Contains(clientPoint))
                        {
                            m.Result = (IntPtr)hitBox.Key;
                            handled = true;
                            break;
                        }
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            //adpw.Show();
            adpw.ShowDialog();
            try
            {
                if (adpw.datapwClass.domain != "")
                {
                    datapwList.Add(adpw.datapwClass);
                }
                itemsC = new ListViewItem[lvPasswords.Items.Count];
                lvPasswords.Items.CopyTo(itemsC, 0);
                updateCounter();
            } catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Unexpected shutdown");
            }
            
           
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            int length = generatedPwLength == 0 ? rnd.Next(7, 20) : generatedPwLength;
            string password = adpw.CreatePassword(length);
            TbGeneratedPassword.Text = password;

            Clipboard.SetText(password);

        }

        /// <summary>
        /// Not used anymore as it was just for manually loding in the debug process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = dataPath;
            saveFileDialog.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSave.SaveData(datapwList, saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Load all the data in the class and list
        /// </summary>
        private void LoadData()
        {
            try
            {
                XmlLoad<List<Data>> loadData = new XmlLoad<List<Data>>();
                datapwList = loadData.LoadData(fullDataPathAndName);
                updateCounter();

                foreach (Data mData in datapwList)
                {
                    if (mData != null)
                    {
                        ListViewItem items = new ListViewItem(mData.domain);
                        items.SubItems.Add(mData.username);
                        items.SubItems.Add(encryption.DecryptString(mData.password,EncryptionPassword));

                        lvPasswords.Items.Add(items);
                    }
                }
                itemsC = new ListViewItem[lvPasswords.Items.Count];
                lvPasswords.Items.CopyTo(itemsC, 0);

                Console.WriteLine(itemsC);

            }
            catch (ArgumentException arg)
            {
                MessageBox.Show(arg.Message);
            }

        }

        /// <summary>
        /// Saving all the data that has been created
        /// </summary>
        private void SaveData()
        {
            XmlSave.SaveData(datapwList, fullDataPathAndName);
            Console.WriteLine(datapwList);
        }

        private void PassKeeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
            SaveSettings();
        }

        private void CMSDelEntry_Click(object sender, EventArgs e)
        {
            if (lvPasswords.SelectedItems.Count != 0)
            {
                int indexToRemove = lvPasswords.Items.IndexOf(lvPasswords.SelectedItems[0]);
                lvPasswords.Items.RemoveAt(indexToRemove);

                datapwList.RemoveAt(indexToRemove);


                itemsC = itemsC.Where(val => val.Index != indexToRemove).ToArray();
                itemsC = itemsC.Where(val => val.Index != -1).ToArray();

                updateCounter();
            }
            else
            {
                MessageBox.Show("Please select a valid item");
            }
        }

        private void CMSCopyPW_Click(object sender, EventArgs e)
        {
            if (lvPasswords.SelectedItems.Count != 0)
            {
                int selectedIndex = lvPasswords.Items.IndexOf(lvPasswords.SelectedItems[0]);
                string password = lvPasswords.Items[selectedIndex].SubItems[2].Text;

                Clipboard.SetText(password);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchInList();
        }

        private void TbSearch_OnValueChanged(object sender, EventArgs e)
        {
            searchInList();
        }

        /// <summary>
        /// Search in the list and filter it
        /// </summary>
        private void searchInList()
        {
            pattern = TbSearch.Text;
            indeces = new HashSet<int>();
            if (pattern.Length > 0)
            {
                for (int i = 0; i < itemsC.Count(); i++)
                {
                    ListViewItem CurrItem = itemsC[i];
                    Console.WriteLine(itemsC[i]);

                    if (CbSearchAll.Checked)
                    {
                        if (maybeMatch(CurrItem.Text, pattern) || maybeMatch(CurrItem.SubItems[1].Text, pattern) || maybeMatch(CurrItem.SubItems[2].Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }
                    else if (CbSearchUsername.Checked && CbSearchPassword.Checked)
                    {
                        if (maybeMatch(CurrItem.SubItems[1].Text, pattern) || maybeMatch(CurrItem.SubItems[2].Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }
                    else if (CbSearchDomain.Checked && CbSearchPassword.Checked)
                    {
                        if (maybeMatch(CurrItem.Text, pattern) || maybeMatch(CurrItem.SubItems[2].Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }
                    else if (CbSearchDomain.Checked && CbSearchUsername.Checked)
                    {
                        if (maybeMatch(CurrItem.Text, pattern) || maybeMatch(CurrItem.SubItems[1].Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }
                    else if (CbSearchDomain.Checked)
                    {
                        if (maybeMatch(CurrItem.Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }else if (CbSearchUsername.Checked)
                    {
                        if ( maybeMatch(CurrItem.SubItems[1].Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }
                    else if (CbSearchPassword.Checked)
                    {
                        if (maybeMatch(CurrItem.SubItems[2].Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }
                    else
                    {
                        if (maybeMatch(CurrItem.Text, pattern))
                        {
                            if (!indeces.Contains(i))
                            {
                                indeces.Add(i);
                            }
                            Console.WriteLine("Index added: " + i);
                            Console.WriteLine("count" + indeces.Count);
                        }
                    }





                }

                this.lvPasswords.Items.Clear();
                foreach (var index in indeces)
                {
                    Console.WriteLine("The index: " + index + " is in the array");
                    this.lvPasswords.Items.Add(itemsC[index]);
                }
            }
            else
            {
                DisplayAllItems();
                indeces.Clear();
                Console.WriteLine("Indces cleared!");
            }
        }

        /// <summary>
        /// checking for a match in the source using the provided pattern
        /// </summary>
        /// <param name="source"></param>
        /// <param name="patternX"></param>
        /// <returns></returns>
        private bool maybeMatch(string source, string patternX)
        {
            string pattern = Regex.Escape(patternX.ToLower());
            string sentence = source.ToLower();
            foreach (Match match in Regex.Matches(sentence, pattern))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Displaying all the items in the listview
        /// </summary>
        void DisplayAllItems()
        {
            this.lvPasswords.Items.Clear();
            foreach (var item in itemsC)
            {
                lvPasswords.Items.Add(item);
            }
        }

        private void BtnPasswordTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void BtnGenerateTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }


        /// <summary>
        /// showing the main screen
        /// </summary>
        private void LogIn()
        {
            sidePanel.Visible = true;
            tabControl1.SelectedIndex = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string _username = tbUsernameLogin.Text;
            string _password = tbPasswordLogin.Text;
            Console.WriteLine($"{_username} : {_password}");
            Console.WriteLine($"{correctUsername} : {correctPassword}");
            if (_username == correctUsername && _password == correctPassword)
                LogIn();
            else
            {
                lblError.Text = "Please Try again!\nYour Credentials where faulty.";
                lblError.ForeColor = Color.OrangeRed;
            }
        }

        private void BtnPassKeeperSettingsTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void BtnSaveGenLength_Click(object sender, EventArgs e)
        {
            int selectedVal = Convert.ToInt32(NudPasswordLength.Value);
            if (selectedVal < 1)
                MessageBox.Show("Please select a value above 0","Error");
            else
            {
                generatedPwLength = selectedVal > 0 ? selectedVal : 0;
                MessageBox.Show("Generated password length succesfully changed!", "success");
            }

            settings.genlength = selectedVal;
        }

        private void CbSearchPassword_OnChange(object sender, EventArgs e)
        {
            searchPassword = CheckIfChecked(sender);
            CheckIfNotChecked(sender);
            checkIfAllChecked();
        }

        private void CbSearchUsername_OnChange(object sender, EventArgs e)
        {
            searchUsername = CheckIfChecked(sender);
            CheckIfNotChecked(sender);
            checkIfAllChecked();
        }

        private void CbSearchDomain_OnChange(object sender, EventArgs e)
        {
            searchDomain = CheckIfChecked(sender);

            CheckIfNotChecked(sender);
            checkIfAllChecked();
        }

        /// <summary>
        /// checks if all checkboxes are checked so it will check on the first checkbox (all)
        /// </summary>
        private void checkIfAllChecked()
        {
            CbSearchAll.Checked = (CbSearchDomain.Checked && CbSearchUsername.Checked && CbSearchPassword.Checked) ? true : false;
        }

        private void CbSearchAll_OnChange(object sender, EventArgs e)
        {
            searchAll = CheckIfChecked(sender);

            BunifuCheckbox cb = (BunifuCheckbox)sender;
            if (cb.Checked)
            {
                CbSearchDomain.Checked = true;
                CbSearchPassword.Checked = true;
                CbSearchUsername.Checked = true;
            }
            else
            {
                CbSearchDomain.Checked = true;
                CbSearchPassword.Checked = false;
                CbSearchUsername.Checked = false;
            }

        }

        /// <summary>
        /// Checks if the checkbox is checked and than returns a boolean with the result
        /// </summary>
        /// <param name="mSender"></param>
        /// <returns></returns>
        private bool CheckIfChecked(object mSender)
        {
            bool _result;
            BunifuCheckbox _cb = (BunifuCheckbox)mSender;
            _result = _cb.Checked ? true : false;

            return _result;
        }

        /// <summary>
        /// check if checkbox is not checked so checkbox of all can be unchecked
        /// </summary>
        /// <param name="sender"></param>
        private void CheckIfNotChecked(object sender)
        {
            BunifuCheckbox _cb = (BunifuCheckbox)sender;
            if (!_cb.Checked)
            {
                CbSearchAll.Checked = false;
            }
        }

        private void BtnLogOutTab_Click(object sender, EventArgs e)
        {
            tbPasswordLogin.Text = "";
            tbUsernameLogin.Text = "";
            tabControl1.SelectedIndex = 2;
            sidePanel.Visible = false;
        }

        /// <summary>
        /// not used anymore just for debugging purposes only!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// saving all the settings to the corespondig file
        /// </summary>
        private void SaveSettings()
        {
                XmlSave.SaveData(settings, settingsPath+ settingsFileName);

            Database.Connect();
            DbDataReader res = Database.sql($"insert into settings (passwordlength, datapath) VALUES ({settings.genlength}, {settings.path})");
            while (res.Read())
            {

                Console.WriteLine($"{res["password"]}");
            }
            Database.Close();
        }

        /// <summary>
        /// Load the settings and inting the local varibales
        /// </summary>
        private void LoadSettings()
        {
            try
            {
                XmlLoad<Settings> loadSettings = new XmlLoad<Settings>();
                settings = loadSettings.LoadData(settingsPath + settingsFileName);
                correctUsername = encryption.DecryptString(settings.username, EncryptionPassword);
                correctPassword = encryption.DecryptString(settings.password, EncryptionPassword);
                fullDataPathAndName = settings.path;

                tbPathChange.Text = fullDataPathAndName;
                NudPasswordLength.Value = settings.genlength;
            }
            catch (ArgumentException arg)
            {
                MessageBox.Show(arg.Message);
            }
        }

        private void BtnSaveUsernameLogin_Click(object sender, EventArgs e)
        {
            string newUsername = this.tbUsernameChange.Text;
            this.correctUsername = newUsername;
            settings.username = encryption.EncryptString(correctUsername,EncryptionPassword);

            MessageBox.Show("Username succesfully changed!", "success");
        }

        private void BtnSavePasswordLogin_Click(object sender, EventArgs e)
        {
            string newPassword = this.tbPasswordChange.Text;
            this.correctPassword = newPassword;
            settings.password = encryption.EncryptString(correctPassword, EncryptionPassword);

            MessageBox.Show("password succesfully changed!", "success");
        }

        private void BtnSaveDataPath_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = dataPath;
            saveFileDialog.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newDataPath = saveFileDialog.FileName;
                fullDataPathAndName = newDataPath;
                settings.path = fullDataPathAndName;

                tbPathChange.Text = newDataPath;
                MessageBox.Show("path succesfully changed!", "success");

            }
        }
    }
}


