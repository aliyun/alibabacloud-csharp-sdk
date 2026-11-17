// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListRouteTargetGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. If NextToken is empty, no subsequent query is required. If NextToken is returned, the value indicates the token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of route target groups.</para>
        /// </summary>
        [NameInMap("RouteTargetGroups")]
        [Validation(Required=false)]
        public List<ListRouteTargetGroupsResponseBodyRouteTargetGroups> RouteTargetGroups { get; set; }
        public class ListRouteTargetGroupsResponseBodyRouteTargetGroups : TeaModel {
            /// <summary>
            /// <para>The configuration mode of the route target group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active-Standby</b>: Active/standby mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active-Standby</para>
            /// </summary>
            [NameInMap("ConfigMode")]
            [Validation(Required=false)]
            public string ConfigMode { get; set; }

            /// <summary>
            /// <para>The time when the route target group was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T06:40:50Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC to which the route target group belongs.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
            /// <para>The description of the route target group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myRouteTargetGroupDescription</para>
            /// </summary>
            [NameInMap("RouteTargetGroupDescription")]
            [Validation(Required=false)]
            public string RouteTargetGroupDescription { get; set; }

            /// <summary>
            /// <para>The instance ID of the routing target group.</para>
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
            /// <para>The list of members in the route target group.</para>
            /// </summary>
            [NameInMap("RouteTargetMemberList")]
            [Validation(Required=false)]
            public List<ListRouteTargetGroupsResponseBodyRouteTargetGroupsRouteTargetMemberList> RouteTargetMemberList { get; set; }
            public class ListRouteTargetGroupsResponseBodyRouteTargetGroupsRouteTargetMemberList : TeaModel {
                /// <summary>
                /// <para>The enablement status of the member in the route target group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enable</b>: Enabled.</description></item>
                /// <item><description><b>Disable</b>: Disabled.</description></item>
                /// </list>
                /// <para>Only members in the Disabled state can be changed to other instances. Members in the Enabled state cannot be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                /// <summary>
                /// <para>The health check status of the member in the route target group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: Normal.</description></item>
                /// <item><description><b>Abnormal</b>: Abnormal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("HealthCheckStatus")]
                [Validation(Required=false)]
                public string HealthCheckStatus { get; set; }

                /// <summary>
                /// <para>The member instance ID of the routing target group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-xxxx</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <para>The member type of the route target group.</para>
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
                /// <para>The weight of the member in the route target group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>100</b>: The member is the primary instance.</description></item>
                /// <item><description><b>0</b>: The member is the secondary instance.</description></item>
                /// </list>
                /// <para>The weight can only be set during creation and cannot be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The status of the routing target group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Recovering</b>: Switching back to the primary instance.</description></item>
            /// <item><description><b>Switched</b>: Primary/secondary switchover completed.</description></item>
            /// <item><description><b>Available</b>: active.</description></item>
            /// <item><description><b>Abnormal</b>: Secondary instance failures.</description></item>
            /// <item><description><b>Pending</b>: Creating.</description></item>
            /// <item><description><b>Switching</b>: Performing primary/secondary switchover.</description></item>
            /// <item><description><b>Deleting</b>: delete.</description></item>
            /// <item><description><b>Unavailable</b>: Both primary and secondary instances have instance failures.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string. A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRouteTargetGroupsResponseBodyRouteTargetGroupsTags> Tags { get; set; }
            public class ListRouteTargetGroupsResponseBodyRouteTargetGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/upload/cbbec42e0be33abb27babefcbe0397f0</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string. A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
