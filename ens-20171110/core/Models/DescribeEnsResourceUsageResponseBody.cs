// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsResourceUsageResponseBody : TeaModel {
        [NameInMap("EnsResourceUsage")]
        [Validation(Required=false)]
        public List<DescribeEnsResourceUsageResponseBodyEnsResourceUsage> EnsResourceUsage { get; set; }
        public class DescribeEnsResourceUsageResponseBodyEnsResourceUsage : TeaModel {
            [NameInMap("ComputeResourceCount")]
            [Validation(Required=false)]
            public int? ComputeResourceCount { get; set; }

            [NameInMap("CpuSum")]
            [Validation(Required=false)]
            public long? CpuSum { get; set; }

            [NameInMap("DiskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            [NameInMap("DownCount")]
            [Validation(Required=false)]
            public int? DownCount { get; set; }

            [NameInMap("ExpiredCount")]
            [Validation(Required=false)]
            public int? ExpiredCount { get; set; }

            [NameInMap("ExpiringCount")]
            [Validation(Required=false)]
            public int? ExpiringCount { get; set; }

            [NameInMap("GpuSum")]
            [Validation(Required=false)]
            public long? GpuSum { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("StorageSum")]
            [Validation(Required=false)]
            public long? StorageSum { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
