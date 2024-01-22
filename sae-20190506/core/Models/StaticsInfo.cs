// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class StaticsInfo : TeaModel {
        [NameInMap("activeCPUUsage")]
        [Validation(Required=false)]
        public long? ActiveCPUUsage { get; set; }

        [NameInMap("cost")]
        [Validation(Required=false)]
        public float? Cost { get; set; }

        [NameInMap("diskUsage")]
        [Validation(Required=false)]
        public long? DiskUsage { get; set; }

        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("gpuUsage")]
        [Validation(Required=false)]
        public long? GpuUsage { get; set; }

        [NameInMap("idleCPUUsage")]
        [Validation(Required=false)]
        public long? IdleCPUUsage { get; set; }

        [NameInMap("instanceTrafficOut")]
        [Validation(Required=false)]
        public long? InstanceTrafficOut { get; set; }

        [NameInMap("invocations")]
        [Validation(Required=false)]
        public long? Invocations { get; set; }

        [NameInMap("invokeCDNOut")]
        [Validation(Required=false)]
        public long? InvokeCDNOut { get; set; }

        [NameInMap("invokeInternetOut")]
        [Validation(Required=false)]
        public long? InvokeInternetOut { get; set; }

        [NameInMap("memoryUsage")]
        [Validation(Required=false)]
        public long? MemoryUsage { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
