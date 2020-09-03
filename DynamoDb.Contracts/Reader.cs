using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamoDb.Contracts
{
    [DynamoDBTable("test_readers")]
    public class Reader
    {
        [DynamoDBProperty("id")]
        [DynamoDBHashKey]
        public Guid Id { get; set; }

        [DynamoDBProperty("name")]
        public string Name { get; set; }

        [DynamoDBProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [DynamoDBProperty("userName")]
        public string Username { get; set; }

        [DynamoDBProperty("addedOn")]
        public DateTime AddedOn { get; set; }
    }
}
