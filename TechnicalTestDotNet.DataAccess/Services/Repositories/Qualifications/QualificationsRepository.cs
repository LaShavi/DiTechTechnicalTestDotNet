using AutoMapper;
using Microsoft.Extensions.Configuration;
using TechnicalTestDotNet.Core.Interfaces.Qualifications;
using TechnicalTestDotNet.DataAccess.DataBase;

namespace TechnicalTestDotNet.DataAccess.Services.Repositories.Qualifications
{
    public class QualificationsRepository: IQualificationsRepository
    {
        #region Dependency Injection

        private readonly dbContext _dbContext;
        public IConfiguration Configuration { get; }
        private readonly IMapper _mapper;
        Utils _util = new Utils();

        public QualificationsRepository(dbContext dbContext, IConfiguration configuration, IMapper mapper)
        {
            _dbContext = dbContext;
            Configuration = configuration;
            _mapper = mapper;
        }
        #endregion
    }
}
