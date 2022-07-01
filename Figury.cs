using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dodanie nowych przestrzeni nazw dal potrzeb grafiki 2D
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Projekt2_Chalyi_59022
{
    class FiguryGeometryczne
    { //deklracja klasy Punkt
        public class Punkt
        {//deklaracja klasy bazowej
            const int DomyslnyRozmiarPunktu = 20;
            protected int scX;
            protected int scY;
            protected int scGruboscLinii;
            protected Color scKolor;
            protected bool scWidoczny;
            //deklaracj atrybutów wspólnych dla klas potomnych
            protected Color scKolorTla;
            protected DashStyle scStylLinii;

            //deklaracja konstruktorska
            public Punkt(int x, int y)
            {
                scX = x; scY = y;
                scKolor = Color.Black;
                scKolorTla = Color.White;
                scStylLinii = DashStyle.Solid;
                scGruboscLinii = DomyslnyRozmiarPunktu;
                scWidoczny = false;
            }
            public Punkt(int x, int y, Color Kolor) : this(x, y)
            {
                this.scKolor = Kolor;
            }
            public Punkt(int x, int y, Color Kolor, int RozmiarPunktu) : this(x, y, Kolor)
            {
                scGruboscLinii = RozmiarPunktu;
            }
            public Punkt(int x, int y, Color Kolor, DashStyle StylLinii, int RozmiarPunktu) : this(x, y, Kolor)
            {
                this.scStylLinii = StylLinii;
                scGruboscLinii = RozmiarPunktu;
            }
            //deklaracja metod
            public virtual void scUstawXY(int x, int y)
            {
                this.scX = x;
                this.scY = y;
            }
            private void scUaktualnijXY(Point NowaLokalizacja)
            {
                scX = NowaLokalizacja.X;
                scY = NowaLokalizacja.Y;
            }
            public void scUstalAtrybutyGraficzne(Color KolorLinii, DashStyle StylLinii,
                int GruboscLinii)
            {
                scKolor = KolorLinii;
                this.scStylLinii = StylLinii;
                this.scGruboscLinii = GruboscLinii;
            }
            public void scUstalAtrybutyGraficzne(Color KolorTla)
            {
                this.scKolorTla = KolorTla;
            }
            protected void scUstalStylLinii(DashStyle StylLinii)
            {
                this.scStylLinii = StylLinii;
            }
            public virtual void scWykresl(Graphics scRysownica)
            {
                SolidBrush scPedzel = new SolidBrush(scKolor);
                scRysownica.FillEllipse(scPedzel, scX - scGruboscLinii / 2,
                    scY - scGruboscLinii / 2, scGruboscLinii, scGruboscLinii);
                scWidoczny = true;
                scPedzel.Dispose();
            }
            public virtual void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (this.scWidoczny)
                {
                    SolidBrush scPedzel = new SolidBrush(scKontrolka.BackColor);
                    scRysownica.FillEllipse(scPedzel, scX - scGruboscLinii / 2,
                        scY - scGruboscLinii / 2, scGruboscLinii, scGruboscLinii);
                    scWidoczny = false;
                    scPedzel.Dispose();
                }
            }
            public virtual void scPresunDoNowegoXY(Control scKontrolka,
                Graphics scRysownica, Point scNowaLokalizacja)
            {
                scUaktualnijXY(scNowaLokalizacja);
                scWykresl(scRysownica);
            }
            public virtual void scPresunDoNowegoXY(Control scKontrolka,
                Graphics scRysownica, int x, int y)
            {
                scUstawXY(x, y);
                scWykresl(scRysownica);
            }
        }

        //deklaracja klasy Linia
        public class Linia : Punkt
        { //deklaracja dla przecowywania wspólrzędnych końca Linii
            int scXk, scYk;
            //deklaracja konstruktorska
            public Linia(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp)
            {
                this.scXk = Xk;
                this.scYk = Yk;
            }
            public Linia(int Xp, int Yp, int Xk, int Yk, Color KolorLininii,
                DashStyle StylLinii, int GruboscLinii) : base(Xp, Yp, KolorLininii, StylLinii, GruboscLinii)
            {
                this.scXk = Xk;
                this.scYk = Yk;
            }
            //deklaracja metodów
            public override void scWykresl(Graphics scRysownica)
            {
                Pen scPioro = new Pen(scKolor, this.scGruboscLinii);
                //ustalenie stylu linii
                scPioro.DashStyle = scStylLinii;
                //wykreślenie linii
                scRysownica.DrawLine(scPioro, scX, scY, scXk, scYk);
                scWidoczny = true;
                scPioro.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Pen scPioro = new Pen(scKontrolka.BackColor, this.scGruboscLinii);
                    //ustalenie stylu linii
                    scPioro.DashStyle = scStylLinii;
                    //wykreślenie linii
                    scRysownica.DrawLine(scPioro, scX, scY, scXk, scYk);
                    scWidoczny = false;
                    scPioro.Dispose();
                }
            }
            public override void scPresunDoNowegoXY(Control scKontrolka, Graphics scRysownica, int x, int y)
            {
                //deklaracja zmiennych dla wyznaczeni e wektora
                int scdx, scdy;
                //wyznaczenie przyrostu zmian współrzędnych X oraz Y
                if (x > scX)
                    scdx = x - scX;
                else
                    scdx = scX - x;
                if (y > scY)
                    scdy = y - scY;
                else
                    scdy = scY - y;
                //zmiana wsółrędniej początku linii
                scX = x; scY = y;
                scXk = (scXk + scdx) % scKontrolka.Width;
                scYk = (scYk + scdy) % scKontrolka.Height;
                scWykresl(scRysownica);
            }

        }

        //deklaracja klasy Elipsa
        public class Elipsa : Punkt
        {
            protected int scOsDuza, scOsMala;
            //deklaracja konstruktorska
            public Elipsa(int x, int y, int OsDuza, int OsMala) : base(x, y)
            {
                this.scOsDuza = OsDuza;
                this.scOsMala = OsMala;
            }
            public Elipsa(int x, int y, int OsDuza, int OsMala, Color KolorLininii,
                DashStyle StylLinii, int GruboscLinii) : base(x, y, KolorLininii, StylLinii, GruboscLinii)
            {
                this.scOsDuza = OsDuza;
                this.scOsMala = OsMala;
            }

            //deklracja metod
            public override void scWykresl(Graphics scRysownica)
            {
                Pen scPioro = new Pen(scKolor, this.scGruboscLinii);
                scPioro.DashStyle = scStylLinii;
                scRysownica.DrawEllipse(scPioro, scX , scY, scOsDuza, scOsMala);
                scWidoczny = true;
                scPioro.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Pen scPioro = new Pen(scKontrolka.BackColor, this.scGruboscLinii);
                    scPioro.DashStyle = scStylLinii;
                    scRysownica.DrawEllipse(scPioro, scX , scY, scOsDuza, scOsMala);
                    scWidoczny = false;
                    scPioro.Dispose();
                }
            }
        }

        //deklaracja klasy FillElipsa
        public class FillElipsa : Elipsa
        {
            public FillElipsa(int x, int y, int OsDuza, int OsMala) : base(x, y , OsDuza , OsMala)
            {
            }
            public FillElipsa(int x, int y, int OsDuza, int OsMala, Color KolorTla,
                DashStyle StylLinii, int GruboscLinii) : base(x, y, OsDuza, OsMala)
            {
                this.scKolorTla = KolorTla;
            }

            //deklracja metod
            public override void scWykresl(Graphics scRysownica)
            {
                Brush scPieziel = new SolidBrush(scKolorTla);
                scRysownica.FillEllipse(scPieziel, scX, scY, scOsDuza, scOsMala);
                scWidoczny = true;
                scPieziel.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Brush scPieziel = new SolidBrush(scKolorTla);
                    scRysownica.FillEllipse(scPieziel, scX, scY, scOsDuza, scOsMala);
                    scWidoczny = true;
                    scPieziel.Dispose();
                }
            }
        }

        //deklaracja klsy Okrąg
        public class Okrąg : Elipsa
        {
            protected int scPromien;
            public Okrąg(int x, int y, int Promien) : base(x, y, 2 * Promien, 2 * Promien)
            {
                this.scPromien = Promien;
            }
            public Okrąg(int x, int y, int Promien, Color KolorLininii,
                DashStyle StylLinii, int GruboscLinii) : base(x, y, 2 * Promien, 2 * Promien, KolorLininii, StylLinii, GruboscLinii)
            {
                this.scPromien = Promien;
            }
            public override void scWykresl(Graphics scRysownica)
            {
                Pen scPioro = new Pen(scKolor, this.scGruboscLinii);
                scPioro.DashStyle = scStylLinii;
                scRysownica.DrawEllipse(scPioro, scX, scY, 2 * scPromien, 2 * scPromien);
                scWidoczny = true;
                scPioro.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Pen scPioro = new Pen(scKontrolka.BackColor, this.scGruboscLinii);
                    scPioro.DashStyle = scStylLinii;
                    scRysownica.DrawEllipse(scPioro, scX , scY, 2 * scPromien, 2 * scPromien);
                    scWidoczny = false;
                    scPioro.Dispose();
                }
            }
        }

        //deklaracja klasy Kolo
        public class Kolo : Okrąg
        {
            //deklaracja konstruktorska
            public Kolo(int x, int y, int Promien) : base(x, y, Promien)
            {
            }
            public Kolo(int x, int y, int Promien, Color KolorTla) : base(x, y, Promien)
            {
                this.scKolorTla = KolorTla;
            }

            //deklaracja metodów
            public override void scWykresl(Graphics scRysownica)
            {
                Brush scPieziel = new SolidBrush(scKolorTla);
                scRysownica.FillEllipse(scPieziel, scX , scY , 2 * scPromien, 2 * scPromien);
                scWidoczny = true;
                scPieziel.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Brush scPieziel = new SolidBrush(scKontrolka.BackColor);
                    scRysownica.FillEllipse(scPieziel, scX, scY, 2 * scPromien, 2 * scPromien);
                    scWidoczny = false;
                    scPieziel.Dispose();
                }
            }
        }

        //deklracja klasy Prostokąt
        public class Prostokąt : Punkt
        {
            protected int scSzyrokosc, scWysokosc;
            //deklaracja konstruktorska
            public Prostokąt(int x, int y, int szyrokosc, int wysokosc) : base(x, y)
            {
                this.scWysokosc = wysokosc;
                this.scSzyrokosc = szyrokosc;
            }
            public Prostokąt(int x, int y, int szyrokosc, int wysokosc, Color KolorLininii,
               DashStyle StylLinii, int GruboscLinii) : base(x, y, KolorLininii, StylLinii, GruboscLinii)
            {
                this.scWysokosc = wysokosc;
                this.scSzyrokosc = szyrokosc;
            }
            //deklracja metodów
            public override void scWykresl(Graphics scRysownica)
            {
                Pen scPioro = new Pen(scKolor, this.scGruboscLinii);
                scPioro.DashStyle = scStylLinii;
                scRysownica.DrawRectangle(scPioro, scX, scY , scSzyrokosc , scWysokosc);
                scWidoczny = true;
                scPioro.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Pen scPioro = new Pen(scKontrolka.BackColor, this.scGruboscLinii);
                    scPioro.DashStyle = scStylLinii;
                    scRysownica.DrawRectangle(scPioro, scX, scY, scSzyrokosc, scWysokosc);
                    scWidoczny = false;
                    scPioro.Dispose();
                }
            }
        }

        //deklaracja klasy Kwadrat
        public class Kwadrat : Prostokąt
        {
            protected int scStorona;
            //deklracja konstruktorska
            public Kwadrat(int x, int y, int Storona) : base(x, y, Storona, Storona)
            {
                this.scStorona = Storona;

            }
            public Kwadrat(int x, int y, int Storona, Color KolorLininii,
              DashStyle StylLinii, int GruboscLinii) : base(x, y,Storona,Storona, KolorLininii, StylLinii, GruboscLinii)
            {
                this.scStorona = Storona;
            }
            //deklaracja metodów
            public override void scWykresl(Graphics scRysownica)
            {
                Pen scPioro = new Pen(scKolor, this.scGruboscLinii);
                scPioro.DashStyle = scStylLinii;
                scRysownica.DrawRectangle(scPioro, scX, scY, scStorona, scStorona);
                scWidoczny = true;
                scPioro.Dispose();
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Pen scPioro = new Pen(scKontrolka.BackColor, this.scGruboscLinii);
                    scPioro.DashStyle = scStylLinii;
                    scRysownica.DrawRectangle(scPioro, scX, scY, scStorona, scStorona);
                    scWidoczny = false;
                    scPioro.Dispose();
                }
            }
        }


        //deklaracja klsy Wielokąt
        public class Wielokąt : Punkt
        {
            protected int scRadius;
            public Wielokąt(int x, int y, int Radius) : base(x, y)
            {
                this.scRadius = Radius;
            }
            public Wielokąt(int x, int y, int Radius, Color scKolor,
               DashStyle StylLinii, int GruboscLinii) : base(x, y, scKolor,
                StylLinii,  GruboscLinii)
            {
                this.scRadius = Radius;
            }
            public override void scWykresl(Graphics scRysownica)
            {

                Pen scPioro = new Pen(scKolor, scGruboscLinii);
                scPioro.DashStyle = scStylLinii;

                Point[] scPoint ={
                   new Point(scX, scY),
                    new Point(scX + scRadius / 2, scY),
                    new Point(scX + scRadius / 2 + scRadius / 4, scY + scRadius / 2),
                   new Point(scX + scRadius / 2, scY + scRadius),
                    new Point(scX, scY + scRadius),
                     new Point(scX - scRadius / 4, scY + scRadius / 2),
                                  };
                scRysownica.DrawPolygon(scPioro, scPoint);
                scWidoczny = true;
                scPioro.Dispose();
            }

            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if(scWidoczny)
                {
                    Pen scPioro = new Pen(scKontrolka.BackColor, scGruboscLinii);
                    scPioro.DashStyle = scStylLinii;

                    Point[] scPoint ={
                   new Point(scX, scY),
                    new Point(scX + scRadius / 2, scY),
                    new Point(scX + scRadius / 2 + scRadius / 4, scY + scRadius / 2),
                   new Point(scX + scRadius / 2, scY + scRadius),
                    new Point(scX, scY + scRadius),
                     new Point(scX - scRadius / 4, scY + scRadius / 2),
                                  };
                    scRysownica.DrawPolygon(scPioro, scPoint);
                    scPioro.Dispose();
                }
            }


        }

        //deklaracje klasy WielokątWypiełniony
        public class WielokątWypiełniony : Wielokąt
        {
            public WielokątWypiełniony(int x, int y, int Radius) : base( x,  y,  Radius)
            { }
            public WielokątWypiełniony(int x, int y, int Radius, Color KolorTla) : base (x, y, Radius)
            {
                this.scKolorTla = KolorTla;
            }
            public override void scWykresl(Graphics scRysownica)
            {

                Brush scPedzel = new SolidBrush(scKolorTla);
                Point[] scPoint ={
                   new Point(scX, scY),
                    new Point(scX + scRadius / 2, scY),
                    new Point(scX + scRadius / 2 + scRadius / 4, scY + scRadius / 2),
                   new Point(scX + scRadius / 2, scY + scRadius),
                    new Point(scX, scY + scRadius),
                     new Point(scX - scRadius / 4, scY + scRadius / 2),
                                  };
                scRysownica.FillPolygon(scPedzel, scPoint);
                scWidoczny = true;
                scPedzel.Dispose();
            }

            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {
                    Brush scPedzel = new SolidBrush(scKontrolka.BackColor);
                    Point[] scPoint ={
                   new Point(scX, scY),
                    new Point(scX + scRadius / 2, scY),
                    new Point(scX + scRadius / 2 + scRadius / 4, scY + scRadius / 2),
                   new Point(scX + scRadius / 2, scY + scRadius),
                    new Point(scX, scY + scRadius),
                     new Point(scX - scRadius / 4, scY + scRadius / 2),
                                  };
                    scRysownica.FillPolygon(scPedzel, scPoint);
                    scWidoczny = false;
                    scPedzel.Dispose();
                }
            }
        }

        //deklaracja klasy dla linii ciąglej kreślonej myszą
        public class LiniaKreślonaMyszą: Punkt
        {
            //deklaracja listy punktów
            List<Point> scListaPunktów = new List<Point>();
            //deklaracja konstruktorów
            public LiniaKreślonaMyszą(Point scPoczątekLinii) : base(scPoczątekLinii.X , scPoczątekLinii.Y)
            {
                scListaPunktów.Add(scPoczątekLinii);
            }
            public LiniaKreślonaMyszą(Point scPoczatekLinii, Color scKolor, DashStyle scStylLinii,
                int scGruboscLinii) : base (scPoczatekLinii.X , scPoczatekLinii.Y, scKolor, scStylLinii, scGruboscLinii)
            {
                scListaPunktów.Add(scPoczatekLinii);
            }
            //deklaracja metod
            public void DodajNowyPunktkreslonejLinii(Point scNowyPunkt)
            {
                scListaPunktów.Add(scNowyPunkt);
            }
            //deklaracja metod nadpisujących metody wirtualne klasy Punkt
            public override void scUstawXY(int x, int y)
            {
                if (scListaPunktów.Count < 1)
                    //lista jest pusta
                    return;
                //deklaracja zmiennych
                int scPrzyrostX = scListaPunktów[0].X - x;
                int scPrzyrostY = scListaPunktów[0].Y - y;
                //zmiama polożenia wszystkich punktów linii kreślonej myszą
                for (int sci = 0; sci < scListaPunktów.Count; sci++)
                    scListaPunktów[sci] = new Point(scListaPunktów[sci].X - scPrzyrostX, 
                        scListaPunktów[sci].Y - scPrzyrostY);
            }
            public override void scWykresl(Graphics scRysownica)
            {
                //deklaracja pomocnicze
                Point[] scTablicaPunktow = new Point[scListaPunktów.Count];
                //przepisanie współtrzędnych wszystkich punktów wykreślonej linii myszą
                for (int sci = 0; sci < scListaPunktów.Count; sci++)
                    scTablicaPunktow[sci] = scListaPunktów[sci];
                //wykreślenie linii
                Pen scPioro = new Pen(scKolor, scGruboscLinii);
                scPioro.DashStyle = scStylLinii;
                scRysownica.DrawLines(scPioro, scTablicaPunktow);
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                //deklaracja pomocnicze
                Point[] scTablicaPunktow = new Point[scListaPunktów.Count];
                //przepisanie współtrzędnych wszystkich punktów wykreślonej linii myszą
                for (int sci = 0; sci < scListaPunktów.Count; sci++)
                    scTablicaPunktow[sci] = scListaPunktów[sci];
                //wykreślenie linii
                Pen scPioro = new Pen(scKontrolka.BackColor, scGruboscLinii);
                scPioro.DashStyle = scStylLinii;
                scRysownica.DrawLines(scPioro, scTablicaPunktow);
            }
        }

        //deklaracja klasy krzywa Berziera
        public class KrzywaBeziera : Punkt
        {
            //deklaracja listu punktów
            public List<Point> scPunktyKontrolneKrzywejBeziera = new  List<Point>();
            //rozmiar punktu kontrolnego
            int scPromieńPunktuKontrolnego = 5;
            public ushort scLiczbaPunktówKontrolnych
            {
                get;
                set;
            }
            //deklaracja Fontru opisu punktu kontrolnego
            Font scFontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);
            //deklaracja konstruktorska
            public KrzywaBeziera(Graphics Rysownica, Pen Pioro, Point XYpunktu) : 
                base (XYpunktu.X, XYpunktu.Y,Pioro.Color, (int)Pioro.Width)
            {
                scPunktyKontrolneKrzywejBeziera.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Pioro.Color))
                {
                    //wykreślenie punktu kontrolnego
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - scPromieńPunktuKontrolnego,
                        XYpunktu.Y - scPromieńPunktuKontrolnego, 2 * scPromieńPunktuKontrolnego,
                        2 * scPromieńPunktuKontrolnego);
                    //wykreslenie opisu punktu kontrolnego
                    Rysownica.DrawString("p" + (scPunktyKontrolneKrzywejBeziera.Count - 1).ToString(),
                        scFontOpisuPunktów, Pedzel, scPunktyKontrolneKrzywejBeziera[scPunktyKontrolneKrzywejBeziera.Count - 1]);
                }
            }

            //deklaracja metod
            public void scDodajNowyPunktkontrolnych(Point XYpunktu , Graphics Rysownica)
            {
                scPunktyKontrolneKrzywejBeziera.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Color.Red))
                {
                    //wykreślenie punktu kontrolnego
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - scPromieńPunktuKontrolnego,
                        XYpunktu.Y - scPromieńPunktuKontrolnego, 2 * scPromieńPunktuKontrolnego,
                        2 * scPromieńPunktuKontrolnego);
                    //wykreslenie opisu punktu kontrolnego
                    Rysownica.DrawString("p" + (scPunktyKontrolneKrzywejBeziera.Count - 1).ToString(),
                        scFontOpisuPunktów, Pedzel, scPunktyKontrolneKrzywejBeziera[scPunktyKontrolneKrzywejBeziera.Count - 1]);
                    //sprawdzenie czy to jest już 4 punkt kontrolny
                    if (scPunktyKontrolneKrzywejBeziera.Count == 4)
                        scWykresl(Rysownica);
                }
            }

            public override void scWykresl(Graphics scRysownica)
            {
                using (Pen Pioro = new Pen(scKolor, scGruboscLinii))
                {
                    Pioro.DashStyle = scStylLinii;
                    //deklaracja i utorzenie egzemplarza tablicy
                    Point[] scPunktyKontrolne = new Point[scPunktyKontrolneKrzywejBeziera.Count];
                    //przepisanie do tablicy punktów z listy
                    for (ushort sci = 0; sci < scPunktyKontrolneKrzywejBeziera.Count; sci++)
                        scPunktyKontrolne[sci] = new Point(scPunktyKontrolneKrzywejBeziera[sci].X, scPunktyKontrolneKrzywejBeziera[sci].Y);
                    //wykreślenie krzywej Beziera
                    scRysownica.DrawBezier(Pioro, scPunktyKontrolne[0], scPunktyKontrolne[1], scPunktyKontrolne[2], scPunktyKontrolne[3]);
                    scWidoczny = true;
                }
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
                if (scWidoczny)
                {

                    using (Pen Pioro = new Pen(scKontrolka.BackColor, scGruboscLinii))
                    {
                        Pioro.DashStyle = scStylLinii;
                        //deklaracja i utorzenie egzemplarza tablicy
                        Point[] scPunktyKontrolne = new Point[scPunktyKontrolneKrzywejBeziera.Count];
                        //przepisanie do tablicy punktów z listy
                        for (ushort sci = 0; sci < scPunktyKontrolneKrzywejBeziera.Count; sci++)
                            scPunktyKontrolne[sci] = new Point(scPunktyKontrolneKrzywejBeziera[sci].X, scPunktyKontrolneKrzywejBeziera[sci].Y);
                        //wykreślenie krzywej Beziera
                        scRysownica.DrawBezier(Pioro, scPunktyKontrolne[0], scPunktyKontrolne[1], scPunktyKontrolne[2], scPunktyKontrolne[3]);
                        scWidoczny = false;
                    }
                }
            }
            public override void scUstawXY(int x, int y)
            {
                //deklaracja pomocnicze
                int scPrzyrostX = scPunktyKontrolneKrzywejBeziera[0].X - x;
                int scPrzyrostY = scPunktyKontrolneKrzywejBeziera[0].Y - y;

                //dokonanie zmian wartości współrzędnych wszystkich punktów kontrolnych
                for (int sci = 0; sci < scPunktyKontrolneKrzywejBeziera.Count; sci++)
                {
                    scPunktyKontrolneKrzywejBeziera[sci] = new Point(scPunktyKontrolneKrzywejBeziera[sci].X - scPrzyrostX,
                        scPunktyKontrolneKrzywejBeziera[sci].Y - scPrzyrostY);
                }
            }
        }

        //deklaracja klasy KrzywaKardynalna

        public class KrzywaKardynalna : Punkt
        {
            //deklaracja listu punktów
            public List<Point> scPunktyKontrolneKrzywejKardynalna = new List<Point>();
            int scPromieńPunktuKontrolnego = 5;
            public ushort scLiczbaPunktówKontrolnych
            {
                get;
                set;
            }
            //deklaracja Fontru opisu punktu kontrolnego
            Font scFontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);
            //deklaracja konstruktorska
            public KrzywaKardynalna(Graphics Rysownica, Pen Pioro, Point XYpunktu) :
                base(XYpunktu.X, XYpunktu.Y, Pioro.Color, (int)Pioro.Width)
            {
                scPunktyKontrolneKrzywejKardynalna.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Pioro.Color))
                {
                    //wykreślenie punktu kontrolnego
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - scPromieńPunktuKontrolnego,
                        XYpunktu.Y - scPromieńPunktuKontrolnego, 2 * scPromieńPunktuKontrolnego,
                        2 * scPromieńPunktuKontrolnego);
                    //wykreslenie opisu punktu kontrolnego
                    Rysownica.DrawString("p" + (scPunktyKontrolneKrzywejKardynalna.Count - 1).ToString(),
                        scFontOpisuPunktów, Pedzel, scPunktyKontrolneKrzywejKardynalna[scPunktyKontrolneKrzywejKardynalna.Count - 1]);
                }
            }

            //deklaracja metod
            public void scDodajNowyPunktkontrolnych(Point XYpunktu, Graphics Rysownica, Pen Pioro)
            {
                scPunktyKontrolneKrzywejKardynalna.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Pioro.Color))
                {
                    //wykreślenie punktu kontrolnego
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - scPromieńPunktuKontrolnego,
                        XYpunktu.Y - scPromieńPunktuKontrolnego, 2 * scPromieńPunktuKontrolnego,
                        2 * scPromieńPunktuKontrolnego);
                    //wykreslenie opisu punktu kontrolnego
                    Rysownica.DrawString("p" + (scPunktyKontrolneKrzywejKardynalna.Count - 1).ToString(),
                        scFontOpisuPunktów, Pedzel, scPunktyKontrolneKrzywejKardynalna[scPunktyKontrolneKrzywejKardynalna.Count - 1]);
                }
            }

            public override void scWykresl(Graphics scRysownica)
            {
                using (Pen Pioro = new Pen(scKolor, scGruboscLinii))
                {
                    Pioro.DashStyle = scStylLinii;
                    //deklaracja i utorzenie egzemplarza tablicy
                    Point[] scPunktyKontrolne = new Point[scPunktyKontrolneKrzywejKardynalna.Count];
                    //przepisanie do tablicy punktów z listy
                    for (ushort sci = 0; sci < scPunktyKontrolneKrzywejKardynalna.Count; sci++)
                        scPunktyKontrolne[sci] = new Point(scPunktyKontrolneKrzywejKardynalna[sci].X, scPunktyKontrolneKrzywejKardynalna[sci].Y);
                    scRysownica.DrawCurve(Pioro, scPunktyKontrolne);
                    scWidoczny = true;
                }
            }
            public override void scWymaz(Control scKontrolka, Graphics scRysownica)
            {
               if (scWidoczny)
                {
                    using (Pen Pioro = new Pen(scKontrolka.BackColor, scGruboscLinii))
                    {
                        Pioro.DashStyle = scStylLinii;
                        //deklaracja i utorzenie egzemplarza tablicy
                        Point[] scPunktyKontrolne = new Point[scPunktyKontrolneKrzywejKardynalna.Count];
                        //przepisanie do tablicy punktów z listy
                        for (ushort sci = 0; sci < scPunktyKontrolneKrzywejKardynalna.Count; sci++)
                            scPunktyKontrolne[sci] = new Point(scPunktyKontrolneKrzywejKardynalna[sci].X, scPunktyKontrolneKrzywejKardynalna[sci].Y);
                        //wykreślenie krzywej Beziera
                        scRysownica.DrawCurve(Pioro, scPunktyKontrolne);
                        scWidoczny = false;
                    }
                }
            }
            public override void scUstawXY(int x, int y)
            {
                //deklaracja pomocnicze
                int scPrzyrostX = scPunktyKontrolneKrzywejKardynalna[0].X - x;
                int scPrzyrostY = scPunktyKontrolneKrzywejKardynalna[0].Y - y;

                //dokonanie zmian wartości współrzędnych wszystkich punktów kontrolnych
                for (int sci = 0; sci < scPunktyKontrolneKrzywejKardynalna.Count; sci++)
                {
                    scPunktyKontrolneKrzywejKardynalna[sci] = new Point(scPunktyKontrolneKrzywejKardynalna[sci].X - scPrzyrostX,
                        scPunktyKontrolneKrzywejKardynalna[sci].Y - scPrzyrostY);
                }
            }

        }

      



       
    }
    
}
