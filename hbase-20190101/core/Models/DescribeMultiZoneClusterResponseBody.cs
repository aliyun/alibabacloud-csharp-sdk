// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneClusterResponseBody : TeaModel {
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        [NameInMap("ModuleStackVersion")]
        [Validation(Required=false)]
        public string ModuleStackVersion { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("PrimaryVSwitchIds")]
        [Validation(Required=false)]
        public string PrimaryVSwitchIds { get; set; }

        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        [NameInMap("LogDiskCount")]
        [Validation(Required=false)]
        public string LogDiskCount { get; set; }

        [NameInMap("IsDeletionProtection")]
        [Validation(Required=false)]
        public bool? IsDeletionProtection { get; set; }

        [NameInMap("LogDiskSize")]
        [Validation(Required=false)]
        public int? LogDiskSize { get; set; }

        [NameInMap("ModuleId")]
        [Validation(Required=false)]
        public int? ModuleId { get; set; }

        [NameInMap("ArbiterVSwitchIds")]
        [Validation(Required=false)]
        public string ArbiterVSwitchIds { get; set; }

        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        [NameInMap("StandbyVSwitchIds")]
        [Validation(Required=false)]
        public string StandbyVSwitchIds { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("MasterDiskType")]
        [Validation(Required=false)]
        public string MasterDiskType { get; set; }

        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeMultiZoneClusterResponseBodyTags Tags { get; set; }
        public class DescribeMultiZoneClusterResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneClusterResponseBodyTagsTag> Tag { get; set; }
            public class DescribeMultiZoneClusterResponseBodyTagsTag : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        [NameInMap("CoreDiskCount")]
        [Validation(Required=false)]
        public string CoreDiskCount { get; set; }

        [NameInMap("MultiZoneInstanceModels")]
        [Validation(Required=false)]
        public DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModels MultiZoneInstanceModels { get; set; }
        public class DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModels : TeaModel {
            [NameInMap("MultiZoneInstanceModel")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModelsMultiZoneInstanceModel> MultiZoneInstanceModel { get; set; }
            public class DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModelsMultiZoneInstanceModel : TeaModel {
                public string Status { get; set; }
                public bool? IsLatestVersion { get; set; }
                public string InsName { get; set; }
                public string Role { get; set; }
                public string MinorVersion { get; set; }
            }
        };

        [NameInMap("ExpireTimeUTC")]
        [Validation(Required=false)]
        public string ExpireTimeUTC { get; set; }

        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        [NameInMap("MasterDiskSize")]
        [Validation(Required=false)]
        public int? MasterDiskSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("CoreNodeCount")]
        [Validation(Required=false)]
        public int? CoreNodeCount { get; set; }

        [NameInMap("CreatedTimeUTC")]
        [Validation(Required=false)]
        public string CreatedTimeUTC { get; set; }

        [NameInMap("LogInstanceType")]
        [Validation(Required=false)]
        public string LogInstanceType { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("MasterNodeCount")]
        [Validation(Required=false)]
        public int? MasterNodeCount { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        [NameInMap("LogNodeCount")]
        [Validation(Required=false)]
        public int? LogNodeCount { get; set; }

        [NameInMap("LogDiskType")]
        [Validation(Required=false)]
        public string LogDiskType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public int? CoreDiskSize { get; set; }

    }

}
