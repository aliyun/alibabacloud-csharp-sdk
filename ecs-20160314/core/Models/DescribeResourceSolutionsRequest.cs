// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceSolutionsRequest : TeaModel {
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("InstanceTypeModel")]
        [Validation(Required=false)]
        public List<DescribeResourceSolutionsRequestInstanceTypeModel> InstanceTypeModel { get; set; }
        public class DescribeResourceSolutionsRequestInstanceTypeModel : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public float? WeightedCapacity { get; set; }

        }

        [NameInMap("InstanceTypeSupportIPv6")]
        [Validation(Required=false)]
        public bool? InstanceTypeSupportIPv6 { get; set; }

        [NameInMap("MatchOpenInstances")]
        [Validation(Required=false)]
        public bool? MatchOpenInstances { get; set; }

        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceAmountType")]
        [Validation(Required=false)]
        public string ResourceAmountType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        [NameInMap("TargetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public List<string> ZoneId { get; set; }

    }

}
