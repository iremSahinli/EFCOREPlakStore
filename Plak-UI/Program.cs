using Plak_DAL.Context;
using Plak_DAL.Repository;
using Plak_DATA.Entity;

namespace Plak_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //// To customize application configuration such as set high DPI settings or default font,
        //// see https://aka.ms/applicationconfiguration.
        //ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());

        //}
        static void Main()  //bu kýsýmda form bizden repository parametrelerini bekliyor burayý yazmamýz gerek.
        {
            using (var context = new AppDbContext())
            {
                var albumRepository = new AlbumRepository(context);
                var adminRepository = new AdminRepository(context);
                var admin = new Admin();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(context, albumRepository, adminRepository, admin));
            }
        }
    }
}