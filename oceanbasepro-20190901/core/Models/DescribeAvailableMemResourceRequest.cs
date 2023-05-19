// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableMemResourceRequest : TeaModel {
        /// <summary>
        /// The available memory size.
        /// </summary>
        [NameInMap("CpuNum")]
        [Validation(Required=false)]
        public long? CpuNum { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The number of resource units in the tenant.
        /// </summary>
        [NameInMap("UnitNum")]
        [Validation(Required=false)]
        public long? UnitNum { get; set; }

    }

}
