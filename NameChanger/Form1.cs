using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameChanger
{
    //partial??
    public partial class Form1 : Form
    {
        private static string SITE_PREFIX;

        public Form1()
        {
            InitializeComponent();
            SITE_PREFIX = prefixTextBox.Text;
        }

        private void changeFileButton_Click(object sender, EventArgs e)
        {
            
            if (oldAudioList.Items.Count != 0) {
                oldAudioList.Items.Clear();
            }
            if (newAudioList.Items.Count != 0){
                newAudioList.Items.Clear();
            }
            
            SITE_PREFIX = prefixTextBox.Text;

            string[] audioFiles = Directory.GetFiles(@"C:\Users\User\Downloads", "*.mp3");
            Console.WriteLine("audioFiles size: " + audioFiles.Length);

            //add old names of files to listView
            foreach (string oldAudioName in audioFiles) {
                oldAudioList.Items.Add(oldAudioName.Replace(@"C:\Users\User\Downloads\", ""));
            }

            List<string> newNames = new List<string>();

            foreach (String oldNameOfFile in audioFiles) {
                if (oldNameOfFile.Contains(SITE_PREFIX))
                {
                    string newFileName = oldNameOfFile.Replace(SITE_PREFIX, "");
                    newNames.Add(newFileName);
                    System.IO.File.Move(oldNameOfFile, newFileName);
                }
            }

            //add NEW names of files to listView
            foreach (string newName in newNames) {
                newAudioList.Items.Add(newName.Replace(@"C:\Users\User\Downloads\", ""));
            }

            numberOfAudiofiles.Text = Convert.ToString(newNames.Count);

        }

        private void numberOfAudiofiles_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oldAudioList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
