// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventSourceParameters : TeaModel {
        [NameInMap("sourceDTSParameters")]
        [Validation(Required=false)]
        public SourceDTSParameters SourceDTSParameters { get; set; }

        [NameInMap("sourceKafkaParameters")]
        [Validation(Required=false)]
        public SourceKafkaParameters SourceKafkaParameters { get; set; }

        [NameInMap("sourceMNSParameters")]
        [Validation(Required=false)]
        public SourceMNSParameters SourceMNSParameters { get; set; }

        [NameInMap("sourceMQTTParameters")]
        [Validation(Required=false)]
        public SourceMQTTParameters SourceMQTTParameters { get; set; }

        [NameInMap("sourceRabbitMQParameters")]
        [Validation(Required=false)]
        public SourceRabbitMQParameters SourceRabbitMQParameters { get; set; }

        [NameInMap("sourceRocketMQParameters")]
        [Validation(Required=false)]
        public SourceRocketMQParameters SourceRocketMQParameters { get; set; }

    }

}
