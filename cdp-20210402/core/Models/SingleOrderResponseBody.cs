// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class SingleOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SingleOrderResponseBodyData Data { get; set; }
        public class SingleOrderResponseBodyData : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterSize")]
            [Validation(Required=false)]
            public int? ClusterSize { get; set; }

            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public int? ClusterStatus { get; set; }

            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("EcsGroupList")]
            [Validation(Required=false)]
            public List<SingleOrderResponseBodyDataEcsGroupList> EcsGroupList { get; set; }
            public class SingleOrderResponseBodyDataEcsGroupList : TeaModel {
                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                [NameInMap("DiskCapacity")]
                [Validation(Required=false)]
                public int? DiskCapacity { get; set; }

                [NameInMap("DiskCount")]
                [Validation(Required=false)]
                public int? DiskCount { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("HostGroupName")]
                [Validation(Required=false)]
                public string HostGroupName { get; set; }

                [NameInMap("HostGroupType")]
                [Validation(Required=false)]
                public string HostGroupType { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                [NameInMap("SystemDiskCapacity")]
                [Validation(Required=false)]
                public int? SystemDiskCapacity { get; set; }

                [NameInMap("SystemDiskCount")]
                [Validation(Required=false)]
                public int? SystemDiskCount { get; set; }

                [NameInMap("SystemDiskType")]
                [Validation(Required=false)]
                public string SystemDiskType { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
