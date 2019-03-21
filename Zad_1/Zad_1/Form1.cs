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
using System.Reflection;


namespace Zad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPlugins();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName);
            }

        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!wtyczkiToolStripMenuItem.DropDownItems.ContainsKey("Nazwa"))
            {
                wtyczkiToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(textBox1.Text, null, MenuHandler, textBox1.Text));
            }

        }
        private void MenuHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            
            string[] names = item.Name.Split(new char[] { '|' });
            string NazwaAssembly = names[0];
            string NazwaKlasy = names[1];
            string NazwaMetody = names[2];
            MessageBox.Show("Wciśnięto menu.\nKlucz: " + item.Name + " Napis: " + item.Text);
            Assembly plugin = Assembly.Load(NazwaAssembly);
            Type item2 = plugin.GetType(NazwaKlasy);            MethodInfo method = item2.GetMethod(NazwaMetody);
            object result = method.Invoke(null, new object[] { richTextBox1.Text });
        }

        void LoadPlugins()
        {
            foreach (string myFilename in Directory.GetFiles(@"C:\Users\Szymon\source\repos\Prog_Sys_Wieloag", "*.dll", SearchOption.AllDirectories))
            {
                Assembly plugin = Assembly.LoadFrom(myFilename);
                foreach (Type item in plugin.GetTypes()) //lista klas
                {
                   
                    foreach (MethodInfo method in item.GetMethods())
                    {
                        if (method.Name.EndsWith("xs") || method.Name.EndsWith("xr") || method.Name.EndsWith("xe"))
                        {
                            wtyczkiToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(method.Name, null, MenuHandler, myFilename + "|" + item.Name + "|" + method.Name));
                            object result = method.Invoke(null, new object[] { richTextBox1.Text});
                        }
                    }
                }
            }


        }
    }
}
