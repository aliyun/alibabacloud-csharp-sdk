// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use asynchronous calls when adding load balancing instances. Asynchronous calls ensure the transactionality of operations, meaning that either all operations succeed or none of the operations take effect if any operation fails. Use asynchronous calls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: asynchronous call. The request returns the ID of the scaling activity.</description></item>
        /// <item><description>false: synchronous call.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure that the value is unique across different requests. The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to add all existing instances in the scaling group as backend servers of the load balancing instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: adds all existing instances. If this parameter is set to <c>true</c>, when the load balancing instances are added to the scaling group, the system adds all existing instances in the scaling group as backend servers of the load balancing instances.</para>
        /// <remarks>
        /// <para>If a load balancing instance is already added to the scaling group and you want to add all instances in the scaling group as backend servers of the load balancing instance, you can add the load balancing instance to the scaling group again and set ForceAttach to true.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: does not add existing instances. If this parameter is set to false, when the load balancing instances are added to the scaling group, the system does not add the existing instances in the scaling group as backend servers of the load balancing instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceAttach")]
        [Validation(Required=false)]
        public bool? ForceAttach { get; set; }

        /// <summary>
        /// <para>The configurations of the load balancing CLB (formerly SLB) instances.</para>
        /// </summary>
        [NameInMap("LoadBalancerConfigs")]
        [Validation(Required=false)]
        public List<AttachLoadBalancersRequestLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
        public class AttachLoadBalancersRequestLoadBalancerConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the load balancing CLB (formerly SLB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>147b46d767c-cn-qingdao-cm5****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The weight of the ECS instance or ECI instance as a backend server after Auto Scaling adds the instance to the SLB server group. A higher weight indicates that the ECS instance or ECI instance is allocated more access requests. If the weight is 0, the ECS instance or ECI instance does not receive access requests.</para>
            /// <para>Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the load balancing CLB (formerly SLB) instances to add.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<string> LoadBalancers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1avr6ensitts3w****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
