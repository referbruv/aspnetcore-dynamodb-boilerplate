namespace DynamoDb.Contracts
{
    public class SearchRequest
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
    }
}