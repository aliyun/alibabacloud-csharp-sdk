// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHttp2EnableRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name, and the domain name must be associated with an instance that uses the Enhanced function plan. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query all domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP/2. Valid values:
        /// 
        /// *   **0**: disables HTTP/2.
        /// *   **1**: enables HTTP/2.
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
