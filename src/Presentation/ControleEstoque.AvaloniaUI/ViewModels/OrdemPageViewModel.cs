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
        private ObservableCollection<Ordem> ordens;

        public OrdemPageViewModel()
        {
            Ordens = new ObservableCollection<Ordem>
            {
                new Ordem { NumeroOrdem = 1, Descricao = "Descrição 1", LocalizacaoAlmox = "Localização 1", Status = "Pendente" },
            new Ordem { NumeroOrdem = 2, Descricao = "Descrição 2", LocalizacaoAlmox = "Localização 2", Status = "Completo" },
            new Ordem { NumeroOrdem = 3, Descricao = "Descrição 3", LocalizacaoAlmox = "Localização 3", Status = "Em Progresso" },
            new Ordem { NumeroOrdem = 4, Descricao = "Descrição 4", LocalizacaoAlmox = "Localização 4", Status = "Pendente" },
            new Ordem { NumeroOrdem = 5, Descricao = "Descrição 5", LocalizacaoAlmox = "Localização 5", Status = "Completo" },
            new Ordem { NumeroOrdem = 6, Descricao = "Descrição 6", LocalizacaoAlmox = "Localização 6", Status = "Em Progresso" },
            new Ordem { NumeroOrdem = 7, Descricao = "Descrição 7", LocalizacaoAlmox = "Localização 7", Status = "Pendente" },
            new Ordem { NumeroOrdem = 8, Descricao = "Descrição 8", LocalizacaoAlmox = "Localização 8", Status = "Completo" },
            new Ordem { NumeroOrdem = 9, Descricao = "Descrição 9", LocalizacaoAlmox = "Localização 9", Status = "Em Progresso" },
            new Ordem { NumeroOrdem = 10, Descricao = "Descrição 10", LocalizacaoAlmox = "Localização 10", Status = "Pendente" },
            new Ordem { NumeroOrdem = 11, Descricao = "Descrição 11", LocalizacaoAlmox = "Localização 11", Status = "Completo" },
            new Ordem { NumeroOrdem = 12, Descricao = "Descrição 12", LocalizacaoAlmox = "Localização 12", Status = "Em Progresso" },
            new Ordem { NumeroOrdem = 13, Descricao = "Descrição 13", LocalizacaoAlmox = "Localização 13", Status = "Pendente" },
            new Ordem { NumeroOrdem = 14, Descricao = "Descrição 14", LocalizacaoAlmox = "Localização 14", Status = "Completo" },
            new Ordem { NumeroOrdem = 15, Descricao = "Descrição 15", LocalizacaoAlmox = "Localização 15", Status = "Em Progresso" },
            new Ordem { NumeroOrdem = 16, Descricao = "Descrição 16", LocalizacaoAlmox = "Localização 16", Status = "Pendente" },
            new Ordem { NumeroOrdem = 17, Descricao = "Descrição 17", LocalizacaoAlmox = "Localização 17", Status = "Completo" },
            new Ordem { NumeroOrdem = 18, Descricao = "Descrição 18", LocalizacaoAlmox = "Localização 18", Status = "Em Progresso" },
            new Ordem { NumeroOrdem = 19, Descricao = "Descrição 19", LocalizacaoAlmox = "Localização 19", Status = "Pendente" },
            new Ordem { NumeroOrdem = 20, Descricao = "Descrição 20", LocalizacaoAlmox = "Localização 20", Status = "Completo" }
            };
        }
    }

    public class Ordem
    {
        public int NumeroOrdem { get; set; }
        public string Descricao { get; set; }
        public string LocalizacaoAlmox { get; set; }
        public string Status { get; set; }
    }
}