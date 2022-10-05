using DemoLibrary.DataAccess;
using DemoLibrary.DataAccess.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHendler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDemoDataAccess _dataAccess;

        public GetPersonListHendler(IDemoDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetPeople());
        }
    }
}
