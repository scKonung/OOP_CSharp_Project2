
namespace Projekt2_Chalyi_59022
{
    partial class PrzezentacjaLososwaZeSlajderem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzezentacjaLososwaZeSlajderem));
            this.lblN = new System.Windows.Forms.Label();
            this.bttnStart = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.chlbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.bttnPrzesun = new System.Windows.Forms.Button();
            this.bttnWylosuj = new System.Windows.Forms.Button();
            this.gpWyborPokazu = new System.Windows.Forms.GroupBox();
            this.radioButtonManualny = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomatyczny = new System.Windows.Forms.RadioButton();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.lblNF = new System.Windows.Forms.Label();
            this.bttn_Next = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnWlacz = new System.Windows.Forms.Button();
            this.bttnWylacz = new System.Windows.Forms.Button();
            this.bttnPowrot = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bttnResetuj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msPlik = new System.Windows.Forms.ToolStripMenuItem();
            this.rysownicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msZapisz = new System.Windows.Forms.ToolStripMenuItem();
            this.msOdczytaj = new System.Windows.Forms.ToolStripMenuItem();
            this.msZmienic = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gpWyborPokazu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblN.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblN.Location = new System.Drawing.Point(7, 45);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(299, 26);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Podaj liczbe figur geometrycznych";
            // 
            // bttnStart
            // 
            this.bttnStart.Enabled = false;
            this.bttnStart.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnStart.Location = new System.Drawing.Point(12, 170);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(198, 47);
            this.bttnStart.TabIndex = 1;
            this.bttnStart.Text = "START";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtN.Location = new System.Drawing.Point(40, 83);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 29);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // chlbFiguryGeometryczne
            // 
            this.chlbFiguryGeometryczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chlbFiguryGeometryczne.FormattingEnabled = true;
            this.chlbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Prostokąt",
            "Kwadrat",
            "Kolo",
            "Wielokąt",
            "FillElipse"});
            this.chlbFiguryGeometryczne.Location = new System.Drawing.Point(1155, 103);
            this.chlbFiguryGeometryczne.Name = "chlbFiguryGeometryczne";
            this.chlbFiguryGeometryczne.Size = new System.Drawing.Size(161, 319);
            this.chlbFiguryGeometryczne.TabIndex = 3;
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.Color.White;
            this.pbRysownica.Location = new System.Drawing.Point(254, 74);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(892, 552);
            this.pbRysownica.TabIndex = 4;
            this.pbRysownica.TabStop = false;
            // 
            // bttnPrzesun
            // 
            this.bttnPrzesun.Enabled = false;
            this.bttnPrzesun.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnPrzesun.Location = new System.Drawing.Point(12, 237);
            this.bttnPrzesun.Name = "bttnPrzesun";
            this.bttnPrzesun.Size = new System.Drawing.Size(221, 66);
            this.bttnPrzesun.TabIndex = 5;
            this.bttnPrzesun.Text = "Przesunięcie do nowego mejsca";
            this.bttnPrzesun.UseVisualStyleBackColor = true;
            this.bttnPrzesun.Click += new System.EventHandler(this.bttnPrzesun_Click);
            // 
            // bttnWylosuj
            // 
            this.bttnWylosuj.Enabled = false;
            this.bttnWylosuj.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnWylosuj.Location = new System.Drawing.Point(12, 309);
            this.bttnWylosuj.Name = "bttnWylosuj";
            this.bttnWylosuj.Size = new System.Drawing.Size(221, 89);
            this.bttnWylosuj.TabIndex = 6;
            this.bttnWylosuj.Text = "Wyłosuj nowe położenie oraz atrybuty graficzne figur geometrycznych";
            this.bttnWylosuj.UseVisualStyleBackColor = true;
            this.bttnWylosuj.Click += new System.EventHandler(this.bttnWylosuj_Click);
            // 
            // gpWyborPokazu
            // 
            this.gpWyborPokazu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gpWyborPokazu.Controls.Add(this.radioButtonManualny);
            this.gpWyborPokazu.Controls.Add(this.radioButtonAutomatyczny);
            this.gpWyborPokazu.Enabled = false;
            this.gpWyborPokazu.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpWyborPokazu.Location = new System.Drawing.Point(278, 705);
            this.gpWyborPokazu.Name = "gpWyborPokazu";
            this.gpWyborPokazu.Size = new System.Drawing.Size(408, 76);
            this.gpWyborPokazu.TabIndex = 7;
            this.gpWyborPokazu.TabStop = false;
            this.gpWyborPokazu.Text = "Pokaz figur";
            // 
            // radioButtonManualny
            // 
            this.radioButtonManualny.AutoSize = true;
            this.radioButtonManualny.Location = new System.Drawing.Point(248, 32);
            this.radioButtonManualny.Name = "radioButtonManualny";
            this.radioButtonManualny.Size = new System.Drawing.Size(115, 30);
            this.radioButtonManualny.TabIndex = 1;
            this.radioButtonManualny.Text = "Manualny";
            this.radioButtonManualny.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutomatyczny
            // 
            this.radioButtonAutomatyczny.AutoSize = true;
            this.radioButtonAutomatyczny.Checked = true;
            this.radioButtonAutomatyczny.Location = new System.Drawing.Point(40, 32);
            this.radioButtonAutomatyczny.Name = "radioButtonAutomatyczny";
            this.radioButtonAutomatyczny.Size = new System.Drawing.Size(154, 30);
            this.radioButtonAutomatyczny.TabIndex = 0;
            this.radioButtonAutomatyczny.TabStop = true;
            this.radioButtonAutomatyczny.Text = "Automatyczny";
            this.radioButtonAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Enabled = false;
            this.txtNumerFigury.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerFigury.Location = new System.Drawing.Point(978, 669);
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(100, 29);
            this.txtNumerFigury.TabIndex = 9;
            // 
            // lblNF
            // 
            this.lblNF.AutoSize = true;
            this.lblNF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNF.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNF.Location = new System.Drawing.Point(863, 673);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(109, 22);
            this.lblNF.TabIndex = 8;
            this.lblNF.Text = "Numer figury:";
            // 
            // bttn_Next
            // 
            this.bttn_Next.Enabled = false;
            this.bttn_Next.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_Next.Location = new System.Drawing.Point(715, 669);
            this.bttn_Next.Name = "bttn_Next";
            this.bttn_Next.Size = new System.Drawing.Size(126, 35);
            this.bttn_Next.TabIndex = 10;
            this.bttn_Next.Text = "Następny";
            this.bttn_Next.UseVisualStyleBackColor = true;
            this.bttn_Next.Click += new System.EventHandler(this.bttn_Next_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Enabled = false;
            this.bttnBack.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnBack.Location = new System.Drawing.Point(715, 710);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(126, 35);
            this.bttnBack.TabIndex = 11;
            this.bttnBack.Text = "Poprzedni";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnWlacz
            // 
            this.bttnWlacz.Enabled = false;
            this.bttnWlacz.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnWlacz.Location = new System.Drawing.Point(12, 633);
            this.bttnWlacz.Name = "bttnWlacz";
            this.bttnWlacz.Size = new System.Drawing.Size(221, 71);
            this.bttnWlacz.TabIndex = 12;
            this.bttnWlacz.Text = "Włączenie slajdera figur geometrycznych";
            this.bttnWlacz.UseVisualStyleBackColor = true;
            this.bttnWlacz.Click += new System.EventHandler(this.bttnWlacz_Click);
            // 
            // bttnWylacz
            // 
            this.bttnWylacz.Enabled = false;
            this.bttnWylacz.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnWylacz.Location = new System.Drawing.Point(12, 710);
            this.bttnWylacz.Name = "bttnWylacz";
            this.bttnWylacz.Size = new System.Drawing.Size(221, 71);
            this.bttnWylacz.TabIndex = 13;
            this.bttnWylacz.Text = "Wyłącz pokaz figur geometrycznych";
            this.bttnWylacz.UseVisualStyleBackColor = true;
            this.bttnWylacz.Click += new System.EventHandler(this.bttnWylacz_Click);
            // 
            // bttnPowrot
            // 
            this.bttnPowrot.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnPowrot.Location = new System.Drawing.Point(1155, 45);
            this.bttnPowrot.Name = "bttnPowrot";
            this.bttnPowrot.Size = new System.Drawing.Size(142, 47);
            this.bttnPowrot.TabIndex = 14;
            this.bttnPowrot.Text = "Powrót";
            this.bttnPowrot.UseVisualStyleBackColor = true;
            this.bttnPowrot.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttnResetuj
            // 
            this.bttnResetuj.Enabled = false;
            this.bttnResetuj.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnResetuj.Location = new System.Drawing.Point(1155, 428);
            this.bttnResetuj.Name = "bttnResetuj";
            this.bttnResetuj.Size = new System.Drawing.Size(161, 35);
            this.bttnResetuj.TabIndex = 15;
            this.bttnResetuj.Text = "RESETUJ";
            this.bttnResetuj.UseVisualStyleBackColor = true;
            this.bttnResetuj.Click += new System.EventHandler(this.bttnResetuj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlik,
            this.rysownicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msPlik
            // 
            this.msPlik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msZapisz,
            this.msOdczytaj});
            this.msPlik.Enabled = false;
            this.msPlik.Name = "msPlik";
            this.msPlik.Size = new System.Drawing.Size(38, 20);
            this.msPlik.Text = "&Plik";
            // 
            // rysownicaToolStripMenuItem
            // 
            this.rysownicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msZmienic});
            this.rysownicaToolStripMenuItem.Name = "rysownicaToolStripMenuItem";
            this.rysownicaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.rysownicaToolStripMenuItem.Text = "&Rysownica";
            // 
            // msZapisz
            // 
            this.msZapisz.Name = "msZapisz";
            this.msZapisz.Size = new System.Drawing.Size(195, 22);
            this.msZapisz.Text = "&Zapisz bitmape w pliku";
            this.msZapisz.Click += new System.EventHandler(this.zapiszBitmapeWPlikuToolStripMenuItem_Click);
            // 
            // msOdczytaj
            // 
            this.msOdczytaj.Name = "msOdczytaj";
            this.msOdczytaj.Size = new System.Drawing.Size(195, 22);
            this.msOdczytaj.Text = "&Odczytaj bitmape";
            this.msOdczytaj.Click += new System.EventHandler(this.msOdczytaj_Click);
            // 
            // msZmienic
            // 
            this.msZmienic.Name = "msZmienic";
            this.msZmienic.Size = new System.Drawing.Size(180, 22);
            this.msZmienic.Text = "Zmienić KolorTla";
            this.msZmienic.Click += new System.EventHandler(this.msZmienic_Click);
            // 
            // PrzezentacjaLososwaZeSlajderem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1328, 795);
            this.Controls.Add(this.bttnResetuj);
            this.Controls.Add(this.bttnPowrot);
            this.Controls.Add(this.bttnWylacz);
            this.Controls.Add(this.bttnWlacz);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttn_Next);
            this.Controls.Add(this.txtNumerFigury);
            this.Controls.Add(this.lblNF);
            this.Controls.Add(this.gpWyborPokazu);
            this.Controls.Add(this.bttnWylosuj);
            this.Controls.Add(this.bttnPrzesun);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.chlbFiguryGeometryczne);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrzezentacjaLososwaZeSlajderem";
            this.Text = "PrzezentacjaLososwaZeSlajderem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzezentacjaLososwaZeSlajderem_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gpWyborPokazu.ResumeLayout(false);
            this.gpWyborPokazu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.CheckedListBox chlbFiguryGeometryczne;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button bttnPrzesun;
        private System.Windows.Forms.Button bttnWylosuj;
        private System.Windows.Forms.GroupBox gpWyborPokazu;
        private System.Windows.Forms.RadioButton radioButtonManualny;
        private System.Windows.Forms.RadioButton radioButtonAutomatyczny;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Label lblNF;
        private System.Windows.Forms.Button bttn_Next;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnWlacz;
        private System.Windows.Forms.Button bttnWylacz;
        private System.Windows.Forms.Button bttnPowrot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnResetuj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msPlik;
        private System.Windows.Forms.ToolStripMenuItem rysownicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msZapisz;
        private System.Windows.Forms.ToolStripMenuItem msOdczytaj;
        private System.Windows.Forms.ToolStripMenuItem msZmienic;
    }
}