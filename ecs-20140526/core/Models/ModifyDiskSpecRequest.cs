// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskSpecRequest : TeaModel {
        /// <summary>
        /// The new category of the disk. Valid values:
        /// 
        /// *   cloud_essd: ESSD
        /// *   cloud_ssd: standard SSD
        /// *   cloud_efficiency: ultra disk
        /// 
        /// This parameter is empty by default, which indicates that the disk category is not changed.
        /// 
        /// >  The preceding values are listed in descending order of disk performance. The disk cannot be downgraded if it is a subscription disk.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The ID of the disk.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies whether to check the validity of the request without actually making the request. Valid values:
        /// 
        /// *   true: The validity of the request is checked but the request is not made. Check items include the required parameters, request format, service limits, and available ECS resources. If the check fails, the corresponding error message is returned. If the check succeeds, the `DryRunOperation` error code is returned.
        /// *   false: The validity of the request is checked. If the check succeeds, a 2xx HTTP status code is returned and the request is made.
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
        /// The new performance level of the ESSD. Valid values:
        /// 
        /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1.
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// 是否修改ESSD AutoPL云盘预配置读写IOPS。取值范围：0~min{50000, 1000*容量-基准性能}。
        /// 
        /// 基准性能=min{1,800+50*容量, 50,000}
        /// 
        /// > 当DiskCategory取值为cloud_auto时才支持设置该参数。更多信息，请参见[ESSD AutoPL云盘](~~368372~~)和[修改ESSD AutoPL云盘预配置信息](~~413275~~)。
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
