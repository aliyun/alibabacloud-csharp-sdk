// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRouteTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC51ACB0-460D-5CA0-BA2D-E1F3B5547AE9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the route tables.</para>
        /// </summary>
        [NameInMap("RouteTables")]
        [Validation(Required=false)]
        public List<DescribeEnsRouteTablesResponseBodyRouteTables> RouteTables { get; set; }
        public class DescribeEnsRouteTablesResponseBodyRouteTables : TeaModel {
            /// <summary>
            /// <para>The type of the route table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VSwitch</b> (default): vSwitch route table</description></item>
            /// <item><description><b>Gateway</b>: gateway route table</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("AssociateType")]
            [Validation(Required=false)]
            public string AssociateType { get; set; }

            /// <summary>
            /// <para>The time when the route table was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-08T08:35:18Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the network.</para>
            /// <para>The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the edge node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-15</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>Is the gateway routing table the default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefaultGatewayRouteTable")]
            [Validation(Required=false)]
            public bool? IsDefaultGatewayRouteTable { get; set; }

            /// <summary>
            /// <para>The ID of the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5v9lufsezl4g****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The ID of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rt-5xde2bit9****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// <para>The name of the route table that you want to query.</para>
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-tf-vtb7</para>
            /// </summary>
            [NameInMap("RouteTableName")]
            [Validation(Required=false)]
            public string RouteTableName { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: The route table is available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the route table. Examples:</para>
            /// <list type="bullet">
            /// <item><description>Custom: custom route table.</description></item>
            /// <item><description>System: system route table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The vSwitches that are associated with the route table.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
