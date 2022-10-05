using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
}
