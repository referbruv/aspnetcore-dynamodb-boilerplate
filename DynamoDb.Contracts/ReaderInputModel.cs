namespace DynamoDb.Contracts
{
    public class ReaderInputModel
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public InputType InputType { get; set; }
    }
}
