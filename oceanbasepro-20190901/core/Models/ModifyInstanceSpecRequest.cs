// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        /// <summary>
        /// The size of the storage space, in GB. The required storage space varies based on the cluster specifications:
        /// - 8C32G: 100 GB to 10 TB.
        /// - 14C70G: 200 GB to 10 TB.
        /// - 30C180G: 400 GB to 10 TB.
        /// - 62C400G: 800 GB to 10 TB. The preceding minimum storage space sizes are the default storage space sizes of the corresponding cluster specification plans.
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public long? DiskSize { get; set; }

        /// <summary>
        /// Disk type.
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run for the request. Default value: false. Valid values:
        /// - true: Only a dry-run request is sent and the instance settings are not modified. If the dry run succeeds, DryRunResult=true is returned. If the dry run fails, an error code is returned.
        /// - false: If the DryRun parameter is set to false, no dry run is performed and the DryRunResult parameter returns false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The specifications of the cluster. You can specify one of the following four plans:
        /// - 8C32GB: indicates 8 CPU cores and 32 GB of memory.
        /// - 14C70GB: indicates 14 CPU cores and 70 GB of memory. This is the default value.
        /// - 30C180GB: indicates 30 CPU cores and 180 GB of memory.
        /// - 62C400GB: indicates 62 CPU cores and 400 GB of memory.
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
