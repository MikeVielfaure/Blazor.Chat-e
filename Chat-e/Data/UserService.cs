using Chat_e.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.Data
{
  public class UserService
  {
    private readonly UserContext _context;
    

    public UserService(UserContext context)
    {
      _context = context;

    }

    public async Task<List<User>> GetAllUser()
    {
      return await _context.User.ToListAsync();
    }

    public async Task<string> PostUser(User utilisateur)
    {
      List<User> user = await _context.User.Where(o => o.id == utilisateur.id).ToListAsync();
      if (user.Count() == 0)
      {
        _context.User.Add(utilisateur);
        await _context.SaveChangesAsync();
        return "ok";
      }
      else
      {
        return "deja pris";
      }

    }

    public async Task<string> DeleteUser(string id)
    {
      var user = await _context.User.FindAsync(id);
      if (user == null)
      {
        return "null";
      }

      _context.User.Remove(user);
      await _context.SaveChangesAsync();

      return "ok";
    }

    private IActionResult NotFound()
    {
      throw new NotImplementedException();
    }
  }
}
