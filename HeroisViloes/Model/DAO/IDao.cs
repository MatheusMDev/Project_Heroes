using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.DAO
{
    interface IDao
    {
        bool atualizar(object objeto);
        bool excluir(object objeto);
        bool inserir(object objeto);
        bool consultar(object objeto);
        DataTable consultar1(object objeto);
        int inserir1(object objeto);
        List<Object> consultar(string sql);
    }
}
