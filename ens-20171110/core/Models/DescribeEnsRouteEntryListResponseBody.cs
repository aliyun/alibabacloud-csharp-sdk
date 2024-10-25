// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRouteEntryListResponseBody : TeaModel {
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the route.</para>
        /// </summary>
        [NameInMap("RouteEntrys")]
        [Validation(Required=false)]
        public List<DescribeEnsRouteEntryListResponseBodyRouteEntrys> RouteEntrys { get; set; }
        public class DescribeEnsRouteEntryListResponseBodyRouteEntrys : TeaModel {
            /// <summary>
            /// <para>Enter a description for the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.0.45.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The information about the next hop.</para>
            /// </summary>
            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<DescribeEnsRouteEntryListResponseBodyRouteEntrysNextHops> NextHops { get; set; }
            public class DescribeEnsRouteEntryListResponseBodyRouteEntrysNextHops : TeaModel {
                /// <summary>
                /// <para>The ID of the next hop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1111yup9991890woxq</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The type of the next hop. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rte-2zeksx7h436f5unk349m1</para>
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            /// <summary>
            /// <para>The name of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0</para>
            /// </summary>
            [NameInMap("RouteEntryName")]
            [Validation(Required=false)]
            public string RouteEntryName { get; set; }

            /// <summary>
            /// <para>The ID of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-uf62p9o5cn35fi8xgurnm</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// <para>The status of the route entry. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
