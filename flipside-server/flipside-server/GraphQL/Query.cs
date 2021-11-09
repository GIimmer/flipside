using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flipside_Server.Data;
using HotChocolate;
using HotChocolate.Data;

namespace Flipside_Server.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Debate> GetDebate([ScopedService] AppDbContext context) =>
            context.Debates;
     }
}
