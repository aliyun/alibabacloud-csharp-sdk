// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateRuleListRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Simplified Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The sensitivity level of the data that is not compliant with the rule. Valid values: **1** to **11**. Default value: **null**.
        /// 
        /// *   **1**: No sensitive data is detected.
        /// *   **2**: specifies the S1 sensitivity level.
        /// *   **3**: specifies the S2 sensitivity level.
        /// *   **4**: specifies the S3 sensitivity level.
        /// *   **5**: specifies the S4 sensitivity level.
        /// *   **6**: specifies the S5 sensitivity level.
        /// *   **7**: specifies the S6 sensitivity level.
        /// *   **8**: specifies the S7 sensitivity level.
        /// *   **9**: specifies the S8 sensitivity level.
        /// *   **10**: specifies the S9 sensitivity level.
        /// *   **11**: specifies the S10 sensitivity level.
        /// *   **null**: specifies all preceding sensitivity levels.
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// The status of the rule. Default value: **null**. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// *   **null**: all states
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
