using HotelsRent.Data; // Aseg�rate de tener esta importaci�n para el DbContext
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace hotelsRent.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HotelDbContext _context;

        // Propiedad para pasar el mensaje de conexi�n a la vista
        public string DbConnectionMessage { get; set; }

        public IndexModel(ILogger<IndexModel> logger, HotelDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // M�todo OnGet modificado para verificar la conexi�n a la base de datos
        public async Task OnGetAsync()
        {
            try
            {
                // Intentamos conectar a la base de datos
                bool canConnect = await _context.Database.CanConnectAsync();
                if (canConnect)
                {
                    DbConnectionMessage = "Connection to the database was successful!";
                }
                else
                {
                    DbConnectionMessage = "Unable to connect to the database, please check your connection.";
                }
            }
            catch (Exception ex)
            {
                // Capturamos el mensaje de la excepci�n y lo mostramos
                DbConnectionMessage = $"Failed to connect to the database. Error: {ex.Message}";

                // Si necesitas informaci�n m�s detallada, tambi�n puedes registrar el StackTrace
                _logger.LogError($"Error connecting to the database: {ex.StackTrace}");
            }
        }

    }
}
