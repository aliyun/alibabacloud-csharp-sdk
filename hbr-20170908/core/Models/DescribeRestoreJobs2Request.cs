// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRestoreJobs2Request : TeaModel {
        /// <summary>
        /// The keys in the filter.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeRestoreJobs2RequestFilters> Filters { get; set; }
        public class DescribeRestoreJobs2RequestFilters : TeaModel {
            /// <summary>
            /// The key in the filter. Valid values:
            /// 
            /// *   **RegionId**: the region ID
            /// *   **PlanId**: the ID of a backup plan
            /// *   **JobId**: the ID of a backup job
            /// *   **VaultId**: the ID of a backup vault
            /// *   **InstanceId**: the ID of an ECS instance
            /// *   **Bucket**: the name of an OSS bucket
            /// *   **FileSystemId**: the ID of a file system
            /// *   **Status**: the status of a backup job
            /// *   **CompleteTime**: the end time of a backup job
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The matching method. Default value: IN. This parameter specifies the operator that you want to use to match a key and a value in the filter. Valid values:
            /// 
            /// *   **EQUAL**: equal to
            /// *   **NOT_EQUAL**: not equal to
            /// *   **GREATER_THAN**: greater than
            /// *   **GREATER_THAN_OR_EQUAL**: greater than or equal to
            /// *   **LESS_THAN**: less than
            /// *   **LESS_THAN_OR_EQUAL**: less than or equal to
            /// *   **BETWEEN**: specifies a JSON array as a range. The results must fall within the range in the `[Minimum value,Maximum value]` format.
            /// *   **IN**: specifies an array as a collection. The results must fall within the collection.
            /// 
            /// > If you specify the **CompleteTime** parameter as a key to query backup jobs, you cannot use the IN operator to perform a match.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The values that you want to match in the filter.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: Elastic Compute Service (ECS) files
        /// *   **OSS**: Object Storage Service (OSS) buckets
        /// *   **NAS**: Apsara File Storage NAS file systems
        /// *   **OTS_TABLE**: Tablestore instances
        /// *   **UDM_ECS_ROLLBACK**: ECS instances
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

    }

}
