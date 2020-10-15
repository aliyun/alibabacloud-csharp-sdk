// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePrePaidInstanceStockRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=true)]
        public string EnsRegionId { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=true)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=true)]
        public int? DataDiskSize { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=true)]
        public string InstanceSpec { get; set; }

    }

}
