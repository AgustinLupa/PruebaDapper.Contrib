namespace Fast_Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            var result = data.GetUsers();
            foreach (var users in result)
            {
                Console.WriteLine(users.ToString());
            }
            var user = new UserDTO () { 
                Name = "usuario",
                Password = "usuario"
                };
            var resultByInsert= data.Insert(user);
            Console.WriteLine(resultByInsert);
        }
    }
}