
namespace Projekt2_Chalyi_59022
{
    partial class KreślenieFigur_Linii_59022
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreślenieFigur_Linii_59022));
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.bttnPowrot = new System.Windows.Forms.Button();
            this.gbWybierz = new System.Windows.Forms.GroupBox();
            this.bttnZakoncz = new System.Windows.Forms.Button();
            this.rbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.bttnCofnij = new System.Windows.Forms.Button();
            this.rbFillElipse = new System.Windows.Forms.RadioButton();
            this.rbKzywa_Beziera = new System.Windows.Forms.RadioButton();
            this.rbLinia_ciągla = new System.Windows.Forms.RadioButton();
            this.rbWielokąt_wypelniony = new System.Windows.Forms.RadioButton();
            this.rbWielokąt_foremny = new System.Windows.Forms.RadioButton();
            this.rbKwadrat = new System.Windows.Forms.RadioButton();
            this.rbProstokąt = new System.Windows.Forms.RadioButton();
            this.rbKolo = new System.Windows.Forms.RadioButton();
            this.rbOkrąg = new System.Windows.Forms.RadioButton();
            this.rbElipsa = new System.Windows.Forms.RadioButton();
            this.rbLiniaProsta = new System.Windows.Forms.RadioButton();
            this.rbPunkt = new System.Windows.Forms.RadioButton();
            this.gbAtrybutyGraficzne = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSylLinii = new System.Windows.Forms.ComboBox();
            this.txtkolorWypelnenia = new System.Windows.Forms.TextBox();
            this.bttnKolorWypelnenia = new System.Windows.Forms.Button();
            this.txtKolorLinii = new System.Windows.Forms.TextBox();
            this.bttnKolorLinii = new System.Windows.Forms.Button();
            this.bttnWylacz = new System.Windows.Forms.Button();
            this.bttnWlacz = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttn_Next = new System.Windows.Forms.Button();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.lblNF = new System.Windows.Forms.Label();
            this.gpWyborPokazu = new System.Windows.Forms.GroupBox();
            this.radioButtonManualny = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomatyczny = new System.Windows.Forms.RadioButton();
            this.gbSlajder = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bttnPrzesun = new System.Windows.Forms.Button();
            this.bttnZapisz = new System.Windows.Forms.Button();
            this.bttnOdczytaj = new System.Windows.Forms.Button();
            this.gbplik = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gbWybierz.SuspendLayout();
            this.gbAtrybutyGraficzne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGruboscLinii)).BeginInit();
            this.gpWyborPokazu.SuspendLayout();
            this.gbSlajder.SuspendLayout();
            this.gbplik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.Color.White;
            this.pbRysownica.Location = new System.Drawing.Point(12, 74);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(847, 503);
            this.pbRysownica.TabIndex = 5;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(102, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Współrzędne poożenia myszy:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblX.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(342, 37);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 22);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblY.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(404, 37);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 22);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y";
            // 
            // bttnPowrot
            // 
            this.bttnPowrot.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnPowrot.Location = new System.Drawing.Point(897, 21);
            this.bttnPowrot.Name = "bttnPowrot";
            this.bttnPowrot.Size = new System.Drawing.Size(142, 47);
            this.bttnPowrot.TabIndex = 15;
            this.bttnPowrot.Text = "Powrót";
            this.bttnPowrot.UseVisualStyleBackColor = true;
            this.bttnPowrot.Click += new System.EventHandler(this.bttnPowrot_Click);
            // 
            // gbWybierz
            // 
            this.gbWybierz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbWybierz.Controls.Add(this.bttnZakoncz);
            this.gbWybierz.Controls.Add(this.rbKrzywaKardynalna);
            this.gbWybierz.Controls.Add(this.bttnCofnij);
            this.gbWybierz.Controls.Add(this.rbFillElipse);
            this.gbWybierz.Controls.Add(this.rbKzywa_Beziera);
            this.gbWybierz.Controls.Add(this.rbLinia_ciągla);
            this.gbWybierz.Controls.Add(this.rbWielokąt_wypelniony);
            this.gbWybierz.Controls.Add(this.rbWielokąt_foremny);
            this.gbWybierz.Controls.Add(this.rbKwadrat);
            this.gbWybierz.Controls.Add(this.rbProstokąt);
            this.gbWybierz.Controls.Add(this.rbKolo);
            this.gbWybierz.Controls.Add(this.rbOkrąg);
            this.gbWybierz.Controls.Add(this.rbElipsa);
            this.gbWybierz.Controls.Add(this.rbLiniaProsta);
            this.gbWybierz.Controls.Add(this.rbPunkt);
            this.gbWybierz.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbWybierz.Location = new System.Drawing.Point(877, 93);
            this.gbWybierz.Name = "gbWybierz";
            this.gbWybierz.Size = new System.Drawing.Size(313, 254);
            this.gbWybierz.TabIndex = 16;
            this.gbWybierz.TabStop = false;
            this.gbWybierz.Text = "wybierz figure lub linię";
            // 
            // bttnZakoncz
            // 
            this.bttnZakoncz.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZakoncz.Location = new System.Drawing.Point(168, 213);
            this.bttnZakoncz.Name = "bttnZakoncz";
            this.bttnZakoncz.Size = new System.Drawing.Size(126, 35);
            this.bttnZakoncz.TabIndex = 28;
            this.bttnZakoncz.Text = "ZAKONCZ!";
            this.bttnZakoncz.UseVisualStyleBackColor = true;
            this.bttnZakoncz.Visible = false;
            this.bttnZakoncz.Click += new System.EventHandler(this.bttnZakoncz_Click);
            // 
            // rbKrzywaKardynalna
            // 
            this.rbKrzywaKardynalna.AutoSize = true;
            this.rbKrzywaKardynalna.Location = new System.Drawing.Point(6, 191);
            this.rbKrzywaKardynalna.Name = "rbKrzywaKardynalna";
            this.rbKrzywaKardynalna.Size = new System.Drawing.Size(150, 22);
            this.rbKrzywaKardynalna.TabIndex = 26;
            this.rbKrzywaKardynalna.Text = "Krzywa Kardnylana";
            this.rbKrzywaKardynalna.UseVisualStyleBackColor = true;
            this.rbKrzywaKardynalna.CheckedChanged += new System.EventHandler(this.rbKrzywaKardynalna_CheckedChanged);
            // 
            // bttnCofnij
            // 
            this.bttnCofnij.Enabled = false;
            this.bttnCofnij.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnCofnij.Location = new System.Drawing.Point(168, 213);
            this.bttnCofnij.Name = "bttnCofnij";
            this.bttnCofnij.Size = new System.Drawing.Size(126, 35);
            this.bttnCofnij.TabIndex = 25;
            this.bttnCofnij.Text = "Cofnij";
            this.bttnCofnij.UseVisualStyleBackColor = true;
            this.bttnCofnij.Click += new System.EventHandler(this.bttnCofnij_Click);
            // 
            // rbFillElipse
            // 
            this.rbFillElipse.AutoSize = true;
            this.rbFillElipse.Location = new System.Drawing.Point(168, 164);
            this.rbFillElipse.Name = "rbFillElipse";
            this.rbFillElipse.Size = new System.Drawing.Size(80, 22);
            this.rbFillElipse.TabIndex = 11;
            this.rbFillElipse.Text = "FillElipse";
            this.rbFillElipse.UseVisualStyleBackColor = true;
            // 
            // rbKzywa_Beziera
            // 
            this.rbKzywa_Beziera.AutoSize = true;
            this.rbKzywa_Beziera.Location = new System.Drawing.Point(6, 164);
            this.rbKzywa_Beziera.Name = "rbKzywa_Beziera";
            this.rbKzywa_Beziera.Size = new System.Drawing.Size(122, 22);
            this.rbKzywa_Beziera.TabIndex = 10;
            this.rbKzywa_Beziera.Text = "Krzywa Beziera";
            this.rbKzywa_Beziera.UseVisualStyleBackColor = true;
            // 
            // rbLinia_ciągla
            // 
            this.rbLinia_ciągla.AutoSize = true;
            this.rbLinia_ciągla.Location = new System.Drawing.Point(168, 136);
            this.rbLinia_ciągla.Name = "rbLinia_ciągla";
            this.rbLinia_ciągla.Size = new System.Drawing.Size(95, 22);
            this.rbLinia_ciągla.TabIndex = 9;
            this.rbLinia_ciągla.Text = "Linia ciągla";
            this.rbLinia_ciągla.UseVisualStyleBackColor = true;
            // 
            // rbWielokąt_wypelniony
            // 
            this.rbWielokąt_wypelniony.AutoSize = true;
            this.rbWielokąt_wypelniony.Location = new System.Drawing.Point(6, 136);
            this.rbWielokąt_wypelniony.Name = "rbWielokąt_wypelniony";
            this.rbWielokąt_wypelniony.Size = new System.Drawing.Size(156, 22);
            this.rbWielokąt_wypelniony.TabIndex = 8;
            this.rbWielokąt_wypelniony.Text = "Wielokąt wypelniony";
            this.rbWielokąt_wypelniony.UseVisualStyleBackColor = true;
            // 
            // rbWielokąt_foremny
            // 
            this.rbWielokąt_foremny.AutoSize = true;
            this.rbWielokąt_foremny.Location = new System.Drawing.Point(168, 108);
            this.rbWielokąt_foremny.Name = "rbWielokąt_foremny";
            this.rbWielokąt_foremny.Size = new System.Drawing.Size(134, 22);
            this.rbWielokąt_foremny.TabIndex = 7;
            this.rbWielokąt_foremny.Text = "Wielokąt foremny";
            this.rbWielokąt_foremny.UseVisualStyleBackColor = true;
            // 
            // rbKwadrat
            // 
            this.rbKwadrat.AutoSize = true;
            this.rbKwadrat.Location = new System.Drawing.Point(6, 108);
            this.rbKwadrat.Name = "rbKwadrat";
            this.rbKwadrat.Size = new System.Drawing.Size(80, 22);
            this.rbKwadrat.TabIndex = 6;
            this.rbKwadrat.Text = "Kwadrat";
            this.rbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rbProstokąt
            // 
            this.rbProstokąt.AutoSize = true;
            this.rbProstokąt.Location = new System.Drawing.Point(168, 80);
            this.rbProstokąt.Name = "rbProstokąt";
            this.rbProstokąt.Size = new System.Drawing.Size(84, 22);
            this.rbProstokąt.TabIndex = 5;
            this.rbProstokąt.Text = "Prostokąt";
            this.rbProstokąt.UseVisualStyleBackColor = true;
            // 
            // rbKolo
            // 
            this.rbKolo.AutoSize = true;
            this.rbKolo.Location = new System.Drawing.Point(6, 80);
            this.rbKolo.Name = "rbKolo";
            this.rbKolo.Size = new System.Drawing.Size(53, 22);
            this.rbKolo.TabIndex = 4;
            this.rbKolo.Text = "Kolo";
            this.rbKolo.UseVisualStyleBackColor = true;
            // 
            // rbOkrąg
            // 
            this.rbOkrąg.AutoSize = true;
            this.rbOkrąg.Location = new System.Drawing.Point(168, 52);
            this.rbOkrąg.Name = "rbOkrąg";
            this.rbOkrąg.Size = new System.Drawing.Size(63, 22);
            this.rbOkrąg.TabIndex = 3;
            this.rbOkrąg.Text = "Okrąg";
            this.rbOkrąg.UseVisualStyleBackColor = true;
            // 
            // rbElipsa
            // 
            this.rbElipsa.AutoSize = true;
            this.rbElipsa.Location = new System.Drawing.Point(6, 52);
            this.rbElipsa.Name = "rbElipsa";
            this.rbElipsa.Size = new System.Drawing.Size(62, 22);
            this.rbElipsa.TabIndex = 2;
            this.rbElipsa.Text = "Elipsa";
            this.rbElipsa.UseVisualStyleBackColor = true;
            // 
            // rbLiniaProsta
            // 
            this.rbLiniaProsta.AutoSize = true;
            this.rbLiniaProsta.Location = new System.Drawing.Point(168, 24);
            this.rbLiniaProsta.Name = "rbLiniaProsta";
            this.rbLiniaProsta.Size = new System.Drawing.Size(99, 22);
            this.rbLiniaProsta.TabIndex = 1;
            this.rbLiniaProsta.Text = "Linia prosta";
            this.rbLiniaProsta.UseVisualStyleBackColor = true;
            // 
            // rbPunkt
            // 
            this.rbPunkt.AutoSize = true;
            this.rbPunkt.Checked = true;
            this.rbPunkt.Location = new System.Drawing.Point(6, 24);
            this.rbPunkt.Name = "rbPunkt";
            this.rbPunkt.Size = new System.Drawing.Size(62, 22);
            this.rbPunkt.TabIndex = 0;
            this.rbPunkt.TabStop = true;
            this.rbPunkt.Text = "Punkt";
            this.rbPunkt.UseVisualStyleBackColor = true;
            // 
            // gbAtrybutyGraficzne
            // 
            this.gbAtrybutyGraficzne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbAtrybutyGraficzne.Controls.Add(this.label3);
            this.gbAtrybutyGraficzne.Controls.Add(this.tbGruboscLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.label2);
            this.gbAtrybutyGraficzne.Controls.Add(this.cbSylLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtkolorWypelnenia);
            this.gbAtrybutyGraficzne.Controls.Add(this.bttnKolorWypelnenia);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.bttnKolorLinii);
            this.gbAtrybutyGraficzne.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAtrybutyGraficzne.Location = new System.Drawing.Point(865, 363);
            this.gbAtrybutyGraficzne.Name = "gbAtrybutyGraficzne";
            this.gbAtrybutyGraficzne.Size = new System.Drawing.Size(325, 224);
            this.gbAtrybutyGraficzne.TabIndex = 17;
            this.gbAtrybutyGraficzne.TabStop = false;
            this.gbAtrybutyGraficzne.Text = "Atrybuty graficzne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(177, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ustaw styl linii:";
            // 
            // tbGruboscLinii
            // 
            this.tbGruboscLinii.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbGruboscLinii.Location = new System.Drawing.Point(180, 143);
            this.tbGruboscLinii.Maximum = 11;
            this.tbGruboscLinii.Minimum = 1;
            this.tbGruboscLinii.Name = "tbGruboscLinii";
            this.tbGruboscLinii.Size = new System.Drawing.Size(134, 45);
            this.tbGruboscLinii.TabIndex = 6;
            this.tbGruboscLinii.Value = 1;
            this.tbGruboscLinii.Scroll += new System.EventHandler(this.tbGruboscLinii_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ustaw grubość linii:";
            // 
            // cbSylLinii
            // 
            this.cbSylLinii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSylLinii.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSylLinii.FormattingEnabled = true;
            this.cbSylLinii.Items.AddRange(new object[] {
            "Solid",
            "Dot",
            "Dash",
            "DashDot",
            "DashDotDot"});
            this.cbSylLinii.Location = new System.Drawing.Point(175, 62);
            this.cbSylLinii.Name = "cbSylLinii";
            this.cbSylLinii.Size = new System.Drawing.Size(144, 26);
            this.cbSylLinii.TabIndex = 4;
            this.cbSylLinii.SelectedIndexChanged += new System.EventHandler(this.cbSylLinii_SelectedIndexChanged);
            // 
            // txtkolorWypelnenia
            // 
            this.txtkolorWypelnenia.BackColor = System.Drawing.Color.White;
            this.txtkolorWypelnenia.Enabled = false;
            this.txtkolorWypelnenia.Location = new System.Drawing.Point(27, 185);
            this.txtkolorWypelnenia.Name = "txtkolorWypelnenia";
            this.txtkolorWypelnenia.ReadOnly = true;
            this.txtkolorWypelnenia.Size = new System.Drawing.Size(125, 25);
            this.txtkolorWypelnenia.TabIndex = 3;
            // 
            // bttnKolorWypelnenia
            // 
            this.bttnKolorWypelnenia.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnKolorWypelnenia.Location = new System.Drawing.Point(27, 133);
            this.bttnKolorWypelnenia.Name = "bttnKolorWypelnenia";
            this.bttnKolorWypelnenia.Size = new System.Drawing.Size(125, 46);
            this.bttnKolorWypelnenia.TabIndex = 2;
            this.bttnKolorWypelnenia.Text = "Kolor Wypelnenia";
            this.bttnKolorWypelnenia.UseVisualStyleBackColor = true;
            this.bttnKolorWypelnenia.Click += new System.EventHandler(this.bttnKolorWypelnenia_Click);
            // 
            // txtKolorLinii
            // 
            this.txtKolorLinii.BackColor = System.Drawing.Color.White;
            this.txtKolorLinii.Enabled = false;
            this.txtKolorLinii.Location = new System.Drawing.Point(27, 80);
            this.txtKolorLinii.Name = "txtKolorLinii";
            this.txtKolorLinii.ReadOnly = true;
            this.txtKolorLinii.Size = new System.Drawing.Size(125, 25);
            this.txtKolorLinii.TabIndex = 1;
            // 
            // bttnKolorLinii
            // 
            this.bttnKolorLinii.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnKolorLinii.Location = new System.Drawing.Point(27, 28);
            this.bttnKolorLinii.Name = "bttnKolorLinii";
            this.bttnKolorLinii.Size = new System.Drawing.Size(125, 46);
            this.bttnKolorLinii.TabIndex = 0;
            this.bttnKolorLinii.Text = "Kolor Linii";
            this.bttnKolorLinii.UseVisualStyleBackColor = true;
            this.bttnKolorLinii.Click += new System.EventHandler(this.bttnKolorLinii_Click);
            // 
            // bttnWylacz
            // 
            this.bttnWylacz.Enabled = false;
            this.bttnWylacz.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnWylacz.Location = new System.Drawing.Point(17, 107);
            this.bttnWylacz.Name = "bttnWylacz";
            this.bttnWylacz.Size = new System.Drawing.Size(221, 71);
            this.bttnWylacz.TabIndex = 24;
            this.bttnWylacz.Text = "Wyłącz pokaz figur geometrycznych";
            this.bttnWylacz.UseVisualStyleBackColor = true;
            this.bttnWylacz.Click += new System.EventHandler(this.bttnWylacz_Click);
            // 
            // bttnWlacz
            // 
            this.bttnWlacz.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnWlacz.Location = new System.Drawing.Point(17, 21);
            this.bttnWlacz.Name = "bttnWlacz";
            this.bttnWlacz.Size = new System.Drawing.Size(221, 71);
            this.bttnWlacz.TabIndex = 23;
            this.bttnWlacz.Text = "Włączenie slajdera figur geometrycznych";
            this.bttnWlacz.UseVisualStyleBackColor = true;
            this.bttnWlacz.Click += new System.EventHandler(this.bttnWlacz_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Enabled = false;
            this.bttnBack.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnBack.Location = new System.Drawing.Point(481, 143);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(126, 35);
            this.bttnBack.TabIndex = 22;
            this.bttnBack.Text = "Poprzedni";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttn_Next
            // 
            this.bttn_Next.Enabled = false;
            this.bttn_Next.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_Next.Location = new System.Drawing.Point(284, 143);
            this.bttn_Next.Name = "bttn_Next";
            this.bttn_Next.Size = new System.Drawing.Size(126, 35);
            this.bttn_Next.TabIndex = 21;
            this.bttn_Next.Text = "Następny";
            this.bttn_Next.UseVisualStyleBackColor = true;
            this.bttn_Next.Click += new System.EventHandler(this.bttn_Next_Click);
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Enabled = false;
            this.txtNumerFigury.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumerFigury.Location = new System.Drawing.Point(715, 94);
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(100, 29);
            this.txtNumerFigury.TabIndex = 20;
            // 
            // lblNF
            // 
            this.lblNF.AutoSize = true;
            this.lblNF.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNF.Location = new System.Drawing.Point(711, 70);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(109, 22);
            this.lblNF.TabIndex = 19;
            this.lblNF.Text = "Numer figury:";
            // 
            // gpWyborPokazu
            // 
            this.gpWyborPokazu.Controls.Add(this.radioButtonManualny);
            this.gpWyborPokazu.Controls.Add(this.radioButtonAutomatyczny);
            this.gpWyborPokazu.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpWyborPokazu.Location = new System.Drawing.Point(244, 61);
            this.gpWyborPokazu.Name = "gpWyborPokazu";
            this.gpWyborPokazu.Size = new System.Drawing.Size(408, 76);
            this.gpWyborPokazu.TabIndex = 18;
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
            // gbSlajder
            // 
            this.gbSlajder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbSlajder.Controls.Add(this.bttnWlacz);
            this.gbSlajder.Controls.Add(this.bttnWylacz);
            this.gbSlajder.Controls.Add(this.gpWyborPokazu);
            this.gbSlajder.Controls.Add(this.lblNF);
            this.gbSlajder.Controls.Add(this.bttnBack);
            this.gbSlajder.Controls.Add(this.txtNumerFigury);
            this.gbSlajder.Controls.Add(this.bttn_Next);
            this.gbSlajder.Enabled = false;
            this.gbSlajder.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSlajder.Location = new System.Drawing.Point(12, 593);
            this.gbSlajder.Name = "gbSlajder";
            this.gbSlajder.Size = new System.Drawing.Size(847, 195);
            this.gbSlajder.TabIndex = 25;
            this.gbSlajder.TabStop = false;
            this.gbSlajder.Text = "Slajder";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttnPrzesun
            // 
            this.bttnPrzesun.Enabled = false;
            this.bttnPrzesun.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnPrzesun.Location = new System.Drawing.Point(569, 12);
            this.bttnPrzesun.Name = "bttnPrzesun";
            this.bttnPrzesun.Size = new System.Drawing.Size(290, 56);
            this.bttnPrzesun.TabIndex = 26;
            this.bttnPrzesun.Text = "Przesunięcie do nowego mejsca";
            this.bttnPrzesun.UseVisualStyleBackColor = true;
            this.bttnPrzesun.Click += new System.EventHandler(this.bttnPrzesun_Click);
            // 
            // bttnZapisz
            // 
            this.bttnZapisz.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZapisz.Location = new System.Drawing.Point(6, 47);
            this.bttnZapisz.Name = "bttnZapisz";
            this.bttnZapisz.Size = new System.Drawing.Size(238, 56);
            this.bttnZapisz.TabIndex = 27;
            this.bttnZapisz.Text = "Zapisz bitmape w pliku";
            this.bttnZapisz.UseVisualStyleBackColor = true;
            this.bttnZapisz.Click += new System.EventHandler(this.bttnZapisz_Click);
            // 
            // bttnOdczytaj
            // 
            this.bttnOdczytaj.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnOdczytaj.Location = new System.Drawing.Point(6, 109);
            this.bttnOdczytaj.Name = "bttnOdczytaj";
            this.bttnOdczytaj.Size = new System.Drawing.Size(238, 56);
            this.bttnOdczytaj.TabIndex = 28;
            this.bttnOdczytaj.Text = "Odczytaj bitmape w pliku";
            this.bttnOdczytaj.UseVisualStyleBackColor = true;
            this.bttnOdczytaj.Click += new System.EventHandler(this.bttnOdczytaj_Click);
            // 
            // gbplik
            // 
            this.gbplik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbplik.Controls.Add(this.bttnZapisz);
            this.gbplik.Controls.Add(this.bttnOdczytaj);
            this.gbplik.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbplik.Location = new System.Drawing.Point(880, 593);
            this.gbplik.Name = "gbplik";
            this.gbplik.Size = new System.Drawing.Size(253, 195);
            this.gbplik.TabIndex = 29;
            this.gbplik.TabStop = false;
            this.gbplik.Text = "Plik";
            // 
            // KreślenieFigur_Linii_59022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Projekt2_Chalyi_59022.Properties.Resources.RedAbstractShapesSmall;
            this.ClientSize = new System.Drawing.Size(1205, 800);
            this.Controls.Add(this.gbplik);
            this.Controls.Add(this.bttnPrzesun);
            this.Controls.Add(this.gbSlajder);
            this.Controls.Add(this.gbAtrybutyGraficzne);
            this.Controls.Add(this.gbWybierz);
            this.Controls.Add(this.bttnPowrot);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KreślenieFigur_Linii_59022";
            this.Text = "KreślenieFigur_Linii_59022";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KreślenieFigur_Linii_59022_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gbWybierz.ResumeLayout(false);
            this.gbWybierz.PerformLayout();
            this.gbAtrybutyGraficzne.ResumeLayout(false);
            this.gbAtrybutyGraficzne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGruboscLinii)).EndInit();
            this.gpWyborPokazu.ResumeLayout(false);
            this.gpWyborPokazu.PerformLayout();
            this.gbSlajder.ResumeLayout(false);
            this.gbSlajder.PerformLayout();
            this.gbplik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button bttnPowrot;
        private System.Windows.Forms.GroupBox gbWybierz;
        private System.Windows.Forms.RadioButton rbLiniaProsta;
        private System.Windows.Forms.RadioButton rbPunkt;
        private System.Windows.Forms.RadioButton rbLinia_ciągla;
        private System.Windows.Forms.RadioButton rbWielokąt_wypelniony;
        private System.Windows.Forms.RadioButton rbWielokąt_foremny;
        private System.Windows.Forms.RadioButton rbKwadrat;
        private System.Windows.Forms.RadioButton rbProstokąt;
        private System.Windows.Forms.RadioButton rbKolo;
        private System.Windows.Forms.RadioButton rbOkrąg;
        private System.Windows.Forms.RadioButton rbElipsa;
        private System.Windows.Forms.RadioButton rbKzywa_Beziera;
        private System.Windows.Forms.GroupBox gbAtrybutyGraficzne;
        private System.Windows.Forms.TextBox txtkolorWypelnenia;
        private System.Windows.Forms.Button bttnKolorWypelnenia;
        private System.Windows.Forms.TextBox txtKolorLinii;
        private System.Windows.Forms.Button bttnKolorLinii;
        private System.Windows.Forms.ComboBox cbSylLinii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbGruboscLinii;
        private System.Windows.Forms.Button bttnWylacz;
        private System.Windows.Forms.Button bttnWlacz;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttn_Next;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Label lblNF;
        private System.Windows.Forms.GroupBox gpWyborPokazu;
        private System.Windows.Forms.RadioButton radioButtonManualny;
        private System.Windows.Forms.RadioButton radioButtonAutomatyczny;
        private System.Windows.Forms.GroupBox gbSlajder;
        private System.Windows.Forms.RadioButton rbFillElipse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnPrzesun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnCofnij;
        private System.Windows.Forms.Button bttnZapisz;
        private System.Windows.Forms.Button bttnOdczytaj;
        private System.Windows.Forms.GroupBox gbplik;
        private System.Windows.Forms.RadioButton rbKrzywaKardynalna;
        private System.Windows.Forms.Button bttnZakoncz;
    }
}