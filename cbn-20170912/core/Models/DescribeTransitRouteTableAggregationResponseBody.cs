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
        /// <para>A list of aggregate routes.</para>
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
            /// <para>The type of the aggregate route.</para>
            /// <para>The value is set to <b>Static</b>. This indicates that the route is a static route. After the aggregate route is advertised to a VPC, it becomes a custom route entry by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// <para>The scope of the aggregate route.</para>
            /// <para>The value is set to <b>VPC</b>. This indicates that the aggregate route is advertised to all VPCs that are associated with the route table of the Enterprise Edition transit router and have route synchronization enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The list of scopes of the aggregate route.</para>
            /// <remarks>
            /// <para>You must specify at least one of the Scope and ScopeList properties. We recommend that you specify ScopeList. The elements in ScopeList cannot be the same as the value of Scope.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ScopeList")]
            [Validation(Required=false)]
            public List<string> ScopeList { get; set; }

            /// <summary>
            /// <para>The advertising status of the aggregate route.</para>
            /// <list type="bullet">
            /// <item><description><para><b>AllConfigured</b>: The aggregate route is advertised to all VPCs.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: The aggregate route is being advertised.</para>
            /// </description></item>
            /// <item><description><para><b>ConfigFailed</b>: The aggregate route failed to be advertised.</para>
            /// </description></item>
            /// <item><description><para><b>PartialConfigured</b>: The aggregate route is advertised to some VPCs.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The aggregate route is being deleted.</para>
            /// </description></item>
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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no next page exists.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</para>
        /// </description></item>
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
