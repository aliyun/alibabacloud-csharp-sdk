// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteTargetGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters. If you do not specify this parameter, the system automatically uses the RequestId value as the ClientToken value. The RequestId value is different for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe6****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration mode of the route target group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active-Standby</b>: active/standby mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active-Standby</para>
        /// </summary>
        [NameInMap("ConfigMode")]
        [Validation(Required=false)]
        public string ConfigMode { get; set; }

        /// <summary>
        /// <para>The region ID of the route target group. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazffggds****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The description of the route target group.
        /// The description must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupDescription</para>
        /// </summary>
        [NameInMap("RouteTargetGroupDescription")]
        [Validation(Required=false)]
        public string RouteTargetGroupDescription { get; set; }

        /// <summary>
        /// <para>The name of the route target group.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupName</para>
        /// </summary>
        [NameInMap("RouteTargetGroupName")]
        [Validation(Required=false)]
        public string RouteTargetGroupName { get; set; }

        /// <summary>
        /// <para>The member list of the route target group.</para>
        /// <para>In active/standby mode, the following limits apply to route target group members:</para>
        /// <ol>
        /// <item><description>The number of route target group members must be 2.</description></item>
        /// <item><description>The route target group members must be in different zones.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouteTargetMemberList")]
        [Validation(Required=false)]
        public List<CreateRouteTargetGroupRequestRouteTargetMemberList> RouteTargetMemberList { get; set; }
        public class CreateRouteTargetGroupRequestRouteTargetMemberList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the route target group member.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-xxxx</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>The member type of the route target group.</para>
            /// <para>Supported type:</para>
            /// <list type="bullet">
            /// <item><description><b>GatewayLoadBalancerEndpoint</b></description></item>
            /// </list>
            /// <para>In active/standby mode, all members of the route target group must be of the same type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GatewayLoadBalancerEndpoint</para>
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <para>The weight of the route target group member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100</b>: The member is the active instance.</description></item>
            /// <item><description><b>0</b>: The member is the standby instance.</description></item>
            /// </list>
            /// <para>The weight can only be set during creation and cannot be modified.</para>
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
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRouteTargetGroupRequestTag> Tag { get; set; }
        public class CreateRouteTargetGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the route target group belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
