// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of the data assets.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyItems> Items { get; set; }
        public class DescribeInstancesResponseBodyItems : TeaModel {
            /// <summary>
            /// The point in time when the data asset was created. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// The name of the department to which the data asset belongs.
            /// </summary>
            [NameInMap("DepartName")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// The unique ID of the data asset.
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
            /// The security status of the data asset. Valid values:
            /// 
            /// *   **true**: The data asset is secure.
            /// *   **false**: The data asset is insecure.
            /// </summary>
            [NameInMap("Labelsec")]
            [Validation(Required=false)]
            public bool? Labelsec { get; set; }

            /// <summary>
            /// The point in time when the data asset was last scanned. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastFinishTime")]
            [Validation(Required=false)]
            public long? LastFinishTime { get; set; }

            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeInstancesResponseBodyItemsModelTags : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The name of the data asset.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// The Alibaba Cloud account to which the data asset belongs.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The name of the service to which the data asset belongs, such as MaxCompute, OSS, and ApsaraDB RDS. For more information about the types of data assets from which DSC can scan for sensitive data, see [Supported data assets](~~212906~~).
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The ID of the service to which the data asset belongs.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The protection status of the data asset. Valid values:
            /// 
            /// *   **true**: The data asset is being protected.
            /// *   **false**: The data asset is not protected.
            /// </summary>
            [NameInMap("Protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

            /// <summary>
            /// The sensitivity level of the data asset. A higher sensitivity level indicates that the identified data is more sensitive.
            /// 
            /// *   **1**: No sensitive data is identified.
            /// *   **2**: sensitive data at level 1.
            /// *   **3**: sensitive data at level 2.
            /// *   **4**: sensitive data at level 3
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
            /// The total number of sensitive data objects in the data asset. For example, if the data asset is an ApsaraDB RDS instance, the value indicates the total number of sensitive tables in all databases of the instance.
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// The name of the tenant.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The total number of data objects in the data asset. For example, if the data asset is an ApsaraDB RDS instance, the value indicates the total number of tables in all databases of the instance.
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
        /// The total number of data assets.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
