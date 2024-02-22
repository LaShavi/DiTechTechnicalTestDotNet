using AutoMapper;
using Microsoft.Extensions.Configuration;
using TechnicalTestDotNet.Core.Interfaces.Courses;
using TechnicalTestDotNet.DataAccess.DataBase;

namespace TechnicalTestDotNet.DataAccess.Services.Repositories.Courses
{
    public class CoursesRepository: ICoursesRepository
    {
        #region Dependency Injection

        private readonly dbContext _dbContext;
        public IConfiguration Configuration { get; }
        private readonly IMapper _mapper;
        Utils _util = new Utils();

        public CoursesRepository(dbContext dbContext, IConfiguration configuration, IMapper mapper)
        {
            _dbContext = dbContext;
            Configuration = configuration;
            _mapper = mapper;
        }
        #endregion
    }
}

