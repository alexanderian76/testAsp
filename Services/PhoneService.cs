using TestAsp.Models;

public class PhoneService: IPhoneService
{

    private readonly IBaseEditableRepository<Phone> _repository;
    public PhoneService(IBaseEditableRepository<Phone> repository)
	{
        _repository = repository;
	}

    public async Task<IBaseResponse<Phone>> Create(Phone phone)
    {
        var baseResponse = new BaseResponse<Phone>();
        baseResponse.Description = "Phone created";
        baseResponse.StatusCode = StatusCode.OK;
        
        await _repository.Create(phone);
        return baseResponse;
    }

    public async Task<IBaseResponse<Phone>> CreatePhones(IEnumerable<Phone> phones)
    {
        var baseResponse = new BaseResponse<Phone>();
        baseResponse.Description = "Phones created";
        baseResponse.StatusCode = StatusCode.OK;
        
        await _repository.CreateObjects(phones);
        return baseResponse;
    }

    public async Task<IBaseResponse<IEnumerable<Phone>>> GetAll()
    {
        var baseResponse = new BaseResponse<IEnumerable<Phone>>();
        try
        {
            baseResponse.Description = "Get Phones";
            baseResponse.StatusCode = StatusCode.OK;
            baseResponse.Data = await _repository.GetAll();
            return baseResponse;
        }
        catch(Exception)
        {
            baseResponse.Description = "Error during request";
            baseResponse.StatusCode = StatusCode.InternalServerError;
            return baseResponse;
        }
    }

    public async Task<IBaseResponse<Phone>> GetById(int id)
    {
        var baseResponse = new BaseResponse<Phone>();
        try
        {
            baseResponse.Description = "Get Phone";
            baseResponse.StatusCode = StatusCode.OK;
            baseResponse.Data = await _repository.Get(id);
            return baseResponse;
        }
        catch(Exception)
        {
            baseResponse.Description = "Error during request";
            baseResponse.StatusCode = StatusCode.InternalServerError;
            return baseResponse;
        }
    }
}


