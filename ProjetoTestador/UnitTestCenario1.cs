using AppCliente.Models;
using AppCliente.Negocio;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTestador
{
    public class UnitTestCenario1
    {
        private ParametroRetorno retorno;
        private Institucionalizado idoso;

        [SetUp]
        public void Setup()
        {
            retorno = new ParametroRetorno();

        }

        #region Metodos de teste que Falham

        [Test]
        public void InstitucionalizadoJaExisteNoSistemaFalha()
        {
            idoso = new Institucionalizado
            {
                Id = 0,
                Cpf = 44096023060,
                CI = 1254887,
                EstadoCivil = 1,
                DataNascimento = Convert.ToDateTime("05/08/1948"),
                Nome = "Barak Obama da Silva",
            };

            var institucionalizadoAcao = new InstitucionalizadoAcao();
            var retornoEsperado = institucionalizadoAcao.SalvarItem(idoso);
            Assert.That(retornoEsperado.Sucesso, Is.EqualTo(true));
            Assert.Pass();
        }

        #endregion

        #region Metodos de teste de Sucesso


        #endregion
    }
}
