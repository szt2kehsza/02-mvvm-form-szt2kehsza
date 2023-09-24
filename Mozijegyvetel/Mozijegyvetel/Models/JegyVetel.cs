using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum JegyTipusa { DIAK, FELNOTT, NYUGDIJAS}



namespace MoziProjekt.Models
{
    public class JegyVetel
    {

        public JegyVetel() 
        {
            TeljesNev = string.Empty;
            Filmdatuma = new DateTime();
            FilmNev = string.Empty;
            Jegy = JegyTipusa.DIAK;
            Ar = 2200;
        }

        public JegyVetel(string teljesNev, DateTime filmdatuma, string filmNev, JegyTipusa jegyTipusa, int ar)
        {
            TeljesNev = teljesNev;
            Filmdatuma = filmdatuma;
            FilmNev = filmNev;
            Jegy = jegyTipusa;
            Ar = ar;
        }

        public string TeljesNev { get; set; }
        public DateTime Filmdatuma { get; set; }
        public string FilmNev { get; set; }
        public JegyTipusa Jegy { get; set; }
        public int Ar { get; set;}

        public void UpdateAr()
        {
            switch (JegyTipusa.DIAK)
            {
                case JegyTipusa.DIAK:
                case JegyTipusa.NYUGDIJAS:
                    Ar = 2200;
                    break;
                case JegyTipusa.FELNOTT:
                    Ar = 2500;
                    break;
                default:
                    Ar = 0;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{TeljesNev} ({FilmNev}.{Jegy}) - ({String.Format("{0:yyyy.MM.dd.}", Filmdatuma)})";
        }

    }
}
