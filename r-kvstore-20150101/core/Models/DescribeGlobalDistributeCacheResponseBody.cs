// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalDistributeCacheResponseBody : TeaModel {
        /// <summary>
        /// Details of the distributed instance.
        /// </summary>
        [NameInMap("GlobalDistributeCaches")]
        [Validation(Required=false)]
        public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches> GlobalDistributeCaches { get; set; }
        public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches : TeaModel {
            /// <summary>
            /// The ID of the distributed instance.
            /// </summary>
            [NameInMap("GlobalInstanceId")]
            [Validation(Required=false)]
            public string GlobalInstanceId { get; set; }

            /// <summary>
            /// The state of the distributed instance. Valid values:
            /// 
            /// *   **Normal**: The instance is normal.
            /// *   **Changing**: The configurations of the instance are being changed.
            /// *   **Creating**: The instance is being created.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// Details of the child instances.
            /// </summary>
            [NameInMap("SubInstances")]
            [Validation(Required=false)]
            public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances> SubInstances { get; set; }
            public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances : TeaModel {
                /// <summary>
                /// The ID of the distributed instance.
                /// </summary>
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                /// <summary>
                /// The instance type of the child instance. For more information, see the following topics:
                /// 
                /// *   [Standard DRAM-based instances](~~145228~~)
                /// *   [Cluster DRAM-based instances](~~150458~~)
                /// *   [Read/write splitting DRAM-based instances](~~150459~~)
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// The ID of the child instance.
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// The state of the child instance. Valid values:
                /// 
                /// *   **Normal**: The instance is normal.
                /// *   **Creating**: The instance is being created.
                /// *   **Changing**: The configurations of the instance are being changed.
                /// *   **Inactive**: The instance is disabled.
                /// *   **Flushing**: The instance is being released.
                /// *   **Released**: The instance is released.
                /// *   **Transforming**: The billing method of the instance is changing.
                /// *   **Unavailable**: The instance is suspended.
                /// *   **Error**: The instance failed to be created.
                /// *   **Migrating**: The instance is being migrated.
                /// *   **BackupRecovering**: The instance is being restored from a backup.
                /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
                /// *   **NetworkModifying**: The network type of the instance is being changed.
                /// *   **SSLModifying**: The SSL certificate of the instance is being changed.
                /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains available during the upgrade.
                /// 
                /// >  For more information about instance states, see [Instance states and impacts](~~200740~~).
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
