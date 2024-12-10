// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaNodeViewMetric : TeaModel {
        [NameInMap("CPUUsageRate")]
        [Validation(Required=false)]
        public string CPUUsageRate { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("DiskReadRate")]
        [Validation(Required=false)]
        public string DiskReadRate { get; set; }

        [NameInMap("DiskWriteRate")]
        [Validation(Required=false)]
        public string DiskWriteRate { get; set; }

        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("MemoryUsageRate")]
        [Validation(Required=false)]
        public string MemoryUsageRate { get; set; }

        [NameInMap("NetworkInputRate")]
        [Validation(Required=false)]
        public string NetworkInputRate { get; set; }

        [NameInMap("NetworkOutputRate")]
        [Validation(Required=false)]
        public string NetworkOutputRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-i121212node</para>
        /// </summary>
        [NameInMap("NodeID")]
        [Validation(Required=false)]
        public string NodeID { get; set; }

        [NameInMap("NodeStatus")]
        [Validation(Required=false)]
        public string NodeStatus { get; set; }

        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public long? RequestCPU { get; set; }

        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public long? RequestGPU { get; set; }

        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public long? RequestMemory { get; set; }

        [NameInMap("TaskIdMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> TaskIdMap { get; set; }

        [NameInMap("TotalCPU")]
        [Validation(Required=false)]
        public long? TotalCPU { get; set; }

        [NameInMap("TotalGPU")]
        [Validation(Required=false)]
        public long? TotalGPU { get; set; }

        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public long? TotalMemory { get; set; }

        [NameInMap("TotalTasks")]
        [Validation(Required=false)]
        public long? TotalTasks { get; set; }

        [NameInMap("UserIDs")]
        [Validation(Required=false)]
        public List<string> UserIDs { get; set; }

        [NameInMap("UserNumber")]
        [Validation(Required=false)]
        public string UserNumber { get; set; }

    }

}
