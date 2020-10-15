// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePrePaidInstanceStockResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=true)]
        public int? DataDiskSize { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=true)]
        public string EnsRegionId { get; set; }

        [NameInMap("Cores")]
        [Validation(Required=true)]
        public int? Cores { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=true)]
        public int? Memory { get; set; }

        [NameInMap("AvaliableCount")]
        [Validation(Required=true)]
        public int? AvaliableCount { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=true)]
        public string InstanceSpec { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=true)]
        public int? SystemDiskSize { get; set; }

    }

}
