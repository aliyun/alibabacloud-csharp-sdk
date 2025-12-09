// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class EcsSpec : TeaModel {
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("EcsImageId")]
        [Validation(Required=false)]
        public string EcsImageId { get; set; }

        [NameInMap("EriQuantity")]
        [Validation(Required=false)]
        public int? EriQuantity { get; set; }

        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        [NameInMap("GpuGUSpec")]
        [Validation(Required=false)]
        public string GpuGUSpec { get; set; }

        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        [NameInMap("GpuTypeAlias")]
        [Validation(Required=false)]
        public string GpuTypeAlias { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("MachineModel")]
        [Validation(Required=false)]
        public string MachineModel { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        [NameInMap("PlannedCpu")]
        [Validation(Required=false)]
        public int? PlannedCpu { get; set; }

        [NameInMap("PlannedMemory")]
        [Validation(Required=false)]
        public int? PlannedMemory { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SupportGPUShare")]
        [Validation(Required=false)]
        public bool? SupportGPUShare { get; set; }

        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public bool? SupportRDMA { get; set; }

        [NameInMap("SupportSetNetworkCardIndex")]
        [Validation(Required=false)]
        public bool? SupportSetNetworkCardIndex { get; set; }

    }

}
