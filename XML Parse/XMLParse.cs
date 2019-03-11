/* XMLParse.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//USING
using System.Xml;

namespace XML_Parse
{
    public partial class XMLParse : Form
    {
        public XMLParse()
        {
            InitializeComponent();
        }

        private void uxParse_Click(object sender, EventArgs e)
        {
            if (uxParseTerm.Text != null && uxParseTerm.Text.Length >= 3)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load();
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == uxParseTerm.Text)
                    {
                        foreach (XmlNode child in node)
                        {
                            uxList.Items.Add(child.InnerText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
                uxParseTerm.Text = string.Empty;
                uxParseTerm.Focus();
            }
        }
    }
}
