// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetRouteTargetGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration mode of the route target group. Supported modes are as follows:</para>
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
        /// <para>The region ID of the VPC to which the route target group belongs. You can obtain the region ID by calling the DescribeRegions interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AE05898-06E5-4782-xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the route target group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazdjdhd****</para>
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
        /// <para>ID of the route target group instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtg-xxxx</para>
        /// </summary>
        [NameInMap("RouteTargetGroupId")]
        [Validation(Required=false)]
        public string RouteTargetGroupId { get; set; }

        /// <summary>
        /// <para>Name of the route target group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTargetGroupName</para>
        /// </summary>
        [NameInMap("RouteTargetGroupName")]
        [Validation(Required=false)]
        public string RouteTargetGroupName { get; set; }

        /// <summary>
        /// <para>List of members in the route target group.</para>
        /// </summary>
        [NameInMap("RouteTargetMemberList")]
        [Validation(Required=false)]
        public List<GetRouteTargetGroupResponseBodyRouteTargetMemberList> RouteTargetMemberList { get; set; }
        public class GetRouteTargetGroupResponseBodyRouteTargetMemberList : TeaModel {
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
            /// <para>Route target group member health check status. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal </description></item>
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
            /// <para>ID of the route target group member instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-xxxx</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>Type of the route target group member.</para>
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
            /// <para>Weight value of the route target group member. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>100</b>: Indicates the member is the primary instance.</description></item>
            /// <item><description><b>0</b>: Indicates the member is the standby instance.</description></item>
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
        /// <para>The status of the route target group. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Recovering</b>: In the process of switching back to the primary </description></item>
        /// <item><description><b>Switched</b>: The primary and secondary have been switched </description></item>
        /// <item><description><b>Available</b>: Available </description></item>
        /// <item><description><b>Abnormal</b>: Secondary instance is abnormal </description></item>
        /// <item><description><b>Pending</b>: In the process of being created </description></item>
        /// <item><description><b>Switching</b>: In the process of switching between primary and secondary </description></item>
        /// <item><description><b>Deleting</b>: In the process of being deleted </description></item>
        /// <item><description><b>Unavailable</b>: Both primary and secondary instances are abnormal</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Tags of the route target group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetRouteTargetGroupResponseBodyTags> Tags { get; set; }
        public class GetRouteTargetGroupResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>ID of the VPC to which the route target group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
