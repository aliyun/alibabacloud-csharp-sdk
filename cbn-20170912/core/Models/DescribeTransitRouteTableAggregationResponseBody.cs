// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouteTableAggregationResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of aggregate routes.</para>
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
            /// <para>The route type of the aggregate route.</para>
            /// <para>Valid value: <b>Static</b>, which indicates a static route. After the aggregate route is propagated to a VPC-connected instance, it becomes a custom route entry by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// <para>The propagation scope of the aggregate route.</para>
            /// <para>Valid value: <b>VPC</b>, which indicates that the aggregate route is propagated to all VPC-connected instances that are associated with the route table of the current Enterprise Edition transit router and have route synchronization enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The list of propagation scopes for the aggregate route.</para>
            /// <remarks>
            /// <para>You must specify at least one of the propagation scope and the propagation scope list. We recommend that you specify the propagation scope list. The elements in the propagation scope list cannot be the same as the value of the propagation scope.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ScopeList")]
            [Validation(Required=false)]
            public List<string> ScopeList { get; set; }

            /// <summary>
            /// <para>The propagation status of the aggregate route.</para>
            /// <list type="bullet">
            /// <item><description><b>AllConfigured</b>: The aggregate route is delivered to all VPC-connected instances.</description></item>
            /// <item><description><b>Configuring</b>: The aggregate route is being delivered.</description></item>
            /// <item><description><b>ConfigFailed</b>: The aggregate route failed to be delivered.</description></item>
            /// <item><description><b>PartialConfigured</b>: The aggregate route is not delivered to some VPC-connected instances.</description></item>
            /// <item><description><b>Deleting</b>: The aggregate route is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllConfigured</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the route table of the Enterprise Edition transit router.</para>
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
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
