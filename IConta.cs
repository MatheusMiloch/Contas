﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    interface IConta
    {
        void SolicitarEmprestimo(float valorPretendido);

        void SolicitarAumentoLimite(float valorAtual, float valorPretendido);

    }
}
