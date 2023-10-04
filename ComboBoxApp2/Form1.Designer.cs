namespace ComboBoxApp2
{
    partial class Form1
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
            this.labelIzaberi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxIzabir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelIzaberi
            // 
            this.labelIzaberi.AutoSize = true;
            this.labelIzaberi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIzaberi.Location = new System.Drawing.Point(33, 31);
            this.labelIzaberi.Name = "labelIzaberi";
            this.labelIzaberi.Size = new System.Drawing.Size(242, 19);
            this.labelIzaberi.TabIndex = 0;
            this.labelIzaberi.Text = "Izaberi jednu od ponuđenih opcija:";
            this.labelIzaberi.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(33, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxIzabir
            // 
            this.comboBoxIzabir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIzabir.FormattingEnabled = true;
            this.comboBoxIzabir.Items.AddRange(new object[] {
            "MiG-29",
            "MiG-31",
            "MiG-35",
            "Su-27",
            "Su-30",
            "Su-33",
            "Su-35",
            "Su-57"});
            this.comboBoxIzabir.Location = new System.Drawing.Point(33, 68);
            this.comboBoxIzabir.Name = "comboBoxIzabir";
            this.comboBoxIzabir.Size = new System.Drawing.Size(242, 24);
            this.comboBoxIzabir.TabIndex = 3;
            this.comboBoxIzabir.Text = "Izaberi neki od ponuđenih odabira";
            this.comboBoxIzabir.SelectedIndexChanged += new System.EventHandler(this.comboBoxIzabir_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 202);
            this.Controls.Add(this.comboBoxIzabir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelIzaberi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIzaberi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxIzabir;
    }
}

