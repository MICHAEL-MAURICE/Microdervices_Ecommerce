using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface IQueryHandler<in Tquery, TResponse> : IRequestHandler<Tquery, TResponse>
    where Tquery : IQuery<TResponse>
    where TResponse : notnull
    {
    }
}
