// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachServerGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the token value from your client and ensure that it is unique across different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the existing ECS instances or ECI instances in the scaling group to the newly added server groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: adds the instances.</para>
        /// </description></item>
        /// <item><description><para>false: does not add the instances.</para>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the scaling group belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1fo0dbtsbmqa9h****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The information about the load balancing server groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<AttachServerGroupsRequestServerGroups> ServerGroups { get; set; }
        public class AttachServerGroupsRequestServerGroups : TeaModel {
            /// <summary>
            /// <para>The port number used by the ECS instance or ECI instance after Auto Scaling adds it to the server group.</para>
            /// <para>Valid values: 1 to 65535.</para>
            /// <remarks>
            /// <para>This parameter is required for ALB and NLB load balancing. You cannot modify the Settings of this parameter for GWLB load balancing, and the default value is 6081.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the load balancing server group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-5yc3bd9lfyh*****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The type of the load balancing server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALB: Application Load Balancer (ALB).</description></item>
            /// <item><description>NLB: Network Load Balancer (NLB).</description></item>
            /// <item><description>GWLB: Gateway Load Balancer (GWLB).</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of the ECS instance or ECI instance as a backend server after Auto Scaling adds it to the server group. Valid values: 0 to 100.</para>
            /// <para>A higher weight indicates that Auto Scaling will allocate more access requests to the ECS instance or ECI instance. If the weight is set to 0, the instance does not receive access requests.</para>
            /// <remarks>
            /// <para>This parameter is required for ALB and NLB load balancing. You cannot modify the Settings of this parameter for GWLB load balancing.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
