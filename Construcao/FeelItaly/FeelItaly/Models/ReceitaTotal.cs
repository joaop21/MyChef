﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeelItaly.Models{

    public class ReceitaTotal{

        public Receita rec; 
        public List<Passo> pass;
        public List<Ingrediente> ingredientes;
        public Dictionary<int,string> desc_passos;
        public List<Comentario> coments;
        public int idpasso;
        public int nrpassos;
        //public string nrpassoatual;
        //public string passoatual;

    }
}
