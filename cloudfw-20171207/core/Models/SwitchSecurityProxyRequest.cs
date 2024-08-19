// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class SwitchSecurityProxyRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh** (default)
        /// *   **en**
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the NAT firewall.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

        /// <summary>
        /// Specifies whether to enable the NAT firewall. Valid values:
        /// 
        /// *   open: yes
        /// *   close: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
