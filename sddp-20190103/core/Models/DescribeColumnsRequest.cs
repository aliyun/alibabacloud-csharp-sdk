// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsRequest : TeaModel {
        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// The ID of the instance to which data in the column of the table belongs.
        /// 
        /// > You can call the [DescribeInstances](~~DescribeRules~~) operation to query the IDs of instances.
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
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ModelTagId")]
        [Validation(Required=false)]
        public string ModelTagId { get; set; }

        /// <summary>
        /// The search keyword. Fuzzy match is supported.
        /// 
        /// For example, if you enter **test**, all columns whose names contain **test** are retrieved.
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
        /// The name of the service to which data in the column of the table belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The sensitivity level of the sensitive data that hits the sensitive data detection rule. Valid values:
        /// 
        /// *   **1**: N/A
        /// *   **2**: S1
        /// *   **3**: S2
        /// *   **4**: S3
        /// *   **5**: S4
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// The ID of the sensitive data detection rule that data in the column of the table hits.
        /// 
        /// > You can call the [DescribeRules](~~DescribeRules~~) operation to query the IDs of sensitive data detection rules.
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
        /// The name of the sensitivity level of the data that hits the sensitive data detection rule. Valid values:
        /// 
        /// *   **N/A**: No sensitive data is detected.
        /// *   **S1**: indicates the low sensitivity level.
        /// *   **S2**: indicates the medium sensitivity level.
        /// *   **S3**: indicates the high sensitivity level.
        /// *   **S4**: indicates the highest sensitivity level.
        /// </summary>
        [NameInMap("SensLevelName")]
        [Validation(Required=false)]
        public string SensLevelName { get; set; }

        /// <summary>
        /// The ID of the table to which the column belongs.
        /// 
        /// > You can call the [DescribeTables](~~DescribeTables~~) operation to query the IDs of tables.
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateRuleId")]
        [Validation(Required=false)]
        public string TemplateRuleId { get; set; }

    }

}
