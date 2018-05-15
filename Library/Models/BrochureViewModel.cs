﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library.Models
{
    [DataContract]
    public class BrochureViewModel
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