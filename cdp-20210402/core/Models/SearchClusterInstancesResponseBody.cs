// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class SearchClusterInstancesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchClusterInstancesResponseBodyData> Data { get; set; }
        public class SearchClusterInstancesResponseBodyData : TeaModel {
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            [NameInMap("ClusterBizId")]
            [Validation(Required=false)]
            public string ClusterBizId { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterInstanceInfo")]
            [Validation(Required=false)]
            public SearchClusterInstancesResponseBodyDataClusterInstanceInfo ClusterInstanceInfo { get; set; }
            public class SearchClusterInstancesResponseBodyDataClusterInstanceInfo : TeaModel {
                [NameInMap("ControlCenterLoginName")]
                [Validation(Required=false)]
                public string ControlCenterLoginName { get; set; }

                [NameInMap("ControlCenterUrl")]
                [Validation(Required=false)]
                public string ControlCenterUrl { get; set; }

                [NameInMap("SgId")]
                [Validation(Required=false)]
                public string SgId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

            }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            [NameInMap("ClusterStatusValue")]
            [Validation(Required=false)]
            public int? ClusterStatusValue { get; set; }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("ControlCenterUrl")]
            [Validation(Required=false)]
            public string ControlCenterUrl { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("EcsGroupList")]
            [Validation(Required=false)]
            public List<SearchClusterInstancesResponseBodyDataEcsGroupList> EcsGroupList { get; set; }
            public class SearchClusterInstancesResponseBodyDataEcsGroupList : TeaModel {
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
                public string SystemDiskCapacity { get; set; }

                [NameInMap("SystemDiskCount")]
                [Validation(Required=false)]
                public int? SystemDiskCount { get; set; }

                [NameInMap("SystemDiskType")]
                [Validation(Required=false)]
                public string SystemDiskType { get; set; }

            }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("InstanceConf")]
            [Validation(Required=false)]
            public Dictionary<string, object> InstanceConf { get; set; }

            [NameInMap("NoticeConfirmed")]
            [Validation(Required=false)]
            public bool? NoticeConfirmed { get; set; }

            [NameInMap("OrderBizId")]
            [Validation(Required=false)]
            public string OrderBizId { get; set; }

            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

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

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
