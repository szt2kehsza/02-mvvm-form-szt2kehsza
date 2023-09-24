using System;
using System.Collections.Generic;
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
        private string filmKivalasztasa;

        [ObservableProperty]
        private List<string> filmNevek;

        [ObservableProperty]
        private ObservableCollection<JegyVetel> _jegyvetelek = new ObservableCollection<JegyVetel>();

        [ObservableProperty]
        private JegyVetel _selectedJegy;

        public JegyVetelViewModel()
        {
            SelectedJegy= new JegyVetel();
        }

        [RelayCommand]
        public void DoSave(JegyVetel newJegyVetel)
        {
            JegyVetelek.Add(newJegyVetel);
            OnPropertyChanged(nameof(JegyVetelek));
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

