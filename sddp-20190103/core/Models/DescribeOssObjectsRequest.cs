// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectsRequest : TeaModel {
        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The code of the file type.
        /// </summary>
        [NameInMap("FileCategoryCode")]
        [Validation(Required=false)]
        public long? FileCategoryCode { get; set; }

        /// <summary>
        /// The ID of the instance to which the OSS object belongs.
        /// 
        /// > You can call the **DescribeInstances** operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The end time of the last scan. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("LastScanTimeEnd")]
        [Validation(Required=false)]
        public long? LastScanTimeEnd { get; set; }

        /// <summary>
        /// The start time of the last scan. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("LastScanTimeStart")]
        [Validation(Required=false)]
        public long? LastScanTimeStart { get; set; }

        /// <summary>
        /// The search keyword. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The sensitivity level of the OSS object. Valid values:
        /// 
        /// *   **1**: N/A, which indicates that no sensitive data is detected.
        /// *   **2**: S1, which indicates the low sensitivity level.
        /// *   **3**: S2, which indicates the medium sensitivity level.
        /// *   **4**: S3, which indicates the high sensitivity level.
        /// *   **5**: S4, which indicates the highest sensitivity level.
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public int? RiskLevelId { get; set; }

        /// <summary>
        /// The ID of the sensitive data detection rule that the OSS object hits.
        /// 
        /// > You can call the **DescribeRules** operation to query the ID of the sensitive data detection rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The region in which the data asset resides.
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// The ID of the industry-specific rule template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
