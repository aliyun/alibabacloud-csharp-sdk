// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListEcsSpecsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<ListEcsSpecsResponseBodyEcsSpecs> EcsSpecs { get; set; }
        public class ListEcsSpecsResponseBodyEcsSpecs : TeaModel {
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            [NameInMap("CPU")]
            [Validation(Required=false)]
            public long? CPU { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("GPU")]
            [Validation(Required=false)]
            public long? GPU { get; set; }

            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            [NameInMap("InstanceBandwidthRx")]
            [Validation(Required=false)]
            public long? InstanceBandwidthRx { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            [NameInMap("SystemDiskCapacity")]
            [Validation(Required=false)]
            public long? SystemDiskCapacity { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
