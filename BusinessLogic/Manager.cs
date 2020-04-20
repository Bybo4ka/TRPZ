﻿using System.Runtime.Serialization;

namespace BusinessLogic
{
    [DataContract]
    public class Manager
    {
        [DataMember]
        public double timeBeforeAvailability = 0;
        public double timeNeededToPerformTask(Product product)
        {
            this.timeBeforeAvailability = product.Name.Length / 60.0;
            return ((product.Name.Length / 60.0)); // We assume that the longer the name of the type, the longer will manager operate with it.
        }

    }
}