﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library.Entities.Models
{
    [DataContract]
    public class Brochure
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string TypeOfCover { get; set; }

        [DataMember]
        public int NumberOfPages { get; set; }
    }
}
