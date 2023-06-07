using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models;

[TestClass]
public class MiniCursoTest
{
    [TestMethod]
    public void MiniCursoTeste()
    {
        var nome = "curso profissionalizante";
        var dataRealizacao = DateTime.Now;
        var cargaHoraria = 10;
        var certificado = "https://foa.edu.br";

        var miniCurso = new Minicurso(nome, dataRealizacao, cargaHoraria, certificado);

       
        Assert.AreEqual(nome, miniCurso.Nome);
        Assert.AreEqual(cargaHoraria, miniCurso.CargaHoraria);
        Assert.AreEqual(dataRealizacao, miniCurso.Datarealizacao);
        


    }
}
