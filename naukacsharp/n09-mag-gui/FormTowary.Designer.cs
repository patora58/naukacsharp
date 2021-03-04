
namespace n09_mag_gui
{
    partial class FormTowary
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
            this.listBoxTowary = new System.Windows.Forms.ListBox();
            this.groupBoxOperacje = new System.Windows.Forms.GroupBox();
            this.buttonListaTowarow = new System.Windows.Forms.Button();
            this.buttonResetuj = new System.Windows.Forms.Button();
            this.groupBoxOperacje.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTowary
            // 
            this.listBoxTowary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTowary.FormattingEnabled = true;
            this.listBoxTowary.Location = new System.Drawing.Point(12, 12);
            this.listBoxTowary.Name = "listBoxTowary";
            this.listBoxTowary.Size = new System.Drawing.Size(499, 433);
            this.listBoxTowary.TabIndex = 0;
            // 
            // groupBoxOperacje
            // 
            this.groupBoxOperacje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOperacje.Controls.Add(this.buttonResetuj);
            this.groupBoxOperacje.Controls.Add(this.buttonListaTowarow);
            this.groupBoxOperacje.Location = new System.Drawing.Point(517, 12);
            this.groupBoxOperacje.Name = "groupBoxOperacje";
            this.groupBoxOperacje.Size = new System.Drawing.Size(271, 426);
            this.groupBoxOperacje.TabIndex = 1;
            this.groupBoxOperacje.TabStop = false;
            this.groupBoxOperacje.Text = "Operacje";
            // 
            // buttonListaTowarow
            // 
            this.buttonListaTowarow.Location = new System.Drawing.Point(6, 172);
            this.buttonListaTowarow.Name = "buttonListaTowarow";
            this.buttonListaTowarow.Size = new System.Drawing.Size(142, 23);
            this.buttonListaTowarow.TabIndex = 0;
            this.buttonListaTowarow.Text = "lista towarów";
            this.buttonListaTowarow.UseVisualStyleBackColor = true;
            this.buttonListaTowarow.Click += new System.EventHandler(this.buttonListaTowarow_Click);
            // 
            // buttonResetuj
            // 
            this.buttonResetuj.Location = new System.Drawing.Point(6, 109);
            this.buttonResetuj.Name = "buttonResetuj";
            this.buttonResetuj.Size = new System.Drawing.Size(142, 23);
            this.buttonResetuj.TabIndex = 1;
            this.buttonResetuj.Text = "resetuj";
            this.buttonResetuj.UseVisualStyleBackColor = true;
            this.buttonResetuj.Click += new System.EventHandler(this.buttonResetuj_Click);
            // 
            // FormTowary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOperacje);
            this.Controls.Add(this.listBoxTowary);
            this.Name = "FormTowary";
            this.Text = "Towary";
            this.groupBoxOperacje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTowary;
        private System.Windows.Forms.GroupBox groupBoxOperacje;
        private System.Windows.Forms.Button buttonListaTowarow;
        private System.Windows.Forms.Button buttonResetuj;
    }
}

