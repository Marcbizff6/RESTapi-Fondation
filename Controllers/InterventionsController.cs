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

      [HttpGet("get/status/all")]
      public async Task<ActionResult<List<Interventions>>> GetInterventionsAllStatusList()
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

      [HttpGet("get/status/{id}")]
      public async Task<ActionResult<List<Interventions>>> GetInterventionsAllStatusList(long id)
      {
        var list =  await _context.Interventions.ToListAsync();
          if (list == null)
          {
            return NotFound();
          }
      List<Interventions> listInterventions = new List<Interventions>();
        foreach (var intervention in list){
          if (intervention.id == id){
          listInterventions.Add(intervention);
            }
          }
            return listInterventions;
      }

      [HttpGet("get/status/!pending!started")]
      public async Task<ActionResult<List<Interventions>>> GetInterventionsNotPendingList()
      {
        var list =  await _context.Interventions.ToListAsync();
          if (list == null)
          {
            return NotFound();
          }
      List<Interventions> listInterventions = new List<Interventions>();
        foreach (var intervention in list){
          if (intervention.status != "Pending" && intervention.start_date == null ){
          listInterventions.Add(intervention);
            }
          }
            return listInterventions;
      }

      [HttpPut("put/inprogress/{id}")]
      public IActionResult PutInterventionsInProgressList(long id, Interventions item)
      {
        var inter =  _context.Interventions.Find(id);
          if (inter == null)
          {
            return NotFound();
          }

          inter.status = "InProgress";
          inter.start_date = DateTime.Now ;
            _context.Interventions.Update(inter);
            _context.SaveChanges();
    
            var jsonPut = new JObject ();
            jsonPut["Update"] = "Update done to intervention id : " + id + " to the status : " + inter.status + " starting at " + inter.start_date;
            return Content  (jsonPut.ToString(), "application/json");
        
        }

      [HttpPut("put/completed/{id}")]
      public IActionResult PutInterventionsCompletedList(long id, Interventions item)
      {
        var inter =  _context.Interventions.Find(id);
          if (inter == null)
          {
            return NotFound();
          }

          inter.status = "Completed";
          inter.end_date = DateTime.Now ;
            _context.Interventions.Update(inter);
            _context.SaveChanges();
    
            var jsonPut = new JObject ();
            jsonPut["Update"] = "Update done to intervention id : " + id + " to the status : " + inter.status + " ending at " + inter.end_date;
            return Content  (jsonPut.ToString(), "application/json");
        
        }
  }
}