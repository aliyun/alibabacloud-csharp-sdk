// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7UsKeepaliveRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// >  A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The settings for back-to-origin persistent connections. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
        /// 
        /// *   **enabled**: the switch for back-to-origin persistent connections. This field is required, and the value is of the Boolean type.
        /// *   **keepalive_requests**: the number of requests that reuse a persistent connection. This field is required, and the value is of the integer type.
        /// *   **keepalive_timeout**: the timeout period for an idle persistent connection. This field is required, and the value is of the integer type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpstreamKeepalive")]
        [Validation(Required=false)]
        public string UpstreamKeepalive { get; set; }

    }

}
