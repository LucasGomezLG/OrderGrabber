namespace Order_Graber_Desktop.Forms
{
    partial class Datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(106, 90);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(545, 150);
            this.gridClientes.TabIndex = 1;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Productos";
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(106, 411);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(545, 150);
            this.gridProductos.TabIndex = 5;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 594);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cargar productos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Agregar producto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 150);
            this.ClientSize = new System.Drawing.Size(787, 492);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.label1);
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}