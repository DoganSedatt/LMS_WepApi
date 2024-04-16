using NArchitecture.Core.Application.Responses;

namespace Application.Features.Books.Queries.GetById;

public class GetByIdBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ISBN { get; set; }
}