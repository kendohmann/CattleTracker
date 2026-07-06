using Microsoft.AspNetCore.Mvc;
using Api.Data;
using Api.Models;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CattleController : ControllerBase
{
    private readonly AppDbContext _db;
    public CattleController(AppDbContext db) => _db = db;

    [HttpGet]
    public ActionResult<IEnumerable<Cow>> Get() => Ok(_db.Cattle.Take(50).ToList());

    [HttpPost]
    public async Task<ActionResult<Cow>> Post(Cow cattle)
    {
        _db.Cattle.Add(cattle);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = cattle.Id }, cattle);
    }
}
