namespace SYSTEM_SHUT_DOWN
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonWYJSCIE = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.minimalize_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(153, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(153, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Autor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonWYJSCIE
            // 
            this.buttonWYJSCIE.BackColor = System.Drawing.Color.Transparent;
            this.buttonWYJSCIE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonWYJSCIE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonWYJSCIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWYJSCIE.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWYJSCIE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonWYJSCIE.Location = new System.Drawing.Point(153, 250);
            this.buttonWYJSCIE.Name = "buttonWYJSCIE";
            this.buttonWYJSCIE.Size = new System.Drawing.Size(150, 42);
            this.buttonWYJSCIE.TabIndex = 2;
            this.buttonWYJSCIE.Text = "Wyjście";
            this.buttonWYJSCIE.UseVisualStyleBackColor = false;
            this.buttonWYJSCIE.Click += new System.EventHandler(this.buttonWYJSCIE_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(423, 1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(30, 24);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "x";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // minimalize_button
            // 
            this.minimalize_button.BackColor = System.Drawing.Color.Transparent;
            this.minimalize_button.FlatAppearance.BorderSize = 0;
            this.minimalize_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.minimalize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimalize_button.ForeColor = System.Drawing.Color.White;
            this.minimalize_button.Location = new System.Drawing.Point(388, 1);
            this.minimalize_button.Name = "minimalize_button";
            this.minimalize_button.Size = new System.Drawing.Size(42, 24);
            this.minimalize_button.TabIndex = 4;
            this.minimalize_button.Text = "-";
            this.minimalize_button.UseVisualStyleBackColor = false;
            this.minimalize_button.Click += new System.EventHandler(this.minimalize_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(130, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "System Shut Down ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimalize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.buttonWYJSCIE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "SYSTEM SHUT DOWN ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonWYJSCIE;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button minimalize_button;
        private System.Windows.Forms.Label label1;
    }
}

