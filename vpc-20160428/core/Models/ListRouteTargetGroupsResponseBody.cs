// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListRouteTargetGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the next query. Value: If NextToken is empty, it indicates there is no next query. If NextToken has a return value, it indicates the token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of route target groups.</para>
        /// </summary>
        [NameInMap("RouteTargetGroups")]
        [Validation(Required=false)]
        public List<ListRouteTargetGroupsResponseBodyRouteTargetGroups> RouteTargetGroups { get; set; }
        public class ListRouteTargetGroupsResponseBodyRouteTargetGroups : TeaModel {
            /// <summary>
            /// <para>The configuration mode of the route target group. Supported modes are as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>Active-Standby</b>: Active-standby mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active-Standby</para>
            /// </summary>
            [NameInMap("ConfigMode")]
            [Validation(Required=false)]
            public string ConfigMode { get; set; }

            /// <summary>
            /// <para>The time when the route target group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T06:40:50Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC to which the route target group belongs.</para>
            /// <para>You can obtain the region ID by calling the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the route target group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3swh6ta56ri</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Description of the route target group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myRouteTargetGroupDescription</para>
            /// </summary>
            [NameInMap("RouteTargetGroupDescription")]
            [Validation(Required=false)]
            public string RouteTargetGroupDescription { get; set; }

            /// <summary>
            /// <para>The ID of the route target group instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtg-xxxx</para>
            /// </summary>
            [NameInMap("RouteTargetGroupId")]
            [Validation(Required=false)]
            public string RouteTargetGroupId { get; set; }

            /// <summary>
            /// <para>The name of the route target group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myRouteTargetGroupName</para>
            /// </summary>
            [NameInMap("RouteTargetGroupName")]
            [Validation(Required=false)]
            public string RouteTargetGroupName { get; set; }

            /// <summary>
            /// <para>The list of route target group members.</para>
            /// </summary>
            [NameInMap("RouteTargetMemberList")]
            [Validation(Required=false)]
            public List<ListRouteTargetGroupsResponseBodyRouteTargetGroupsRouteTargetMemberList> RouteTargetMemberList { get; set; }
            public class ListRouteTargetGroupsResponseBodyRouteTargetGroupsRouteTargetMemberList : TeaModel {
                /// <summary>
                /// <para>The enable status of the route target group member. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enable</b>: Enabled.</description></item>
                /// <item><description><b>Disable</b>: Disabled.</description></item>
                /// </list>
                /// <para>Only disabled route target group members can be modified to other instances. Enabled route target group members cannot be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                /// <summary>
                /// <para>The health check status of the route target group member. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: Normal</description></item>
                /// <item><description><b>Abnormal</b>: Abnormal</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("HealthCheckStatus")]
                [Validation(Required=false)]
                public string HealthCheckStatus { get; set; }

                /// <summary>
                /// <para>The ID of the route target group member instance.</para>
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
                /// <item><description><b>100</b>: Indicates that the member is the primary instance.</description></item>
                /// <item><description><b>0</b>: Indicates that the member is the backup instance.</description></item>
                /// </list>
                /// <para>The weight value can only be set during creation and cannot be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>Status of the route target group. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>Recovering</b>: Active-Standby rollback in progress</description></item>
            /// <item><description><b>Switched</b>: Active-Standby switched</description></item>
            /// <item><description><b>Available</b>: Available</description></item>
            /// <item><description><b>Abnormal</b>: Standby instance abnormal</description></item>
            /// <item><description><b>Pending</b>: Creating</description></item>
            /// <item><description><b>Switching</b>: Active-Standby switching in progress</description></item>
            /// <item><description><b>Deleting</b>: Deleting</description></item>
            /// <item><description><b>Unavailable</b>: Both primary and standby instances are abnormal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag values. A maximum of 20 tag values are supported. If you need to pass this value, you can input an empty string.</para>
            /// <para>A maximum of 128 characters are supported. The value cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRouteTargetGroupsResponseBodyRouteTargetGroupsTags> Tags { get; set; }
            public class ListRouteTargetGroupsResponseBodyRouteTargetGroupsTags : TeaModel {
                /// <summary>
                /// <para>The key of the resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/upload/cbbec42e0be33abb27babefcbe0397f0</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the resource tag. Up to 20 tag values are supported. If you need to pass this value, you can input an empty string. A maximum of 128 characters is allowed. The value cannot start with <c>aliyun</c> or <c>acs:</c>, and it must not contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC to which the route target group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf60y8uzhsvbhmuh3l654</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Number of items in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
