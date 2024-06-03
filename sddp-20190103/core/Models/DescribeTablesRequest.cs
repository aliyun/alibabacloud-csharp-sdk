// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeTablesRequest : TeaModel {
        /// <summary>
        /// The page number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the data asset to which the table belongs. You can call the [DescribeInstances](~~DescribeInstances~~) operation to obtain the ID of the data asset.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The search keyword. Fuzzy match is supported. For example, if you specify test, all tables whose names contain test are retrieved.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the package to which the table belongs. You can call the [DescribePackages](~~DescribePackages~~) operation to obtain the ID of the package.
        /// </summary>
        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public long? PackageId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the service to which the table belongs, such as MaxCompute, OSS, and ApsaraDB RDS. For more information about the types of data assets from which Data Security Center (DSC) can scan for sensitive data, see [Supported data assets](https://help.aliyun.com/document_detail/212906.html).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the service to which the table belongs. You can call the [DescribeDataAssets](~~DescribeDataAssets~~) operation to obtain the ID of the service.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

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
        /// The ID of the sensitive data detection rule that the table hits. You can call the [DescribeRules](~~DescribeRules~~) operation to obtain the ID of the sensitive data detection rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The region in which DSC is activated. For more information, see [Supported regions](https://help.aliyun.com/document_detail/214257.html).
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
