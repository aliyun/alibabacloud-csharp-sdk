// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeGPUMetric : TeaModel {
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("GPUCount")]
        [Validation(Required=false)]
        public int? GPUCount { get; set; }

        [NameInMap("GPUMetrics")]
        [Validation(Required=false)]
        public List<GPUMetric> GPUMetrics { get; set; }

        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("MemoryUtil")]
        [Validation(Required=false)]
        public float? MemoryUtil { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public float? TotalMemory { get; set; }

        [NameInMap("UsedMemory")]
        [Validation(Required=false)]
        public float? UsedMemory { get; set; }

    }

}
