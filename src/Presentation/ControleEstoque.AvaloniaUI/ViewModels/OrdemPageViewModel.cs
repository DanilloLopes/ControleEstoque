using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.AvaloniaUI.ViewModels
{
    public partial class OrdemPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<Ordemm> ordens;

        public OrdemPageViewModel()
        {
            Ordens = new ObservableCollection<Ordemm>
            {
                
            };
        }
    }

    public class Ordemm
    {
        public int NumeroOrdem { get; set; }
        public string Descricao { get; set; }
        public string LocalizacaoAlmox { get; set; }
        public string Status { get; set; }
    }
}