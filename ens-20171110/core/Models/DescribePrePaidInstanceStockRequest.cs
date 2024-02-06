// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePrePaidInstanceStockRequest : TeaModel {
        /// <summary>
        /// The ID of the datadisk.
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// The ID of the edge node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The size of the system disk. Unit: GB.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// The ID of the systemdisk
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

    }

}
