using Microsoft.AspNetCore.Mvc;
using TechnicalTestDotNet.Core.Interfaces.Qualifications;

namespace TechnicalTestDotNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // [ApiController, Authorize]
    public class QualificationsController : ControllerBase
    {
        #region Dependency Injection
        private readonly IQualificationsRepository _IRepository;
        public QualificationsController(IQualificationsRepository IQualificationsRepository)
        {
            _IRepository = IQualificationsRepository;
        }
        #endregion

        // Servicios        
    }
}
