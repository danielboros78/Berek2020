
namespace Berek2020
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
      this.lblDolgozokSzama = new System.Windows.Forms.Label();
      this.lbOsszesAdat = new System.Windows.Forms.ListBox();
      this.lblBerekAtlaga = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tbReszlegMegnevezes = new System.Windows.Forms.TextBox();
      this.btnDolgozoKivalaszt = new System.Windows.Forms.Button();
      this.lblHatodik = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbStatisztika = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // lblDolgozokSzama
      // 
      this.lblDolgozokSzama.AutoSize = true;
      this.lblDolgozokSzama.Location = new System.Drawing.Point(13, 13);
      this.lblDolgozokSzama.Name = "lblDolgozokSzama";
      this.lblDolgozokSzama.Size = new System.Drawing.Size(0, 20);
      this.lblDolgozokSzama.TabIndex = 0;
      // 
      // lbOsszesAdat
      // 
      this.lbOsszesAdat.FormattingEnabled = true;
      this.lbOsszesAdat.ItemHeight = 20;
      this.lbOsszesAdat.Location = new System.Drawing.Point(200, 14);
      this.lbOsszesAdat.Name = "lbOsszesAdat";
      this.lbOsszesAdat.Size = new System.Drawing.Size(886, 224);
      this.lbOsszesAdat.TabIndex = 1;
      // 
      // lblBerekAtlaga
      // 
      this.lblBerekAtlaga.AutoSize = true;
      this.lblBerekAtlaga.Location = new System.Drawing.Point(46, 275);
      this.lblBerekAtlaga.Name = "lblBerekAtlaga";
      this.lblBerekAtlaga.Size = new System.Drawing.Size(0, 20);
      this.lblBerekAtlaga.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(50, 343);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(170, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Kérem a részleg nevét:";
      // 
      // tbReszlegMegnevezes
      // 
      this.tbReszlegMegnevezes.Location = new System.Drawing.Point(227, 342);
      this.tbReszlegMegnevezes.Name = "tbReszlegMegnevezes";
      this.tbReszlegMegnevezes.Size = new System.Drawing.Size(190, 26);
      this.tbReszlegMegnevezes.TabIndex = 4;
      // 
      // btnDolgozoKivalaszt
      // 
      this.btnDolgozoKivalaszt.Location = new System.Drawing.Point(486, 334);
      this.btnDolgozoKivalaszt.Name = "btnDolgozoKivalaszt";
      this.btnDolgozoKivalaszt.Size = new System.Drawing.Size(364, 38);
      this.btnDolgozoKivalaszt.TabIndex = 5;
      this.btnDolgozoKivalaszt.Text = "legnagyobb bérrel rendelkező dolgozó";
      this.btnDolgozoKivalaszt.UseVisualStyleBackColor = true;
      this.btnDolgozoKivalaszt.Click += new System.EventHandler(this.btnDolgozoKivalaszt_Click);
      // 
      // lblHatodik
      // 
      this.lblHatodik.AutoSize = true;
      this.lblHatodik.Location = new System.Drawing.Point(592, 396);
      this.lblHatodik.Name = "lblHatodik";
      this.lblHatodik.Size = new System.Drawing.Size(80, 20);
      this.lblHatodik.TabIndex = 6;
      this.lblHatodik.Text = "6. Feladat";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(54, 396);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(166, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = " 7. Feladat: Statisztika";
      // 
      // lbStatisztika
      // 
      this.lbStatisztika.FormattingEnabled = true;
      this.lbStatisztika.ItemHeight = 20;
      this.lbStatisztika.Location = new System.Drawing.Point(50, 433);
      this.lbStatisztika.Name = "lbStatisztika";
      this.lbStatisztika.Size = new System.Drawing.Size(296, 184);
      this.lbStatisztika.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1118, 640);
      this.Controls.Add(this.lbStatisztika);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblHatodik);
      this.Controls.Add(this.btnDolgozoKivalaszt);
      this.Controls.Add(this.tbReszlegMegnevezes);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblBerekAtlaga);
      this.Controls.Add(this.lbOsszesAdat);
      this.Controls.Add(this.lblDolgozokSzama);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Berek2020";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDolgozokSzama;
    private System.Windows.Forms.ListBox lbOsszesAdat;
    private System.Windows.Forms.Label lblBerekAtlaga;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbReszlegMegnevezes;
    private System.Windows.Forms.Button btnDolgozoKivalaszt;
    private System.Windows.Forms.Label lblHatodik;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lbStatisztika;
  }
}

