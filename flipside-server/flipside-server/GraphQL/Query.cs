using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flipside_Server.Data;
using HotChocolate;

namespace Flipside_Server.GraphQL
{
    public class Query
    {
        public IQueryable<Debate> GetDebate([Service] AppDbContext context) =>
            context.Debates;
     }
}
