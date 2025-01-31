﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogCore.AccesoDatos.Data.Repository.IRepository;
using BlogCore.Data;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo: IContenedorTrabajo
    {
        private readonly ApplicationDbContext _context;
        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            Categoria = new CategoriaRepository(_context);

        }

        public ICategoriarepository Categoria {  get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
