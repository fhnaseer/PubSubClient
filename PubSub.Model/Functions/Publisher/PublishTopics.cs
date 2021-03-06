﻿using System.Collections.Generic;
using PubSub.Model.Responses;

namespace PubSub.Model.Functions.Publisher
{
    public class PublishTopics : PostServerlessFunctionBase
    {
        public PublishTopics(string baseAddress) : base(baseAddress)
        {
        }

        public override string Name => "Publish Topics";

        protected override string FunctionRelativeAddress => "publishtopic";

        private MessageBase _sampleMessageInput;
        public override MessageBase SampleMessageInput => _sampleMessageInput ?? (_sampleMessageInput = new PublishTopicsInput
        {
            Message = "This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random string. This is some random.",
            Topics = new List<string> { "computer" }
        });
    }
}