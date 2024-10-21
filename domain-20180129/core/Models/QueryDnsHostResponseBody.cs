// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDnsHostResponseBody : TeaModel {
        [NameInMap("DnsHostList")]
        [Validation(Required=false)]
        public List<QueryDnsHostResponseBodyDnsHostList> DnsHostList { get; set; }
        public class QueryDnsHostResponseBodyDnsHostList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ns3</para>
            /// </summary>
            [NameInMap("DnsName")]
            [Validation(Required=false)]
            public string DnsName { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18A313DD-3AF3-40AA-84F9-56BA45DC511F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
