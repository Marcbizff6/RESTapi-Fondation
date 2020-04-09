using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using Newtonsoft.Json.Linq;

namespace RestApi.Controllers
{
  [Route("api/interventions")]
  [ApiController]
  public class InterventionsController : ControllerBase
  {
    private readonly DatabaseContext _context;

      public InterventionsController(DatabaseContext context)
      {
        _context = context;
      }


      [HttpGet]
      // [HttpGet("get/status/all")]
      public async Task<ActionResult<List<Interventions>>> GetInterventionsList()
      {
        var list =  await _context.Interventions.ToListAsync();
          if (list == null)
          {
            return NotFound();
          }
      List<Interventions> listInterventions = new List<Interventions>();
        foreach (var intervention in list){
          if (intervention.id != null){
          listInterventions.Add(intervention);
            }
          }
            return listInterventions;
      }
  }
}