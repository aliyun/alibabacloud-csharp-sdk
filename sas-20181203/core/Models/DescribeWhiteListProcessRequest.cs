// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListProcessRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**. Pages start from page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The sort order. Default value: descending order. Valid values:
        /// 
        /// *   **1**: ascending order
        /// *   **2**: descending order
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public int? Desc { get; set; }

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
        /// The item based on which you want to sort the returned results. Default value: **process type**. Valid values:
        /// 
        /// *   **1**: process type
        /// *   **2**: degree of trustability
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public int? OrderBy { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 1000. Default value: 20. If you leave this parameter empty, 20 data entries are returned per page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the process.
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// The type of the process. Valid values:
        /// 
        /// *   **1**: trusted
        /// *   **2**: suspicious
        /// *   **3**: malicious
        /// </summary>
        [NameInMap("ProcessType")]
        [Validation(Required=false)]
        public int? ProcessType { get; set; }

        /// <summary>
        /// The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// >  You can call the [DescribeWhiteListStrategyList](~~DescribeWhiteListStrategyList~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
