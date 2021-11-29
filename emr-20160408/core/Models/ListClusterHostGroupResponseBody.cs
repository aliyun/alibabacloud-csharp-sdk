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
                public string ChargeType { get; set; }
                public string Comment { get; set; }
                public float? CostSavingPercent { get; set; }
                public int? Cpu { get; set; }
                public int? DataDiskCount { get; set; }
                public int? DataDiskSize { get; set; }
                public string DataDiskType { get; set; }
                public string HostGroupChangeStatus { get; set; }
                public string HostGroupChangeType { get; set; }
                public string HostGroupId { get; set; }
                public string HostGroupName { get; set; }
                public string HostGroupSubType { get; set; }
                public string HostGroupType { get; set; }
                public string InstanceType { get; set; }
                public string LockReason { get; set; }
                public string LockType { get; set; }
                public int? Memory { get; set; }
                public int? NodeCount { get; set; }
                public string PayType { get; set; }
                public string ScalingGroupActiveStatus { get; set; }
                public string ScalingGroupBizId { get; set; }
                public string ScalingGroupConfigState { get; set; }
                public int? ScalingGroupMaxNode { get; set; }
                public int? ScalingGroupMinNode { get; set; }
                public string ScalingInMode { get; set; }
                public string SecurityGroupId { get; set; }
                public string Status { get; set; }
                public int? SystemDiskCount { get; set; }
                public int? SystemDiskSize { get; set; }
                public string SystemDiskType { get; set; }
                public string VswitchId { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
            }
        };

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
