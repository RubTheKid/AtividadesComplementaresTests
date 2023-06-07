using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesComplementares.Models
{
    public class AtividadeComplementar
    //public abstract class AtividadeComplementar
    {
        public AtividadeComplementar(string nome, DateTime data, int cargaHoraria) { 
            Nome = nome;
            Datarealizacao = data;
            CargaHoraria = cargaHoraria;
        }
        public string Nome { get; set; }
        public DateTime Datarealizacao { get;  set; }
        public int CargaHoraria { get; set; }
    }
}
