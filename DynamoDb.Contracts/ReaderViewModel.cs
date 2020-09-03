using System;
using System.Collections.Generic;
using System.Text;

namespace DynamoDb.Contracts
{
    public class ReaderViewModel
    {
        public IEnumerable<Reader> Readers { get; set; }
        public ResultsType ResultsType { get; set; }
        public string PaginationToken { get; set; }
    }
}
