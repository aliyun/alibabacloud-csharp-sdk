// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserVipsByDomainRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the virtual IP addresses of only healthy POPs. Valid value:
        /// 
        /// *   **on**: queries healthy VIPs.
        /// *   **off**: queries all VIPs.
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify only one domain name.
        /// 
        /// Enumeration values: example.com
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
