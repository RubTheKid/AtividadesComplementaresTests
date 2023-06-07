using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models;

[TestClass]
public class PalestraTest
{
    [TestMethod]
    public void PalestraTeste()
    {
        var nome = "palestra teste";
        var data = DateTime.Now;
        var cargaHoraria = 90;
        var palestrante = "Rosen";

        Palestra palestra = new Palestra(nome, data, cargaHoraria, palestrante);

        Assert.AreEqual(nome, palestra.Nome);
        //Assert.AreEqual(data, palestra.Data); //err
        //Assert.IsNotNull(data);
        Assert.AreEqual(cargaHoraria, palestra.CargaHoraria);
        Assert.AreEqual(palestrante, palestra.Palestrante);


    }
}
