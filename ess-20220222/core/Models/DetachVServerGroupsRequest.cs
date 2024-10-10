// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DetachVServerGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the existing instances in the scaling group from the vServer group marked for detachment.</para>
        /// <list type="bullet">
        /// <item><description>true: If you set this parameter to <c>true</c>, the detachment of the load balancer from the scaling group causes automatic removal of the existing instances in the scaling group from the corresponding vServer group.</description></item>
        /// <item><description>false: If you set this parameter to <c>false</c>, the detachment of the load balancer from the scaling group does not cause automatic removal of the existing instances in the scaling group from the corresponding vServer group.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceDetach")]
        [Validation(Required=false)]
        public bool? ForceDetach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group. Examples: cn-hangzhou and cn-shanghai.</para>
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
        /// <para>The collection of information about the vServer groups marked for detachment.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<DetachVServerGroupsRequestVServerGroups> VServerGroups { get; set; }
        public class DetachVServerGroupsRequestVServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the load balancer to which the vServer group belongs.</para>
            /// <remarks>
            /// <para> You can detach vServer groups of up to five load balancers from a scaling group in one call.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1p90y3ya9h8s62d****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The attributes of the backend vServer group.</para>
            /// </summary>
            [NameInMap("VServerGroupAttributes")]
            [Validation(Required=false)]
            public List<DetachVServerGroupsRequestVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
            public class DetachVServerGroupsRequestVServerGroupsVServerGroupAttributes : TeaModel {
                /// <summary>
                /// <para>The port number that Auto Scaling employs to incorporate instances into the vServer group. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the backend vServer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-bp1jp1rge****</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

    }

}
