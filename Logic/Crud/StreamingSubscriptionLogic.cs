using Dal.Interfaces;
using Logic.Abstracts;
using Logic.Interfaces;
using Models.Entities;

namespace Logic.Crud
{
    public class StreamingSubscriptionLogic : AbstractBasicLogic<StreamingSubscription>, IStreamingSubscriptionLogic
    {
        private readonly IStreamingSubscriptionDal _streamingSubscriptionDal;

        /// <summary>
        /// Constructor dependency injection
        /// </summary>
        /// <param name="streamingSubscriptionDal"></param>
        public StreamingSubscriptionLogic(IStreamingSubscriptionDal streamingSubscriptionDal)
        {
            _streamingSubscriptionDal = streamingSubscriptionDal;
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns DAL
        /// </summary>
        /// <returns></returns>
        protected override IBasicDal<StreamingSubscription> GetBasicCrudDal() => _streamingSubscriptionDal;
    }
}