namespace xmas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCelkemPolozek = new Label();
            lblCelkemCena = new Label();
            txtNazev = new TextBox();
            txtSeznam = new TextBox();
            numCena = new NumericUpDown();
            numPocet = new NumericUpDown();
            btnPridat = new Button();
            btnShrnuti = new Button();
            btnSmazatVse = new Button();
            ((System.ComponentModel.ISupportInitialize)numCena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPocet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 123);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Název dárku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 175);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 0;
            label2.Text = "Cena za kus (Kč):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 264);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 1;
            label3.Text = "Seznam dárku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 221);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 2;
            label4.Text = "Počet kusů:";
            // 
            // lblCelkemPolozek
            // 
            lblCelkemPolozek.AutoSize = true;
            lblCelkemPolozek.Location = new Point(697, 524);
            lblCelkemPolozek.Margin = new Padding(5, 0, 5, 0);
            lblCelkemPolozek.Name = "lblCelkemPolozek";
            lblCelkemPolozek.Size = new Size(164, 25);
            lblCelkemPolozek.TabIndex = 1;
            lblCelkemPolozek.Text = "Celkem položek: 0";
            // 
            // lblCelkemCena
            // 
            lblCelkemCena.AutoSize = true;
            lblCelkemCena.Location = new Point(409, 524);
            lblCelkemCena.Margin = new Padding(5, 0, 5, 0);
            lblCelkemCena.Name = "lblCelkemCena";
            lblCelkemCena.Size = new Size(167, 25);
            lblCelkemCena.TabIndex = 1;
            lblCelkemCena.Text = "Celková cena: 0 Kč";
            // 
            // txtNazev
            // 
            txtNazev.Location = new Point(607, 123);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(254, 32);
            txtNazev.TabIndex = 3;
            // 
            // txtSeznam
            // 
            txtSeznam.Location = new Point(409, 292);
            txtSeznam.Multiline = true;
            txtSeznam.Name = "txtSeznam";
            txtSeznam.Size = new Size(452, 208);
            txtSeznam.TabIndex = 3;
            // 
            // numCena
            // 
            numCena.Location = new Point(607, 168);
            numCena.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numCena.Name = "numCena";
            numCena.Size = new Size(254, 32);
            numCena.TabIndex = 4;
            // 
            // numPocet
            // 
            numPocet.Location = new Point(607, 214);
            numPocet.Name = "numPocet";
            numPocet.Size = new Size(254, 32);
            numPocet.TabIndex = 4;
            // 
            // btnPridat
            // 
            btnPridat.Location = new Point(409, 569);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(131, 45);
            btnPridat.TabIndex = 5;
            btnPridat.Text = "Přidat dárek";
            btnPridat.UseVisualStyleBackColor = true;
            btnPridat.Click += btnPridat_Click;
            // 
            // btnShrnuti
            // 
            btnShrnuti.Location = new Point(567, 569);
            btnShrnuti.Name = "btnShrnuti";
            btnShrnuti.Size = new Size(173, 45);
            btnShrnuti.TabIndex = 5;
            btnShrnuti.Text = "Odeslat Ježíškovi";
            btnShrnuti.UseVisualStyleBackColor = true;
            btnShrnuti.Click += btnShrnuti_Click;
            // 
            // btnSmazatVse
            // 
            btnSmazatVse.Location = new Point(764, 569);
            btnSmazatVse.Name = "btnSmazatVse";
            btnSmazatVse.Size = new Size(97, 45);
            btnSmazatVse.TabIndex = 5;
            btnSmazatVse.Text = "Smazat";
            btnSmazatVse.UseVisualStyleBackColor = true;
            btnSmazatVse.Click += btnSmazatVse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(btnSmazatVse);
            Controls.Add(btnShrnuti);
            Controls.Add(btnPridat);
            Controls.Add(numPocet);
            Controls.Add(numCena);
            Controls.Add(txtSeznam);
            Controls.Add(txtNazev);
            Controls.Add(lblCelkemCena);
            Controls.Add(lblCelkemPolozek);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numCena).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPocet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCelkemPolozek;
        private Label lblCelkemCena;
        private TextBox txtNazev;
        private TextBox txtSeznam;
        private NumericUpDown numCena;
        private NumericUpDown numPocet;
        private Button btnPridat;
        private Button btnShrnuti;
        private Button btnSmazatVse;
    }
}
