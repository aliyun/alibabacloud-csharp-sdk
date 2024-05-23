// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20160722.Models
{
    public class DescribeScalingInstancesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingInstances")]
        [Validation(Required=false)]
        public DescribeScalingInstancesResponseBodyScalingInstances ScalingInstances { get; set; }
        public class DescribeScalingInstancesResponseBodyScalingInstances : TeaModel {
            [NameInMap("ScalingInstance")]
            [Validation(Required=false)]
            public List<DescribeScalingInstancesResponseBodyScalingInstancesScalingInstance> ScalingInstance { get; set; }
            public class DescribeScalingInstancesResponseBodyScalingInstancesScalingInstance : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("CreationType")]
                [Validation(Required=false)]
                public string CreationType { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LifecycleState")]
                [Validation(Required=false)]
                public string LifecycleState { get; set; }

                [NameInMap("ScalingConfigurationId")]
                [Validation(Required=false)]
                public string ScalingConfigurationId { get; set; }

                [NameInMap("ScalingGroupId")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
