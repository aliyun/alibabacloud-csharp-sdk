// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockInstancesRequest : TeaModel {
        /// <summary>
        /// The IP address that you want to specify in the rule.
        /// 
        /// >  You can call the [DescribeCustomBlockRecords](~~DescribeCustomBlockRecords~~) operation to obtain the IP address.
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// The traffic direction that you want to specify in the custom rule. Valid values:
        /// 
        /// *   **in**: inbound
        /// *   **out**: outbound
        /// </summary>
        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether the rule is enabled for the server.
        /// 
        /// *   **2**: enabling failed
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
