// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class EventSourceParameters : TeaModel {
        [NameInMap("sourceMNSParameters")]
        [Validation(Required=false)]
        public SourceMNSParameters SourceMNSParameters { get; set; }

        [NameInMap("sourceRabbitMQParameters")]
        [Validation(Required=false)]
        public SourceRabbitMQParameters SourceRabbitMQParameters { get; set; }

        [NameInMap("sourceRocketMQParameters")]
        [Validation(Required=false)]
        public SourceRocketMQParameters SourceRocketMQParameters { get; set; }

    }

}
