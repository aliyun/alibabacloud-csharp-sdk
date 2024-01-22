// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class InstanceMetricInfo : TeaModel {
        [NameInMap("applicationID")]
        [Validation(Required=false)]
        public string ApplicationID { get; set; }

        [NameInMap("cpuPercent")]
        [Validation(Required=false)]
        public float? CpuPercent { get; set; }

        [NameInMap("cpuQuotaPercent")]
        [Validation(Required=false)]
        public float? CpuQuotaPercent { get; set; }

        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        [NameInMap("memoryLimitMB")]
        [Validation(Required=false)]
        public float? MemoryLimitMB { get; set; }

        [NameInMap("memoryUsageMB")]
        [Validation(Required=false)]
        public float? MemoryUsageMB { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
