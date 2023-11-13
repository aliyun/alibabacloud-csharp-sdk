// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebCacheSwitchRequest : TeaModel {
        /// <summary>
        /// The domain name for which you want to configure the Static Page Caching policy.
        /// 
        /// > You can call the [DescribeDomains](~~91724~~) operation to query all the domain names that are added to Anti-DDoS Pro or Anti-DDoS Premium.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies whether to enable or disable the Static Page Caching policy for a website. Valid values:
        /// 
        /// *   **1**: enables the policy.
        /// *   **0**: disables the policy.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not configure this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
