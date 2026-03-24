// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The addresses in the address book.</para>
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public List<DescribeAddressesResponseBodyAddressList> AddressList { get; set; }
        public class DescribeAddressesResponseBodyAddressList : TeaModel {
            /// <summary>
            /// <para>The IP address or CIDR block in the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The most recent modification time of the address. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760408233000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. If this parameter is returned, more results are available.</para>
        /// <remarks>
        /// <para>Include this value in the <b>NextToken</b> parameter of the next request to retrieve additional results. If this parameter is not returned, all results have been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D8EBFB7-E1EB-5236-952A-092EDC72***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of addresses that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
