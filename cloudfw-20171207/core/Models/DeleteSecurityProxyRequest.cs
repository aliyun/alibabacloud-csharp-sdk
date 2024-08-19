// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteSecurityProxyRequest : TeaModel {
        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
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

    }

}
