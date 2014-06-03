using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MF0493_e3.Models
{
    public class UsuarioManager
    {
        public static usuario getUsuario(string username) 
        {
            using (MySQL_Entities db = new MySQL_Entities())
            {
                var data = from usr in db.usuarios
                           where usr.username == username
                           select usr;
                return data.First();
            }
        }
    }
}