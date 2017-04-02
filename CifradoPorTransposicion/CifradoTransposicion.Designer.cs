namespace CifradoPorTransposicion
{
    partial class CifradoTransposicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CifradoTransposicion));
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Dimenciones = new System.Windows.Forms.Label();
            this.dgv_Matriz = new System.Windows.Forms.DataGridView();
            this.btn_Cifrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OutPut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(12, 25);
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(518, 51);
            this.txt_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a cifrar";
            // 
            // lbl_Dimenciones
            // 
            this.lbl_Dimenciones.AutoSize = true;
            this.lbl_Dimenciones.Location = new System.Drawing.Point(12, 217);
            this.lbl_Dimenciones.Name = "lbl_Dimenciones";
            this.lbl_Dimenciones.Size = new System.Drawing.Size(82, 13);
            this.lbl_Dimenciones.TabIndex = 2;
            this.lbl_Dimenciones.Text = "Matriz de % X %";
            // 
            // dgv_Matriz
            // 
            this.dgv_Matriz.AllowUserToAddRows = false;
            this.dgv_Matriz.AllowUserToDeleteRows = false;
            this.dgv_Matriz.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Matriz.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Matriz.Location = new System.Drawing.Point(12, 253);
            this.dgv_Matriz.Name = "dgv_Matriz";
            this.dgv_Matriz.ReadOnly = true;
            this.dgv_Matriz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Matriz.Size = new System.Drawing.Size(518, 202);
            this.dgv_Matriz.TabIndex = 3;
            // 
            // btn_Cifrar
            // 
            this.btn_Cifrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cifrar.Location = new System.Drawing.Point(414, 217);
            this.btn_Cifrar.Name = "btn_Cifrar";
            this.btn_Cifrar.Size = new System.Drawing.Size(116, 23);
            this.btn_Cifrar.TabIndex = 4;
            this.btn_Cifrar.Text = "Cifrar";
            this.btn_Cifrar.UseVisualStyleBackColor = false;
            this.btn_Cifrar.Click += new System.EventHandler(this.btn_cifrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Texto cifrado";
            // 
            // txt_OutPut
            // 
            this.txt_OutPut.Location = new System.Drawing.Point(12, 100);
            this.txt_OutPut.Multiline = true;
            this.txt_OutPut.Name = "txt_OutPut";
            this.txt_OutPut.Size = new System.Drawing.Size(518, 51);
            this.txt_OutPut.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave";
            // 
            // txt_key
            // 
            this.txt_key.Enabled = false;
            this.txt_key.Location = new System.Drawing.Point(15, 179);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(515, 20);
            this.txt_key.TabIndex = 8;
            this.txt_key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_key_KeyPress);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_calcular.Location = new System.Drawing.Point(292, 217);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(116, 23);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // CifradoTransposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(542, 467);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_OutPut);
            this.Controls.Add(this.btn_Cifrar);
            this.Controls.Add(this.dgv_Matriz);
            this.Controls.Add(this.lbl_Dimenciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(558, 506);
            this.MinimumSize = new System.Drawing.Size(558, 506);
            this.Name = "CifradoTransposicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CifradoTransposicion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Dimenciones;
        private System.Windows.Forms.DataGridView dgv_Matriz;
        private System.Windows.Forms.Button btn_Cifrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OutPut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_calcular;
    }
}

