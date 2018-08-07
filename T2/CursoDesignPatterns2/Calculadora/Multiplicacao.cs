﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Calculadora
{
    class Multiplicacao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public double Avalia()
        {
            double resultadoDaEsquerda = esquerda.Avalia();
            double resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda * resultadoDaDireita;
        }
    }
}
