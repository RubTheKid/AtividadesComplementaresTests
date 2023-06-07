using AtividadesComplementares.Models;

namespace TestProject.Models;

[TestClass]
public class AlunoTest
{
    [TestMethod]
    public void AlunoTeste()
    {
        var nome = "Rosen";
        var email = "teste@tuta.io";

        Aluno aluno = new Aluno(nome, email);

        Assert.AreEqual("Rosen", nome);
        Assert.AreEqual("teste@tuta.io", email);
    }

}