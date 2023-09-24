using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoziProjekt.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace MoziProjekt.ViewModels
{
    public partial class JegyVetelViewModel : ObservableObject
    {
        private ObservableCollection<string> _filmNev = new ObservableCollection<string>(new FilmNev().OsszesFilmNev);


        [ObservableProperty]
        private ObservableCollection<JegyVetel> _jegyvetelek = new ObservableCollection<JegyVetel>();

        [ObservableProperty]
        private JegyVetel _selectedJegy;

        private string _kivalasztottfilm = string.Empty;
        public string KivalasztottFilm
        {
            get => _kivalasztottfilm;
            set
            {
                SetProperty(ref _kivalasztottfilm, value);
                SelectedJegy.FilmNev = _kivalasztottfilm;
            }
        }

        public JegyVetelViewModel()
        {
            SelectedJegy= new JegyVetel();
            KivalasztottFilm = _filmNev.ElementAt(0);
        }

        [RelayCommand]
        public void DoSave(JegyVetel newJegyVetel)
        {
            Jegyvetelek.Add(newJegyVetel);
            OnPropertyChanged(nameof(Jegyvetelek));
        }

        //JegyVetelek.Add(new JegyVetel("Elek Teszt", System.DateTime.Now, "", JegyTipusa.DIAK,));

        [RelayCommand]
        void DoNewJegy()
        {
            SelectedJegy = new JegyVetel();
        }

        [RelayCommand]
        public void DoRemove(JegyVetel jegyToDelete)
        {
            Jegyvetelek.Remove(jegyToDelete);
            OnPropertyChanged(nameof(Jegyvetelek));
        }


    }

}

