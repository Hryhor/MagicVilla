using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController : ControllerBase
    {
        private readonly IVillaRepository _dbVilla;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IMapper _mapper;
        protected APIResponse _response;


        public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            _response = new();
            _dbVilla = dbVilla;
        }


        [HttpGet]
        //[MapToApiVersion("2.0")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
