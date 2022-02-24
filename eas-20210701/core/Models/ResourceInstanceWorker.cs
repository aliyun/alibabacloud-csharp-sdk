// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ResourceInstanceWorker : TeaModel {
        /// <summary>
        /// CpuLimit
        /// </summary>
        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public int? CpuLimit { get; set; }

        /// <summary>
        /// CpuRequest
        /// </summary>
        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public int? CpuRequest { get; set; }

        /// <summary>
        /// GpuLimit
        /// </summary>
        [NameInMap("GpuLimit")]
        [Validation(Required=false)]
        public int? GpuLimit { get; set; }

        /// <summary>
        /// GpuRequest
        /// </summary>
        [NameInMap("GpuRequest")]
        [Validation(Required=false)]
        public int? GpuRequest { get; set; }

        /// <summary>
        /// MemoryLimit
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public int? MemoryLimit { get; set; }

        /// <summary>
        /// MemoryRquest
        /// </summary>
        [NameInMap("MemoryRquest")]
        [Validation(Required=false)]
        public int? MemoryRquest { get; set; }

        /// <summary>
        /// pod名
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否ready
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public bool? Ready { get; set; }

        /// <summary>
        /// RestartCount
        /// </summary>
        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// StartTime
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// pod状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
