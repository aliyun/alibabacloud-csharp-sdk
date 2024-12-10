// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UserViewMetric : TeaModel {
        [NameInMap("CPUNodeNumber")]
        [Validation(Required=false)]
        public int? CPUNodeNumber { get; set; }

        [NameInMap("CPUUsageRate")]
        [Validation(Required=false)]
        public string CPUUsageRate { get; set; }

        [NameInMap("CpuJobNames")]
        [Validation(Required=false)]
        public List<string> CpuJobNames { get; set; }

        [NameInMap("CpuNodeNames")]
        [Validation(Required=false)]
        public List<string> CpuNodeNames { get; set; }

        [NameInMap("DiskReadRate")]
        [Validation(Required=false)]
        public string DiskReadRate { get; set; }

        [NameInMap("DiskWriteRate")]
        [Validation(Required=false)]
        public string DiskWriteRate { get; set; }

        [NameInMap("GPUNodeNumber")]
        [Validation(Required=false)]
        public int? GPUNodeNumber { get; set; }

        [NameInMap("GPUUsageRate")]
        [Validation(Required=false)]
        public string GPUUsageRate { get; set; }

        [NameInMap("GpuJobNames")]
        [Validation(Required=false)]
        public List<string> GpuJobNames { get; set; }

        [NameInMap("GpuNodeNames")]
        [Validation(Required=false)]
        public List<string> GpuNodeNames { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("MemoryUsageRate")]
        [Validation(Required=false)]
        public string MemoryUsageRate { get; set; }

        [NameInMap("NetworkInputRate")]
        [Validation(Required=false)]
        public string NetworkInputRate { get; set; }

        [NameInMap("NetworkOutputRate")]
        [Validation(Required=false)]
        public string NetworkOutputRate { get; set; }

        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public int? RequestCPU { get; set; }

        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public int? RequestGPU { get; set; }

        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public long? RequestMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg17tmvwiokhzaxg</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("TotalCPU")]
        [Validation(Required=false)]
        public int? TotalCPU { get; set; }

        [NameInMap("TotalGPU")]
        [Validation(Required=false)]
        public int? TotalGPU { get; set; }

        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public long? TotalMemory { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
