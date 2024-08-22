namespace TP1_Grupo9
{
    partial class FormEjercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbLista1 = new System.Windows.Forms.ListBox();
            this.lbLista2 = new System.Windows.Forms.ListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnMoverTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(68, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(363, 60);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbLista1
            // 
            this.lbLista1.FormattingEnabled = true;
            this.lbLista1.Location = new System.Drawing.Point(71, 151);
            this.lbLista1.Name = "lbLista1";
            this.lbLista1.Size = new System.Drawing.Size(156, 186);
            this.lbLista1.TabIndex = 3;
            // 
            // lbLista2
            // 
            this.lbLista2.FormattingEnabled = true;
            this.lbLista2.Location = new System.Drawing.Point(431, 151);
            this.lbLista2.Name = "lbLista2";
            this.lbLista2.Size = new System.Drawing.Size(156, 186);
            this.lbLista2.TabIndex = 4;
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(293, 187);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = ">";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnMoverTodo
            // 
            this.btnMoverTodo.Location = new System.Drawing.Point(293, 237);
            this.btnMoverTodo.Name = "btnMoverTodo";
            this.btnMoverTodo.Size = new System.Drawing.Size(75, 23);
            this.btnMoverTodo.TabIndex = 6;
            this.btnMoverTodo.Text = ">>";
            this.btnMoverTodo.UseVisualStyleBackColor = true;
            this.btnMoverTodo.Click += new System.EventHandler(this.btnMoverTodo_Click);
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverTodo);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lbLista2);
            this.Controls.Add(this.lbLista1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormEjercicio1";
            this.Text = "Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lbLista1;
        private System.Windows.Forms.ListBox lbLista2;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnMoverTodo;
    }
}