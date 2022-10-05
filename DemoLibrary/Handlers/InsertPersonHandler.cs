using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.DataAccess.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    internal class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDemoDataAccess _dataAccess;

        public InsertPersonHandler(IDemoDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InserPerson(request.FirstName, request.LastName));
        }
    }
}
