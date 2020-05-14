namespace Ejercicio22
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gbx_Tipo = new System.Windows.Forms.GroupBox();
            this.R_CheckLBx = new System.Windows.Forms.RadioButton();
            this.R_ComboBx = new System.Windows.Forms.RadioButton();
            this.R_ListBx = new System.Windows.Forms.RadioButton();
            this.lbl_elemento = new System.Windows.Forms.Label();
            this.txtBx_Elemnto = new System.Windows.Forms.TextBox();
            this.btnn_Añadir = new System.Windows.Forms.Button();
            this.bttn_Eliminar = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lbl_Elementos = new System.Windows.Forms.Label();
            this.lbl_ListBx = new System.Windows.Forms.Label();
            this.lbl_ComboBx = new System.Windows.Forms.Label();
            this.lbl_CheckListBx = new System.Windows.Forms.Label();
            this.bttn_mostrar = new System.Windows.Forms.Button();
            this.lbl_unica = new System.Windows.Forms.Label();
            this.txtBx_unica = new System.Windows.Forms.TextBox();
            this.lbl_multi = new System.Windows.Forms.Label();
            this.txtBx_multi = new System.Windows.Forms.TextBox();
            this.Panel_ElementoS = new System.Windows.Forms.Panel();
            this.Panel_Elemento = new System.Windows.Forms.Panel();
            this.Panel_ListBxS = new System.Windows.Forms.Panel();
            this.Panel_Mostrar = new System.Windows.Forms.Panel();
            this.bttn_limpiar = new System.Windows.Forms.Button();
            this.Gbx_Tipo.SuspendLayout();
            this.Panel_ElementoS.SuspendLayout();
            this.Panel_Elemento.SuspendLayout();
            this.Panel_ListBxS.SuspendLayout();
            this.Panel_Mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_Tipo
            // 
            this.Gbx_Tipo.Controls.Add(this.R_CheckLBx);
            this.Gbx_Tipo.Controls.Add(this.R_ComboBx);
            this.Gbx_Tipo.Controls.Add(this.R_ListBx);
            this.Gbx_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbx_Tipo.Location = new System.Drawing.Point(12, 12);
            this.Gbx_Tipo.Name = "Gbx_Tipo";
            this.Gbx_Tipo.Size = new System.Drawing.Size(463, 108);
            this.Gbx_Tipo.TabIndex = 0;
            this.Gbx_Tipo.TabStop = false;
            this.Gbx_Tipo.Text = "Tipo de componente";
            // 
            // R_CheckLBx
            // 
            this.R_CheckLBx.AutoSize = true;
            this.R_CheckLBx.Location = new System.Drawing.Point(279, 46);
            this.R_CheckLBx.Name = "R_CheckLBx";
            this.R_CheckLBx.Size = new System.Drawing.Size(152, 24);
            this.R_CheckLBx.TabIndex = 3;
            this.R_CheckLBx.TabStop = true;
            this.R_CheckLBx.Text = "CheckedListBox";
            this.R_CheckLBx.UseVisualStyleBackColor = true;
            this.R_CheckLBx.CheckedChanged += new System.EventHandler(this.R_CheckLBx_CheckedChanged);
            // 
            // R_ComboBx
            // 
            this.R_ComboBx.AutoSize = true;
            this.R_ComboBx.Location = new System.Drawing.Point(135, 46);
            this.R_ComboBx.Name = "R_ComboBx";
            this.R_ComboBx.Size = new System.Drawing.Size(112, 24);
            this.R_ComboBx.TabIndex = 2;
            this.R_ComboBx.TabStop = true;
            this.R_ComboBx.Text = "ComboBox";
            this.R_ComboBx.UseVisualStyleBackColor = true;
            this.R_ComboBx.CheckedChanged += new System.EventHandler(this.R_ComboBx_CheckedChanged);
            // 
            // R_ListBx
            // 
            this.R_ListBx.AutoSize = true;
            this.R_ListBx.Location = new System.Drawing.Point(16, 46);
            this.R_ListBx.Name = "R_ListBx";
            this.R_ListBx.Size = new System.Drawing.Size(87, 24);
            this.R_ListBx.TabIndex = 1;
            this.R_ListBx.TabStop = true;
            this.R_ListBx.Text = "ListBox";
            this.R_ListBx.UseVisualStyleBackColor = true;
            this.R_ListBx.CheckedChanged += new System.EventHandler(this.R_ListBx_CheckedChanged);
            // 
            // lbl_elemento
            // 
            this.lbl_elemento.AutoSize = true;
            this.lbl_elemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elemento.Location = new System.Drawing.Point(16, 17);
            this.lbl_elemento.Name = "lbl_elemento";
            this.lbl_elemento.Size = new System.Drawing.Size(79, 20);
            this.lbl_elemento.TabIndex = 1;
            this.lbl_elemento.Text = "Elemento";
            // 
            // txtBx_Elemnto
            // 
            this.txtBx_Elemnto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_Elemnto.Location = new System.Drawing.Point(127, 14);
            this.txtBx_Elemnto.Name = "txtBx_Elemnto";
            this.txtBx_Elemnto.Size = new System.Drawing.Size(102, 26);
            this.txtBx_Elemnto.TabIndex = 1;
            // 
            // btnn_Añadir
            // 
            this.btnn_Añadir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnn_Añadir.FlatAppearance.BorderSize = 0;
            this.btnn_Añadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnn_Añadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnn_Añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnn_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn_Añadir.Location = new System.Drawing.Point(19, 45);
            this.btnn_Añadir.Name = "btnn_Añadir";
            this.btnn_Añadir.Size = new System.Drawing.Size(102, 42);
            this.btnn_Añadir.TabIndex = 3;
            this.btnn_Añadir.Text = "Añadir";
            this.btnn_Añadir.UseVisualStyleBackColor = false;
            this.btnn_Añadir.Click += new System.EventHandler(this.btnn_Añadir_Click);
            // 
            // bttn_Eliminar
            // 
            this.bttn_Eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bttn_Eliminar.FlatAppearance.BorderSize = 0;
            this.bttn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.bttn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.bttn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Eliminar.Location = new System.Drawing.Point(127, 46);
            this.bttn_Eliminar.Name = "bttn_Eliminar";
            this.bttn_Eliminar.Size = new System.Drawing.Size(102, 42);
            this.bttn_Eliminar.TabIndex = 4;
            this.bttn_Eliminar.Text = "Eliminar";
            this.bttn_Eliminar.UseVisualStyleBackColor = false;
            this.bttn_Eliminar.Click += new System.EventHandler(this.bttn_Eliminar_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(499, 15);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(197, 151);
            this.checkedListBox.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(265, 15);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(197, 28);
            this.comboBox.TabIndex = 6;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(31, 15);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(197, 164);
            this.listBox.TabIndex = 7;
            // 
            // lbl_Elementos
            // 
            this.lbl_Elementos.AutoSize = true;
            this.lbl_Elementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Elementos.Location = new System.Drawing.Point(14, 25);
            this.lbl_Elementos.Name = "lbl_Elementos";
            this.lbl_Elementos.Size = new System.Drawing.Size(88, 20);
            this.lbl_Elementos.TabIndex = 8;
            this.lbl_Elementos.Text = "Elementos";
            // 
            // lbl_ListBx
            // 
            this.lbl_ListBx.AutoSize = true;
            this.lbl_ListBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListBx.Location = new System.Drawing.Point(187, 25);
            this.lbl_ListBx.Name = "lbl_ListBx";
            this.lbl_ListBx.Size = new System.Drawing.Size(18, 20);
            this.lbl_ListBx.TabIndex = 9;
            this.lbl_ListBx.Text = "0";
            // 
            // lbl_ComboBx
            // 
            this.lbl_ComboBx.AutoSize = true;
            this.lbl_ComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComboBx.Location = new System.Drawing.Point(383, 25);
            this.lbl_ComboBx.Name = "lbl_ComboBx";
            this.lbl_ComboBx.Size = new System.Drawing.Size(18, 20);
            this.lbl_ComboBx.TabIndex = 10;
            this.lbl_ComboBx.Text = "0";
            // 
            // lbl_CheckListBx
            // 
            this.lbl_CheckListBx.AutoSize = true;
            this.lbl_CheckListBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckListBx.Location = new System.Drawing.Point(579, 25);
            this.lbl_CheckListBx.Name = "lbl_CheckListBx";
            this.lbl_CheckListBx.Size = new System.Drawing.Size(18, 20);
            this.lbl_CheckListBx.TabIndex = 11;
            this.lbl_CheckListBx.Text = "0";
            // 
            // bttn_mostrar
            // 
            this.bttn_mostrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bttn_mostrar.FlatAppearance.BorderSize = 0;
            this.bttn_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.bttn_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.bttn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_mostrar.Location = new System.Drawing.Point(23, 32);
            this.bttn_mostrar.Name = "bttn_mostrar";
            this.bttn_mostrar.Size = new System.Drawing.Size(224, 44);
            this.bttn_mostrar.TabIndex = 12;
            this.bttn_mostrar.Text = "Mostrar Seleccionado/s";
            this.bttn_mostrar.UseVisualStyleBackColor = false;
            this.bttn_mostrar.Click += new System.EventHandler(this.bttn_mostrar_Click);
            // 
            // lbl_unica
            // 
            this.lbl_unica.AutoSize = true;
            this.lbl_unica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unica.Location = new System.Drawing.Point(325, 9);
            this.lbl_unica.Name = "lbl_unica";
            this.lbl_unica.Size = new System.Drawing.Size(127, 20);
            this.lbl_unica.TabIndex = 13;
            this.lbl_unica.Text = "Selección única";
            // 
            // txtBx_unica
            // 
            this.txtBx_unica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_unica.Location = new System.Drawing.Point(329, 41);
            this.txtBx_unica.Name = "txtBx_unica";
            this.txtBx_unica.Size = new System.Drawing.Size(123, 26);
            this.txtBx_unica.TabIndex = 14;
            // 
            // lbl_multi
            // 
            this.lbl_multi.AutoSize = true;
            this.lbl_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multi.Location = new System.Drawing.Point(541, 9);
            this.lbl_multi.Name = "lbl_multi";
            this.lbl_multi.Size = new System.Drawing.Size(116, 20);
            this.lbl_multi.TabIndex = 15;
            this.lbl_multi.Text = "Multiselección";
            // 
            // txtBx_multi
            // 
            this.txtBx_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_multi.Location = new System.Drawing.Point(534, 41);
            this.txtBx_multi.Multiline = true;
            this.txtBx_multi.Name = "txtBx_multi";
            this.txtBx_multi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_multi.Size = new System.Drawing.Size(123, 92);
            this.txtBx_multi.TabIndex = 16;
            // 
            // Panel_ElementoS
            // 
            this.Panel_ElementoS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel_ElementoS.Controls.Add(this.lbl_CheckListBx);
            this.Panel_ElementoS.Controls.Add(this.lbl_Elementos);
            this.Panel_ElementoS.Controls.Add(this.lbl_ListBx);
            this.Panel_ElementoS.Controls.Add(this.lbl_ComboBx);
            this.Panel_ElementoS.Location = new System.Drawing.Point(13, 338);
            this.Panel_ElementoS.Name = "Panel_ElementoS";
            this.Panel_ElementoS.Size = new System.Drawing.Size(721, 70);
            this.Panel_ElementoS.TabIndex = 17;
            // 
            // Panel_Elemento
            // 
            this.Panel_Elemento.Controls.Add(this.lbl_elemento);
            this.Panel_Elemento.Controls.Add(this.txtBx_Elemnto);
            this.Panel_Elemento.Controls.Add(this.btnn_Añadir);
            this.Panel_Elemento.Controls.Add(this.bttn_Eliminar);
            this.Panel_Elemento.Location = new System.Drawing.Point(481, 12);
            this.Panel_Elemento.Name = "Panel_Elemento";
            this.Panel_Elemento.Size = new System.Drawing.Size(253, 108);
            this.Panel_Elemento.TabIndex = 18;
            // 
            // Panel_ListBxS
            // 
            this.Panel_ListBxS.Controls.Add(this.checkedListBox);
            this.Panel_ListBxS.Controls.Add(this.comboBox);
            this.Panel_ListBxS.Controls.Add(this.listBox);
            this.Panel_ListBxS.Location = new System.Drawing.Point(13, 126);
            this.Panel_ListBxS.Name = "Panel_ListBxS";
            this.Panel_ListBxS.Size = new System.Drawing.Size(721, 206);
            this.Panel_ListBxS.TabIndex = 19;
            // 
            // Panel_Mostrar
            // 
            this.Panel_Mostrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.Panel_Mostrar.Controls.Add(this.bttn_limpiar);
            this.Panel_Mostrar.Controls.Add(this.txtBx_multi);
            this.Panel_Mostrar.Controls.Add(this.bttn_mostrar);
            this.Panel_Mostrar.Controls.Add(this.txtBx_unica);
            this.Panel_Mostrar.Controls.Add(this.lbl_multi);
            this.Panel_Mostrar.Controls.Add(this.lbl_unica);
            this.Panel_Mostrar.Location = new System.Drawing.Point(12, 414);
            this.Panel_Mostrar.Name = "Panel_Mostrar";
            this.Panel_Mostrar.Size = new System.Drawing.Size(722, 159);
            this.Panel_Mostrar.TabIndex = 20;
            // 
            // bttn_limpiar
            // 
            this.bttn_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bttn_limpiar.FlatAppearance.BorderSize = 0;
            this.bttn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.bttn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.bttn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_limpiar.Location = new System.Drawing.Point(84, 91);
            this.bttn_limpiar.Name = "bttn_limpiar";
            this.bttn_limpiar.Size = new System.Drawing.Size(102, 42);
            this.bttn_limpiar.TabIndex = 21;
            this.bttn_limpiar.Text = "Limpiar";
            this.bttn_limpiar.UseVisualStyleBackColor = false;
            this.bttn_limpiar.Click += new System.EventHandler(this.bttn_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(751, 586);
            this.Controls.Add(this.Panel_Mostrar);
            this.Controls.Add(this.Panel_ListBxS);
            this.Controls.Add(this.Panel_Elemento);
            this.Controls.Add(this.Panel_ElementoS);
            this.Controls.Add(this.Gbx_Tipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajando con Listas";
            this.Gbx_Tipo.ResumeLayout(false);
            this.Gbx_Tipo.PerformLayout();
            this.Panel_ElementoS.ResumeLayout(false);
            this.Panel_ElementoS.PerformLayout();
            this.Panel_Elemento.ResumeLayout(false);
            this.Panel_Elemento.PerformLayout();
            this.Panel_ListBxS.ResumeLayout(false);
            this.Panel_Mostrar.ResumeLayout(false);
            this.Panel_Mostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_Tipo;
        private System.Windows.Forms.RadioButton R_CheckLBx;
        private System.Windows.Forms.RadioButton R_ComboBx;
        private System.Windows.Forms.RadioButton R_ListBx;
        private System.Windows.Forms.Label lbl_elemento;
        private System.Windows.Forms.TextBox txtBx_Elemnto;
        private System.Windows.Forms.Button btnn_Añadir;
        private System.Windows.Forms.Button bttn_Eliminar;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lbl_Elementos;
        private System.Windows.Forms.Label lbl_ListBx;
        private System.Windows.Forms.Label lbl_ComboBx;
        private System.Windows.Forms.Label lbl_CheckListBx;
        private System.Windows.Forms.Button bttn_mostrar;
        private System.Windows.Forms.Label lbl_unica;
        private System.Windows.Forms.TextBox txtBx_unica;
        private System.Windows.Forms.Label lbl_multi;
        private System.Windows.Forms.TextBox txtBx_multi;
        private System.Windows.Forms.Panel Panel_Elemento;
        private System.Windows.Forms.Panel Panel_ListBxS;
        private System.Windows.Forms.Panel Panel_Mostrar;
        private System.Windows.Forms.Button bttn_limpiar;
        public System.Windows.Forms.Panel Panel_ElementoS;
    }
}

