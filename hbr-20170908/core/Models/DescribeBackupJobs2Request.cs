// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupJobs2Request : TeaModel {
        /// <summary>
        /// The keys in the filter.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeBackupJobs2RequestFilters> Filters { get; set; }
        public class DescribeBackupJobs2RequestFilters : TeaModel {
            /// <summary>
            /// The key in the filter. Valid values:
            /// 
            /// *   **RegionId**: the ID of a region
            /// *   **PlanId**: the ID of a backup plan
            /// *   **JobId**: the ID of a backup job
            /// *   **VaultId**: the ID of a backup vault
            /// *   **InstanceId**: the ID of an ECS instance
            /// *   **Bucket**: the name of an OSS bucket
            /// *   **FileSystemId**: the ID of a file system
            /// *   **Status**: the status of a backup job
            /// *   **CreatedTime**: the start time of a backup job
            /// *   **CompleteTime**: the end time of a backup job
            /// *   **InstanceName**: the name of a Tablestore instance
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
            /// The variable values of the filter.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The order in which you want to sort the results. Valid values:
        /// 
        /// *   **ASCEND**: sorts the results in ascending order
        /// *   **DESCEND** (default value): sorts the results in descending order
        /// </summary>
        [NameInMap("SortDirection")]
        [Validation(Required=false)]
        public string SortDirection { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: Elastic Compute Service (ECS) files
        /// *   **OSS**: Object Storage Service (OSS) buckets
        /// *   **NAS**: Apsara File Storage NAS file systems
        /// *   **OTS**: Tablestore instances
        /// *   **UDM_ECS**: ECS instances
        /// *   **UDM_ECS_DISK**: ECS disks
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
