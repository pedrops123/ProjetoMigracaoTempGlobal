using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Lets.Importation.Domain.Command.Commands.TesteImportacao.Create
{
    public class CreateTesteImportacaoCommandHandle : IRequestHandler<CreateTesteImportacaoCommand, Unit>
    {
        public CreateTesteImportacaoCommandHandle()
        {
            
        }

        public Task<Unit> Handle(CreateTesteImportacaoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
