/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DataTopicLagMapValue : TeaModel {
        [NameInMap("readyCount")]
        [Validation(Required=false)]
        public long? ReadyCount { get; set; }

        [NameInMap("inflightCount")]
        [Validation(Required=false)]
        public long? InflightCount { get; set; }

        [NameInMap("deliveryDuration")]
        [Validation(Required=false)]
        public long? DeliveryDuration { get; set; }

    }

}
