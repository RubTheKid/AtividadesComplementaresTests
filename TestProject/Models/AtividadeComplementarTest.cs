using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models;

[TestClass]
public class AtividadeComplementarTest
{
    [TestMethod]
    public void AtividadeTest()
    {
        var nome = "palestra foa";
        var dataRealizacao = DateTime.Now;
        var cargaHoraria = 10;

        var atividadeComplementar = new AtividadeComplementar(nome, dataRealizacao, cargaHoraria);

        Assert.AreEqual(nome, atividadeComplementar.Nome);
        Assert.AreEqual(dataRealizacao, atividadeComplementar.Datarealizacao);
        Assert.AreEqual(cargaHoraria, atividadeComplementar.CargaHoraria);

    }
    
}
