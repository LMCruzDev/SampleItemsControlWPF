using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Teste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ControleBase
    {

        private string nomeTela;
        public string NomeTela
        {
            get
            {
                return nomeTela;
            }
            set
            {
                nomeTela = value;
                NotifyPropertyChanged();
            }
        }


        private List<Grupo> listaGrupo;
        public List<Grupo> ListaGrupo
        {
            get
            {
                return listaGrupo;
            }
            set
            {
                listaGrupo = value;
                NotifyPropertyChanged();
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            PopularGrid();
        }

        public void PopularGrid()
        {
            NomeTela = "Crédito";

            var lista = new List<Grupo>()
            {
                new Grupo()
                {
                    TotalJuros = 1000,
                    TotalLimite = 100,
                    TotalMora = 200,
                    TotalMulta = 300,
                    ListaEmpresa = new List<Empresa>()
                    {
                        new Empresa()
                        {
                            Nome = "Teste",
                            Juros = 1000,
                            Limite = 100,
                            Mora = 200,
                            Multa = 300
                        }
                    }
                },
                 new Grupo()
                {
                    TotalJuros = 1000,
                    TotalLimite = 100,
                    TotalMora = 200,
                    TotalMulta = 300,
                    ListaEmpresa = new List<Empresa>()
                    {
                        new Empresa()
                        {
                            Nome = "Teste",
                            Juros = 1000,
                            Limite = 100,
                            Mora = 200,
                            Multa = 300
                        }
                    }
                },
                  new Grupo()
                {
                    TotalJuros = 1000,
                    TotalLimite = 100,
                    TotalMora = 200,
                    TotalMulta = 300,
                    ListaEmpresa = new List<Empresa>()
                    {
                        new Empresa()
                        {
                            Nome = "Teste",
                            Juros = 1000,
                            Limite = 100,
                            Mora = 200,
                            Multa = 300
                        }
                    }
                }
            };

            ListaGrupo = lista;
        }
    }

    public class Grupo : AEntidade
    {
        private double totalLimite;
        public double TotalLimite
        {
            get
            {
                return totalLimite;
            }
            set
            {
                totalLimite = value;
                NotifyPropertyChanged();
            }
        }

        private double totalMulta;
        public double TotalMulta
        {
            get
            {
                return totalMulta;
            }
            set
            {
                totalMulta = value;
                NotifyPropertyChanged();
            }
        }

        private double totalMora;
        public double TotalMora
        {
            get
            {
                return totalMora;
            }
            set
            {
                totalMora = value;
                NotifyPropertyChanged();
            }
        }

        private double totalJuros;
        public double TotalJuros
        {
            get
            {
                return totalJuros;
            }
            set
            {
                totalJuros = value;
                NotifyPropertyChanged();
            }
        }

        private List<Empresa> listaEmpresa;

        public List<Empresa> ListaEmpresa
        {
            get { return listaEmpresa; }
            set { listaEmpresa = value; NotifyPropertyChanged(); }
        }

    }

    public class Empresa : AEntidade
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; NotifyPropertyChanged(); }
        }

        private double limite;
        public double Limite
        {
            get { return limite; }
            set { limite = value; NotifyPropertyChanged(); }
        }

        private double multa;
        public double Multa
        {
            get { return multa; }
            set { multa = value; NotifyPropertyChanged(); }
        }

        private double juros;
        public double Juros
        {
            get { return juros; }
            set { juros = value; NotifyPropertyChanged(); }
        }

        private double mora;
        public double Mora
        {
            get { return mora; }
            set { mora = value; NotifyPropertyChanged(); }
        }
    }
}
