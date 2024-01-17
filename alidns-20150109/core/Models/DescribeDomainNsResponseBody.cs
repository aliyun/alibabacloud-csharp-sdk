// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainNsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether all the name servers are Alibaba Cloud DNS servers.
        /// </summary>
        [NameInMap("AllAliDns")]
        [Validation(Required=false)]
        public bool? AllAliDns { get; set; }

        /// <summary>
        /// The cause code of the detection failure.
        /// </summary>
        [NameInMap("DetectFailedReasonCode")]
        [Validation(Required=false)]
        public string DetectFailedReasonCode { get; set; }

        /// <summary>
        /// The DNS server names configured for the domain name.
        /// </summary>
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDomainNsResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDomainNsResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// The Domain Name System (DNS) server names assigned by Alibaba Cloud DNS.
        /// </summary>
        [NameInMap("ExpectDnsServers")]
        [Validation(Required=false)]
        public DescribeDomainNsResponseBodyExpectDnsServers ExpectDnsServers { get; set; }
        public class DescribeDomainNsResponseBodyExpectDnsServers : TeaModel {
            [NameInMap("ExpectDnsServer")]
            [Validation(Required=false)]
            public List<string> ExpectDnsServer { get; set; }

        }

        /// <summary>
        /// Indicates whether the name servers include Alibaba Cloud DNS servers.
        /// </summary>
        [NameInMap("IncludeAliDns")]
        [Validation(Required=false)]
        public bool? IncludeAliDns { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
