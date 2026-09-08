// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouteTableAggregationResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of aggregate route information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTransitRouteTableAggregationResponseBodyData> Data { get; set; }
        public class DescribeTransitRouteTableAggregationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the aggregate route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the aggregate route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The routing type of the aggregation route.</para>
            /// <para>The value is <b>Static</b> only, which indicates a static route. After the aggregation route is propagated to a VPC-connected instance, it becomes a custom route entry by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// <para>The propagation scope of the aggregation route.</para>
            /// <para>The value is <b>VPC</b> only, which indicates that the aggregation route is propagated to all VPC-connected instances that have established associated forwarding relationships with the current Enterprise Edition transit router route table and have the route synchronization feature enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The propagation scope list of the aggregate route.</para>
            /// <remarks>
            /// <para>You must specify at least one of the propagation scope or the propagation scope list for the aggregate route. We recommend that you use the propagation scope list. Elements in the propagation scope list cannot duplicate the value of the propagation scope.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ScopeList")]
            [Validation(Required=false)]
            public List<string> ScopeList { get; set; }

            /// <summary>
            /// <para>The propagation status of the aggregation route.</para>
            /// <list type="bullet">
            /// <item><description><b>AllConfigured</b>: The aggregation routing has been propagated to all VPC-connected instances.</description></item>
            /// <item><description><b>Configuring</b>: The aggregation routing is being propagated.</description></item>
            /// <item><description><b>ConfigFailed</b>: The aggregation routing failed to be propagated.</description></item>
            /// <item><description><b>PartialConfigured</b>: The aggregation routing failed to be propagated to some VPC-connected instances.</description></item>
            /// <item><description><b>Deleting</b>: The aggregation routing is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllConfigured</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the Enterprise Edition transit router route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-6ehgc262hr170qgyc****</para>
            /// </summary>
            [NameInMap("TrRouteTableId")]
            [Validation(Required=false)]
            public string TrRouteTableId { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the aggregate route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("TransitRouteTableAggregationCidr")]
            [Validation(Required=false)]
            public string TransitRouteTableAggregationCidr { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C2EE7A8-74D4-4081-8236-CEBDE3BBCF50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
