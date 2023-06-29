// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the security audit feature. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// The data detection status. Valid values:
        /// 
        /// *   **0**: The data detection is ready.
        /// *   **1**: The data detection is running.
        /// *   **2**: The connectivity test is in progress.
        /// *   **3**: The connectivity test passed.
        /// *   **4**: The connectivity test failed.
        /// </summary>
        [NameInMap("CheckStatus")]
        [Validation(Required=false)]
        public int? CheckStatus { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether DSC has the data de-identification permissions on the data asset. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("DatamaskStatus")]
        [Validation(Required=false)]
        public int? DatamaskStatus { get; set; }

        /// <summary>
        /// Specifies whether DSC has the data detection permissions on the data asset. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The end of the time range to query The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The type of the database engine. Valid values include **MySQL**, **SQLServer**, **Oracle**, **PostgreSQL**, and **MongoDB**.
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

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
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The parent ID of the data asset to be queried. Valid values:
        /// 
        /// *   The name or ID of the MaxCompute project.
        /// *   The name or ID of the OSS bucket.
        /// *   The name or ID of the ApsaraDB RDS instance or database.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// The type of the service to which the data asset to be queried belongs. Valid values:
        /// 
        /// *   **1**: MaxCompute
        /// *   **2**: Object Storage Service (OSS)
        /// *   **3**: AnalyticDB for MySQL
        /// *   **4**: Tablestore
        /// *   **5**: ApsaraDB RDS
        /// *   **6**: self-managed database
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// The region in which the data asset resides.
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
