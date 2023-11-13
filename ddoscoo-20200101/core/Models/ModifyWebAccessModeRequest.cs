// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebAccessModeRequest : TeaModel {
        /// <summary>
        /// The mode in which a website service is added to Anti-DDoS Pro or Anti-DDoS Premium. Valid values:
        /// 
        /// *   **0**: A record mode
        /// *   **1**: anti-DDoS mode
        /// *   **2**: origin redundancy mode
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public int? AccessMode { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](~~91724~~) operation to query all domain names.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
