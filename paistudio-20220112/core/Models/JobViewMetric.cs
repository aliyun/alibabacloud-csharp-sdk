// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class JobViewMetric : TeaModel {
        [NameInMap("CPUUsageRate")]
        [Validation(Required=false)]
        public string CPUUsageRate { get; set; }

        [NameInMap("DiskReadRate")]
        [Validation(Required=false)]
        public string DiskReadRate { get; set; }

        [NameInMap("DiskWriteRate")]
        [Validation(Required=false)]
        public string DiskWriteRate { get; set; }

        [NameInMap("GPUUsageRate")]
        [Validation(Required=false)]
        public string GPUUsageRate { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

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
