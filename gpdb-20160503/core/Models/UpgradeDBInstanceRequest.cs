// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpgradeDBInstanceRequest : TeaModel {
        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The specifications of each compute node. For information about the supported specifications, see [Instance specifications](https://help.aliyun.com/document_detail/35406.html).
        /// 
        /// > This parameter is available only for instances in elastic storage mode.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("MasterNodeNum")]
        [Validation(Required=false)]
        public string MasterNodeNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/86912.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs. For information about how to obtain the ID of a resource group, see [View basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The performance level of enhanced SSDs (ESSDs). Valid values:
        /// 
        /// *   **pl0**
        /// *   **pl1**
        /// *   **pl2**
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The number of compute nodes. The number of compute nodes varies based on the instance resource type and edition.
        /// 
        /// *   Valid values for High-availability Edition instances in elastic storage mode: 4 to 512, in 4 increments.
        /// *   Valid values for High-performance Edition instances in elastic storage mode: 2 to 512, in 2 increments.
        /// *   Valid values for instances in manual Serverless mode: 2 to 512, in 2 increments.
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// The disk storage type of the instance after the change. The disk storage type can be changed only to ESSD. Set the value to **cloud_essd**.
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// The storage capacity of each compute node. Unit: GB. Valid values: 50 to 6000, in 50 increments.
        /// 
        /// >  This parameter is available only for instances in elastic storage mode.
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// The type of the instance configuration change. Valid values:
        /// 
        /// *   **0** (default): changes the number of compute nodes.
        /// *   **1**: changes the specifications and storage capacity of each compute node.
        /// *   **2**: changes the number of coordinator nodes.
        /// *   **3**: changes the disk storage type and ESSD performance level of the instance.
        /// 
        /// > 
        /// 
        /// *   The supported changes to compute node configurations vary based on the instance resource type. For more information, see the "[Usage notes](https://help.aliyun.com/document_detail/50956.html)" section of the Change compute node configurations topic.
        /// 
        /// *   After you specify a change type, only the corresponding parameters take effect. For example, if you set **UpgradeType** to 0, the parameter that is used to change the number of compute nodes takes effect, but the parameter that is used to change the number of coordinator nodes does not.
        /// *   The number of coordinator nodes can be changed only on the China site (aliyun.com).
        /// *   The disk storage type can be changed only from ultra disks to ESSDs.
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public long? UpgradeType { get; set; }

    }

}
