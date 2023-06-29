// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateRuleListResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The list of rules.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCategoryTemplateRuleListResponseBodyItems> Items { get; set; }
        public class DescribeCategoryTemplateRuleListResponseBodyItems : TeaModel {
            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The unique ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The IDs of sensitive data types. Multiple IDs are separated by commas (,).
            /// </summary>
            [NameInMap("IdentificationRuleIds")]
            [Validation(Required=false)]
            public string IdentificationRuleIds { get; set; }

            /// <summary>
            /// The scan scope of the rule. The value is a JSON array of the STRING type. Each element in a JSON array indicates a scan scope that contains the following fields:
            /// 
            /// *   **Asset**: the data asset type. Valid values: RDS, DRDS, PolarDB, OTS, ADB, and OceanBase. The value is of the STRING type.
            /// 
            /// *   **Content**: the scan scope. The value is of the STRING type. Each element in a JSON array indicates a scan scope that contains the following fields:
            /// 
            ///     *   **Range**: the matching condition. Valid values: Instance, database, table, column, project, bucket, and object. The value project is valid only for data assets in MaxCompute. The values bucket and object are valid only for data assets in Object Storage Service (OSS). The value of this parameter is of the STRING type.
            ///     *   **Operator**: the operator. Valid values: equals, regex, prefix, and suffix. The operator equals indicates a full match. The operator regex indicates a match by regular expression. The operator prefix indicates a match by prefix. The operator suffix indicates a match by suffix.
            ///     *   **Value**: the matching content. The value is of the STRING type.
            /// </summary>
            [NameInMap("IdentificationScope")]
            [Validation(Required=false)]
            public string IdentificationScope { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The sensitivity level of the data that is not compliant with the rule. Valid values: **1** to **11**.
            /// 
            /// *   **1**: No sensitive data is detected.
            /// *   **2**: indicates the S1 sensitivity level.
            /// *   **3**: indicates the S2 sensitivity level.
            /// *   **4**: indicates the S3 sensitivity level.
            /// *   **5**: indicates the S4 sensitivity level.
            /// *   **6**: indicates the S5 sensitivity level.
            /// *   **7**: indicates the S6 sensitivity level.
            /// *   **8**: indicates the S7 sensitivity level.
            /// *   **9**: indicates the S8 sensitivity level.
            /// *   **10**: indicates the S9 sensitivity level.
            /// *   **11**: indicates the S10 sensitivity level.
            /// *   **null**: indicates all preceding sensitivity levels.
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// *   **null**: all states
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of rules in the template.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
