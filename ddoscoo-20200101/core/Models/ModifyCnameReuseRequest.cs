// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyCnameReuseRequest : TeaModel {
        /// <summary>
        /// The CNAME record that you want to reuse for the website.
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies whether to enable CNAME reuse. Valid values:
        /// 
        /// *   **1**: enables CNAME reuse.
        /// *   **2**: disables CNAME reuse.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
