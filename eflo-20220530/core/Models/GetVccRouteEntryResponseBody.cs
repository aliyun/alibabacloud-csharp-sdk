// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetVccRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetVccRouteEntryResponseBodyContent Content { get; set; }
        public class GetVccRouteEntryResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Destination CIDR Block</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The time when the agent was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Next Hop Instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>local</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>Next Hop Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>VCC</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Resource group instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2l4sq6l7u***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Route type</para>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// <para>The status of the intervention entry. Valid value:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655449505171</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun connection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcc-cn-zvp2w222001</para>
            /// </summary>
            [NameInMap("VccId")]
            [Validation(Required=false)]
            public string VccId { get; set; }

            /// <summary>
            /// <para>The ID of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcc-rte-31ocvdhq</para>
            /// </summary>
            [NameInMap("VccRouteEntryId")]
            [Validation(Required=false)]
            public string VccRouteEntryId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDBCC783-84CA-5733-8EEA-645C88B9009C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
