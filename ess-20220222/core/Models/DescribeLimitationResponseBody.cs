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
        /// >  To view the server group quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfAlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfAlbServerGroup { get; set; }

        /// <summary>
        /// The maximum number of ApsaraDB RDS instances that can be attached to a scaling group.
        /// 
        /// >  To view the database quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfDBInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfDBInstances { get; set; }

        [NameInMap("MaxNumberOfLifecycleHooks")]
        [Validation(Required=false)]
        public int? MaxNumberOfLifecycleHooks { get; set; }

        [NameInMap("MaxNumberOfLoadBalancers")]
        [Validation(Required=false)]
        public int? MaxNumberOfLoadBalancers { get; set; }

        [NameInMap("MaxNumberOfMaxSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMaxSize { get; set; }

        /// <summary>
        /// The minimum number of instances that must be contained in a scaling group. The value of `MaxNumberOfMinSize` must be consistent with the value of `MaxNumberOfMaxSize`.
        /// </summary>
        [NameInMap("MaxNumberOfMinSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMinSize { get; set; }

        [NameInMap("MaxNumberOfNlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfNlbServerGroup { get; set; }

        [NameInMap("MaxNumberOfNotificationConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfNotificationConfigurations { get; set; }

        /// <summary>
        /// The maximum number of scaling configurations that can be created in a scaling group.
        /// 
        /// >  To view the scaling configuration quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScalingConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingConfigurations { get; set; }

        /// <summary>
        /// The maximum number of scaling groups that can be created in a region by using an Alibaba Cloud account.
        /// 
        /// >  To view the scaling group quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScalingGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingGroups { get; set; }

        [NameInMap("MaxNumberOfScalingInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingInstances { get; set; }

        /// <summary>
        /// The maximum number of scaling rules that can be created in a scaling group.
        /// 
        /// >  To view the scaling rule quota or request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
        /// </summary>
        [NameInMap("MaxNumberOfScalingRules")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingRules { get; set; }

        [NameInMap("MaxNumberOfScheduledTasks")]
        [Validation(Required=false)]
        public int? MaxNumberOfScheduledTasks { get; set; }

        [NameInMap("MaxNumberOfVServerGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfVServerGroups { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
