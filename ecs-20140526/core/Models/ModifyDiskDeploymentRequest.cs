// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskDeploymentRequest : TeaModel {
        /// <summary>
        /// The new disk category. The parameter can be used only when you migrate a disk between dedicated block storage clusters. Only ESSDs can be created in dedicated block storage clusters. Set this parameter to cloud_essd.
        /// 
        /// This parameter is empty by default, which indicates that the disk category is not changed.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The ID of the disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and unavailable ECS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The new performance level of the ESSD. The parameter can be used only when you migrate data between dedicated block storage clusters. Valid values:
        /// 
        /// *   PL0: A single ESSD can deliver up to 10000 random read/write IOPS.
        /// *   PL1: A single ESSD can deliver up to 50000 random read/write IOPS.
        /// 
        /// This parameter is empty by default, which indicates that the performance level is not modified.
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the dedicated block storage cluster.
        /// 
        /// *   When you migrate a disk to a dedicated block storage cluster, the StorageClusterId parameter must be specified.
        /// *   When you migrate a disk to a public block storage cluster, the StorageClusterId parameter must be left empty.
        /// 
        /// This parameter is empty by default, which indicates that the disk is migrated to a public block storage cluster.
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

    }

}
