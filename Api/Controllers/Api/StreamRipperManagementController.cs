using Api.Abstracts;
using Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace Api.Controllers.Api
{
    // [Authorize]
    [Route("api/[controller]")]
    public class StreamRipperManagementController : AbstractBasicCrudController<StreamingSubscription>
    {
        private readonly IStreamingSubscriptionLogic _streamingSubscriptionLogic;

        public StreamRipperManagementController(IStreamingSubscriptionLogic streamingSubscriptionLogic)
        {
            _streamingSubscriptionLogic = streamingSubscriptionLogic;
        }
        
        protected override IBasicLogic<StreamingSubscription> BasicLogic()
        {
            return _streamingSubscriptionLogic;
        }
    }
}