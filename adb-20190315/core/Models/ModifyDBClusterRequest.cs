// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// The computing resources of the cluster. You can call the [DescribeAvailableResource](~~190632~~) operation to query the computing resources that are available within a region.
        /// 
        /// > This parameter must be specified when Mode is set to Flexible.
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// The edition of the cluster. Valid values:
        /// 
        /// *   **Cluster**: reserved mode for Cluster Edition.
        /// *   **MixedStorage**: elastic mode for Cluster Edition.
        /// 
        /// > If you set DBClusterCategory to Cluster, you must set Mode to Reserver. If you set DBClusterCategory to MixedStorage, you must set Mode to Flexible. Otherwise, you fail to change the specifications of the cluster.
        /// </summary>
        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The node specifications of the cluster. Valid values:
        /// 
        /// *   **C8**
        /// *   **C32**
        /// 
        /// > This parameter must be specified when Mode is set to Reserver.
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// The number of node groups. Valid values: 1 to 200.
        /// 
        /// > This parameter must be specified when Mode is set to Reserver.
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// The storage capacity per node. Unit: GB.
        /// 
        /// *   Valid values when DBClusterClass is set to C8: 100 to 2000.
        /// *   Valid values when DBClusterClass is set to C32: 100 to 8000.
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when Mode is set to Reserver.
        /// 
        /// *   The storage capacity less than 1,000 GB increases in 100 GB increments. The storage capacity greater than 1,000 GB increases in 1,000 GB increments.
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// The enhanced SSD (ESSD) performance level of the cluster. Valid values: PL1 PL2 PL3
        /// </summary>
        [NameInMap("DiskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// The number of EIUs. The number of EIUs that you can purchase varies based on the single-node EIU specifications.
        /// 
        /// *   If the single-node EIU specifications are 8 cores and 64 GB, you can purchase up to 32 EIUs.
        /// *   If the single-node EIU specifications are 12 cores and 96 GB, you can purchase up to 16 EIUs.
        /// </summary>
        [NameInMap("ElasticIOResource")]
        [Validation(Required=false)]
        public int? ElasticIOResource { get; set; }

        /// <summary>
        /// The single-node specifications of an elastic I/O unit (EIU). Valid values:
        /// 
        /// *   **8Core64GB**: If you set the parameter to **8Core64GB**, the specifications of an EIU are 24 cores and 192 GB memory.
        /// *   **12Core96GB**: If you set the parameter to **12Core96GB**, the specifications of an EIU are 36 cores and 288 GB memory.
        /// 
        /// > This parameter is available only when the cluster meets the following conditions:
        /// 
        /// *   The cluster is in elastic mode.
        /// 
        /// *   If the cluster resides in the China (Guangzhou), China (Shenzhen), China (Hangzhou), China (Shanghai), China (Qingdao), China (Beijing), or China (Zhangjiakou) region, the cluster has 16 cores and 64 GB memory or higher specifications.
        /// 
        /// *   If the cluster resides in another region, the cluster has 32 cores and 128 GB memory or higher specifications.
        /// </summary>
        [NameInMap("ElasticIOResourceSize")]
        [Validation(Required=false)]
        public string ElasticIOResourceSize { get; set; }

        /// <summary>
        /// N/A
        /// </summary>
        [NameInMap("ExecutorCount")]
        [Validation(Required=false)]
        public string ExecutorCount { get; set; }

        /// <summary>
        /// The mode of the cluster. Valid values:
        /// 
        /// *   **Reserver**: the reserved mode.
        /// *   **Flexible**: the elastic mode.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The change type. Valid values:
        /// 
        /// *   **Upgrade**
        /// *   **Downgrade**
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the cluster. You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// N/A
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

    }

}
