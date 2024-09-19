// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortRequest : TeaModel {
        /// <summary>
        /// The forwarding port to query. Valid values: **0** to **65535**.
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// The type of the forwarding protocol to query. Valid values:
        /// 
        /// *   **tcp**
        /// *   **udp**
        /// </summary>
        [NameInMap("FrontendProtocol")]
        [Validation(Required=false)]
        public string FrontendProtocol { get; set; }

        /// <summary>
        /// The ID of the instance to query.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The page number. For example, if you want to obtain results on the first page, set the value to **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
