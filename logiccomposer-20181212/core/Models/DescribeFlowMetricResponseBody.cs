// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeFlowMetricResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InvocationCount")]
        [Validation(Required=false)]
        public long? InvocationCount { get; set; }

        [NameInMap("InvocationErrorCount")]
        [Validation(Required=false)]
        public long? InvocationErrorCount { get; set; }

        [NameInMap("ErrorRate")]
        [Validation(Required=false)]
        public float? ErrorRate { get; set; }

        [NameInMap("CostAverage")]
        [Validation(Required=false)]
        public long? CostAverage { get; set; }

    }

}
