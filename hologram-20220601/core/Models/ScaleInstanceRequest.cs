// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ScaleInstanceRequest : TeaModel {
        /// <summary>
        /// The infrequent access (IA) storage space of the instance. Unit: GB.
        /// 
        /// > Ignore this parameter for pay-as-you-go instances.
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// The specifications of the instance. Valid values:
        /// 
        /// *   8-core 32GB (number of compute nodes: 1)
        /// *   16-core 64GB (number of compute nodes: 1)
        /// *   32-core 128GB (number of compute nodes: 2)
        /// *   64-core 256GB (number of compute nodes: 4)
        /// *   96-core 384GB (number of compute nodes: 6)
        /// *   128-core 512GB (number of compute nodes: 8)
        /// *   Others
        /// 
        /// > 
        /// 
        /// *   Set this parameter to the number of cores.
        /// 
        /// *   If you want to set this parameter to specifications with more than 1,024 compute units (CUs), you must submit a ticket.
        /// 
        /// *   This parameter is invalid for Hologres Shared Cluster instances.
        /// 
        /// *   The specifications of 8-core 32GB (number of compute nodes: 1) are for trial use only and cannot be used for production.
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        [NameInMap("enableServerlessComputing")]
        [Validation(Required=false)]
        public bool? EnableServerlessComputing { get; set; }

        /// <summary>
        /// The number of gateways. Valid values: 2 to 50.
        /// 
        /// > This parameter is required only for virtual warehouse instances.
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        /// <summary>
        /// The specification change type. Valid values:
        /// 
        /// *   UPGRADE
        /// *   DOWNGRADE
        /// 
        /// > 
        /// 
        /// *   If you set this parameter to UPGRADE, the new specifications must be higher than the original specifications. You must configure at least one of the cpu, storageSize, and coldStorageSize parameters. If you leave a parameter empty, the related configuration remains unchanged.
        /// 
        /// *   If you set this parameter to DOWNGRADE, the new specifications must be lower than the original specifications. You must configure at least one of the cpu, storageSize, and coldStorageSize parameters. If you leave a parameter empty, the related configuration remains unchanged.
        /// </summary>
        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        /// <summary>
        /// The standard storage space of the instance. Unit: GB.
        /// 
        /// > Ignore this parameter for pay-as-you-go instances.
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

    }

}
