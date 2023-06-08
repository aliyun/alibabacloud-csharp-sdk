// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserVipsByDomainRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the virtual IP addresses of only healthy CDN POPs. Valid values:
        /// 
        /// *   **on**：healthy CDN edge nodes.
        /// *   **off**：all CDN edge nodes.
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify only one domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
