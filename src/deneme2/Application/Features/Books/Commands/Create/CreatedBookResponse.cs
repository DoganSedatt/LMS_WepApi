using NArchitecture.Core.Application.Responses;

namespace Application.Features.Books.Commands.Create;

public class CreatedBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string BookName { get; set; }
    public string ISBN { get; set; }
}