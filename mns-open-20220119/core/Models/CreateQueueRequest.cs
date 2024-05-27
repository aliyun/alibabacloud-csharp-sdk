/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateQueueRequest : TeaModel {
        [NameInMap("DelaySeconds")]
        [Validation(Required=false)]
        public long? DelaySeconds { get; set; }

        [NameInMap("EnableLogging")]
        [Validation(Required=false)]
        public bool? EnableLogging { get; set; }

        [NameInMap("MaximumMessageSize")]
        [Validation(Required=false)]
        public long? MaximumMessageSize { get; set; }

        [NameInMap("MessageRetentionPeriod")]
        [Validation(Required=false)]
        public long? MessageRetentionPeriod { get; set; }

        [NameInMap("PollingWaitSeconds")]
        [Validation(Required=false)]
        public long? PollingWaitSeconds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateQueueRequestTag> Tag { get; set; }
        public class CreateQueueRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VisibilityTimeout")]
        [Validation(Required=false)]
        public long? VisibilityTimeout { get; set; }

    }

}
