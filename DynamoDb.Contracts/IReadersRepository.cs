using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamoDb.Contracts.Interfaces
{
    public interface IReadersRepository
    {
        Task<Reader> Single(Guid readerId);
        Task<ReaderViewModel> All(string paginationToken = "");
        Task<IEnumerable<Reader>> Find(SearchRequest searchReq);
        Task Add(ReaderInputModel entity);
        Task Remove(Guid readerId);
        Task Update(Guid readerId, ReaderInputModel entity);
    }
}
