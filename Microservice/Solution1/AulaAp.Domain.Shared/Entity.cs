using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAp.Domain.Shared
{
    public abstract class Entity<TId> 
    {
        public TId Id { get; set; }
        public abstract bool IsValid();
    }
}
