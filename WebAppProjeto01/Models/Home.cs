﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto01.Models
{
    public class Home
    {
        public IQueryable<Fabricante> fabricantes;
        public IQueryable<Categoria> categorias;
    }
}