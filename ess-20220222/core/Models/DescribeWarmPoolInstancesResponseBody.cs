// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeWarmPoolInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. An empty NextToken value indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAcSz4VTb1Nq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E38EB733-D714-4658-8A5F-0688AB68****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The list of ECS instances in the warm pool.</para>
        /// </summary>
        [NameInMap("WarmPoolInstances")]
        [Validation(Required=false)]
        public List<DescribeWarmPoolInstancesResponseBodyWarmPoolInstances> WarmPoolInstances { get; set; }
        public class DescribeWarmPoolInstancesResponseBodyWarmPoolInstances : TeaModel {
            /// <summary>
            /// <para>The time when the ECS instance was added to the warm pool, accurate to the second. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18T03:11:39Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1c2hf**********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the instance launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-uf64k10pok76*****</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The version of the instance launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// <para>The lifecycle state of the ECS instance in the warm pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The ECS instance is being added to the warm pool.</para>
            /// </description></item>
            /// <item><description><para>Pending:Wait: The addition of the ECS instance is suspended. If a lifecycle hook that applies to scale-out activities for the warm pool is created in the scaling group, the ECS instance is suspended when it is added to the warm pool and waits for the lifecycle hook to time out.</para>
            /// </description></item>
            /// <item><description><para>Removing: The ECS instance is being removed from the warm pool.</para>
            /// </description></item>
            /// <item><description><para>Removing:Wait: The removal of the ECS instance is suspended. If a lifecycle hook that applies to scale-in activities for the warm pool is created in the scaling group, the ECS instance is suspended when it is removed from the warm pool and waits for the lifecycle hook to time out.</para>
            /// </description></item>
            /// <item><description><para>Running: The ECS instance is successfully added to the warm pool and is in the running state.</para>
            /// </description></item>
            /// <item><description><para>Stopped: The ECS instance is successfully added to the warm pool and is in the economical mode.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The private IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1*.1*.1*.2*</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the scaling activity when the ECS instance was added to the warm pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asa-2ze87i********</para>
            /// </summary>
            [NameInMap("ScalingActivityId")]
            [Validation(Required=false)]
            public string ScalingActivityId { get; set; }

            /// <summary>
            /// <para>The ID of the associated scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-2ze3j8*********</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp18p2yfxow2dloq****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The instance identity in the scaling group, which corresponds one-to-one with the ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asi-j6cj1gcte640ekhb****</para>
            /// </summary>
            [NameInMap("ScalingInstanceId")]
            [Validation(Required=false)]
            public string ScalingInstanceId { get; set; }

            /// <summary>
            /// <para>The zone ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
