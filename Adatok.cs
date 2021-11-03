using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
  class Adatok
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
    }

    private string nem;

    public string Nem
    {
      get { return nem; }
    }

    private string reszleg;

    public string Reszleg
    {
      get { return reszleg; }
    }

    private int belepesEv;

    public int BelepesEv
    {
      get { return belepesEv; }
    }

    private int fizetes;

    public int Fizetes
    {
      get { return fizetes; }
    }

    public Adatok(string nev, string nem, string reszleg, int belepesEv, int fizetes)
    {
      this.nev = nev;
      this.nem = nem;
      this.reszleg = reszleg;
      this.belepesEv = belepesEv;
      this.fizetes = fizetes;
    }
  }
}
