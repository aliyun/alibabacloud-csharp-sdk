// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleRequest : TeaModel {
        /// <summary>
        /// The content type of the sensitive data detection rule. Valid values:
        /// 
        /// *   **2**: regular expression
        /// *   **3**: algorithm
        /// *   **5**: keyword
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// The content of the sensitive data detection rule. You can specify a regular expression, an algorithm, or keywords that are used to match sensitive fields or text.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The ID of the sensitive data detection rule.
        /// 
        /// You can call the [DescribeRules](~~DescribeRules~~) operation to obtain the rule ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// The match type. Valid values:
        /// 
        /// *   **1**: rule-based match
        /// *   **2**: dictionary-based match
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public int? MatchType { get; set; }

        /// <summary>
        /// The name of the sensitive data detection rule.
        /// 
        /// You can call the [DescribeRules](~~DescribeRules~~) operation to obtain the rule name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The service to which the sensitive data detection rule is applied. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the service to which the sensitive data detection rule is applied. Valid values include **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates Object Storage Service (OSS). The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// The sensitivity level of the sensitive data that hits the sensitive data detection rule. Valid values:
        /// 
        /// *   **1**: N/A, which indicates that no sensitive data is detected.
        /// *   **2**: S1, which indicates the low sensitivity level.
        /// *   **3**: S2, which indicates the medium sensitivity level.
        /// *   **4**: S3, which indicates the high sensitivity level.
        /// *   **5**: S4, which indicates the highest sensitivity level.
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// The type of the sensitive data detection rule. Valid values:
        /// 
        /// *   **1**: data detection rule
        /// *   **2**: audit rule
        /// *   **3**: anomalous event detection rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The data assets supported by the sensitive data detection rule. Valid values:
        /// 
        /// *   **0**: all data assets
        /// *   **1**: structured data assets
        /// *   **2**: unstructured data assets
        /// </summary>
        [NameInMap("SupportForm")]
        [Validation(Required=false)]
        public int? SupportForm { get; set; }

        /// <summary>
        /// The risk level of the alert that is triggered by the sensitive data detection rule. Valid values:
        /// 
        /// *   **1**: low level
        /// *   **2**: medium level
        /// *   **3**: high level
        /// </summary>
        [NameInMap("WarnLevel")]
        [Validation(Required=false)]
        public int? WarnLevel { get; set; }

    }

}
