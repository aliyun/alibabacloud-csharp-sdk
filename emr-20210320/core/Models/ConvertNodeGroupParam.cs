// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ConvertNodeGroupParam : TeaModel {
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public long? PaymentDuration { get; set; }

        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

    }

}
