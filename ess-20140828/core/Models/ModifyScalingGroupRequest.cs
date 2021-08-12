// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class ModifyScalingGroupRequest : TeaModel {
        [NameInMap("RemovalPolicy")]
        [Validation(Required=false)]
        public List<string> RemovalPolicy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        [NameInMap("ActiveScalingConfigurationId")]
        [Validation(Required=false)]
        public string ActiveScalingConfigurationId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        [NameInMap("OnDemandPercentageAboveBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandPercentageAboveBaseCapacity { get; set; }

        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        [NameInMap("GroupDeletionProtection")]
        [Validation(Required=false)]
        public bool? GroupDeletionProtection { get; set; }

        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        [NameInMap("LaunchTemplateOverride")]
        [Validation(Required=false)]
        public List<ModifyScalingGroupRequestLaunchTemplateOverride> LaunchTemplateOverride { get; set; }
        public class ModifyScalingGroupRequestLaunchTemplateOverride : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

    }

}
