// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyRequest : TeaModel {
        /// <summary>
        /// The type of the baseline check policy that you want to query. Valid values:
        /// 
        /// *   **common**: standard baseline check policy
        /// *   **custom**: custom baseline check policy
        /// </summary>
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

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
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The ID of the baseline check policy that you want to query. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public string StrategyIds { get; set; }

    }

}
