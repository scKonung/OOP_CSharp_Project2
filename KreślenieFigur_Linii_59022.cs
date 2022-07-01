using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie przestrzeni
using static Projekt2_Chalyi_59022.FiguryGeometryczne;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Projekt2_Chalyi_59022
{
    public partial class KreślenieFigur_Linii_59022 : Form
    {
        //deklaracja pomocnicze
        const ushort scMargines = 10;
        const ushort scMarginesFormularz = 20;
        //deklaracja pwierhzchni graficznej
        Graphics scRysownica;
        Graphics scRysownicaTymaczsowa;
        //deklaracja punktu
        Point scPunkt;
        //deklaracja pióra
        Pen scPioro;
        //deklaracja stylu linii z domyśnim stylem i grubosci linii
        DashStyle scStylLinii = DashStyle.Solid;
        int scGruboscLinii = 1;
        //seklaracja Pędzla
        SolidBrush scPedzel;
        Pen scPioroTymczasowe;
        //liste ewidencji
        List<Punkt> scLFG = new List<Punkt>();
        public KreślenieFigur_Linii_59022()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + scMarginesFormularz,
                Screen.PrimaryScreen.Bounds.Y + 2*scMarginesFormularz);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);
            //lokalizacja i zmiarowanie kontrolki pictureBox
            pbRysownica.Location = new Point(Left + scMarginesFormularz,Top + scMarginesFormularz);
            pbRysownica.Width = (int)(this.Width * 0.7F);
            pbRysownica.Height = (int)(this.Height * 0.6F);
            pbRysownica.BackColor = Color.White;
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            //utworzenie mapy itowej i podpięcie jej do kontrolki PictureBox
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //lokalizacja GB
            gbWybierz.Location = new Point(pbRysownica.Left + pbRysownica.Width + scMargines, pbRysownica.Top);
            //lokalizacja innego gb
            gbAtrybutyGraficzne.Location = new Point(gbWybierz.Left , gbWybierz.Top + gbWybierz.Height + scMargines);
            gbSlajder.Location = new Point(pbRysownica.Left, pbRysownica.Top + pbRysownica.Height + scMargines);
            label1.Location = new Point(pbRysownica.Left, pbRysownica.Top - 3 *scMargines);
            bttnPowrot.Location = new Point(gbWybierz.Left, label1.Top - 2 *scMargines);
            lblX.Location = new Point(label1.Right + scMargines, label1.Top);
            lblY.Location = new Point(lblX.Right + 3*scMargines, label1.Top);
            bttnPrzesun.Location = new Point(pbRysownica.Right - bttnPrzesun.Width, pbRysownica.Top - bttnPrzesun.Height -scMargines);
            gbplik.Location = new Point(gbSlajder.Right + scMargines,gbSlajder.Top);
            //utworzenie egzemplarza powierhzchni graficznej na Bitmapie
            scRysownica = Graphics.FromImage(pbRysownica.Image);

            scRysownicaTymaczsowa = pbRysownica.CreateGraphics();
            //utworzenie egzemplarza pióra glównego
            scPunkt = Point.Empty;
            scPioro = new Pen(Color.Black, 1F);
            scPioro.DashStyle = DashStyle.Solid;
            scPioro.StartCap = LineCap.Round;
            scPioro.EndCap = LineCap.Round;
            scPioroTymczasowe = new Pen(Color.Blue, 1);
            scPedzel = new SolidBrush(Color.Blue);
        }

        private void KreślenieFigur_Linii_59022_FormClosed(object sender, FormClosedEventArgs e)
        {
            //zamknięcie program
            Application.Exit();
        }

        private void bttnPowrot_Click(object sender, EventArgs e)
        {
            Form Foma = new FormGlowna();
            this.Hide();
            Foma.Show();

        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            //wyświetlenie akualnego polożenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                scPunkt = e.Location;
                //obsluga kontrolki kreślenia linii myszą
                if(rbLinia_ciągla.Checked)
                {
                    //dodanie do LFG egzemplarza
                    scLFG.Add(new LiniaKreślonaMyszą(scPunkt, scPioro.Color, scStylLinii, scGruboscLinii));
                }    
            }
        }

        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            //wyświetlenie akualnego polożenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            //deklaracja zmiennych pomocniczych]
            int scLewyGornynaroznikX = (scPunkt.X > e.Location.X) ? e.Location.X : scPunkt.X;
            int scLewyGornynaroznikY = (scPunkt.Y > e.Location.Y) ? e.Location.Y : scPunkt.Y;
            int scSzerokosc = Math.Abs(scPunkt.X - e.Location.X);
            int scWysokosc = Math.Abs(scPunkt.Y - e.Location.Y);
            if (e.Button == MouseButtons.Left)
            {
                if (rbPunkt.Checked)
                { //utworzenie egzemplarza i dodanie jego referencji do LFG
                    scLFG.Add(new Punkt(scPunkt.X, scPunkt.Y));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, DashStyle.Solid, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);

                }
                if (rbLiniaProsta.Checked)
                {
                    scLFG.Add(new Linia(scPunkt.X, scPunkt.Y, e.Location.X, e.Location.Y));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);

                }
                if (rbElipsa.Checked)
                {
                    scLFG.Add(new Elipsa(scLewyGornynaroznikX , scLewyGornynaroznikY, scSzerokosc , scWysokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if (rbOkrąg.Checked)
                {
                    scLFG.Add(new Okrąg(scLewyGornynaroznikX,scLewyGornynaroznikY,scWysokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if (rbKolo.Checked)
                {
                    scLFG.Add(new Kolo(scLewyGornynaroznikX,scLewyGornynaroznikY,scWysokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPedzel.Color);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if (rbProstokąt.Checked)
                {
                    scLFG.Add(new Prostokąt(scLewyGornynaroznikX, scLewyGornynaroznikY, scSzerokosc , scWysokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if (rbKwadrat.Checked)
                {
                    scLFG.Add(new Kwadrat(scLewyGornynaroznikX, scLewyGornynaroznikY, scSzerokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if (rbFillElipse.Checked)
                {
                    scLFG.Add(new FillElipsa(scLewyGornynaroznikX, scLewyGornynaroznikY, scSzerokosc, scWysokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPedzel.Color);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if(rbLinia_ciągla.Checked)
                {
                    Pen scPioroDlaMyszy = new Pen(scPioro.Color, scGruboscLinii);
                    scPioroDlaMyszy.DashStyle = scStylLinii;
                    ((LiniaKreślonaMyszą)scLFG[scLFG.Count - 1]).DodajNowyPunktkreslonejLinii(e.Location);
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    scRysownica.DrawLine(scPioroDlaMyszy,scPunkt,e.Location);
                }
                if (rbKzywa_Beziera.Checked)
                {

                        Pen scPioroDlaBeziera = new Pen(scPioro.Color, scGruboscLinii);
                    scPioroDlaBeziera.DashStyle = scStylLinii;
                    //sprawdzenie, czy to jest pierwszy punkt kontrolny
                    if (gbWybierz.Enabled)
                    {
                        //utworzenie egzemplarza
                        scLFG.Add(new KrzywaBeziera(scRysownica, scPioroDlaBeziera, scPunkt));
                        gbWybierz.Enabled = false;
                        ((KrzywaBeziera)scLFG[scLFG.Count - 1]).scLiczbaPunktówKontrolnych = 0;
                    }
                    else
                    {

                        //dodanie nowego punktu kontrolnego
                        ((KrzywaBeziera)scLFG[scLFG.Count - 1]).scDodajNowyPunktkontrolnych(e.Location, scRysownica);
                        ((KrzywaBeziera)scLFG[scLFG.Count-1]).scLiczbaPunktówKontrolnych++;
                        if(((KrzywaBeziera)scLFG[scLFG.Count-1]).scLiczbaPunktówKontrolnych == 3)
                        {
                            gbWybierz.Enabled = true;
                            scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                        }

                    }
                }
                if (rbWielokąt_foremny.Checked)
                {
                    scLFG.Add(new Wielokąt(scLewyGornynaroznikX, scLewyGornynaroznikY, scSzerokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPioro.Color, scStylLinii, scGruboscLinii);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                }
                if (rbWielokąt_wypelniony.Checked)
                {
                    scLFG.Add(new WielokątWypiełniony(scLewyGornynaroznikX, scLewyGornynaroznikY, scSzerokosc));
                    //ustalenie atrybutów geometrycznych i graficzhych punktu
                    scLFG[scLFG.Count - 1].scUstalAtrybutyGraficzne(scPedzel.Color);
                    //wykreślenie punktu
                    scLFG[scLFG.Count - 1].scWykresl(scRysownica);

                }
                
                if (rbKrzywaKardynalna.Checked)
                {
                    bttnZakoncz.Visible = true;
                    Pen scPioroDlaKardynalnej = new Pen(scPioro.Color, scGruboscLinii);
                    scPioroDlaKardynalnej.DashStyle = scStylLinii;

                    //sprawdzenie, czy to jest pierwszy punkt kontrolny
                    if (rbElipsa.Enabled)
                    {
                       
                        //utworzenie egzemplarza
                        scLFG.Add(new KrzywaKardynalna(scRysownica, scPioroDlaKardynalnej, scPunkt ));
                        foreach (Control scKontrolka in this.gbWybierz.Controls)
                        {
                            if (scKontrolka.GetType().Name == "RadioButton")
                                scKontrolka.Enabled = false;
                        }
                        bttnCofnij.Enabled = false;
                        ((KrzywaKardynalna)scLFG[scLFG.Count - 1]).scLiczbaPunktówKontrolnych = 0;
                        gbAtrybutyGraficzne.Enabled = false;
                    }
                    else
                    {

                        //dodanie nowego punktu kontrolnego
                        ((KrzywaKardynalna)scLFG[scLFG.Count - 1]).scDodajNowyPunktkontrolnych(e.Location, scRysownica , scPioro);
                        ((KrzywaKardynalna)scLFG[scLFG.Count - 1]).scLiczbaPunktówKontrolnych++;
                    }
                }
            }
            //ustalenie stanu aktywności
            if (scLFG.Count > 0)
            { 
                bttnPrzesun.Enabled = true;
                gbSlajder.Enabled = true;
                bttnCofnij.Enabled = true;
            }
           
                
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wizualizacja akualnego położenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                //wyświetlenie aktualnego polożenia
                lblX.Text = e.Location.X.ToString();
                lblY.Text = e.Location.Y.ToString();

                int sclewyGornyNaroznikX = (scPunkt.X > e.Location.X) ? e.Location.X : scPunkt.X;
                int sclewyGornyNaroznikY = (scPunkt.Y > e.Location.Y) ? e.Location.Y : scPunkt.Y;
                int scSzerokosc = Math.Abs(scPunkt.X - e.Location.X);
                int scWysokosc = Math.Abs(scPunkt.Y - e.Location.Y);
                if (rbPunkt.Checked)
                { }
                if (rbLiniaProsta.Checked)
                    scRysownicaTymaczsowa.DrawLine(scPioroTymczasowe, scPunkt.X , scPunkt.Y, e.Location.X, e.Location.Y);

                if (rbElipsa.Checked)
                    scRysownicaTymaczsowa.DrawEllipse(scPioroTymczasowe, new Rectangle(sclewyGornyNaroznikX, sclewyGornyNaroznikX,
                        scSzerokosc, scWysokosc));
                if (rbOkrąg.Checked)
                    scRysownicaTymaczsowa.DrawEllipse(scPioroTymczasowe, new Rectangle(sclewyGornyNaroznikX, sclewyGornyNaroznikY,
                        scSzerokosc, scSzerokosc));
                if (rbKolo.Checked)
                    scRysownicaTymaczsowa.FillEllipse(scPedzel, new Rectangle(sclewyGornyNaroznikX, sclewyGornyNaroznikY,
                        scSzerokosc, scSzerokosc));
                if (rbProstokąt.Checked)
                    scRysownicaTymaczsowa.DrawRectangle(scPioroTymczasowe, new Rectangle(sclewyGornyNaroznikX, sclewyGornyNaroznikY,
                        scSzerokosc, scWysokosc));
                if (rbKwadrat.Checked)
                    scRysownicaTymaczsowa.DrawRectangle(scPioroTymczasowe, new Rectangle(sclewyGornyNaroznikX, sclewyGornyNaroznikY,
                        scSzerokosc, scSzerokosc));
                if (rbFillElipse.Checked)
                    scRysownicaTymaczsowa.FillEllipse(scPedzel, new Rectangle(sclewyGornyNaroznikX, sclewyGornyNaroznikY,
                        scSzerokosc, scWysokosc));
                if (rbLinia_ciągla.Checked)
                {
                    Pen scPioroDlaMyszy = new Pen(scPioro.Color, scGruboscLinii);
                    scPioroDlaMyszy.DashStyle = scStylLinii;
                    ((LiniaKreślonaMyszą)scLFG[scLFG.Count - 1]).DodajNowyPunktkreslonejLinii(e.Location);
                    scRysownica.DrawLine(scPioroDlaMyszy, scPunkt, e.Location);
                    scPunkt = e.Location;
                }
                if (rbWielokąt_foremny.Checked)
                {
                    Wielokąt scWielokat = new Wielokąt(sclewyGornyNaroznikX, sclewyGornyNaroznikY, scSzerokosc);
                    scWielokat.scWykresl(scRysownicaTymaczsowa);
                }
                if (rbWielokąt_wypelniony.Checked)
                {
                    WielokątWypiełniony scWielokat = new WielokątWypiełniony(sclewyGornyNaroznikX, sclewyGornyNaroznikY, scSzerokosc , scPedzel.Color);
                    scWielokat.scWykresl(scRysownicaTymaczsowa);
                }
                //odświeżenie powierzchni graficznej
                pbRysownica.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wymażenie całej powierhni graficznej
            scRysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiaru powierzchni graficznej
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //wpisanie do kontrolki slajder indeksu LFG pokazywnej figury
            txtNumerFigury.Text = timer1.Tag.ToString();
            //wykreślenie figury o indeksie timer1.Tag w żrodku powierzchni grfaficznej
            scLFG[(int)(timer1.Tag)].scPresunDoNowegoXY(pbRysownica, scRysownica,
                scXmax / 2, scYmax / 2);
            //odświedczenie powierzchni graficznej
            pbRysownica.Refresh();
            //wyznazenie indeksu w polu timer1.Tag
            timer1.Tag = ((int)timer1.Tag + 1) % scLFG.Count;
        }

        private void bttnWlacz_Click(object sender, EventArgs e)
        {
            //wyczyszczenie rysownicy
            scRysownica.Clear(pbRysownica.BackColor);
            //ustawienie indeksu pierwszej figury zapisanej w LFG
            timer1.Tag = 0;
            txtNumerFigury.Text = 0.ToString();
            //wyznaczenie rozmiaru Rysownicy
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //trzeba bęzie zmienić kod
            scLFG[0].scPresunDoNowegoXY(pbRysownica, scRysownica, scXmax / 2, scYmax / 2);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            //rozpoznanie wybrenego trybu
            if (radioButtonAutomatyczny.Checked == true)
                timer1.Enabled = true;
            else if (radioButtonManualny.Checked == true)
            {
                //uaktywnenie przycisków poleceń
                bttn_Next.Enabled = true;
                bttnBack.Enabled = true;
                txtNumerFigury.Enabled = true;
            }
            //ustawenie stanu braku aktywności
            bttnWlacz.Enabled = false;
            bttnPrzesun.Enabled = false;
            gbWybierz.Enabled = false;
            //ustawenie stanu aktywności
            bttnWylacz.Enabled = true;
        }

        private void bttnWylacz_Click(object sender, EventArgs e)
        {
            scRysownica.Clear(pbRysownica.BackColor);
            //wyłączenie zegara
            timer1.Enabled = false;
            //ustawenie stanu  aktywności
            bttnWlacz.Enabled = true;
            //wykreślenie wszystkich figur
            //wyznaczenie rozmiaru Rysownicy
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //deklaracje pomocnicz
            Random scrnd = new Random();
            int scX, scY;
            Color scKolorLinii, scKolorWypelnenia;
            int scGruboscLinii;
            DashStyle scStylLinii;
            for (int sci = 0; sci <scLFG.Count; sci++)
            {
                //wylososwanie kolorów
                scKolorLinii = Color.FromArgb(scrnd.Next(0, 255), scrnd.Next(0, 255), scrnd.Next(0, 255));
                scKolorWypelnenia = Color.FromArgb(scrnd.Next(0, 255), scrnd.Next(0, 255), scrnd.Next(0, 255));
                //wyłososwanie grubości linii
                scGruboscLinii = scrnd.Next(1, 11);
                switch (scrnd.Next(1, 6))
                {
                    case 1: scStylLinii = DashStyle.Dash; break;
                    case 2: scStylLinii = DashStyle.DashDot; break;
                    case 3: scStylLinii = DashStyle.DashDotDot; break;
                    case 4: scStylLinii = DashStyle.Dot; break;
                    default: scStylLinii = DashStyle.Solid; break;
                }
                //ustalenie nowych atrybutów graficznych
                scLFG[sci].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                scLFG[sci].scUstalAtrybutyGraficzne(scKolorWypelnenia);
                //ustalenie nowego polożenia
                scX = scrnd.Next(scMargines, scXmax - scMargines);
                scY = scrnd.Next(scMargines, scYmax - scMargines);
                //przesunięcie figury no nowych koordynatów
                scLFG[sci].scPresunDoNowegoXY(pbRysownica, scRysownica, scX, scY);
            }
            pbRysownica.Refresh();
            //ustalenie stanu braku aktywności
            bttnWylacz.Enabled = false;
            bttn_Next.Enabled = false;
            bttnBack.Enabled = false;
            txtNumerFigury.Enabled = false;
            txtNumerFigury.Text = 0.ToString();
            radioButtonAutomatyczny.Checked = true;
            bttnPrzesun.Enabled = true;
            gbWybierz.Enabled = true;
        }

        private void bttn_Next_Click(object sender, EventArgs e)
        {
            ushort scIndeksFigury;
            //pobrenie wartości indeksu z kontrolki textNumerFigury
            if (!ushort.TryParse(txtNumerFigury.Text, out scIndeksFigury))
            {
                MessageBox.Show("ERROR: w zapisie indeksu figury do prezentacji wystąpił" +
                    " niedozwolony znak","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //sprawdzenie wartośći
            if ((scIndeksFigury < 0) || (scIndeksFigury >= scLFG.Count))
            {
                MessageBox.Show("ERROR: przekroczenie indeksów LFG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //wyznaczenie rozmiarów powierhzchni geometrycznej
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //wymażenie aktualnej wykreślonej figury geometrycznej
            scRysownica.Clear(pbRysownica.BackColor);
            //przesunięcie figury do sródka risownicy
            scLFG[scIndeksFigury].scPresunDoNowegoXY(pbRysownica, scRysownica, scXmax / 2, scYmax / 2);
            //odświadczenie powierzchni graficznej
            pbRysownica.Refresh();
            if (scIndeksFigury <scLFG.Count - 1)
                scIndeksFigury++;
            else
                scIndeksFigury = 0;
            txtNumerFigury.Text = scIndeksFigury.ToString();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            ushort scIndeksFigury;
            //pobrenie wartości indeksu z kontrolki textNumerFigury
            if (!ushort.TryParse(txtNumerFigury.Text, out scIndeksFigury))
            {
                MessageBox.Show("ERROR: w zapisie indeksu figury do prezentacji wystąpił" +
                    " niedozwolony znak", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //sprawdzenie wartośći
            if ((scIndeksFigury < 0) || (scIndeksFigury >=scLFG.Count))
            {
                MessageBox.Show("ERROR: przekroczenie indeksów LFG");
                return;
            }
            //wyznaczenie rozmiarów powierhzchni geometrycznej
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //wymażenie aktualnej wykreślonej figury geometrycznej
            scRysownica.Clear(pbRysownica.BackColor);
            //przesunięcie figury do sródka risownicy
            scLFG[scIndeksFigury].scPresunDoNowegoXY(pbRysownica, scRysownica, scXmax / 2, scYmax / 2);
            //odświadczenie powierzchni graficznej
            pbRysownica.Refresh();
            if (scIndeksFigury > 0)
                scIndeksFigury--;
            else
                scIndeksFigury = (ushort)(scLFG.Count - 1);
            txtNumerFigury.Text = scIndeksFigury.ToString();
        }

        private void bttnPrzesun_Click(object sender, EventArgs e)
        {
            //deklaracje pomocnicz
            int scXp, scYp;
            //generator liczb łosowych
            Random scrnd = new Random();
            //wymazanie kontrolki grficznej
            scRysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiarów powierhni
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            for (int sci = 0; sci < scLFG.Count; sci++)
            {//wylosowanie nowego polożenia
                scXp = scrnd.Next(scMargines, scXmax - scMargines);
                scYp = scrnd.Next(scMargines, scYmax - scMargines);
                scLFG[sci].scPresunDoNowegoXY(pbRysownica, scRysownica, scXp, scYp);
            }
            //odwiaczenie powierhni graficznej
            pbRysownica.Refresh();
        }

        private void bttnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog scKolorDialog = new ColorDialog();
            scKolorDialog.Color = scPioro.Color;

            if (scKolorDialog.ShowDialog() == DialogResult.OK)
            {
                txtKolorLinii.BackColor = scKolorDialog.Color;
                scPioro.Color = scKolorDialog.Color;
            }
            scKolorDialog.Dispose();
        }

        private void bttnKolorWypelnenia_Click(object sender, EventArgs e)
        {
            ColorDialog scKolorDialog = new ColorDialog();
            scKolorDialog.Color = scPedzel.Color;

            if (scKolorDialog.ShowDialog() == DialogResult.OK)
            {
                txtkolorWypelnenia.BackColor = scKolorDialog.Color;
                scPedzel.Color = scKolorDialog.Color;
            }
            scKolorDialog.Dispose();
        }

        private void cbSylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSylLinii.SelectedIndex)
            {
                case 0: scStylLinii = DashStyle.Solid; break;
                case 1: scStylLinii = DashStyle.Dot; break;
                case 2: scStylLinii = DashStyle.Dash; break;
                case 3: scStylLinii = DashStyle.DashDot; break;
                default: scStylLinii = DashStyle.DashDotDot; break;
            }
        }

        private void tbGruboscLinii_Scroll(object sender, EventArgs e)
        {
            scGruboscLinii = tbGruboscLinii.Value;
        }

        private void bttnCofnij_Click(object sender, EventArgs e)
        {
            //usunięcie ostatniego elementu listy
            scLFG.RemoveAt(scLFG.Count-1);
            //wyczyszczenie risownicy
            scRysownica.Clear(pbRysownica.BackColor);
            //ponowne odrysowanie
            for (int sci = 0; sci < scLFG.Count; sci++)
                scLFG[sci].scWykresl(scRysownica);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            if (scLFG.Count == 0)
            {
                bttnPrzesun.Enabled = false;
                gbSlajder.Enabled = false;
                bttnCofnij.Enabled = false;
            }
        }

        private void bttnZapisz_Click(object sender, EventArgs e)
        {
            /*deklaracja i utworzenie egzemplarza okna dialowego dla wyboru
             * (lub dla utworzenia nowego pliku do zapisu*/
            SaveFileDialog scOknoZapisuPliku = new SaveFileDialog();

            //ustanawenie flitrów dla plików wyświetlanych w oknie dialogowym
            scOknoZapisuPliku.Filter = "Image Files(.JPG)|.JPG|Image Files(.BMP)|.BMP|Image Files(.GIF)|.GIF|Image Files(.PNG)|.PNG|All files (.)|.";
            //wybor filtru domyśłnego
            scOknoZapisuPliku.FilterIndex = 1;
            //przywracania bieżący katalogu do zamknięciu okna dialogowego
            scOknoZapisuPliku.RestoreDirectory = true;
            //domyślny wybór dysku w oknie dialogowym wyboru pliku
            scOknoZapisuPliku.InitialDirectory = "G:\\";
            //ustalenie tytułu okna dialogowego wyboru pliku
            scOknoZapisuPliku.Title = "Zapisanie danych z Rysownicy w pliku";
            if (scOknoZapisuPliku.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbRysownica.Image.Save(scOknoZapisuPliku.FileName);
                }
                catch
                {
                    MessageBox.Show("Zapisanie jest niemożliwe", "Błod",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bttnOdczytaj_Click(object sender, EventArgs e)
        {
            /*deklaracja i utworzenie egzemplarza okna dialogowego dla wyboru pliku
            do odczytu*/
            OpenFileDialog scOknoOdczytuPliku = new OpenFileDialog();
            //ustawenie filtrów plików, które mogą być pokazane w oknie dialogowym
            scOknoOdczytuPliku.Filter = "Image Files(.JPG)|.JPG|Image Files(.BMP)|.BMP|Image Files(.GIF)|.GIF|Image Files(.PNG)|.PNG|All files (.)|.";
            //wybor filtru domyślnego
            scOknoOdczytuPliku.FilterIndex = 1;
            //przywracanie bieżącego katalogu po zamknięciu okna dialogowego
            scOknoOdczytuPliku.RestoreDirectory = true;
            //domyśly wybór dyskku i folderu w oknie dialogowym wyboru pliku
            scOknoOdczytuPliku.InitialDirectory = "G: \\";
            //ustalenie tytułu okna dialogowego wyboru pliku
            scOknoOdczytuPliku.Title = "Odczytanie (pobranie ) danych z pliku";
            //sprawdzeniee
            if (scOknoOdczytuPliku.ShowDialog() == DialogResult.OK)
            {
                int scx, scy;
                scx = 0;
                scy = 0;
                scRysownica.DrawImage(Image.FromFile(scOknoOdczytuPliku.FileName) , scx, scy);
                pbRysownica.Refresh();
            }
        }

        private void rbKrzywaKardynalna_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKrzywaKardynalna.Checked)
            {
                MessageBox.Show("Aby poprawnie wyrysować Krzywą kardynalną " +
                    ", prosze zaznaczyć na powierhzchni graficznej conajmniej 3 punkty , a następnie naciśnać " +
                    "przycisk : ZAKONCZ","Krzywa kardynalna", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void bttnZakoncz_Click(object sender, EventArgs e)
        {
            if (rbKrzywaKardynalna.Checked)
            {
                gbWybierz.Enabled = true;
                gbAtrybutyGraficzne.Enabled = true;
                scLFG[scLFG.Count - 1].scWykresl(scRysownica);
                bttnZakoncz.Visible = false;
                bttnCofnij.Enabled = true;
                foreach (Control scKontrolka in this.gbWybierz.Controls)
                {
                    if (scKontrolka.GetType().Name == "RadioButton")
                        scKontrolka.Enabled = true;
                }
                pbRysownica.Refresh();
            }
        }
    }
}
