// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachAlbServerGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The details of the ALB server groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<AttachAlbServerGroupsRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class AttachAlbServerGroupsRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the ALB server group.</para>
            /// <para>A scaling group can be associated with a limited number of ALB server groups. To view the quota or manually apply for a quota increase, go to the <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-ddwb0y0g6y9bjm****</para>
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// <para>The port number used by the ECS instance or elastic container instance after Auto Scaling adds the instance to the ALB server group.</para>
            /// <para>Valid values: 1 to 65535.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The weight of the ECS instance or elastic container instance as a backend server after Auto Scaling adds the instance to the ALB server group. Valid values: 0 to 100.</para>
            /// <para>A higher weight specifies that more access requests are distributed to the ECS instance or elastic container instance. If the weight is 0, the ECS instance or elastic container instance does not receive access requests.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the existing Elastic Compute Service (ECS) instances or elastic container instances in the scaling group to the newly added ALB server groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: adds ECS instances and returns <c>ScalingActivityId</c>. You can check whether the existing instances are added by viewing the ID of the scaling activity.</para>
        /// </description></item>
        /// <item><description><para>false: does not add ECS instances.</para>
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
        /// <para>Examples: <c>cn-hangzhou</c> and <c>cn-shanghai</c>. For more information, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
