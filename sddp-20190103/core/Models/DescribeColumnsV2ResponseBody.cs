// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsV2ResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// A list of column recognition results of the data table.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeColumnsV2ResponseBodyItems> Items { get; set; }
        public class DescribeColumnsV2ResponseBodyItems : TeaModel {
            /// <summary>
            /// The time when the data in the column of the table is created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// The type of data in the column of the table.
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// The ID of the column of the table.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The ID of the instance to which data in the column of the table belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The name of the instance to which data in the column of the table belongs.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// A list of data tags.
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeColumnsV2ResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeColumnsV2ResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// The tag ID. Valid values:
                /// 
                /// *   **101**: personal sensitive information
                /// *   **102**: personal information
                /// *   **107**: general information
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The tag name. Valid values:
                /// 
                /// *   Personal sensitive information
                /// *   Personal information
                /// *   General information
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The name of the column of the table.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The name of the sensitivity level for asset. Valid values:
            /// 
            /// *   **N/A**: indicates that no sensitive data is detected.
            /// *   **S1**: indicates the low sensitivity level.
            /// *   **S2**: indicates the medium sensitivity level.
            /// *   **S3**: indicates the high sensitivity level.
            /// *   **S4**: indicates the highest sensitivity level.
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// The ID of the sensitivity level of the asset. Valid values:
            /// 
            /// *   **1**: N/A
            /// *   **2**: S1
            /// *   **3**: S2
            /// *   **4**: S3
            /// *   **5**: S4
            /// >The return value <=1 means N/A.
            /// </summary>
            [NameInMap("OdpsRiskLevelValue")]
            [Validation(Required=false)]
            public int? OdpsRiskLevelValue { get; set; }

            /// <summary>
            /// The name of the service to which data in the column of the table belongs. Valid values: **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The ID of the revision record.
            /// </summary>
            [NameInMap("RevisionId")]
            [Validation(Required=false)]
            public long? RevisionId { get; set; }

            /// <summary>
            /// Indicates whether the column is revised. Valid values:
            /// 
            /// *   1: yes
            /// *   0: no
            /// </summary>
            [NameInMap("RevisionStatus")]
            [Validation(Required=false)]
            public long? RevisionStatus { get; set; }

            /// <summary>
            /// The ID of the sensitivity level of data in the column of the table. Valid values:
            /// 
            /// *   **1**: N/A
            /// *   **2**: S1
            /// *   **3**: S2
            /// *   **4**: S3
            /// *   **5**: S4
            /// 
            /// >The return value <=1 means N/A.
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// The name of the sensitivity level for data in the column of the table. Valid values:
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
            /// The ID of the sensitive data detection rule that data in the column of the table hits.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The name of the sensitive data detection rule that data in the column of the table hits.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The name of the sensitivity level. Valid values:
            /// 
            /// *   **N/A**: indicates that no sensitive data is detected.
            /// *   **S1**: indicates the low sensitivity level.
            /// *   **S2**: indicates the medium sensitivity level.
            /// *   **S3**: indicates the high sensitivity level.
            /// *   **S4**: indicates the highest sensitivity level.
            /// </summary>
            [NameInMap("SensLevelName")]
            [Validation(Required=false)]
            public string SensLevelName { get; set; }

            /// <summary>
            /// Indicates whether the column contains sensitive data. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// The ID of the table.
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// The name of the table to which the revised column belongs.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
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
