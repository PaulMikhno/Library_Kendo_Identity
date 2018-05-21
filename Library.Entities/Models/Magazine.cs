﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library.Entities.Models
{
    [DataContract]
    public class Magazine: BaseModel
    {
        //[DataMember]
        //public int Id { get; set; }
        //[DataMember]
        //public string Name { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string YearOfPublishing { get; set; }
    }
}