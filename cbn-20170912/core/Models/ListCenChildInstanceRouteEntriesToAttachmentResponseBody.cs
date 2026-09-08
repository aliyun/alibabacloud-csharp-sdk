// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenChildInstanceRouteEntriesToAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a next query token (Token) exists. Valid values:</para>
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
        /// <para>530BC816-F575-412A-AAB2-435125D26328</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the route entries.</para>
        /// </summary>
        [NameInMap("RouteEntry")]
        [Validation(Required=false)]
        public List<ListCenChildInstanceRouteEntriesToAttachmentResponseBodyRouteEntry> RouteEntry { get; set; }
        public class ListCenChildInstanceRouteEntriesToAttachmentResponseBodyRouteEntry : TeaModel {
            /// <summary>
            /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-9adwg6ghpq8oq4dp7q</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The route table ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1tlaj1c4nxr2t3e****</para>
            /// </summary>
            [NameInMap("ChildInstanceRouteTableId")]
            [Validation(Required=false)]
            public string ChildInstanceRouteTableId { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The type of route hosting. If this field is empty, the route is not hosted. Valid values: TR, which indicates that the hosting type is transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TR</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The status of the route entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: available.</description></item>
            /// <item><description><b>Pending</b>: being configured.</description></item>
            /// <item><description><b>Modifying</b>: being modified.</description></item>
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
