// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteConflictResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE3A2CC7-41F1-58DB-8306-CFC99D9C747B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of overlapping routes.</para>
        /// </summary>
        [NameInMap("RouteConflicts")]
        [Validation(Required=false)]
        public DescribeRouteConflictResponseBodyRouteConflicts RouteConflicts { get; set; }
        public class DescribeRouteConflictResponseBodyRouteConflicts : TeaModel {
            [NameInMap("RouteConflict")]
            [Validation(Required=false)]
            public List<DescribeRouteConflictResponseBodyRouteConflictsRouteConflict> RouteConflict { get; set; }
            public class DescribeRouteConflictResponseBodyRouteConflictsRouteConflict : TeaModel {
                /// <summary>
                /// <para>The destination CIDR block of the overlapping route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.0.0/16</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the peer network instance on which the overlapping routes are found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-0q3b7oviikmm9h****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the peer network instance on which the overlapping routes are found.</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: VPC</description></item>
                /// <item><description><b>VBR</b>: VBR</description></item>
                /// <item><description><b>CCN</b>: CCN instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CCN</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The region ID of the peer network instance on which the overlapping routes are found is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The cause of the route error. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>conflict</b>: The routes have the same destination CIDR block.</description></item>
                /// <item><description><b>overflow</b>: The number of routes in the route table configured on another network instance has reached the upper limit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>conflict</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
