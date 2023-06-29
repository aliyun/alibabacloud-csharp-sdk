// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataAssetsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
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
        /// The keyword that is used to search for data assets. Fuzzy search is supported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the data asset that you want to query. Valid values:
        /// 
        /// *   **1**: MaxCompute project
        /// *   **2**: MaxCompute table
        /// *   **3**: MaxCompute package
        /// *   **11**: AnalyticDB for MySQL database
        /// *   **12**: AnalyticDB for MySQL table
        /// *   **21**: Object Storage Service (OSS) bucket
        /// *   **22**: OSS object
        /// *   **31**: Tablestore instance
        /// *   **32**: Tablestore table
        /// *   **51**: ApsaraDB RDS database
        /// *   **52**: ApsaraDB RDS table
        /// *   **61**: self-managed database hosted on an Elastic Compute Service (ECS) instance
        /// *   **62**: self-managed table hosted on an ECS instance
        /// *   **71**: PolarDB-X database
        /// *   **72**: PolarDB-X table
        /// *   **81**: PolarDB database
        /// *   **82**: PolarDB table
        /// *   **91**: AnalyticDB for PostgreSQL database
        /// *   **92**: AnalyticDB for PostgreSQL table
        /// </summary>
        [NameInMap("RangeId")]
        [Validation(Required=false)]
        public int? RangeId { get; set; }

        /// <summary>
        /// The sensitivity level of the data asset. Separate multiple sensitivity levels with commas (,). Valid values:
        /// 
        /// *   **2**: S1, indicating the low sensitivity level
        /// *   **3**: S2, indicating the medium sensitivity level
        /// *   **4**: S3, indicating the high sensitivity level
        /// *   **5**: S4, indicating the highest sensitivity level
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// The unique ID of the sensitive data detection rule that the data assets to be queried hit.
        /// 
        /// > If you query sensitive data detection results based on the sensitive data detection rule that the data assets hit, you can call the [DescribeRules](~~DescribeRules~~) operation to query the ID of the sensitive data detection rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
