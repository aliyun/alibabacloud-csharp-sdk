// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20160722.Models
{
    public class DescribeScalingGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingGroups")]
        [Validation(Required=false)]
        public DescribeScalingGroupsResponseBodyScalingGroups ScalingGroups { get; set; }
        public class DescribeScalingGroupsResponseBodyScalingGroups : TeaModel {
            [NameInMap("ScalingGroup")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsScalingGroup> ScalingGroup { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsScalingGroup : TeaModel {
                [NameInMap("ActiveCapacity")]
                [Validation(Required=false)]
                public int? ActiveCapacity { get; set; }

                [NameInMap("ActiveScalingConfigurationId")]
                [Validation(Required=false)]
                public string ActiveScalingConfigurationId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DBInstanceIds")]
                [Validation(Required=false)]
                public DescribeScalingGroupsResponseBodyScalingGroupsScalingGroupDBInstanceIds DBInstanceIds { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsScalingGroupDBInstanceIds : TeaModel {
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public List<string> DBInstanceId { get; set; }

                }

                [NameInMap("DefaultCooldown")]
                [Validation(Required=false)]
                public int? DefaultCooldown { get; set; }

                [NameInMap("LifecycleState")]
                [Validation(Required=false)]
                public string LifecycleState { get; set; }

                [NameInMap("LoadBalancerIds")]
                [Validation(Required=false)]
                public DescribeScalingGroupsResponseBodyScalingGroupsScalingGroupLoadBalancerIds LoadBalancerIds { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsScalingGroupLoadBalancerIds : TeaModel {
                    [NameInMap("LoadBalancerId")]
                    [Validation(Required=false)]
                    public List<string> LoadBalancerId { get; set; }

                }

                [NameInMap("MaxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                [NameInMap("MinSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                [NameInMap("PendingCapacity")]
                [Validation(Required=false)]
                public int? PendingCapacity { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RemovalPolicies")]
                [Validation(Required=false)]
                public DescribeScalingGroupsResponseBodyScalingGroupsScalingGroupRemovalPolicies RemovalPolicies { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsScalingGroupRemovalPolicies : TeaModel {
                    [NameInMap("RemovalPolicy")]
                    [Validation(Required=false)]
                    public List<string> RemovalPolicy { get; set; }

                }

                [NameInMap("RemovingCapacity")]
                [Validation(Required=false)]
                public int? RemovingCapacity { get; set; }

                [NameInMap("ScalingGroupId")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                [NameInMap("ScalingGroupName")]
                [Validation(Required=false)]
                public string ScalingGroupName { get; set; }

                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public int? TotalCapacity { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
