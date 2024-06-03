// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeTablesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of tables.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTablesResponseBodyItems> Items { get; set; }
        public class DescribeTablesResponseBodyItems : TeaModel {
            /// <summary>
            /// The point in time when the table was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// The ID of the table.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The description of the data asset.
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// The ID of the data asset to which the table belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The name of the data asset to which the table belongs.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The Alibaba Cloud account to which the table belongs.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The name of the service to which the table belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**. For more information about the types of data assets from which DSC can scan for sensitive data, see [Supported data assets](https://help.aliyun.com/document_detail/212906.html).
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The ID of the service to which the table belongs.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The sensitivity level of the table. Each sensitivity level ID corresponds to a sensitivity level name. Valid values:
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
            /// The name of the sensitivity level for the table. Valid values:
            /// 
            /// *   **N/A**: indicates that no sensitive data is detected.
            /// *   **S1**: indicates the low sensitivity level.
            /// *   **S2**: indicates the medium sensitivity level.
            /// *   **S3**: indicates the high sensitivity level.
            /// *   **S4**: indicates the highest sensitivity level.
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// The information about the sensitive data detection rules that are hit.
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeTablesResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeTablesResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// The total number of rules.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The name of the rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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

            }

            /// <summary>
            /// Indicates whether the table contains sensitive fields. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// The total number of sensitive fields in the table.
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// The percentage of sensitive fields in the table.
            /// </summary>
            [NameInMap("SensitiveRatio")]
            [Validation(Required=false)]
            public string SensitiveRatio { get; set; }

            /// <summary>
            /// The name of the tenant.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The total number of fields in the table.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
