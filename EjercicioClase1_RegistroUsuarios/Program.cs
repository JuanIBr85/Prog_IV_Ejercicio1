using EjercicioClase1_RegistroUsuarios.Formularios;
using EjercicioClase1_RegistroUsuarios.Interfaces;
using EjercicioClase1_RegistroUsuarios.Service;
using Microsoft.Extensions.DependencyInjection;

namespace EjercicioClase1_RegistroDeUsuarios
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

            var services = new ServiceCollection();
            ConfiguracionServicios(services);

            using (var serviceProvider = services.BuildServiceProvider()) 
            
            { 
                var formularioInicio = serviceProvider.GetService<FormularioInicio>();
                Application.Run(formularioInicio);
            }

            
      
        }

        private static void ConfiguracionServicios (ServiceCollection services) 
        {
            services.AddScoped<IUsuario, UsuarioService>().AddScoped<FormularioInicio>();
        }
    }

} 