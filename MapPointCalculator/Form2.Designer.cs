namespace MapPointCalculator {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnAmerica = new System.Windows.Forms.Button();
            this.btnEurope = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmerica
            // 
            this.btnAmerica.Location = new System.Drawing.Point(46, 49);
            this.btnAmerica.Name = "btnAmerica";
            this.btnAmerica.Size = new System.Drawing.Size(75, 23);
            this.btnAmerica.TabIndex = 0;
            this.btnAmerica.Text = "America";
            this.btnAmerica.UseVisualStyleBackColor = true;
            this.btnAmerica.Click += new System.EventHandler(this.btnAmerica_Click);
            // 
            // btnEurope
            // 
            this.btnEurope.Location = new System.Drawing.Point(127, 49);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(75, 23);
            this.btnEurope.TabIndex = 1;
            this.btnEurope.Text = "Europe";
            this.btnEurope.UseVisualStyleBackColor = true;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 115);
            this.Controls.Add(this.btnEurope);
            this.Controls.Add(this.btnAmerica);
            this.Name = "Form2";
            this.Text = "Choose Continent";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAmerica;
        private Button btnEurope;
    }
}