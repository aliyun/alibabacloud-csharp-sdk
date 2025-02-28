// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouteTableAggregationResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
            /// <para>The valid value is <b>Static</b>, which indicates a static route. By default, aggregate routes advertised to a VPC are considered custom routes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// <para>The scope of networks that you want to advertise the aggregate route.</para>
            /// <para>The valid value is <b>VPC</b>, which indicates that the aggregate route is advertised to all virtual private clouds (VPCs) that are in associated forwarding correlation with the Enterprise Edition transit router and have route synchronization enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("ScopeList")]
            [Validation(Required=false)]
            public List<string> ScopeList { get; set; }

            /// <summary>
            /// <para>The status of the advertisement of the aggregate route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AllConfigured</b>: The aggregate route is advertised to all VPCs.</description></item>
            /// <item><description><b>Configuring</b>: The aggregate route is being advertised.</description></item>
            /// <item><description><b>ConfigFailed</b>: The aggregate route failed to be advertised.</description></item>
            /// <item><description><b>PartialConfigured</b>: Failed to advertise the aggregate route to some VPCs.</description></item>
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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
