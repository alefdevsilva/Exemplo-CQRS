using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handler
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
             var result = new CreateCustomerResponse{
                Id = Guid.NewGuid(),
                Name = "Alef Silva",
                Email = "Alef@Alef.com",
                Date = DateTime.Now
            };
            return Task.FromResult(result);
        }
    }
}