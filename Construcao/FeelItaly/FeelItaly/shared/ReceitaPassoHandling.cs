﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using FeelItaly.Models;

namespace FeelItaly.shared
{

    public class ReceitaPassoHandling
    {

        private readonly ReceitaPassoContext _context;

        public ReceitaPassoHandling(ReceitaPassoContext context)
        {
            _context = context;
        }

        public ReceitaPasso[] getReceitasPassos()
        {
            return _context.receitapasso.ToArray();
        }

        public List<int> getPassosDaReceita(int idReceita)
        {
            return _context.receitapasso.Where(b => b.IdReceita == idReceita).Select(b => b.IdPasso).ToList();
        }

        public string getPassoDaReceita(int idReceita, int idPasso)
        {
            return _context.receitapasso.Where(b => b.IdReceita == idReceita && b.IdPasso == idPasso).Select(b => b.Numero).FirstOrDefault();
        }

    }
}
