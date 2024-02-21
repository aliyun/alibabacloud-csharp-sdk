// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterHostGroupResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("HostGroupList")]
        [Validation(Required=false)]
        public ListClusterHostGroupResponseBodyHostGroupList HostGroupList { get; set; }
        public class ListClusterHostGroupResponseBodyHostGroupList : TeaModel {
            [NameInMap("HostGroup")]
            [Validation(Required=false)]
            public List<ListClusterHostGroupResponseBodyHostGroupListHostGroup> HostGroup { get; set; }
            public class ListClusterHostGroupResponseBodyHostGroupListHostGroup : TeaModel {
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CostSavingPercent")]
                [Validation(Required=false)]
                public float? CostSavingPercent { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("DataDiskCount")]
                [Validation(Required=false)]
                public int? DataDiskCount { get; set; }

                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public int? DataDiskSize { get; set; }

                [NameInMap("DataDiskType")]
                [Validation(Required=false)]
                public string DataDiskType { get; set; }

                [NameInMap("HostGroupChangeStatus")]
                [Validation(Required=false)]
                public string HostGroupChangeStatus { get; set; }

                [NameInMap("HostGroupChangeType")]
                [Validation(Required=false)]
                public string HostGroupChangeType { get; set; }

                [NameInMap("HostGroupId")]
                [Validation(Required=false)]
                public string HostGroupId { get; set; }

                [NameInMap("HostGroupName")]
                [Validation(Required=false)]
                public string HostGroupName { get; set; }

                [NameInMap("HostGroupSubType")]
                [Validation(Required=false)]
                public string HostGroupSubType { get; set; }

                [NameInMap("HostGroupType")]
                [Validation(Required=false)]
                public string HostGroupType { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("LockType")]
                [Validation(Required=false)]
                public string LockType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("ScalingGroupActiveStatus")]
                [Validation(Required=false)]
                public string ScalingGroupActiveStatus { get; set; }

                [NameInMap("ScalingGroupBizId")]
                [Validation(Required=false)]
                public string ScalingGroupBizId { get; set; }

                [NameInMap("ScalingGroupConfigState")]
                [Validation(Required=false)]
                public string ScalingGroupConfigState { get; set; }

                [NameInMap("ScalingGroupMaxNode")]
                [Validation(Required=false)]
                public int? ScalingGroupMaxNode { get; set; }

                [NameInMap("ScalingGroupMinNode")]
                [Validation(Required=false)]
                public int? ScalingGroupMinNode { get; set; }

                [NameInMap("ScalingInMode")]
                [Validation(Required=false)]
                public string ScalingInMode { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SystemDiskCount")]
                [Validation(Required=false)]
                public int? SystemDiskCount { get; set; }

                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                [NameInMap("SystemDiskType")]
                [Validation(Required=false)]
                public string SystemDiskType { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
