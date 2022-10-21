// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class IncreaseNodeGroupParam : TeaModel {
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public long? NodeCount { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
