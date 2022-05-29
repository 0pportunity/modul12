// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
namespace Modul12
{
    using System;
    using System.Threading;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// method Main
        /// </summary>
        public static void Main()
        {
            User user = new User("login1", false);

            User.HelloUser(user);
        }
    }
}
