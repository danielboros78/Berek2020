using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Berek2020
{
  public partial class Form1 : Form
  {
    static List<Adatok> adattagok = new List<Adatok>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Beolvasas();
      HarmadikFeladat();
      NegyedikFeladat();
      ListboxFeltolt();
      Statisztika();
    }

    private void Statisztika()
    {
      Dictionary<string, int> stat = new Dictionary<string, int>();
      for (int i = 0; i < adattagok.Count; i++)
      {
        if (!stat.ContainsKey(adattagok[i].Reszleg))
        {
          stat.Add(adattagok[i].Reszleg, 1);
        }
        else
        {
          stat[adattagok[i].Reszleg]++;
        }
      }
      foreach (var s in stat)
      {
        lbStatisztika.Items.Add($"{s.Key} - {s.Value} fő");
      }
    }

    private void ListboxFeltolt()
    {
      foreach (var a in adattagok)
      {
        lbOsszesAdat.Items.Add($"{a.Nev}\t{a.Nem}\t{a.Reszleg}\t{a.BelepesEv}\t{a.Fizetes}");
      }
    }

    private void NegyedikFeladat()
    {
      double atlag = 0;
      double osszesBer = 0;
      foreach (var a in adattagok)
      {
        osszesBer += a.Fizetes;
      }
      atlag = osszesBer / adattagok.Count / 1000;
      lblBerekAtlaga.Text = $"4. Feladat: Bérek átlaga: {atlag:N1} eFt";
    }

    private void HarmadikFeladat()
    {
      lblDolgozokSzama.Text = $"Dolgozók száma: {adattagok.Count} fő";
    }

    private void Beolvasas()
    {
      StreamReader be = new StreamReader("berek2020.txt");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] beolvasas = be.ReadLine().Split(';');
        adattagok.Add(new Adatok(beolvasas[0], beolvasas[1], beolvasas[2], Convert.ToInt32(beolvasas[3]), Convert.ToInt32(beolvasas[4])));
      }
      be.Close();
    }

    private void btnDolgozoKivalaszt_Click(object sender, EventArgs e)
    {
      int talaltSzam = 0;
      int max = 0;
      int index = 0;
      int kovetes = 0;
      foreach (var a in adattagok)
      {
        if (tbReszlegMegnevezes.Text.ToLower() == a.Reszleg)
        {
          if (max < a.Fizetes)
          {
            max = a.Fizetes;
            kovetes = index;
          }
          talaltSzam++;
        }
        index++;
      }
      if (talaltSzam == 0)
      {
        lblHatodik.Text = $"6. Feladat: A megadott részleg nem létezik a cégnél!";
      }
      else
      {
        lblHatodik.Text = $"6. Feladat: A legtöbbet kereső dolgozó az adott részlegen\nNév: {adattagok[kovetes].Nev}\nNem: {adattagok[kovetes].Nem}\nBelépés: {adattagok[kovetes].BelepesEv}\nBér: {adattagok[kovetes].Fizetes} forint";
      }
    }
  }
}
