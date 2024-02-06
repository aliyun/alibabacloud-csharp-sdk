// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// The resource usage data.
        /// </summary>
        [NameInMap("EnsResourceUsage")]
        [Validation(Required=false)]
        public List<DescribeEnsResourceUsageResponseBodyEnsResourceUsage> EnsResourceUsage { get; set; }
        public class DescribeEnsResourceUsageResponseBodyEnsResourceUsage : TeaModel {
            /// <summary>
            /// The number of edge services. This parameter is available only when you set the ServiceType parameter to 2.
            /// </summary>
            [NameInMap("ComputeResourceCount")]
            [Validation(Required=false)]
            public int? ComputeResourceCount { get; set; }

            /// <summary>
            /// The CPU usage. Unit: cores.
            /// </summary>
            [NameInMap("CpuSum")]
            [Validation(Required=false)]
            public long? CpuSum { get; set; }

            /// <summary>
            /// The number of data disks.
            /// </summary>
            [NameInMap("DiskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            /// <summary>
            /// The number of stopped VMs.
            /// </summary>
            [NameInMap("DownCount")]
            [Validation(Required=false)]
            public int? DownCount { get; set; }

            /// <summary>
            /// The number of expired VM instances.
            /// </summary>
            [NameInMap("ExpiredCount")]
            [Validation(Required=false)]
            public int? ExpiredCount { get; set; }

            /// <summary>
            /// The number of VM instances that are about to expire.
            /// </summary>
            [NameInMap("ExpiringCount")]
            [Validation(Required=false)]
            public int? ExpiringCount { get; set; }

            /// <summary>
            /// The number of GPUs.
            /// </summary>
            [NameInMap("GpuSum")]
            [Validation(Required=false)]
            public long? GpuSum { get; set; }

            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The number of running instances.
            /// </summary>
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            /// <summary>
            /// The type of the service. Valid values:
            /// 
            /// *   1: subscription instance.
            /// *   2: edge service instance.
            /// *   3: pay-as-you-go instance.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The total disk size.
            /// </summary>
            [NameInMap("StorageSum")]
            [Validation(Required=false)]
            public long? StorageSum { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
