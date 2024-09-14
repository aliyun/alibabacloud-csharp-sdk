// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLimitationResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of Application Load Balancer (ALB) server groups that can be attached to a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfAlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfAlbServerGroup { get; set; }

        /// <summary>
        /// The maximum number of ApsaraDB RDS instances that can be associated with a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfDBInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfDBInstances { get; set; }

        /// <summary>
        /// The maximum number of lifecycle hooks that can be created in a scaling group.
        /// </summary>
        [NameInMap("MaxNumberOfLifecycleHooks")]
        [Validation(Required=false)]
        public int? MaxNumberOfLifecycleHooks { get; set; }

        /// <summary>
        /// The maximum number of Classic Load Balancer (CLB, formerly known as SLB) instances that can be associated with a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfLoadBalancers")]
        [Validation(Required=false)]
        public int? MaxNumberOfLoadBalancers { get; set; }

        /// <summary>
        /// The maximum number of instances that can be contained in a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfMaxSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMaxSize { get; set; }

        /// <summary>
        /// The minimum number of instances that must be contained in a scaling group. The value of `MaxNumberOfMinSize` must be consistent with the value of `MaxNumberOfMaxSize`.
        /// </summary>
        [NameInMap("MaxNumberOfMinSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMinSize { get; set; }

        /// <summary>
        /// The maximum number of Network Load Balancer (NLB) server groups that can be attached to a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfNlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfNlbServerGroup { get; set; }

        /// <summary>
        /// The maximum number of notification rules that can be created in a scaling group.
        /// </summary>
        [NameInMap("MaxNumberOfNotificationConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfNotificationConfigurations { get; set; }

        /// <summary>
        /// The maximum number of scaling configurations that can be created in a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScalingConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingConfigurations { get; set; }

        /// <summary>
        /// The maximum number of scaling groups that can be created in a region by using an Alibaba Cloud account.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScalingGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingGroups { get; set; }

        /// <summary>
        /// The maximum number of Elastic Compute Service (ECS) instances or elastic container instances that can be automatically scaled in a scaling group at the same time.
        /// </summary>
        [NameInMap("MaxNumberOfScalingInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingInstances { get; set; }

        /// <summary>
        /// The maximum number of scaling rules that can be created in a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScalingRules")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingRules { get; set; }

        /// <summary>
        /// The maximum number of scheduled tasks that can be created in a region by using an Alibaba Cloud account.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScheduledTasks")]
        [Validation(Required=false)]
        public int? MaxNumberOfScheduledTasks { get; set; }

        /// <summary>
        /// The maximum number of CLB vServer groups that can be attached to a scaling group.
        /// 
        /// >  To view the quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfVServerGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfVServerGroups { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
