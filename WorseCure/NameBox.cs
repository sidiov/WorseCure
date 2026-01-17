using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorseCure
{
    public partial class NameBox : Form
    {
        public List<string> namelist { get; set; }

        public NameBox(List<string> data)
        {
            InitializeComponent();

            namelist = data;

            lb_names.DataSource = namelist;

        }

        private void btn_addname_Click(object sender, EventArgs e)
        {
            if (tb_entername.Text != "")
            {
                
                namelist.Add(tb_entername.Text);
                tb_entername.Text = "";
            }

            lb_names.DataSource = null;
            lb_names.DataSource = namelist;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                namelist.RemoveAt(lb_names.SelectedIndex);
            }
            catch
            {
            }

            lb_names.DataSource = null;
            lb_names.DataSource = namelist;
        }

        private void NameBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void b_clear_name_Click(object sender, EventArgs e)
        {
            namelist.Clear();

            lb_names.DataSource = null;
            lb_names.DataSource = namelist;
        }
    }
}
