// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablePropagationsResponseBody : TeaModel {
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
        /// <para>The token that determines the start point of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04C81E0D-945E-4D61-A561-3DEA322F243B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of route learning correlations.</para>
        /// </summary>
        [NameInMap("TransitRouterPropagations")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablePropagationsResponseBodyTransitRouterPropagations> TransitRouterPropagations { get; set; }
        public class ListTransitRouterRouteTablePropagationsResponseBodyTransitRouterPropagations : TeaModel {
            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1h8vbrbcgohcju5****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: VPC</description></item>
            /// <item><description><b>VBR</b>: VBR</description></item>
            /// <item><description><b>TR</b>: transit router</description></item>
            /// <item><description><b>VPN</b>: VPN connection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the route learning correlation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabling</b>: being enabled</description></item>
            /// <item><description><b>Disabling</b>: being disabled</description></item>
            /// <item><description><b>Active</b>: available</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-vx6iwhjr1x1j78****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The ID of the route table of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1dudbh2d5na6b50****</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableId")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableId { get; set; }

        }

    }

}
