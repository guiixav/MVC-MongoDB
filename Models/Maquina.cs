using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace RoxierMongoDB.Models
{
    public class Maquina
    {
       [BsonId]
       public ObjectId Id { get; set; }

        [BsonElement("recvTime")]
        public DateTime recvTime { get; set; }

        [BsonElement("attrName")]
        public string attrName { get; set; }

        [BsonElement("attrType")]
        public string attrType { get; set; }

        [BsonElement("attrValue")]
        public string attrValue { get; set; }

    }
}