// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class CreateQueueRequest : TeaModel {
        [NameInMap("AutoDelete")]
        [Validation(Required=false)]
        public bool? AutoDelete { get; set; }

        [NameInMap("AutoExpire")]
        [Validation(Required=false)]
        public long? AutoExpire { get; set; }

        [NameInMap("ConsoleSessionId")]
        [Validation(Required=false)]
        public string ConsoleSessionId { get; set; }

        [NameInMap("DeadLetterExchange")]
        [Validation(Required=false)]
        public string DeadLetterExchange { get; set; }

        [NameInMap("DeadLetterRoutingKey")]
        [Validation(Required=false)]
        public string DeadLetterRoutingKey { get; set; }

        [NameInMap("Exclusive")]
        [Validation(Required=false)]
        public bool? Exclusive { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public long? MaxLength { get; set; }

        [NameInMap("MaximunPrioty")]
        [Validation(Required=false)]
        public long? MaximunPrioty { get; set; }

        [NameInMap("MessageTTL")]
        [Validation(Required=false)]
        public long? MessageTTL { get; set; }

        [NameInMap("Ordered")]
        [Validation(Required=false)]
        public bool? Ordered { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("RetryInherit")]
        [Validation(Required=false)]
        public bool? RetryInherit { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

        [NameInMap("SingleActiveConsumer")]
        [Validation(Required=false)]
        public bool? SingleActiveConsumer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VhostName")]
        [Validation(Required=false)]
        public string VhostName { get; set; }

    }

}
