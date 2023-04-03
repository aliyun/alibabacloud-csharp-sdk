// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainNsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether all the name servers were Alibaba Cloud DNS servers.
        /// </summary>
        [NameInMap("AllAliDns")]
        [Validation(Required=false)]
        public bool? AllAliDns { get; set; }

        [NameInMap("DetectFailedReasonCode")]
        [Validation(Required=false)]
        public string DetectFailedReasonCode { get; set; }

        /// <summary>
        /// The list of DNS servers for the domain name.
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
        /// The list of DNS servers assigned by Alibaba Cloud.
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
        /// Indicates whether the name servers included Alibaba Cloud DNS servers.
        /// </summary>
        [NameInMap("IncludeAliDns")]
        [Validation(Required=false)]
        public bool? IncludeAliDns { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
