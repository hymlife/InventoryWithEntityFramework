using Inventory.Business.Abstract;
using Inventory.Business.Concrete;
using Inventory.DataAccess.Abstract;
using Inventory.DataAccess.Concrete.EntityFrameWork;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryWithEntityFramework
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IDeviceInformationDal, EfDeviceInformationDal>();
                    services.AddSingleton<IDeviceInformationService, DeviceInformationManager>();
                    services.AddSingleton<Form1>();
                })
                .Build()
                .Services
                .GetRequiredService<Form1>()
                .ShowDialog();
        }
    }
}