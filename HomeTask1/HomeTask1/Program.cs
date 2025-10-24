using HomeTask1__;

UsersService service = new UsersService();

User[] allUsers = service.GetAll();
Console.WriteLine("Istifadəçilər:");
for (int i = 0; i < allUsers.Length; i++)
{
    Console.WriteLine(allUsers[i]);
}

Console.WriteLine("______________________________________________");
int deleteId = 2;
service.Delete(deleteId, out bool deleted);
Console.WriteLine($"User silindi? {deleted}");


Console.WriteLine("______________________________________________");
User newUser = new User(17, "Seyid", "seyid@mail.com");
service.Create(ref newUser, out bool created);
Console.WriteLine($"Yeni user əlavə olundu? {created}");


Console.WriteLine("______________________________________________");
Console.WriteLine("Son veziyyet:");
allUsers = service.GetAll();
for (int i = 0; i < allUsers.Length; i++)
{
    Console.WriteLine(allUsers[i]);
}

