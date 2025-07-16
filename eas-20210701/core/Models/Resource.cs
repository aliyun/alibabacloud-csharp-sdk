// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Resource : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        [NameInMap("CpuUsed")]
        [Validation(Required=false)]
        public int? CpuUsed { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public int? GpuCount { get; set; }

        [NameInMap("GpuUsed")]
        [Validation(Required=false)]
        public float? GpuUsed { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        [NameInMap("InstanceMaxAllocatableCPU")]
        [Validation(Required=false)]
        public int? InstanceMaxAllocatableCPU { get; set; }

        [NameInMap("InstanceMaxAllocatableGPU")]
        [Validation(Required=false)]
        public float? InstanceMaxAllocatableGPU { get; set; }

        [NameInMap("InstanceMaxAllocatableMemory")]
        [Validation(Required=false)]
        public int? InstanceMaxAllocatableMemory { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public int? MemoryUsed { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PostPaidInstanceCount")]
        [Validation(Required=false)]
        public int? PostPaidInstanceCount { get; set; }

        [NameInMap("PrePaidInstanceCount")]
        [Validation(Required=false)]
        public int? PrePaidInstanceCount { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
