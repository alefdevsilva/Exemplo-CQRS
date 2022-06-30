using System;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handler
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request){
            //Verifica se o cliente está cadastrado
            //Valida os dados
            //Insere o cliente no banco de dados
            //Envia E-mail de boas vindas
            return new CreateCustomerResponse{
                Id = Guid.NewGuid(),
                Name = "Alef Silva",
                Email = "Alef@Alef.com",
                Date = DateTime.Now
            };
        }
    }
}