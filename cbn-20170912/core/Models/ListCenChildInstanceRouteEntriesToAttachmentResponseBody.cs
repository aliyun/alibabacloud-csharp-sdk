// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenChildInstanceRouteEntriesToAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used for the next query.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no subsequent query is sent.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token that is used for the next query.</para>
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
        /// <para>530BC816-F575-412A-AAB2-435125D26328</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the route.</para>
        /// </summary>
        [NameInMap("RouteEntry")]
        [Validation(Required=false)]
        public List<ListCenChildInstanceRouteEntriesToAttachmentResponseBodyRouteEntry> RouteEntry { get; set; }
        public class ListCenChildInstanceRouteEntriesToAttachmentResponseBodyRouteEntry : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-9adwg6ghpq8oq4dp7q</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The ID of the route table of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1tlaj1c4nxr2t3e****</para>
            /// </summary>
            [NameInMap("ChildInstanceRouteTableId")]
            [Validation(Required=false)]
            public string ChildInstanceRouteTableId { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The type of the managed routing service. If this parameter is empty, the route is not managed. The value TR indicates that the route is managed by a transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TR</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The status of the route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Available</b>: The route is active.</para>
            /// </description></item>
            /// <item><description><para><b>Pending</b>: The route is being configured.</para>
            /// </description></item>
            /// <item><description><para><b>Modifying</b>: The route is being modified.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-y463sghkkv1loe****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

        }

    }

}
