// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// Enable storage compression function. The value of this parameter is ON.
        /// </summary>
        [NameInMap("CompressStorage")]
        [Validation(Required=false)]
        public string CompressStorage { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// >  You can call the DescribeDBClusters operation to query information about all PolarDB clusters that are deployed in a specified region, such as cluster IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The method used to replicate data across zones. Valid values:
        /// 
        /// *   **AsyncSync**: the asynchronous mode.
        /// *   **SemiSync**: the semi-synchronous mode.
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// The fault scenario that you want to simulate for the cluster.
        /// 
        /// *   Set the value to **0**. The value 0 indicates the scenario in which the primary zone of the cluster fails.
        /// 
        /// > 
        /// 
        /// *   This parameter takes effect only when you set the `StandbyHAMode` parameter to 0.
        /// 
        /// *   If you set this parameter to 0, all compute nodes deployed in the primary zone are unavailable. In this case, the switchover degrades the cluster performance.
        /// </summary>
        [NameInMap("FaultSimulateMode")]
        [Validation(Required=false)]
        public string FaultSimulateMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable the cross-zone automatic switchover mode. Valid values:
        /// 
        /// *   **ON**: Enable the cross-zone automatic switchover mode.
        /// *   **OFF**: Disable the cross-zone automatic switchover mode.
        /// *   **0**: Enable the customer drill mode.
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic storage scaling for the cluster of Standard Edition. Valid values:
        /// 
        /// *   Enable
        /// *   Disable
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// The maximum storage capacity of the cluster of Standard Edition in automatic scaling. Unit: GB.
        /// 
        /// >  The maximum value of this parameter is 32000.
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

    }

}
