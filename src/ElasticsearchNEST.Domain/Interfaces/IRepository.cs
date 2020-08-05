using System;
using System.Collections.Generic;
using ElasticsearchNEST.Domain.Entities;

namespace ElasticsearchNEST.Domain.Interfaces
{
    public interface IRepository
    {
        void Add();

        ICollection<IndexItem> FindAll();

        ICollection<IndexItem> FindByName(string name);

        ICollection<IndexItem> FindByDescription(string description);

        ICollection<IndexItem> FindActorsCondition(string name, string description, DateTime? birthdate);

        ICollection<IndexItem> FindActorsAllCondition(string term);
    }
}