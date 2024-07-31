// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetSubscriptionAttributesRequest : TeaModel {
        /// <summary>
        /// The retry policy that is applied if an error occurs when Message Service (MNS) pushes messages to the endpoint. Valid values:
        /// 
        /// *   BACKOFF_RETRY
        /// *   EXPONENTIAL_DECAY_RETRY
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// The name of the subscription.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// The name of the topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
