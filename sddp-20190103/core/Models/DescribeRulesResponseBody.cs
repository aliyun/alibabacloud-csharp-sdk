// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of the sensitive data detection rules.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeRulesResponseBodyItems> Items { get; set; }
        public class DescribeRulesResponseBodyItems : TeaModel {
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
            /// The name of the content type of the sensitive data detection rule.
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// The content in the sensitive data detection rule.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The type of the content in the sensitive data detection rule. Valid values include **1**, **2**, **3**, **4**, and **5**. The value 1 indicates attempts to exploit SQL injections. The value 2 indicates bypass by using SQL injections. The value 3 indicates abuse of stored procedures. The value 4 indicates buffer overflow. The value 5 indicates SQL injections based on errors.
            /// </summary>
            [NameInMap("ContentCategory")]
            [Validation(Required=false)]
            public string ContentCategory { get; set; }

            /// <summary>
            /// The type of the sensitive data detection rule.
            /// 
            /// *   0: built-in rule
            /// *   1: custom rule
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public int? CustomType { get; set; }

            /// <summary>
            /// The description of the sensitive data detection rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The display name of the account that is used to create the sensitive data detection rule.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The time when the sensitive data detection rule is created. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the sensitive data detection rule is modified. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The parent group type of the rule.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The number of times that the sensitive data detection rule is hit.
            /// </summary>
            [NameInMap("HitTotalCount")]
            [Validation(Required=false)]
            public int? HitTotalCount { get; set; }

            /// <summary>
            /// The ID of the sensitive data detection rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The username of the account that is used to create the sensitive data detection rule.
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            /// <summary>
            /// The key of the primary dimension.
            /// </summary>
            [NameInMap("MajorKey")]
            [Validation(Required=false)]
            public string MajorKey { get; set; }

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
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The name of the service to which the data asset belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The ID of the service to which the sensitive data detection rule is applied. Valid values include **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
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
            /// The sensitivity level of data that hits the sensitive data detection rule. Valid values:
            /// 
            /// *   **N/A**: No sensitive data is detected.
            /// *   **S1**: indicates the low sensitivity level.
            /// *   **S2**: indicates the medium sensitivity level.
            /// *   **S3**: indicates the high sensitivity level.
            /// *   **S4**: indicates the highest sensitivity level.
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// The statistical expression.
            /// </summary>
            [NameInMap("StatExpress")]
            [Validation(Required=false)]
            public string StatExpress { get; set; }

            /// <summary>
            /// The status of the sensitive data detection rule. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SupportForm")]
            [Validation(Required=false)]
            public int? SupportForm { get; set; }

            /// <summary>
            /// The name of the service to which the data asset belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The ID of the account that is used to create the sensitive data detection rule.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
