using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using TestAsp.Models;

public class PhoneRepository: IBaseEditableRepository<Phone>
{
    private readonly MobileContext _db;
	public PhoneRepository(MobileContext db)
	{
        _db = db;
	}

    public async Task Create(Phone obj)
    {
        
        await _db.Phones.AddAsync(obj);
        await _db.SaveChangesAsync();
       
    }

    public async Task CreateObjects(IEnumerable<Phone> obj)
    {
        await _db.Phones.ExecuteDeleteAsync();
        await _db.Phones.AddRangeAsync(obj);
        await _db.SaveChangesAsync();
    }

    public async Task<Phone> Get(int id)
    {
        var phone = await _db.Phones.FirstAsync(x => x.Id == id);
        
        return phone;
    }

    public async Task<IEnumerable<Phone>> GetAll()
    {
        return _db.Phones.ToList();
    }
}


public interface IPhoneRepository : IBaseEditableRepository<Phone>
{
    new Task<Phone> Get(int id);
    new Task Create(Phone phone);

}