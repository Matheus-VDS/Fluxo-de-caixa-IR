﻿using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class CollaboratorRepository : ICollaboratorRepository
    {
        private AppDbContext _context;

        public CollaboratorRepository(AppDbContext appDbContext) {
            _context = appDbContext;
        }

        public IEnumerable<Collaborator> GetAll()
        {
            return _context.Collaborator;
        }

        public Task<Collaborator?> GetById(string id)
        {
            return _context.Collaborator.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public Collaborator? FindCollaborator(string id)
        {
            return _context.Collaborator.Include(p => p.CollaboratorType).Include(x => x.Address)
                .FirstOrDefault(p => p.Id == id); ;
        }

        public void Add(Collaborator collaborator)
        {
            _context.Add(collaborator);
            _context.SaveChanges();
        }

        public void Delete(Collaborator collaborator)
        {
            _context.Remove(collaborator);
            _context.SaveChanges();
        }

        public void Update(Collaborator collaborator)
        {
            _context.Update(collaborator);
            _context.SaveChanges();
        }
    }
}