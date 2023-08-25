// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterHealthStatusResponseBody : TeaModel {
        [NameInMap("CS")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyCS CS { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyCS : TeaModel {
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        [NameInMap("Executor")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyExecutor Executor { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyExecutor : TeaModel {
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Worker")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyWorker Worker { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyWorker : TeaModel {
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

    }

}
