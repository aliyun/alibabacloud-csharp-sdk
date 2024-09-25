// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcRouteEntrySummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC668356-BCB4-42FD-9BC3-FA2B2E04B634</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the routes in the route tables.</para>
        /// </summary>
        [NameInMap("RouteEntrySummarys")]
        [Validation(Required=false)]
        public List<GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarys> RouteEntrySummarys { get; set; }
        public class GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarys : TeaModel {
            /// <summary>
            /// <para>The information about the routes of different types in one route table.</para>
            /// </summary>
            [NameInMap("EntrySummarys")]
            [Validation(Required=false)]
            public List<GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarysEntrySummarys> EntrySummarys { get; set; }
            public class GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarysEntrySummarys : TeaModel {
                /// <summary>
                /// <para>The number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The type of the route. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>All</b>: all route types</description></item>
                /// <item><description><b>Custom</b>: a custom route</description></item>
                /// <item><description><b>System</b>: a system route</description></item>
                /// <item><description><b>BGP</b>: a BGP route</description></item>
                /// <item><description><b>CEN</b>: a CEN route</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp145q7glnuzdvzu2****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
