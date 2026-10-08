// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDnsHostResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of DNS hosts.</para>
        /// </summary>
        [NameInMap("DnsHostList")]
        [Validation(Required=false)]
        public List<QueryDnsHostResponseBodyDnsHostList> DnsHostList { get; set; }
        public class QueryDnsHostResponseBodyDnsHostList : TeaModel {
            /// <summary>
            /// <para>The DNS name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ns3</para>
            /// </summary>
            [NameInMap("DnsName")]
            [Validation(Required=false)]
            public string DnsName { get; set; }

            /// <summary>
            /// <para>A list of IP addresses.</para>
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }

        }

        /// <summary>
        /// <para>A unique ID for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18A313DD-3AF3-40AA-84F9-56BA45DC511F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
