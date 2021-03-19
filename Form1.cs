using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnt2
{
    public partial class Form1 : Form
    {

        List<String> quests = new List<String>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = quests;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            quests.Clear();
            bs.ResetBindings(false);
            if (chkbx_easy.Checked)
            {
                EasyQuests();
            }
            if (chkbx_med.Checked)
            {
                MediumQuests();
            }
            if (chkbx_hard.Checked)
            {
                HardQuests();
            }
            lb_quests.DataSource = bs;
            bs.ResetBindings(false);

        }

        private void EasyQuests()
        {
            string[] free = { "Cook's Assistant", "Sheep Shearer", "The Restless Ghost" };
            string[] members = { "Fishing Contest", "Monk's Friend", "Sheep Herder" };
            if (rdbtn_free.Checked)
            {
                quests.AddRange(free);
            }
            else if (rdbtn_mem.Checked)
            {
                quests.AddRange(members);
            }
            else if (rdbtn_both.Checked)
            {
                quests.AddRange(free);
                quests.AddRange(members);
            }
        }

        private void MediumQuests()
        {
            string[] free = { "The Knight's Sword" };
            string[] members = { "Holy Grail", "Tree Gnome Village", "Waterfall Quest", "Watch Tower" };
            if (rdbtn_free.Checked)
            {
                quests.AddRange(free);
            }
            else if (rdbtn_mem.Checked)
            {
                quests.AddRange(members);
            }
            else if (rdbtn_both.Checked)
            {
                quests.AddRange(free);
                quests.AddRange(members);
            }
        }
        private void HardQuests()
        {
            string[] free = { "Dragon Slayer I" };
            string[] members = { "Lost City", "Underground Pass", "Swan Song", "Contact!", "Grim Tales" };
            if (rdbtn_free.Checked)
            {
                quests.AddRange(free);
            }
            else if (rdbtn_mem.Checked)
            {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                quests.AddRange(members);
            }
            else if (rdbtn_both.Checked)
            {
                quests.AddRange(free);
                quests.AddRange(members);
            }
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            lb_comp.Items.Add(lb_quests.SelectedItem);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lb_comp.Items.RemoveAt(lb_comp.SelectedIndex);
        }
    }
}