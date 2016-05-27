using PocoDeArquivo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocoDeArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeViewPrincipal(object sender, TreeViewEventArgs e)
        {

        }

        private string getPath(TreeNode node)
        {
            return "";
        }

        private bool isFile(TreeNode n)
        {
            string[] s = n.Name.Split('/');
            string name = s[s.Length - 1];
            return name.Contains(".txt");
        }

        private bool validateName(string name)
        {
            string n = name.Trim();
            Regex r = new Regex(@"([_+ \- @ # & ( ) a-z A-Z \d]{"+n.Length+"})");
            Match m = r.Match(n);
            return m.Success;
        }

        private bool alreadyExists(TreeNode n,string name, bool isFile)
        {
            string str = n.Name + "/" + name + (isFile ? ".txt" : ".dir");
            bool ret = false;
            foreach(TreeNode tn in n.Nodes)
            {
                if (tn.Name.Equals(str))
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeView1.SelectedNode;
            if (selected != null)
            {
                if (!isFile(selected))
                {
                    if (!tbName.Text.Trim().Equals(""))
                    {
                        if (!alreadyExists(selected, tbName.Text, true))
                        {
                            if (validateName(tbName.Text))
                            {
                                TreeNode n = new TreeNode();
                                n.Name = selected.Name + "/" + tbName.Text.Trim() + ".txt";
                                n.Text = tbName.Text.Trim() + ".txt";

                                selected.Nodes.Add(n);
                                Form f = new FileHandler(this);
                                f.Show();
                                /**
                                 * Send the current node to Controller layer
                                 * insert the node into the Graph
                                 * manipulate the criation/modification times
                                 * into file definitions
                                 */
                            }
                            else
                            {
                                MessageBox.Show("The entry name have an incorrect pattern!",
                                                "Name pattern error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This folder already contains a file with this name!",
                                            "Title of file error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The title of file culdn't be nullable!",
                                        "Title of file error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Impossible to create a folder into a file!",
                                    "Selection error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("There is no file or folder selected!",
                                "Selection error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void btFolder_Click(object sender, EventArgs e)
        {
            TreeNode selected = treeView1.SelectedNode;
            if (selected != null)
            {
                if(!isFile(selected))
                {
                    if (!tbName.Text.Trim().Equals(""))
                    {
                        if(!alreadyExists(selected,tbName.Text,false))
                        {
                            if (validateName(tbName.Text))
                            {
                                TreeNode n = new TreeNode();
                                n.Name = selected.Name + "/" + tbName.Text.Trim() + ".dir";
                                n.Text = tbName.Text;

                                selected.Nodes.Add(n);
                            }
                            else
                            {
                                MessageBox.Show("The entry name have an incorrect pattern!",
                                                "Name pattern error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Impossible to create two folders with same name!",
                            "Title of folder error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The title of folder culdn't be nullable!",
                            "Title of file error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Impossible to create a folder into a file!",
                            "Selection error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("There is no file or folder selected!",
                        "Selection error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
