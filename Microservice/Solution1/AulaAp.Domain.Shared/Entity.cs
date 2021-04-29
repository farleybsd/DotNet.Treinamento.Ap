using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAp.Domain.Shared
{
    public class Entity<TId> 
    {
        public TId Id { get; set; }
    }
}
