using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zadanie09.Entities;

namespace Zadanie09;

[ApiController]
[Route("/clients")]
public class HolidayController
{
    [HttpGet]
    public async Task<IActionResult> GetClients(CancellationToken cancellationToken)
    {
        OkonekDbContext context = new();
        
        List<ClientDTO> clients = await context.Clients
            .Include(x => x.IdClient)
            .Select(x => new ClientDTO() tworze obiekt z DTO)
            .ToListAsync(cancellationToken)
            
    }
}