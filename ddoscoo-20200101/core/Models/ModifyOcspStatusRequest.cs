// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyOcspStatusRequest : TeaModel {
        /// <summary>
        /// The domain name for which you want to configure the Static Page Caching policy.
        /// 
        /// > You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all the domain names that are added to Anti-DDoS Pro or Anti-DDoS Premium.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies whether to enable the OCSP feature. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

    }

}
