namespace Hamming
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
            this.input_data = new System.Windows.Forms.TextBox();
            this.Input_error = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kod_nadmiarowy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bit_zmieniony = new System.Windows.Forms.Label();
            this.oblicz = new System.Windows.Forms.Button();
            this.jeden_blad = new System.Windows.Forms.Button();
            this.dwa_bledy = new System.Windows.Forms.Button();
            this.Wykryj_bledy = new System.Windows.Forms.Button();
            this.Komunikat = new System.Windows.Forms.Label();
            this.Macierz_pokaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_data
            // 
            this.input_data.Location = new System.Drawing.Point(65, 69);
            this.input_data.Name = "input_data";
            this.input_data.Size = new System.Drawing.Size(107, 20);
            this.input_data.TabIndex = 0;
            // 
            // Input_error
            // 
            this.Input_error.Location = new System.Drawing.Point(302, 69);
            this.Input_error.Name = "Input_error";
            this.Input_error.Size = new System.Drawing.Size(107, 20);
            this.Input_error.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wprowadz wiadomość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Obliczony kod nadmiarowy";
            // 
            // Kod_nadmiarowy
            // 
            this.Kod_nadmiarowy.AutoSize = true;
            this.Kod_nadmiarowy.Location = new System.Drawing.Point(90, 136);
            this.Kod_nadmiarowy.Name = "Kod_nadmiarowy";
            this.Kod_nadmiarowy.Size = new System.Drawing.Size(0, 13);
            this.Kod_nadmiarowy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wprowadź błąd reczenie lub wygeneruj";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "d=3",
            "d=4"});
            this.comboBox1.Location = new System.Drawing.Point(65, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wybierz metode obliczania błędu";
            // 
            // bit_zmieniony
            // 
            this.bit_zmieniony.AutoSize = true;
            this.bit_zmieniony.Location = new System.Drawing.Point(302, 135);
            this.bit_zmieniony.Name = "bit_zmieniony";
            this.bit_zmieniony.Size = new System.Drawing.Size(108, 13);
            this.bit_zmieniony.TabIndex = 8;
            this.bit_zmieniony.Text = "wykonaj sprawdzanie";
            // 
            // oblicz
            // 
            this.oblicz.Location = new System.Drawing.Point(68, 257);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(180, 23);
            this.oblicz.TabIndex = 9;
            this.oblicz.Text = "oblicz kod nadmiarowy";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // jeden_blad
            // 
            this.jeden_blad.Location = new System.Drawing.Point(302, 177);
            this.jeden_blad.Name = "jeden_blad";
            this.jeden_blad.Size = new System.Drawing.Size(131, 23);
            this.jeden_blad.TabIndex = 10;
            this.jeden_blad.Text = "Generuj 1 błąd";
            this.jeden_blad.UseVisualStyleBackColor = true;
            this.jeden_blad.Click += new System.EventHandler(this.jeden_blad_Click);
            // 
            // dwa_bledy
            // 
            this.dwa_bledy.Location = new System.Drawing.Point(302, 210);
            this.dwa_bledy.Name = "dwa_bledy";
            this.dwa_bledy.Size = new System.Drawing.Size(131, 23);
            this.dwa_bledy.TabIndex = 11;
            this.dwa_bledy.Text = "Generuj 2 bledy";
            this.dwa_bledy.UseVisualStyleBackColor = true;
            this.dwa_bledy.Click += new System.EventHandler(this.dwa_bledy_Click);
            // 
            // Wykryj_bledy
            // 
            this.Wykryj_bledy.Location = new System.Drawing.Point(305, 257);
            this.Wykryj_bledy.Name = "Wykryj_bledy";
            this.Wykryj_bledy.Size = new System.Drawing.Size(75, 23);
            this.Wykryj_bledy.TabIndex = 12;
            this.Wykryj_bledy.Text = "Wykryj błąd";
            this.Wykryj_bledy.UseVisualStyleBackColor = true;
            this.Wykryj_bledy.Click += new System.EventHandler(this.Wykryj_bledy_Click);
            // 
            // Komunikat
            // 
            this.Komunikat.AutoSize = true;
            this.Komunikat.Location = new System.Drawing.Point(305, 304);
            this.Komunikat.Name = "Komunikat";
            this.Komunikat.Size = new System.Drawing.Size(0, 13);
            this.Komunikat.TabIndex = 13;
            // 
            // Macierz_pokaz
            // 
            this.Macierz_pokaz.AutoSize = true;
            this.Macierz_pokaz.Location = new System.Drawing.Point(65, 303);
            this.Macierz_pokaz.Name = "Macierz_pokaz";
            this.Macierz_pokaz.Size = new System.Drawing.Size(44, 13);
            this.Macierz_pokaz.TabIndex = 14;
            this.Macierz_pokaz.Text = "Macierz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 486);
            this.Controls.Add(this.Macierz_pokaz);
            this.Controls.Add(this.Komunikat);
            this.Controls.Add(this.Wykryj_bledy);
            this.Controls.Add(this.dwa_bledy);
            this.Controls.Add(this.jeden_blad);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.bit_zmieniony);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kod_nadmiarowy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_error);
            this.Controls.Add(this.input_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_data;
        private System.Windows.Forms.TextBox Input_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kod_nadmiarowy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bit_zmieniony;
        private System.Windows.Forms.Button oblicz;
        private System.Windows.Forms.Button jeden_blad;
        private System.Windows.Forms.Button dwa_bledy;
        private System.Windows.Forms.Button Wykryj_bledy;
        private System.Windows.Forms.Label Komunikat;
        private System.Windows.Forms.Label Macierz_pokaz;
    }
}

