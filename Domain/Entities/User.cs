using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FintechWallet.Domain.Entities;

public class User
{   
    public DateTime CreatedAt { get; set; }
      //Properties of the User class
    public int Id { get; set; } //Connedted to the Wallet entity
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }


    //crtl+k crtl+u 
    //public user(string firstname, string lastname, string email)
    //{
    //    id = guid.newguid();
    //    firstname = firstname;
    //    lastname = lastname;
    //    email = email;
    //    createdat = datetime.utcnow; //guarda la fecha y hora de la creacion


    //}
}
