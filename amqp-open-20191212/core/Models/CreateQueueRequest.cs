// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateQueueRequest : TeaModel {
        [NameInMap("AutoDeleteState")]
        [Validation(Required=false)]
        public bool? AutoDeleteState { get; set; }

        [NameInMap("AutoExpireState")]
        [Validation(Required=false)]
        public long? AutoExpireState { get; set; }

        [NameInMap("DeadLetterExchange")]
        [Validation(Required=false)]
        public string DeadLetterExchange { get; set; }

        [NameInMap("DeadLetterRoutingKey")]
        [Validation(Required=false)]
        public string DeadLetterRoutingKey { get; set; }

        [NameInMap("ExclusiveState")]
        [Validation(Required=false)]
        public bool? ExclusiveState { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public long? MaxLength { get; set; }

        [NameInMap("MaximumPriority")]
        [Validation(Required=false)]
        public int? MaximumPriority { get; set; }

        [NameInMap("MessageTTL")]
        [Validation(Required=false)]
        public long? MessageTTL { get; set; }

        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
