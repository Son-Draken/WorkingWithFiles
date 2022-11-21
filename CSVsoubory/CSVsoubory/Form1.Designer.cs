namespace CSVsoubory
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlacitkoUlozit = new System.Windows.Forms.Button();
            this.listUzivatelu = new System.Windows.Forms.ListBox();
            this.nacistUzivatele = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRegistrace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlacitkoPridat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlacitkoUlozit
            // 
            this.tlacitkoUlozit.Location = new System.Drawing.Point(254, 383);
            this.tlacitkoUlozit.Name = "tlacitkoUlozit";
            this.tlacitkoUlozit.Size = new System.Drawing.Size(86, 37);
            this.tlacitkoUlozit.TabIndex = 0;
            this.tlacitkoUlozit.Text = "Uložit";
            this.tlacitkoUlozit.UseVisualStyleBackColor = true;
            this.tlacitkoUlozit.Click += new System.EventHandler(this.tlacitkoUlozit_Click);
            // 
            // listUzivatelu
            // 
            this.listUzivatelu.FormattingEnabled = true;
            this.listUzivatelu.Location = new System.Drawing.Point(31, 101);
            this.listUzivatelu.Name = "listUzivatelu";
            this.listUzivatelu.Size = new System.Drawing.Size(196, 264);
            this.listUzivatelu.Sorted = true;
            this.listUzivatelu.TabIndex = 1;
            this.listUzivatelu.SelectedIndexChanged += new System.EventHandler(this.listUzivatelu_SelectedIndexChanged);
            // 
            // nacistUzivatele
            // 
            this.nacistUzivatele.Location = new System.Drawing.Point(377, 381);
            this.nacistUzivatele.Name = "nacistUzivatele";
            this.nacistUzivatele.Size = new System.Drawing.Size(79, 38);
            this.nacistUzivatele.TabIndex = 2;
            this.nacistUzivatele.Text = "Načíst";
            this.nacistUzivatele.UseVisualStyleBackColor = true;
            this.nacistUzivatele.Click += new System.EventHandler(this.nacistUzivatele_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 120);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(173, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlacitkoPridat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(497, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Přidat nového uživatele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Celé jméno:";
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(18, 48);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(60, 13);
            this.labelJmeno.TabIndex = 8;
            this.labelJmeno.Text = "labelJmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Věk:";
            // 
            // labelVek
            // 
            this.labelVek.AutoSize = true;
            this.labelVek.Location = new System.Drawing.Point(20, 116);
            this.labelVek.Name = "labelVek";
            this.labelVek.Size = new System.Drawing.Size(48, 13);
            this.labelVek.TabIndex = 10;
            this.labelVek.Text = "labelVek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zaregistrován:";
            // 
            // labelRegistrace
            // 
            this.labelRegistrace.AutoSize = true;
            this.labelRegistrace.Location = new System.Drawing.Point(24, 195);
            this.labelRegistrace.Name = "labelRegistrace";
            this.labelRegistrace.Size = new System.Drawing.Size(80, 13);
            this.labelRegistrace.TabIndex = 12;
            this.labelRegistrace.Text = "labelRegistrace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celé jméno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Věk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Registrován:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRegistrace);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelVek);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelJmeno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(251, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 268);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail uživatele";
            // 
            // tlacitkoPridat
            // 
            this.tlacitkoPridat.Location = new System.Drawing.Point(74, 220);
            this.tlacitkoPridat.Name = "tlacitkoPridat";
            this.tlacitkoPridat.Size = new System.Drawing.Size(118, 29);
            this.tlacitkoPridat.TabIndex = 9;
            this.tlacitkoPridat.Text = "Přidat";
            this.tlacitkoPridat.UseVisualStyleBackColor = true;
            this.tlacitkoPridat.Click += new System.EventHandler(this.tlacitkoPridat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nacistUzivatele);
            this.Controls.Add(this.listUzivatelu);
            this.Controls.Add(this.tlacitkoUlozit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlacitkoUlozit;
        private System.Windows.Forms.ListBox listUzivatelu;
        private System.Windows.Forms.Button nacistUzivatele;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRegistrace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tlacitkoPridat;
    }
}

