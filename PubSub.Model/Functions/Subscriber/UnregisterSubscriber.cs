﻿using PubSub.Model.Responses;

namespace PubSub.Model.Functions.Subscriber
{
    public class UnregisterSubscriber : PostServerlessFunctionBase
    {
        public UnregisterSubscriber(string baseAddress)
            : base(baseAddress)
        {
        }

        public override string Name => "Unregister Subscriber";

        protected override string FunctionRelativeAddress => "unregistersubscriber";

        public override MessageBase SampleMessageInput => new UnregisterSubscriberInput
        {
            SubscriberId = ""
        };
    }
}
