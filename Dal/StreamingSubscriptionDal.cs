using AutoMapper;
using Dal.Interfaces;
using DAL.Abstracts;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Dal
{
    public class StreamingSubscriptionDal : AbstractBasicDal<StreamingSubscription>, IStreamingSubscriptionDal
    {
        private readonly IMapper _mapper;
        
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Constructor dependency injection
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="mapper"></param>
        public StreamingSubscriptionDal(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        /// <inheritdoc />
        /// <summary>
        /// Instance of AutoMapper
        /// </summary>
        /// <returns></returns>
        protected override IMapper GetMapper() => _mapper;

        /// <inheritdoc />
        /// <summary>
        /// Returns the database context
        /// </summary>
        /// <returns></returns>
        protected override DbContext GetDbContext() => _dbContext;

        /// <inheritdoc />
        /// <summary>
        /// Returns DbSet
        /// </summary>
        /// <returns></returns>
        protected override DbSet<StreamingSubscription> GetDbSet() => _dbContext.StreamingSubscriptions;
    }
}