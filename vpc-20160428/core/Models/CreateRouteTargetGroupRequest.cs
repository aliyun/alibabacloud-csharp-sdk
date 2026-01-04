// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteTargetGroupRequest : TeaModel {
        /// <summary>
        /// <para>Client token used to ensure the idempotence of the request. Generate a parameter value from your client to ensure that it is unique across different requests. ClientToken supports only ASCII characters. Note: If you do not specify this, the system automatically uses the RequestId of the API request as the ClientToken identifier. Each API request has a different RequestId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe6****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration mode of the route target group. Supported modes:</para>
        /// <list type="bullet">
        /// <item><description><b>Active-Standby</b>: Active-Standby mode.</description></item>
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
        /// <para>The region ID to which the route target group belongs. You can obtain the region ID by calling the DescribeRegions interface.</para>
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
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a Resource Group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazffggds****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The description of the route target group.</para>
        /// <para>The description length must be between 1 and 256 characters, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupDescription</para>
        /// </summary>
        [NameInMap("RouteTargetGroupDescription")]
        [Validation(Required=false)]
        public string RouteTargetGroupDescription { get; set; }

        /// <summary>
        /// <para>The name of the route target group.</para>
        /// <para>The name length must be between 1 and 128 characters, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupName</para>
        /// </summary>
        [NameInMap("RouteTargetGroupName")]
        [Validation(Required=false)]
        public string RouteTargetGroupName { get; set; }

        /// <summary>
        /// <para>The member list of the route target group.</para>
        /// <para>In Active-Standby mode, the following restrictions apply to the members of the route target group:</para>
        /// <ol>
        /// <item><description>The number of route target group members must be 2.</description></item>
        /// <item><description>The route target group members must belong to different availability zones.</description></item>
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
            /// <para>The type of the route target group member.</para>
            /// <para>Currently supported types:</para>
            /// <list type="bullet">
            /// <item><description><b>GatewayLoadBalancerEndpoint</b></description></item>
            /// </list>
            /// <para>In Active-Standby mode, all members of the route target group must have the same type.</para>
            /// <para>This parameter is required.</para>
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
            /// <item><description><b>100</b>: Indicates the member is a primary instance.</description></item>
            /// <item><description><b>0</b>: Indicates the member is a standby instance.</description></item>
            /// </list>
            /// <para>The weight value can only be set during creation and cannot be modified.</para>
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
            /// <para>The tag key of the resource. Up to 20 tag keys are supported. If you need to pass this value, you cannot input an empty string.</para>
            /// <para>A tag key can have up to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. Up to 20 tag values are supported. If you need to pass this value, you can input an empty string.</para>
            /// <para>A tag value can have up to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
