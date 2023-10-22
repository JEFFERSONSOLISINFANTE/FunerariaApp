using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunerariaApp.Services
{
    public class Conexionfirebase
    {
        public static FirebaseClient firebase = new FirebaseClient("https://funerariaapp-b57ed-default-rtdb.firebaseio.com/");
    }
}
