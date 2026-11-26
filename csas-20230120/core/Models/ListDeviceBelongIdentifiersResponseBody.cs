// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDeviceBelongIdentifiersResponseBody : TeaModel {
        /// <summary>
        /// <para>The device ownership identifier records on the current page. An empty list is returned if no matching records are found.</para>
        /// </summary>
        [NameInMap("Identifiers")]
        [Validation(Required=false)]
        public List<ListDeviceBelongIdentifiersResponseBodyIdentifiers> Identifiers { get; set; }
        public class ListDeviceBelongIdentifiersResponseBodyIdentifiers : TeaModel {
            /// <summary>
            /// <para>The time when the record was created. The time is in RFC 3339 format and includes time zone information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-24T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the identifier record, returned as a decimal string. You can use the ID to query or remove the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>482731</para>
            /// </summary>
            [NameInMap("IdentifierId")]
            [Validation(Required=false)]
            public string IdentifierId { get; set; }

            /// <summary>
            /// <para>The identifier type. MAC indicates the MAC address of the network interface controller (NIC), SystemSN indicates the system serial number, and BIOSSN indicates the BIOS serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAC</para>
            /// </summary>
            [NameInMap("IdentifierType")]
            [Validation(Required=false)]
            public string IdentifierType { get; set; }

            /// <summary>
            /// <para>The identifier value in the record. MAC addresses are in the lowercase colon-separated format. System serial numbers and BIOS serial numbers are returned as recorded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00:00:00:01</para>
            /// </summary>
            [NameInMap("IdentifierValue")]
            [Validation(Required=false)]
            public string IdentifierValue { get; set; }

        }

        /// <summary>
        /// <para>A reserved pagination field. No valid value is returned in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A reserved pagination cursor. No valid value is returned in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d9fbd0d1ac24be90</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A92B549-EC82-5F79-8301-63711AFC9DCE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the filter conditions for the current tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
