using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Models.Entities;

namespace Models.Profiles
{
    public class StreamingSubscriptionProfile : Profile
    {
        public StreamingSubscriptionProfile()
        {
            CreateMap<StreamingSubscription, StreamingSubscription>()
                .EqualityComparison((x, y) => x.Id == y.Id);
        }
    }
}