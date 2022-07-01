using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt2_Chalyi_59022.FiguryGeometryczne;
using System.Drawing.Drawing2D;

namespace Projekt2_Chalyi_59022
{
    public partial class PrzezentacjaLososwaZeSlajderem : Form
    {
        //deklaracja pwierhni graficznej
        Graphics scRysownica;
        Punkt[] scTFG;
        int scIndexTFG;
        //deklaracja stalych potomnych
        const int scMarginesformularza = 20;
        const int scMargines = 10;
        public PrzezentacjaLososwaZeSlajderem()
        {
            InitializeComponent();
            //lokalizacja in zwymiarownie formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + scMarginesformularza,
                Screen.PrimaryScreen.Bounds.Y + scMarginesformularza);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.90F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);
            //lokalizacja i zwymiarowanie formularza wedłung podanych ustawień
            this.StartPosition = FormStartPosition.Manual;
            //ustawenie stanu braku aktywności przycisków Maksymalizacji i Minimalizacji
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //lokalizacja i zwymiarowanie kontrolek umieszczonych na formularzu
            lblN.Location = new Point(Left + scMarginesformularza, Top + scMarginesformularza);
            txtN.Location = new Point(lblN.Left + scMarginesformularza, lblN.Top + lblN.Height + scMarginesformularza);
            bttnStart.Location = new Point(lblN.Left, txtN.Top + txtN.Height + scMarginesformularza);
            bttnPrzesun.Location = new Point(lblN.Left - 10, bttnStart.Top + bttnStart.Height + scMarginesformularza);
            bttnWylosuj.Location = new Point(lblN.Left - 10, bttnPrzesun.Top + bttnPrzesun.Height + scMarginesformularza);
            //lokalozacja kontrolki PictureBox
            pbRysownica.Location = new Point(bttnStart.Left + bttnStart.Width + scMarginesformularza,txtN.Top);
            pbRysownica.Width = (int)(this.Width * 0.6F);
            pbRysownica.Height = (int)(this.Height * 0.6F);
            //ustalenie koloru tla kontrolki PictureBox
            pbRysownica.BackColor = Color.White;
            //ustalenie obramowanie kontrolki PiktureBox
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //lokalizacja kontrolki CheckListBox
            chlbFiguryGeometryczne.Location = new Point(pbRysownica.Left + pbRysownica.Width + scMarginesformularza, pbRysownica.Top);
            bttnPowrot.Location = new Point(pbRysownica.Left + pbRysownica.Width + scMarginesformularza, chlbFiguryGeometryczne.Top - 6*scMargines);
            //ustalenie kontrolek dla slajderza
            bttnWlacz.Location = new Point(lblN.Left - 10, lblN.Top + pbRysownica.Height + scMargines);
            bttnWylacz.Location = new Point(lblN.Left - 10, bttnWlacz.Top + bttnWlacz.Height + scMargines);
            gpWyborPokazu.Location = new Point(bttnWylacz.Right + scMargines, pbRysownica.Top + pbRysownica.Height + scMargines);
            bttn_Next.Location = new Point(gpWyborPokazu.Right + scMargines, gpWyborPokazu.Top + scMargines);
            bttnBack.Location = new Point(gpWyborPokazu.Right + scMargines, bttn_Next.Top + bttn_Next.Height + 3);
            lblNF.Location = new Point(bttn_Next.Right + scMargines, gpWyborPokazu.Top + scMargines);
            txtNumerFigury.Location = new Point(bttn_Next.Right + scMargines, lblNF.Top + lblNF.Height + scMargines);
            bttnResetuj.Location = new Point(chlbFiguryGeometryczne.Left, chlbFiguryGeometryczne.Top + chlbFiguryGeometryczne.Height + scMargines);
            //utworzenie egzemplarza powierhni graficznej
            scRysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void PrzezentacjaLososwaZeSlajderem_FormClosed(object sender, FormClosedEventArgs e)
        {
            //zamkniękcie projektu
            Application.Exit();
        }
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtN.Text.Trim()))
                bttnStart.Enabled = false;
            else
                bttnStart.Enabled = true;
        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            ushort scN;
            //wczytanie liczby z tekstbox
            if (!ushort.TryParse(txtN.Text, out scN))
            {
                //wypisanie blędu
                MessageBox.Show("ERROR: w zapisie tej wartości wystąpil niedozwolony znak", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //ustałenie stanu braku sktywności kontrolki textBox
            txtN.ReadOnly = true;
            //sprawdenie czy użytkownik wybrał figur geometrycznych
            if (chlbFiguryGeometryczne.CheckedItems.Count <= 0)
            {
                //wypisanie blędu
                MessageBox.Show(chlbFiguryGeometryczne,"ERROR: musisz wybrać co najmniej jedną z figur geometryczną", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //skopiowanie kolekcji zaznaczonych figur geometrycznych
            CheckedListBox.CheckedItemCollection scWybraneFigury = chlbFiguryGeometryczne.CheckedItems;
            //ustałenie stanu braku aktywności kontrolky CheckedListBox
            chlbFiguryGeometryczne.Enabled = false;
            //ustalenie ilości figur to talicy
            scTFG = new Punkt[scN];
            scIndexTFG = 0;
            Random scrnd = new Random();
            //deklaracja pomocnicza
            int scX, scY;
            Color scKolorLinii, scKolorWypełnenia;
            int scGruboscLinii;
            int scRozmiarPunktu;
            DashStyle scStylLinii;
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //losowe wystawienie polożenie i kolejnych atrybutów figur
            for (int sci = 0; sci < scN; sci++)
            {
                //wyłososwanie polożenia
                scX = scrnd.Next(scMargines, scXmax - scMargines);
                scY = scrnd.Next(scMargines, scYmax - scMargines);
                //wylososwanie kolorów
                scKolorLinii = Color.FromArgb(scrnd.Next(0,255), scrnd.Next(0,255) , scrnd.Next(0,255));
                scKolorWypełnenia = Color.FromArgb(scrnd.Next(0, 255), scrnd.Next(0, 255), scrnd.Next(0, 255));
                //wyłososwanie grubości linii
                scGruboscLinii = scrnd.Next(1,11);
                //wyłososwanie styłu linii
                switch (scrnd.Next(1, 6))
                {
                    case 1: scStylLinii = DashStyle.Dash; break;
                    case 2: scStylLinii = DashStyle.DashDot; break;
                    case 3: scStylLinii = DashStyle.DashDotDot; break;
                    case 4: scStylLinii = DashStyle.Dot; break;
                    default: scStylLinii = DashStyle.Solid; break;
                }
                        //wyłososwanie figury geometrycznej
                        int scWylosowanyIndeksFigury = scrnd.Next(scWybraneFigury.Count);
                        //ropoczęcie wyłosowania
                        switch (scWybraneFigury[scWylosowanyIndeksFigury].ToString())
                        {
                            case "Punkt"://utworzenie egzemplarza klasy Punkt
                                scTFG[scIndexTFG] = new Punkt(scX, scY);
                                //wyłososwanie rozmiaru Punktu
                                scRozmiarPunktu = scrnd.Next(2, 11);
                                //ustalenie atrybutów graficznych i geometrycznych
                                scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scRozmiarPunktu);
                                //wykreślenie wyłosowanej figury geometrycznych
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                scIndexTFG++; 
                                break;
                            case "Linia":
                                int scXk = scrnd.Next(scMargines , scXmax - scMargines);
                                int scYk = scrnd.Next(scMargines, scYmax - scMargines);
                                //utworzenie egzemplarza klasy Linia
                                scTFG[scIndexTFG] = new Linia(scX, scY , scXk , scYk);
                                //ustalenie atrybutów graficznych i geometrycznych
                                scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                                //wykreślenie wyłosowanej figury geometrycznych 
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                scIndexTFG++;
                                break;
                            case "Elipsa":
                                int scOsDuza = scrnd.Next(scMargines, scXmax / 4 - scMargines);
                                int scOsMala = scrnd.Next(scMargines, scYmax/ 4 - scMargines);
                                scTFG[scIndexTFG] = new Elipsa(scX, scY, scOsDuza ,scOsMala);
                                //ustalenie atrybutów graficznych i geometrycznych
                                scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                                //wykreślenie wyłosowanej figury geometrycznych 
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                scIndexTFG++;
                                break;
                            case "Okrąg":
                                int scPromien = scrnd.Next(scMargines , scYmax/4);
                                scTFG[scIndexTFG] = new Okrąg(scX, scY, scPromien);
                                //ustalenie atrybutów graficznych i geometrycznych
                                scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                                //wykreślenie wyłosowanej figury geometrycznych 
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                scIndexTFG++;
                                break;
                            case "Prostokąt":
                                int scSzyrokosc = scrnd.Next(scMargines, scXmax/4 - scMargines);
                                int scWysokosc = scrnd.Next(scMargines, scYmax/4 - scMargines);
                                scTFG[scIndexTFG] = new Prostokąt(scX, scY, scSzyrokosc, scWysokosc);
                                 //ustalenie atrybutów graficznych i geometrycznych
                                 scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                                //wykreślenie wyłosowanej figury geometrycznych 
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                 scIndexTFG++;
                                break;
                            case "Kwadrat":
                                 int scStorona = scrnd.Next(scMargines, scYmax / 4);
                                 scTFG[scIndexTFG] = new Kwadrat(scX, scY, scStorona);
                                 //ustalenie atrybutów graficznych i geometrycznych
                                 scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                                 //wykreślenie wyłosowanej figury geometrycznych 
                                 scTFG[scIndexTFG].scWykresl(scRysownica);
                                 scIndexTFG++;
                                break;
                           case "Kolo":
                             int scPromienKola = scrnd.Next(scMargines, scYmax / 4);
                             scTFG[scIndexTFG] = new Kolo(scX, scY,scPromienKola);
                             //ustalenie atrybutów graficznych i geometrycznych
                                scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorWypełnenia);
                                //wykreślenie wyłosowanej figury geometrycznych 
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                 scIndexTFG++;
                             break;
                          case "Wielokąt":
                                int scRadius = scrnd.Next(scMargines, scYmax / 4);
                                int scIloscKatow = scrnd.Next(5,10);
                                scTFG[scIndexTFG] = new Wielokąt(scX , scY, scRadius);
                                //ustalenie atrybutów graficznych i geometrycznych
                                 scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                                 //wykreślenie wyłosowanej figury geometrycznych 
                                scTFG[scIndexTFG].scWykresl(scRysownica);
                                scIndexTFG++;
                                break;
                          case "FillElipse":
                               int scOsDuzaElipse2 = scrnd.Next(scMargines, scXmax / 4 - scMargines);
                               int scOsMalaElipse2 = scrnd.Next(scMargines, scYmax / 4 - scMargines);
                               scTFG[scIndexTFG] = new FillElipsa(scX, scY, scOsDuzaElipse2, scOsMalaElipse2);
                               //ustalenie atrybutów graficznych i geometrycznych
                              scTFG[scIndexTFG].scUstalAtrybutyGraficzne(scKolorWypełnenia);
                               //wykreślenie wyłosowanej figury geometrycznych 
                                 scTFG[scIndexTFG].scWykresl(scRysownica);
                             scIndexTFG++;
                                 break;
                }
                

            }
            pbRysownica.Refresh();
            //ustalene stanu braku aktywności
            bttnStart.Enabled = false;
            //uaktywenie innych kontrolek
            bttnPrzesun.Enabled = true;
            bttnWylosuj.Enabled = true;
            bttnWlacz.Enabled = true;
            gpWyborPokazu.Enabled = true;
            bttnResetuj.Enabled = true;
            msPlik.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Foma = new FormGlowna();
            this.Hide();
            Foma.Show();

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
            for (int sci = 0; sci<scTFG.Length;sci++)
            {//wylosowanie nowego polożenia
                scXp = scrnd.Next(scMargines, scXmax - scMargines);
                scYp = scrnd.Next(scMargines, scYmax - scMargines);
                scTFG[sci].scPresunDoNowegoXY(pbRysownica,scRysownica,scXp,scYp);
            }
            //odwiaczenie powierhni graficznej
            pbRysownica.Refresh();
        }

        private void bttnWylosuj_Click(object sender, EventArgs e)
        {//deklaracje pomocnicz
            Random scrnd = new Random();
            int scXp, scYp;
            Color scKolorLinii, scKolorWypelnenia;
            int scGruboscLinii;
            DashStyle scStylLinii;
            int scXmax, scYmax;
            //oczyszczenie powierhni graficznej
            scRysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiarów powierhni graficznej
            scXmax = pbRysownica.Width;
            scYmax = pbRysownica.Height;
            //losowanie atrybutów geometrycznych
            for (int sci = 0;sci < scTFG.Length; sci++)
            { //wylososwanie kolorów
                scKolorLinii = Color.FromArgb(scrnd.Next(0, 255), scrnd.Next(0, 255), scrnd.Next(0, 255));
                scKolorWypelnenia = Color.FromArgb(scrnd.Next(0, 255), scrnd.Next(0, 255), scrnd.Next(0, 255));
                //wyłososwanie grubości linii
                scGruboscLinii = scrnd.Next(1, 11);
                //wyłososwanie styłu linii
                switch (scrnd.Next(1, 6))
                {
                    case 1: scStylLinii = DashStyle.Dash; break;
                    case 2: scStylLinii = DashStyle.DashDot; break;
                    case 3: scStylLinii = DashStyle.DashDotDot; break;
                    case 4: scStylLinii = DashStyle.Dot; break;
                    default: scStylLinii = DashStyle.Solid; break;
                }
                //ustalenie nowych atrybutów graficznych
                scTFG[sci].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                scTFG[sci].scUstalAtrybutyGraficzne(scKolorWypelnenia);
                //ustalenie nowego polożenia
                scXp = scrnd.Next(scMargines, scXmax-scMargines);
                scYp = scrnd.Next(scMargines, scYmax - scMargines);
                //przesunięcie figury no nowych koordynatów
                scTFG[sci].scPresunDoNowegoXY(pbRysownica,scRysownica,scXp,scYp);
            }
            //odświedczenie powierhni graficznej
            pbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wymażenie całej powierhni graficznej
            scRysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiaru powierzchni graficznej
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //wpisanie do kontrolki slajder indeksu TFG pokazywnej figury
            txtNumerFigury.Text = timer1.Tag.ToString();
            //wykreślenie figury o indeksie timer1.Tag w żrodku powierzchni grfaficznej
            scTFG[(int)(timer1.Tag)].scPresunDoNowegoXY(pbRysownica,scRysownica,
                scXmax/2,scYmax/2);
            //odświedczenie powierzchni graficznej
            pbRysownica.Refresh();
            //wyznazenie indeksu w polu timer1.Tag
            timer1.Tag = ((int)timer1.Tag + 1) % scTFG.Length;

        }

        private void bttnWlacz_Click(object sender, EventArgs e)
        {
            //wyczyszczenie rysownicy
            scRysownica.Clear(pbRysownica.BackColor);
            //ustawienie indeksu pierwszej figury zapisanej w TFG
            timer1.Tag = 0;
            txtNumerFigury.Text = 0.ToString();
            //wyznaczenie rozmiaru Rysownicy
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //trzeba bęzie zmienić kod
            scTFG[0].scPresunDoNowegoXY(pbRysownica,scRysownica, scXmax/2, scYmax/2);
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
            //ustawenie stanu aktywności
            bttnWylacz.Enabled = true;
            bttnResetuj.Enabled = false;
            msPlik.Enabled = false;
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
            for (int sci = 0; sci < scTFG.Length; sci++) 
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
                scTFG[sci].scUstalAtrybutyGraficzne(scKolorLinii, scStylLinii, scGruboscLinii);
                scTFG[sci].scUstalAtrybutyGraficzne(scKolorWypelnenia);
                //ustalenie nowego polożenia
                scX = scrnd.Next(scMargines, scXmax - scMargines);
                scY = scrnd.Next(scMargines, scYmax - scMargines);
                //przesunięcie figury no nowych koordynatów
                scTFG[sci].scPresunDoNowegoXY(pbRysownica, scRysownica, scX, scY);
            }
            pbRysownica.Refresh();
            //ustalenie stanu braku aktywności
            bttnWylacz.Enabled = false;
            bttn_Next.Enabled = false;
            bttnBack.Enabled = false;
            txtNumerFigury.Enabled = false;
            txtNumerFigury.Text = 0.ToString();
            radioButtonAutomatyczny.Checked = true;
            bttnResetuj.Enabled = true;
            msPlik.Enabled = true;
        }

        private void bttn_Next_Click(object sender, EventArgs e)
        {
            ushort scIndeksFigury;
            //pobrenie wartości indeksu z kontrolki textNumerFigury
            if(!ushort.TryParse(txtNumerFigury.Text, out scIndeksFigury))
            {
                MessageBox.Show("ERROR: w zapisie indeksu figury do prezentacji wystąpił" +
                    " niedozwolony znak", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //sprawdzenie wartośći
            if ((scIndeksFigury < 0) || (scIndeksFigury >= scTFG.Length))
            {
                MessageBox.Show("ERROR: przekroczenie indeksów TFG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //wyznaczenie rozmiarów powierhzchni geometrycznej
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //wymażenie aktualnej wykreślonej figury geometrycznej
            scRysownica.Clear(pbRysownica.BackColor);
            //przesunięcie figury do sródka risownicy
            scTFG[scIndeksFigury].scPresunDoNowegoXY(pbRysownica,scRysownica, scXmax/2 , scYmax/2);
            //odświadczenie powierzchni graficznej
            pbRysownica.Refresh();
            if (scIndeksFigury < scTFG.Length - 1)
                scIndeksFigury++;
            else
                scIndeksFigury = 0;
            txtNumerFigury.Text = scIndeksFigury.ToString();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
             ushort scIndeksFigury;
            //pobrenie wartości indeksu z kontrolki textNumerFigury
            if(!ushort.TryParse(txtNumerFigury.Text, out scIndeksFigury))
            {
                MessageBox.Show("ERROR: w zapisie indeksu figury do prezentacji wystąpił" +
                    " niedozwolony znak", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //sprawdzenie wartośći
            if ((scIndeksFigury < 0) || (scIndeksFigury >= scTFG.Length))
            {
                MessageBox.Show("ERROR: przekroczenie indeksów TFG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //wyznaczenie rozmiarów powierhzchni geometrycznej
            int scXmax = pbRysownica.Width;
            int scYmax = pbRysownica.Height;
            //wymażenie aktualnej wykreślonej figury geometrycznej
            scRysownica.Clear(pbRysownica.BackColor);
            //przesunięcie figury do sródka risownicy
            scTFG[scIndeksFigury].scPresunDoNowegoXY(pbRysownica,scRysownica, scXmax/2 , scYmax/2);
            //odświadczenie powierzchni graficznej
            pbRysownica.Refresh();
            if (scIndeksFigury > 0)
                scIndeksFigury--;
            else
                scIndeksFigury = (ushort)(scTFG.Length - 1);
            txtNumerFigury.Text = scIndeksFigury.ToString();
        }

        private void bttnResetuj_Click(object sender, EventArgs e)
        {   
            //oczyszczenie rysownicy
            scRysownica.Clear(pbRysownica.BackColor);
            //ustalenie zwycznego koloruTla Rysownicy
            pbRysownica.BackColor = Color.White;
            //oczyszczenie tekstu z tekstboxa
            txtN.Text = null;
            txtN.ReadOnly = false;
            //ustalenie staniu aktywności chlb
            chlbFiguryGeometryczne.Enabled = true;
            bttnPrzesun.Enabled = false;
            bttnWylosuj.Enabled = false;
            bttnWlacz.Enabled = false;
            bttnWylacz.Enabled = false;
            gpWyborPokazu.Enabled = false;
            msPlik.Enabled = false;
            //zerowanie TFG
            scTFG = new Punkt[0];
            //wyświetleie pustej rysownicy
            pbRysownica.Refresh();
        }

        private void zapiszBitmapeWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void msZmienic_Click(object sender, EventArgs e)
        {
            ColorDialog scKolorDialog = new ColorDialog();
            scKolorDialog.Color = pbRysownica.BackColor;

            if (scKolorDialog.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.BackColor = scKolorDialog.Color;
            }
            scKolorDialog.Dispose();
        }

        private void msOdczytaj_Click(object sender, EventArgs e)
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
                scRysownica.DrawImage(Image.FromFile(scOknoOdczytuPliku.FileName), scx, scy);
                pbRysownica.Refresh();
            }
        }
    }
}
