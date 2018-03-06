﻿using CommonTypes.Behaviours;
using CommonTypes.Settings;
using PubSub.Behaviours;
using System;
using System.Threading;

namespace PubSub.AWS
{
    public class AWSQueueSubscriber<T> : IQueueSubscriber<T>
    {
        private IAppLogger _appLogger;
        private AWSSettings _awsSettings;

        public AWSQueueSubscriber(IAppLogger appLogger, AWSSettings awsSettings)
        {
            _appLogger = appLogger;
            _awsSettings = awsSettings;
        }

        public void Process(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
