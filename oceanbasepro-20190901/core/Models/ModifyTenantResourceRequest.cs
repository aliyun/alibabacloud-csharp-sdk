// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantResourceRequest : TeaModel {
        /// <summary>
        /// The information about the CPU resources of the tenant.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The size of the log disk allocated to the tenant, in GB.
        /// </summary>
        [NameInMap("LogDisk")]
        [Validation(Required=false)]
        public long? LogDisk { get; set; }

        /// <summary>
        /// The memory size of the tenant, in GB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// Specifies to create a read-only zone. Separate the names of multiple zones with commas (,).
        /// </summary>
        [NameInMap("ReadOnlyZoneList")]
        [Validation(Required=false)]
        public string ReadOnlyZoneList { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
