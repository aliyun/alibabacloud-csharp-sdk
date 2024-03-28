// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainDNSRecordResponseBody : TeaModel {
        /// <summary>
        /// The status of the DNS settings. Valid values:
        /// 
        /// *   **cnameMatched**: The DNS settings are properly configured.
        /// *   **vipMatched**: An A record maps the domain name to the WAF virtual IP address (VIP).
        /// *   **wafVip**: An A record maps the domain name to another WAF VIP.
        /// *   **unRecord**: The domain name does not have a DNS record.
        /// *   **unUsed**: The domain name is not pointed to WAF.
        /// *   **checkTimeout**: The check times out.
        /// </summary>
        [NameInMap("DNSStatus")]
        [Validation(Required=false)]
        public string DNSStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
