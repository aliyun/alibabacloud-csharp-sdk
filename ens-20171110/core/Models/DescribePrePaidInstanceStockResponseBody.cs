// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePrePaidInstanceStockResponseBody : TeaModel {
        [NameInMap("AvaliableCount")]
        [Validation(Required=false)]
        public int? AvaliableCount { get; set; }

        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

    }

}
