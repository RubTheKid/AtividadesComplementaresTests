using AtividadesComplementares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models;

[TestClass]
internal class RegistroTest
{
    [TestMethod]
    public void RegistroAtividadeComplementarTeste()
    {
        var aluno = new Aluno("teste", "teste@tuta.io");
        var dataReg = DateTime.Now;
        var atividadeComplementar = new AtividadeComplementar("poo", DateTime.Now, 10);

        var registro = new Registro(aluno, atividadeComplementar);

        Assert.AreEqual(aluno, registro.Aluno);
        Assert.AreEqual(dataReg, registro.DataValidacao);
        Assert.AreEqual(atividadeComplementar, registro.Atividade);
    }
    [TestMethod]
    public void RegistroMinicursoTeste()
    {
        var dataReg = DateTime.Now;
        var nome = "curso profissionalizante";
        var dataRealizacao = DateTime.Now;
        var cargaHoraria = 10;
        var certificado = "https://foa.edu.br";

        var miniCurso = new Minicurso(nome, dataRealizacao, cargaHoraria, certificado);


        var aluno = new Aluno("teste", "teste@tuta.io");

        var registroCurso = new Registro(aluno, miniCurso);

        Assert.AreEqual(aluno, registroCurso.Aluno);
        
    }

}