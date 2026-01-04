// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateRouteTargetGroupRequest : TeaModel {
        /// <summary>
        /// <para>Client Token, used to ensure the idempotence of requests. Generate a unique value for this parameter from your client for each request. ClientToken supports only ASCII characters. Note that if you do not specify this, the system will automatically use the RequestId of the API request as the ClientToken identifier. The RequestId may differ for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the route target group instance belongs. You can obtain the region ID by calling the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Description of the route target group. </para>
        /// <para>The description length should be between 1 to 256 characters and must not start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupDescription</para>
        /// </summary>
        [NameInMap("RouteTargetGroupDescription")]
        [Validation(Required=false)]
        public string RouteTargetGroupDescription { get; set; }

        /// <summary>
        /// <para>The ID of the route target group instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtg-xxx</para>
        /// </summary>
        [NameInMap("RouteTargetGroupId")]
        [Validation(Required=false)]
        public string RouteTargetGroupId { get; set; }

        /// <summary>
        /// <para>The name of the route target group.</para>
        /// <para>The name length should be between 1 and 128 characters, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupName</para>
        /// </summary>
        [NameInMap("RouteTargetGroupName")]
        [Validation(Required=false)]
        public string RouteTargetGroupName { get; set; }

        /// <summary>
        /// <para>List of members in the route target group.
        /// Under the primary-standby mode, there are the following restrictions on the members of the route target group:</para>
        /// <ol>
        /// <item><description>The number of members in the route target group must be 2. </description></item>
        /// <item><description>The members of the route target group must belong to different availability zones.</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("RouteTargetMemberList")]
        [Validation(Required=false)]
        public List<UpdateRouteTargetGroupRequestRouteTargetMemberList> RouteTargetMemberList { get; set; }
        public class UpdateRouteTargetGroupRequestRouteTargetMemberList : TeaModel {
            /// <summary>
            /// <para>ID of the route target group member instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-xxxx</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>The member type of the route target group. </para>
            /// <para>Currently supported types: - <b>GatewayLoadBalancerEndpoint</b> </para>
            /// <para>In active-standby mode, all members of the route target group must be of the same type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GatewayLoadBalancerEndpoint</para>
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <para>The weight value of the route target group member. Values:</para>
            /// <list type="bullet">
            /// <item><description>100: indicates the member is the primary instance. </description></item>
            /// <item><description>0: indicates the member is the backup instance.
            /// The weight value can only be set during creation and cannot be modified.</description></item>
            /// </list>
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
