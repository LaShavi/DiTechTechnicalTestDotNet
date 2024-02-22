using Microsoft.AspNetCore.Mvc;
using TechnicalTestDotNet.Core.Interfaces.Courses;

namespace TechnicalTestDotNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // [ApiController, Authorize]
    public class CoursesController : ControllerBase
    {
        #region Dependency Injection
        private readonly ICoursesRepository _IRepository;
        public CoursesController(ICoursesRepository ICoursesRepository)
        {
            _IRepository = ICoursesRepository;
        }
        #endregion

        // Servicios        
    }
}
