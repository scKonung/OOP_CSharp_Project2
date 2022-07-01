
namespace Projekt2_Chalyi_59022
{
    partial class FormGlowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlowna));
            this.bttnPrezentacja_Figur_Geometrycznych = new System.Windows.Forms.Button();
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnPrezentacja_Figur_Geometrycznych
            // 
            this.bttnPrezentacja_Figur_Geometrycznych.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPrezentacja_Figur_Geometrycznych.Location = new System.Drawing.Point(12, 181);
            this.bttnPrezentacja_Figur_Geometrycznych.Name = "bttnPrezentacja_Figur_Geometrycznych";
            this.bttnPrezentacja_Figur_Geometrycznych.Size = new System.Drawing.Size(369, 86);
            this.bttnPrezentacja_Figur_Geometrycznych.TabIndex = 0;
            this.bttnPrezentacja_Figur_Geometrycznych.Text = "Prezentacja Figur Geometrycznych ze slajderem";
            this.bttnPrezentacja_Figur_Geometrycznych.UseVisualStyleBackColor = true;
            this.bttnPrezentacja_Figur_Geometrycznych.Click += new System.EventHandler(this.bttnPrezentacja_Figur_Geometrycznych_Click);
            // 
            // bttnKrzeslenie_Figur_Z_pomoca_myszy
            // 
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.Location = new System.Drawing.Point(419, 181);
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.Name = "bttnKrzeslenie_Figur_Z_pomoca_myszy";
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.Size = new System.Drawing.Size(369, 86);
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.TabIndex = 1;
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.Text = "Krześłenie figur i linii geometrycznych przy użyciu myszy";
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.UseVisualStyleBackColor = true;
            this.bttnKrzeslenie_Figur_Z_pomoca_myszy.Click += new System.EventHandler(this.bttnKrzeslenie_Figur_Z_pomoca_myszy_Click);
            // 
            // FormGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnKrzeslenie_Figur_Z_pomoca_myszy);
            this.Controls.Add(this.bttnPrezentacja_Figur_Geometrycznych);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGlowna";
            this.Text = "Wieloformularzowy prezentacja figur geometrycznych";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGlowna_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnPrezentacja_Figur_Geometrycznych;
        private System.Windows.Forms.Button bttnKrzeslenie_Figur_Z_pomoca_myszy;
    }
}

