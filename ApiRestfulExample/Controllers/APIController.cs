using System.Collections.Generic;
using System.Threading.Tasks;
using ApiRestfulExample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("[controller]")]
public class APIController : ControllerBase
{
    private readonly RestAPIDbContext _context;

    public APIController(RestAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ApiData>>> GetApiData()
    {
        return await _context.ApiData.ToListAsync();
    }
}
