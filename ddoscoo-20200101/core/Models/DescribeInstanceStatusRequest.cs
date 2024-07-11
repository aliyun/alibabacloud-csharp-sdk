// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the Anti-DDoS Proxy instance to query.
        /// 
        /// >  You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all Anti-DDoS Proxy (Chinese Mainland) or Anti-DDoS Proxy (Outside Chinese Mainland) instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the Anti-DDoS Proxy instance to query. Valid values:
        /// 
        /// *   **1**: an Anti-DDoS Proxy (Chinese Mainland) instance
        /// *   **2**: an Anti-DDoS Proxy (Outside Chinese Mainland) instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

    }

}
