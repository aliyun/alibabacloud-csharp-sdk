// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesRequest : TeaModel {
        /// <summary>
        /// The content type of the sensitive data detection rule. Valid values:
        /// 
        /// *   **0**: keyword
        /// *   **2**: regular expression
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// The type of the content in the sensitive data detection rule. Valid values include **1**, **2**, **3**, **4**, and **5**. The value 1 indicates attempts to exploit SQL injections. The value 2 indicates bypass by using SQL injections. The value 3 indicates abuse of stored procedures. The value 4 indicates buffer overflow. The value 5 indicates SQL injections based on errors.
        /// </summary>
        [NameInMap("ContentCategory")]
        [Validation(Required=false)]
        public int? ContentCategory { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The type of the sensitive data detection rule. Valid values:
        /// 
        /// *   **0**: built-in rule
        /// *   **1**: custom rule
        /// </summary>
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public int? CustomType { get; set; }

        /// <summary>
        /// The parent group type of the rule.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Specifies whether to allow earlier versions of request parameters to support keywords that are supported in later versions of request parameters. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// > To specify keywords as the content type of the sensitive data detection rule, you can set the Category parameter to 0 for earlier versions of request parameters and set the Category parameter to 5 for later versions of request parameters. You can specify the KeywordCompatible parameter based on your business requirements.
        /// </summary>
        [NameInMap("KeywordCompatible")]
        [Validation(Required=false)]
        public bool? KeywordCompatible { get; set; }

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
        /// The match type. Valid values:
        /// 
        /// *   1: rule-based match
        /// *   2: dictionary-based match
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public int? MatchType { get; set; }

        /// <summary>
        /// The name of the sensitive data detection rule. Fuzzy match is supported.
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
        /// The name of the service to which the data asset belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public int? ProductCode { get; set; }

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
        /// *   **1**: sensitive data detection rule
        /// *   **2**: audit rule
        /// *   **3**: anomalous event detection rule
        /// *   **99**: custom rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The status of the sensitive data detection rule. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The type of the data asset. Valid values:
        /// 
        /// *   **0**: all data assets
        /// *   **1**: structured data asset
        /// *   **2**: unstructured data asset
        /// 
        /// > If you set the parameter to 1 or 2, rules that support all data assets and rules that support the queried data asset type are returned.
        /// </summary>
        [NameInMap("SupportForm")]
        [Validation(Required=false)]
        public int? SupportForm { get; set; }

        /// <summary>
        /// The severity level of the alert. Valid values:
        /// 
        /// *   **1**: low
        /// *   **2**: medium
        /// *   **3**: high
        /// </summary>
        [NameInMap("WarnLevel")]
        [Validation(Required=false)]
        public int? WarnLevel { get; set; }

    }

}
