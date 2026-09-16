using MediatR;

namespace Application.User.Commands.CreateUser;
//Representa la petición para crear un nuevo usuario.
//recibe nombre, apellido, y email.
//MediatR enviará esta petición al handler correspondiente
//El handler devolverá el ID del usuario creado como respuesta.
public record CreateUserCommand(
    string FirstName,
    string LastName,
    string Email
) : IRequest<int>;
