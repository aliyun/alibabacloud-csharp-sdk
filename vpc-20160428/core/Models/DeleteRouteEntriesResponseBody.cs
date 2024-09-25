// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of route entries that failed to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// <para>The information about the route entry that failed to be deleted.</para>
        /// </summary>
        [NameInMap("FailedRouteEntries")]
        [Validation(Required=false)]
        public List<DeleteRouteEntriesResponseBodyFailedRouteEntries> FailedRouteEntries { get; set; }
        public class DeleteRouteEntriesResponseBodyFailedRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route entry that failed to be deleted. IPv4 and IPv6 CIDR blocks are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/24</para>
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC_ROUTER_ENTRY_NOT_EXIST</para>
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vRouterEntry not exists</para>
            /// </summary>
            [NameInMap("FailedMessage")]
            [Validation(Required=false)]
            public string FailedMessage { get; set; }

            /// <summary>
            /// <para>The ID of the next hop that failed to be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6c2fp57q8rr4jlu****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The ID of the route entry that failed to be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rte-bp1mnnr2al0naomnpv****</para>
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of route entries that were deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
