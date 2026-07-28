// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of route entries that failed to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// <para>The details of the route entries that failed to be added.</para>
        /// </summary>
        [NameInMap("FailedRouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesResponseBodyFailedRouteEntries> FailedRouteEntries { get; set; }
        public class CreateRouteEntriesResponseBodyFailedRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the custom route entry that failed to be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/24</para>
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC_ROUTE_ENTRY_CIDR_BLOCK_DUPLICATE</para>
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Specified CIDR block is already exists, entry.cidrBlock=xxxx</para>
            /// </summary>
            [NameInMap("FailedMessage")]
            [Validation(Required=false)]
            public string FailedMessage { get; set; }

            /// <summary>
            /// <para>The ID of the next hop instance of the custom route entry that failed to be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6c2fp57q8rr4jlu****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

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
        /// <para>The instance IDs returned for the successfully added custom route entries. The routing information is included.</para>
        /// </summary>
        [NameInMap("RouteEntryIds")]
        [Validation(Required=false)]
        public List<string> RouteEntryIds { get; set; }

        /// <summary>
        /// <para>The number of route entries that were successfully added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
