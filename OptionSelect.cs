using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beinet.cn.RegexTool
{
    public partial class OptionSelect : Form
    {
        public object para { get; set; }
        public object ret { get; set; }
        public OptionSelect(object arg)
        {
            para = arg;
            if (para == null)
            {
                Close();
                //MessageBox.Show("aaa");
                return;
            }
            InitializeComponent();

            if(para is Regex)
            {
                comboBox1.Items.Clear();
                ret = null;

                var reg = para as Regex;
                int tmp;
                foreach (var gid in reg.GetGroupNumbers())
                {
                    string gname;
                    if (gid == 0)
                        gname = "整个匹配";
                    else
                    {
                        gname = reg.GroupNameFromNumber(gid);
                        if (!string.IsNullOrEmpty(gname) && !int.TryParse(gname, out tmp))
                            gname = "分组" + gid + "(" + gname + ")";
                        else
                            gname = "分组" + gid;
                    }
                    comboBox1.Items.Add(gname);
                }
                comboBox1.SelectedIndex = 0;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("请选择分组");
                return;
            }
            ret = comboBox1.Text;
            Close();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
