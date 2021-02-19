// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeScalingInstancesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ScalingInstances")]
        [Validation(Required=false)]
        public DescribeScalingInstancesResponseBodyScalingInstances ScalingInstances { get; set; }
        public class DescribeScalingInstancesResponseBodyScalingInstances : TeaModel {
            [NameInMap("ScalingInstance")]
            [Validation(Required=false)]
            public List<DescribeScalingInstancesResponseBodyScalingInstancesScalingInstance> ScalingInstance { get; set; }
            public class DescribeScalingInstancesResponseBodyScalingInstancesScalingInstance : TeaModel {
                public string CreationTime { get; set; }
                public int? LoadBalancerWeight { get; set; }
                public string LaunchTemplateId { get; set; }
                public string InstanceId { get; set; }
                public string LaunchTemplateVersion { get; set; }
                public string HealthStatus { get; set; }
                public string SpotStrategy { get; set; }
                public string ScalingGroupId { get; set; }
                public string WarmupState { get; set; }
                public string LifecycleState { get; set; }
                public string CreationType { get; set; }
                public string ScalingConfigurationId { get; set; }
                public bool? Entrusted { get; set; }
                public int? WeightedCapacity { get; set; }
                public string CreatedTime { get; set; }
            }
        };

        [NameInMap("TotalSpotCount")]
        [Validation(Required=false)]
        public int? TotalSpotCount { get; set; }

    }

}
