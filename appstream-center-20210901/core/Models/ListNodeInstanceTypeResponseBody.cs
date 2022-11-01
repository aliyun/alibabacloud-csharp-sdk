// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodeInstanceTypeResponseBody : TeaModel {
        [NameInMap("NodeInstanceTypeModels")]
        [Validation(Required=false)]
        public List<ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels> NodeInstanceTypeModels { get; set; }
        public class ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public string Gpu { get; set; }

            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public int? MaxCapacity { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            [NameInMap("NodeInstanceTypeFamily")]
            [Validation(Required=false)]
            public string NodeInstanceTypeFamily { get; set; }

            [NameInMap("NodeTypeName")]
            [Validation(Required=false)]
            public string NodeTypeName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
