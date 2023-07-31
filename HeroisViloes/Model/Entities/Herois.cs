using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.Entities
{
   public  class Herois : Pessoa
    {
        private string nomeHeroi;
        private string planetaOrigem;
        private string atividadeProfissional;
        private string parceiro;
        private string superPoder;
        private string grupo;

        // ---- Construtor ----//
        public Herois() : base()
        {
            nomeHeroi = "";
            planetaOrigem = "";
            atividadeProfissional = "";
            parceiro = "";
            superPoder = "";
            grupo = "";
        }

        //---- Propriedades ----//

        public string NomeHeroi
        {
            get { return nomeHeroi; }
            set { nomeHeroi = value; }
        }

        public string PlanetaOrigem
        {
            get { return planetaOrigem; }
            set { planetaOrigem = value; }
        }

        public string AtividadeProfissional
        {
            get { return atividadeProfissional; }
            set { atividadeProfissional = value; }
        }

        public string Parceiro
        {
            get { return parceiro; }
            set { parceiro = value; }
        }

        public string SuperPoder
        {
            get { return superPoder; }
            set { superPoder = value; }
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public override void calcularIdade(int anoAtual = 2023)
        {
            base.Idade = anoAtual - base.AnoNasc;
        }
       
    }
}