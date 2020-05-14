using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    
    public partial class Form1 : Form
    {
        List<string> listas = new List<string>();
        List<string> combo = new List<string>();
        List<string> checklist = new List<string>();
        public Form1()
        {
            InitializeComponent();
            txtBx_Elemnto.Select();
            checkedListBox.CheckOnClick = true;
            R_ListBx.Checked = true;
        }
       
        
        public void ContarElementos()
        {
            lbl_ListBx.Text = Convert.ToString(listas.Count());

            lbl_ComboBx.Text = Convert.ToString(combo.Count());

            lbl_CheckListBx.Text = Convert.ToString(checklist.Count());
        }
        

        private void R_ListBx_CheckedChanged(object sender, EventArgs e)
        {
            ContarElementos();
            txtBx_Elemnto.Focus();

            comboBox.Enabled = false;
            checkedListBox.Enabled = false;
            listBox.Enabled = true;
        }

        private void R_ComboBx_CheckedChanged(object sender, EventArgs e)
        {
            ContarElementos();
            txtBx_Elemnto.Focus();

            listBox.Enabled = false;
            checkedListBox.Enabled = false;
            comboBox.Enabled = true;
        }

        private void R_CheckLBx_CheckedChanged(object sender, EventArgs e)
        {
            ContarElementos();
            txtBx_Elemnto.Focus();

            comboBox.Enabled = false;
            listBox.Enabled = false;
            checkedListBox.Enabled = true;
        }

      
        private void bttn_mostrar_Click(object sender, EventArgs e)
        {
            txtBx_unica.Clear();
            txtBx_multi.Clear();
            if (listBox.SelectedIndex != -1)
            {
                txtBx_unica.Text = listBox.SelectedItem.ToString();
            }
            else if (comboBox.SelectedIndex != -1)
            {
                txtBx_unica.Text = comboBox.SelectedItem.ToString();
            }
            string[] checkedlist = new string[checkedListBox.CheckedItems.Count];
            checkedListBox.CheckedItems.CopyTo(checkedlist, 0);
            txtBx_multi.Lines = checkedlist;
        }

        private void btnn_Añadir_Click(object sender, EventArgs e)
        {
            if (R_ListBx.Checked == true && !txtBx_Elemnto.Text.Equals("") && !txtBx_Elemnto.Text.Equals(" "))
            {
                string x = txtBx_Elemnto.Text;
                if (!listas.Contains(x))
                {
                    listas.Add(x);
                    listBox.Items.Add(x);
                    ContarElementos();
                }
                else
                {
                    MessageBox.Show("Ese elemento ya esta en la lista.", "ELEMENTO EXIXTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (R_ComboBx.Checked == true && !txtBx_Elemnto.Text.Equals("") && !txtBx_Elemnto.Text.Equals(" "))
            {
                string x = txtBx_Elemnto.Text;
                if (!combo.Contains(x))
                {
                    combo.Add(x);
                    comboBox.Items.Add(x);
                    ContarElementos();
                }
                else
                {
                    MessageBox.Show("Ese elemento ya esta en el combo.", "ELEMENTO EXIXTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (R_CheckLBx.Checked == true && !txtBx_Elemnto.Text.Equals("") && !txtBx_Elemnto.Text.Equals(" "))
            {
                string x = txtBx_Elemnto.Text;
                if (!checklist.Contains(x))
                {
                    checklist.Add(x);
                    checkedListBox.Items.Add(x);
                    ContarElementos();
                }
                else
                {
                    MessageBox.Show("Ese elemento ya esta en el CheckedListBox.", "ELEMENTO EXIXTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El campo está vacio o contiene un elemento erroneo, prueba a introducir un elemento.", "ELEMENTO ERRONEO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtBx_Elemnto.Clear();
            txtBx_Elemnto.Focus();
        }

        private void bttn_Eliminar_Click(object sender, EventArgs e)
        {
           if (R_ListBx.Checked == true && !txtBx_Elemnto.Text.Equals("") && !txtBx_Elemnto.Text.Equals(" "))
            {
                string x = txtBx_Elemnto.Text;
                if (listas.Contains(x))
                {
                    listas.Remove(x);
                    listBox.Items.Remove(x);
                    ContarElementos();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar porque no se encuentra en la lista.", "ELEMENTO INEXIXTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (R_ComboBx.Checked == true && !txtBx_Elemnto.Text.Equals("") && !txtBx_Elemnto.Text.Equals(" "))
            {
                string x = txtBx_Elemnto.Text;
                if (combo.Contains(x))
                {
                    combo.Remove(x);
                    comboBox.Items.Remove(x);
                    ContarElementos();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar porque no se encuentra en el combo.", "ELEMENTO INEXIXTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (R_CheckLBx.Checked == true && !txtBx_Elemnto.Text.Equals("") && !txtBx_Elemnto.Text.Equals(" "))
            {
                string x = txtBx_Elemnto.Text;
                if (checklist.Contains(x))
                {
                    checklist.Remove(x);
                    checkedListBox.Items.Remove(x);
                    ContarElementos();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar porque no se encuentra en el CheckedListBox.", "ELEMENTO INEXIXTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("El campo está vacio o contiene un elemento erroneo, prueba a introducir un elemento.", "ELEMENTO ERRONEO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtBx_Elemnto.Clear();
            txtBx_Elemnto.Focus();
        }

        private void bttn_limpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea vaciar el formulario?", "¿ESTÁS SEGUR@?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                txtBx_Elemnto.Clear();
                txtBx_Elemnto.Focus();
                txtBx_unica.Clear();
                txtBx_multi.Clear();
                R_ListBx.Checked = true;

                listas.Clear();
                listBox.Items.Clear();

                combo.Clear();
                comboBox.Items.Clear();
                comboBox.ResetText(); 

                checklist.Clear();
                checkedListBox.Items.Clear();

                ContarElementos();
            }
        }
    }
}
