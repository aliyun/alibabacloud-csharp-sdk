// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLimitationResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of Application Load Balancer (ALB) server groups that can be attached to a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxNumberOfAlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfAlbServerGroup { get; set; }

        /// <summary>
        /// <para>The maximum number of ApsaraDB RDS instances that can be associated with a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxNumberOfDBInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfDBInstances { get; set; }

        /// <summary>
        /// <para>The maximum number of lifecycle hooks that can be created in a scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxNumberOfLifecycleHooks")]
        [Validation(Required=false)]
        public int? MaxNumberOfLifecycleHooks { get; set; }

        /// <summary>
        /// <para>The maximum number of Classic Load Balancer (CLB, formerly known as SLB) instances that can be associated with a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxNumberOfLoadBalancers")]
        [Validation(Required=false)]
        public int? MaxNumberOfLoadBalancers { get; set; }

        /// <summary>
        /// <para>The maximum number of instances that can be contained in a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MaxNumberOfMaxSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of instances that must be contained in a scaling group. The value of <c>MaxNumberOfMinSize</c> must be consistent with the value of <c>MaxNumberOfMaxSize</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MaxNumberOfMinSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMinSize { get; set; }

        /// <summary>
        /// <para>The maximum number of Network Load Balancer (NLB) server groups that can be attached to a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxNumberOfNlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfNlbServerGroup { get; set; }

        /// <summary>
        /// <para>The maximum number of notification rules that can be created in a scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("MaxNumberOfNotificationConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfNotificationConfigurations { get; set; }

        /// <summary>
        /// <para>The maximum number of scaling configurations that can be created in a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MaxNumberOfScalingConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingConfigurations { get; set; }

        /// <summary>
        /// <para>The maximum number of scaling groups that can be created in a region by using an Alibaba Cloud account.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxNumberOfScalingGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingGroups { get; set; }

        /// <summary>
        /// <para>The maximum number of Elastic Compute Service (ECS) instances or elastic container instances that can be automatically scaled in a scaling group at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxNumberOfScalingInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingInstances { get; set; }

        /// <summary>
        /// <para>The maximum number of scaling rules that can be created in a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MaxNumberOfScalingRules")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingRules { get; set; }

        /// <summary>
        /// <para>The maximum number of scheduled tasks that can be created in a region by using an Alibaba Cloud account.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MaxNumberOfScheduledTasks")]
        [Validation(Required=false)]
        public int? MaxNumberOfScheduledTasks { get; set; }

        /// <summary>
        /// <para>The maximum number of CLB vServer groups that can be attached to a scaling group.</para>
        /// <remarks>
        /// <para> To view the quota or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxNumberOfVServerGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfVServerGroups { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE9BEB41-E7B8-4C7D-A3CF-2DCB1066****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
