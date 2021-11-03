using Chat_e.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.Data
{
  public class MessageService
  {

    private readonly UserContext _context;


    public MessageService(UserContext context)
    {
      _context = context;

    }

    public async Task<string> PostMessage(Messages leMessage)
    {
        _context.Messages.Add(leMessage);
        await _context.SaveChangesAsync();
        return "ok";
    }

    public async Task<List<Messages>> GetMessage(DateTime date)
    {
      return await _context.Messages.Where(o => o.date.Hour >= date.Hour).Where(p => p.date.Minute >= date.Minute).Where(p => p.date.Second >= date.Second).ToListAsync();
    }

  }


}
