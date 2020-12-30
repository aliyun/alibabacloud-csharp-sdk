// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ResizeClusterV2Request : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("AutoPayOrder")]
        [Validation(Required=false)]
        public bool? AutoPayOrder { get; set; }

        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("IsOpenPublicIp")]
        [Validation(Required=false)]
        public bool? IsOpenPublicIp { get; set; }

        [NameInMap("HostComponentInfo")]
        [Validation(Required=false)]
        public List<ResizeClusterV2RequestHostComponentInfo> HostComponentInfo { get; set; }
        public class ResizeClusterV2RequestHostComponentInfo : TeaModel {
            [NameInMap("ComponentNameList")]
            [Validation(Required=false)]
            public List<string> ComponentNameList { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("HostGroup")]
        [Validation(Required=false)]
        public List<ResizeClusterV2RequestHostGroup> HostGroup { get; set; }
        public class ResizeClusterV2RequestHostGroup : TeaModel {
            [NameInMap("SysDiskCapacity")]
            [Validation(Required=false)]
            public int? SysDiskCapacity { get; set; }

            [NameInMap("HostGroupType")]
            [Validation(Required=false)]
            public string HostGroupType { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public int? VswitchId { get; set; }

            [NameInMap("SysDiskType")]
            [Validation(Required=false)]
            public string SysDiskType { get; set; }

            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("HostKeyPairName")]
            [Validation(Required=false)]
            public string HostKeyPairName { get; set; }

            [NameInMap("DiskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("HostPassword")]
            [Validation(Required=false)]
            public string HostPassword { get; set; }

            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public int? DiskCapacity { get; set; }

            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("PromotionInfo")]
        [Validation(Required=false)]
        public List<ResizeClusterV2RequestPromotionInfo> PromotionInfo { get; set; }
        public class ResizeClusterV2RequestPromotionInfo : TeaModel {
            [NameInMap("PromotionOptionNo")]
            [Validation(Required=false)]
            public string PromotionOptionNo { get; set; }

            [NameInMap("PromotionOptionCode")]
            [Validation(Required=false)]
            public string PromotionOptionCode { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

    }

}
