// <copyright file="User.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
namespace Modul12
{
    using System;
    using System.Threading;

    /// <summary>
    /// User class
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="login">User login</param>
        /// <param name="name">User name</param>
        /// <param name="isPremium">Special access.</param>
        public User(string login, string name, bool isPremium)
        {
            this.Login = login;
            this.Name = name;
            this.IsPremium = isPremium;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="login">User login</param>
        public User(string login)
        {
            this.Login = login;
            this.Name = login;
            this.IsPremium = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="login">User login</param>
        /// <param name="isPremium">Special access.</param>
        public User(string login, bool isPremium)
        {
            this.Login = login;
            this.Name = login;
            this.IsPremium = isPremium;
        }

        /// <summary>
        /// Gets or sets user login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets user name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether have premium
        /// </summary>
        public bool IsPremium { get; set; }

        /// <summary>
        /// method ShowAds
        /// </summary>
        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");

            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");

            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");

            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        /// <summary>
        /// method HelloUser
        /// </summary>
        /// <param name="user">Instance User</param>
        public static void HelloUser(User user)
        {
            Console.WriteLine("Здравствуйте, {0}!", user.Name);

            if (user.IsPremium == false)
            {
                ShowAds();
            }
        }
    }    
}
