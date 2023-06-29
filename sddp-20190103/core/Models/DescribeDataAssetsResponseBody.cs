// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataAssetsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of data assets.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataAssetsResponseBodyItems> Items { get; set; }
        public class DescribeDataAssetsResponseBodyItems : TeaModel {
            /// <summary>
            /// The access control list (ACL) that controls the access permissions on the OSS bucket.
            /// 
            /// > This parameter is returned only when you set the parameter **RangeId** to **21**.
            /// </summary>
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// The time when the data asset was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// The data type of the data asset.
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// The ID of the data asset.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The sensitivity tag of the data. The value is fixed as **0**. **0**, **1**, **2**, or **3** is returned for this parameter only when you set the parameter **RangeId** to **1**.
            /// 
            /// *   **0**: unclassified
            /// *   **1**: confidential
            /// *   **2**: sensitive
            /// *   **3**: highly sensitive
            /// </summary>
            [NameInMap("Labelsec")]
            [Validation(Required=false)]
            public bool? Labelsec { get; set; }

            /// <summary>
            /// The name of the data asset.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The key value of the OSS object.
            /// 
            /// > This parameter is returned only when you set the parameter **RangeId** to **22**.
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// The sensitivity level of the MaxCompute data asset. Valid values:
            /// 
            /// *   **S1**: low sensitivity level
            /// *   **S2**: medium sensitivity level
            /// *   **S3**: high sensitivity level
            /// *   **S4**: highest sensitivity level
            /// 
            /// > This parameter is returned only when you set the parameter **RangeId** to **1**.
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// The account that owns the data asset.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The name of the service to which the data asset belongs.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The ID of the service to which the data asset belongs. Valid values:
            /// 
            /// *   **1**: MaxCompute
            /// *   **2**: OSS
            /// *   **3**: AnalyticDB for MySQL
            /// *   **4**: Tablestore
            /// *   **5**: ApsaraDB RDS
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// Indicates whether the data protection mechanism is enabled for the data asset. The value is fixed as **false**. **true** or **false** is returned for this parameter only when you set the parameter **RangeId** to **1**.
            /// 
            /// *   **false**: The data protection mechanism is disabled.
            /// *   **true**: The data protection mechanism is enabled. Only data inbound is supported. Data outbound is not supported.
            /// </summary>
            [NameInMap("Protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

            /// <summary>
            /// The sensitivity level of the data asset. A higher sensitivity level indicates that the identified data is more sensitive. Valid values:
            /// 
            /// *   **1**: No sensitive data is identified.
            /// *   **2**: sensitive data at level 1.
            /// *   **3**: sensitive data at level 2.
            /// *   **3**: sensitive data at level 3.
            /// *   **5**: sensitive data at level 4.
            /// *   **6**: sensitive data at level 5.
            /// *   **7**: sensitive data at level 6.
            /// *   **8**: sensitive data at level 7.
            /// *   **9**: sensitive data at level 8.
            /// *   **10**: sensitive data at level 9.
            /// *   **11**: sensitive data at level 10.
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// The name of the sensitivity level for the data asset.
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// The name of the sensitive data detection rule that the data asset hits.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// Indicates whether the data asset contains sensitive data. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// The total number of sensitive data assets. For example, the value can be the total number of sensitive MaxCompute projects, packages, or tables, the total number of sensitive ApsaraDB RDS databases or tables, or the total number of sensitive OSS buckets or objects.
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// The percentage of sensitive data in all data assets.
            /// </summary>
            [NameInMap("SensitiveRatio")]
            [Validation(Required=false)]
            public string SensitiveRatio { get; set; }

            /// <summary>
            /// The total number of data assets. For example, the value can be the total number of MaxCompute projects, packages, or tables, the total number of ApsaraDB RDS databases or tables, or the total number of OSS buckets or objects.
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
        /// The total number of queried data assets that contain sensitive data.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
