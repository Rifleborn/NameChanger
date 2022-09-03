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
        private static string SITE_PREFIX = "y2mate.com - ";

        public Form1()
        {
            InitializeComponent();
        }

        private void changeFileButton_Click(object sender, EventArgs e)
        {
            string[] audioFiles = Directory.GetFiles(@"C:\Users\User\Downloads", "*.mp3");
            Console.WriteLine("audioFiles size: " + audioFiles.Length);

            try { 
            Console.WriteLine(audioFiles[0]);
            Console.WriteLine(audioFiles[1]);
            } catch (Exception exc) {
                Console.WriteLine(exc.ToString());
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
            try
            {
                Console.WriteLine(newNames[0]);
                Console.WriteLine(newNames[1]);
            } catch (Exception exc) {
                Console.WriteLine(exc.ToString());
            }
        }
    }
}
