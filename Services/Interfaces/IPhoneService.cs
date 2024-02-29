using System;
using TestAsp.Models;

public interface IPhoneService
{
	Task<IBaseResponse<Phone>> GetById(int id);
	Task<IBaseResponse<IEnumerable<Phone>>> GetAll();
	Task<IBaseResponse<Phone>> Create(Phone phone);
	Task<IBaseResponse<Phone>> CreatePhones(IEnumerable<Phone> phones);
}


