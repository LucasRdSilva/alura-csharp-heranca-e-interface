#region ChangeLog

// 21-03-2011 -  Implementação Inicial

#endregion

using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public  class ParceiroComercial : IAutenticavel
    {
        #region Propriedades

        public string Senha { get; set; }

        #endregion

        #region Métodos

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        #endregion
    }
}
