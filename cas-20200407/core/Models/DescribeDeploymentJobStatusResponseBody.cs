// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobStatusResponseBody : TeaModel {
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public int? BuyCount { get; set; }

        [NameInMap("CertCount")]
        [Validation(Required=false)]
        public int? CertCount { get; set; }

        [NameInMap("CostCount")]
        [Validation(Required=false)]
        public int? CostCount { get; set; }

        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        [NameInMap("MatchWorkerCount")]
        [Validation(Required=false)]
        public int? MatchWorkerCount { get; set; }

        [NameInMap("ProductWorkerCount")]
        [Validation(Required=false)]
        public List<DescribeDeploymentJobStatusResponseBodyProductWorkerCount> ProductWorkerCount { get; set; }
        public class DescribeDeploymentJobStatusResponseBodyProductWorkerCount : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceCount")]
        [Validation(Required=false)]
        public int? ResourceCount { get; set; }

        [NameInMap("RollbackCount")]
        [Validation(Required=false)]
        public int? RollbackCount { get; set; }

        [NameInMap("RollbackFailedCount")]
        [Validation(Required=false)]
        public int? RollbackFailedCount { get; set; }

        [NameInMap("RollbackSuccessCount")]
        [Validation(Required=false)]
        public int? RollbackSuccessCount { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public int? UseCount { get; set; }

        [NameInMap("WorkerCount")]
        [Validation(Required=false)]
        public int? WorkerCount { get; set; }

    }

}
