using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoziProjekt.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MoziProjekt.ViewModels
{
    public partial class JegyVetelViewModel : ObservableObject
    {
        private ObservableCollection<string> _filmNev = new ObservableCollection<string>(new FilmNev().OsszesFilmNev);

        [ObservableProperty]
        private JegyVetel jegyvetel;

        [ObservableProperty]
        private string filmKivalasztasa;

        [ObservableProperty]
        private List<string> filmNevek;

        [ObservableProperty]
        private ObservableCollection<JegyVetel> _jegyvetel = new ObservableCollection<JegyVetel>();

        public JegyVetelViewModel()
        {
            jegyvetel = new JegyVetel();
            FilmKivalasztasa = string.Empty;
            JegyVetel.Add(new JegyVetel("Elek Teszt", System.DateTime.Now, "", JegyTipusa.DIAK,));
            SelectedJegy = JegyTipusa.DIAK; 
            UpdateAr();
        }

        public JegyTipusa _selectedJegy;

        public JegyTipusa SelectedJegy
        {
            get { return _selectedJegy; }
            set
            {
                if (_selectedJegy != value)
                {
                    _selectedJegy = value;
                    OnPropertyChanged(nameof(SelectedJegy));
                    UpdateAr();
                }
            }
        }

        public int Ar
        {
            get { return jegyvetel.Ar; }
            set
            {
                if (jegyvetel.Ar != value)
                {
                    jegyvetel.Ar = value;
                    OnPropertyChanged(nameof(Ar));
                }
            }
        }

        public void UpdateAr()
        {
            switch (SelectedJegy)
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

    }

}

