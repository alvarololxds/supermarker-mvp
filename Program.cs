using Supermarket.mvp.Views;
using Supermarket.mvp.Models;
using Supermarket.mvp._Repositories;
using Supermarket.mvp.Properties;
using Supermarket.mvp.Presenters;

namespace Supermarket.mvp
{
    internal static class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view=new PayModeView();
            IPayModeRepository repository=new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
            Application.Run((Form) view);
        }
    }
}