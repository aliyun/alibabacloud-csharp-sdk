// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainNsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether all the name servers are Alibaba Cloud DNS servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllAliDns")]
        [Validation(Required=false)]
        public bool? AllAliDns { get; set; }

        /// <summary>
        /// <para>The cause code of the detection failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DnsCheck.Failed</para>
        /// </summary>
        [NameInMap("DetectFailedReasonCode")]
        [Validation(Required=false)]
        public string DetectFailedReasonCode { get; set; }

        /// <summary>
        /// <para>The DNS server names configured for the domain name.</para>
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
        /// <para>The Domain Name System (DNS) server names assigned by Alibaba Cloud DNS.</para>
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
        /// <para>Indicates whether the name servers include Alibaba Cloud DNS servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeAliDns")]
        [Validation(Required=false)]
        public bool? IncludeAliDns { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16C7DC7A-2FA7-4D14-8B12-88A2BB6373DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
