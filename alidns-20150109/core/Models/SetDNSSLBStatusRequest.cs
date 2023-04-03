// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDNSSLBStatusRequest : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The language of the subdomain.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// Specifies whether to enable or disable weighted round-robin. Valid values:
        /// 
        /// *   **true**: enables weighted round-robin. This is the default value.
        /// *   **false**: disables weighted round-robin.
        /// </summary>
        [NameInMap("Open")]
        [Validation(Required=false)]
        public bool? Open { get; set; }

        /// <summary>
        /// The subdomain for which you want to configure weighted round-robin. Do not set the value to a string such as aliyun.com. Instead, set the value to @.aliyun.com.
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// The type of the DNS record. Valid values: A and AAAA. Default value: A.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The IP address of the client that you use to configure weighted round-robin.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
