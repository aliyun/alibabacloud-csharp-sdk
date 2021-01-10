// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeAccountSummaryResponseBody : TeaModel {
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("OnlineInstanceCount")]
        [Validation(Required=false)]
        public long? OnlineInstanceCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InvocationCount")]
        [Validation(Required=false)]
        public long? InvocationCount { get; set; }

        [NameInMap("DailyInvocationErrorCount")]
        [Validation(Required=false)]
        public long? DailyInvocationErrorCount { get; set; }

    }

}
