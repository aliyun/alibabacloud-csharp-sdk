// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainDNSRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the DNS settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cnameMatched</b>: The DNS settings are properly configured.</description></item>
        /// <item><description><b>vipMatched</b>: An A record maps the domain name to the WAF virtual IP address (VIP).</description></item>
        /// <item><description><b>wafVip</b>: An A record maps the domain name to another WAF VIP.</description></item>
        /// <item><description><b>unRecord</b>: The domain name does not have a DNS record.</description></item>
        /// <item><description><b>unUsed</b>: The domain name is not pointed to WAF.</description></item>
        /// <item><description><b>checkTimeout</b>: The check times out.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cnameMatched</para>
        /// </summary>
        [NameInMap("DNSStatus")]
        [Validation(Required=false)]
        public string DNSStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-D33C8B4C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
