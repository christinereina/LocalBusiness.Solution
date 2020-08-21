using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        private LocalBusinessContext _db;

        public BusinessesController(LocalBusinessContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Business>> Get(string name, string rating, string type, string address, string hours, string servicesOffered)
        {
        var query = _db.Businesses.AsQueryable();

        if (name != null)
        {
            query = query.Where(entry => entry.Name == name);
        }

        if (rating != null)
        {
            query = query.Where(entry => entry.Rating == rating);
        }

        if (type != null)
        {
            query = query.Where(entry => entry.Type == type);
        }

        if (address != null)
        {
            query = query.Where(entry => entry.Address == address);
        }

        if (hours != null)
        {
            query = query.Where(entry => entry.Hours == hours);
        }

        if (servicesOffered != null)
        {
            query = query.Where(entry => entry.ServicesOffered == servicesOffered);
        }

        return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Business business)
        {
            _db.Businesses.Add(business);
            _db.SaveChanges();
        }

         [HttpGet("{id}")]
        public ActionResult<Business> Get(int id)
        {
        return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Business business)
        {
            business.BusinessId = id;
            _db.Entry(business).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
        _db.Businesses.Remove(businessToDelete);
        _db.SaveChanges();
        }
        
    }
}