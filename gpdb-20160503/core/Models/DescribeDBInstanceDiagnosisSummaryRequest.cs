// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query details about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **20**
        /// *   **50**
        /// *   **100**
        /// 
        /// Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The role state of the node. It specifies whether a primary/secondary switchover occurs. Valid values:
        /// 
        /// *   **normal**: The node role is normal. No primary/secondary switchover occurs.
        /// *   **reverse**: The node role is reversed. A primary/secondary switchover occurs.
        /// </summary>
        [NameInMap("RolePreferd")]
        [Validation(Required=false)]
        public string RolePreferd { get; set; }

        /// <summary>
        /// The running state of the node. Valid values:
        /// 
        /// *   **UP**: The node is running.
        /// *   **DOWN**: The node is faulty.
        /// 
        /// If you do not specify this parameter, the information about nodes in all running states is returned.
        /// </summary>
        [NameInMap("StartStatus")]
        [Validation(Required=false)]
        public string StartStatus { get; set; }

        /// <summary>
        /// The data synchronization state of the node. Valid values:
        /// 
        /// *   **synced**: The node data is synchronized.
        /// *   **notSyncing**: The node data is not synchronized.
        /// 
        /// If you do not specify this parameter, the information about nodes in all synchronization states is returned.
        /// </summary>
        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
