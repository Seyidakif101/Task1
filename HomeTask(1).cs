using System;

namespace HomeTask1__
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Email:{Email}";
        }
    }
    public class UsersService
    {
        private User[] users;
        public UsersService()
        {
            users = new User[16]
            {
                new User(1, "Akif", "akif@mail.com"),
                new User(2, "Nihad", "nihad@mail.com"),
                new User(3, "Gülmirzə", "gulmirze@mail.com"),
                new User(4, "Ümid", "umid@mail.com"),
                new User(5, "Əşrəf", "eshref@mail.com"),
                new User(6, "Saleh", "saleh@mail.com"),
                new User(7, "Fərid", "ferid@mail.com"),
                new User(8, "Adham", "adham@mail.com"),
                new User(9, "Davud", "davud@mail.com"),
                new User(10, "Rəksanə", "reksane@mail.com"),
                new User(11, "Çinarə", "chinare@mail.com"),
                new User(12, "Aziməxamın", "azimexamin@mail.com"),
                new User(13, "Nurlan", "nurlan@mail.com"),
                new User(14, "Nihat", "nihat@mail.com"),
                new User(15, "Cavid", "cavid@mail.com"),
                new User(16, "İslam", "islam@mail.com")
            };

        }
        public void Create(ref User usern, out bool seyid)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id == usern.Id)
                {
                    Console.WriteLine("User artiq movcuddur");
                    seyid = false;
                    break;
                }
            }
            Array.Resize(ref users, users.Length+1);
            users[users.Length-1] = usern;
            /*User[] newUsers1 = new User[users.Length +1];
            int n = 0;
            for (int j = 0; j < users.Length; j++)
            {

                newUsers1[n] = users[j];
                n++;
            }
            //users = newUsers1;
            newUsers1[n] = usern;
            for(int i = 0;i < newUsers1.Length; i++)
            {
                Console.WriteLine(newUsers1[i]);
            }*/
            seyid = true;
        }
        public User[] GetAll()
        {
            return users;
        }
        public User GetById(int id)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id == id)
                {
                    return users[i];
                }
            }
            return null;
        }
        public void Delete(int id, out bool seyid)
        {
            int indeks = -1;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Id == id)
                {
                    indeks = i;
                    break;
                }

            }
            if (indeks == -1)
            {
                seyid = false;
                Console.WriteLine("Id Tapilmadi");
                return;
            }
            User[] newUsers2 = new User[users.Length - 1];
            int n = 0;
            for (int j = 0; j < users.Length; j++)
            {
                if (j == indeks) continue;

                newUsers2[n++] = users[j];
            }
            users = newUsers2;

            seyid = true;

        }


    }
}

