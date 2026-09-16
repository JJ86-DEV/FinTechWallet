using MediatR;
using FintechWallet.Infrastructure.Persistence;
using DomainUser = FintechWallet.Domain.Entities.User;

//Importa MediatR para poder utilizar IRequestHandler.
using Infrastructure.Persistence;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;
//Importar el namespace donde está ApplicationDbContext.


namespace Application.User.Commands.CreateUser //contenedor que agrupa nombres de clases, funciones, y variables.
{ //Define el namespace al que pertenece este Handler.
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        //declara la clase handler
        //IrequestHandler significa que esta clase implementa el handler de MediatR.
        //CreateUserCommand = el comando que va a recibir.
        //int = el tipo de dato que devolverá cuando termine.
        private readonly ApplicationDbContext _context;
        //crea una variable privada llamada_context.
        //Guardará una instancia de ApplicationDbContext.
        //reandonly significa que después de asignarla no la cambiaremos.

        public CreateUserCommandHandler(ApplicationDbContext context)
        {//constructor del handler.
            //recibe un ApplicationDbContext llamado context.
            _context = context;
            //Guarda el context recibido dentro de nuestra variable_context
        }

        // Método que MediatR ejecutará cuando reciba un CreateUserCommand.
        // Recibe el comando y un token de cancelación.
        // Devuelve un int, que será el Id del usuario creado.
        public async Task<int> Handle(
            CreateUserCommand request,
           CancellationToken cancellationToken)
        {
            var user = new DomainUser
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                CreatedAt = DateTime.UtcNow
            };

            _context.Set<DomainUser>().Add(user);

            var wallet = new Wallet
            {
                UserId = user.Id.ToString(),
                Currency = "EUR",
                CreatedAt = DateTime.UtcNow

            };

            _context.Set<Wallet>().Add(wallet);
            await _context.SaveChangesAsync(cancellationToken);
            //Espera de forma asíncrona a que se guarden
            //los cambios en la base de datos.
            return user.Id;
        }
    }
}
