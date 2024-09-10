// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateWhiteListStrategyStatusRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The status of the policy. Valid values:
        /// 
        /// *   **0**: deleted
        /// *   **1**: learning
        /// *   **2**: paused
        /// *   **3**: learning completed
        /// *   **4**: enabled
        /// 
        /// > 
        /// 
        /// *   You can change the status to **paused** only if the policy status is **learning**.
        /// 
        /// *   You can change the status to **learning** only if the policy status is **paused**.
        /// 
        /// *   You can change the status to **enabled** only if the policy status is **learning completed**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// >  You can call the [DescribeWhiteListStrategyList](~~DescribeWhiteListStrategyList~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public string StrategyIds { get; set; }

    }

}
