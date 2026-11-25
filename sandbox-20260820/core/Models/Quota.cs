// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class Quota : TeaModel {
        /// <summary>
        /// <para>The vCPU quota, in cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("cpuCores")]
        [Validation(Required=false)]
        public int? CpuCores { get; set; }

        /// <summary>
        /// <para>The team snapshot-based sandbox creation concurrency quota, in requests. This value represents the maximum number of snapshot-based sandbox creation requests that can be executed at the same time. When updating, omit this parameter or set it to null to retain the original configuration. Set it to a positive integer to specify an exclusive quota. Set it to 0 to prohibit snapshot-based sandbox creation. Set it to -1 to clear the exclusive quota and restore the remaining quota of the shared account. In query responses, this parameter is omitted if it is not configured. An explicit value of 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("createSandboxWithSnapshotConcurrency")]
        [Validation(Required=false)]
        public int? CreateSandboxWithSnapshotConcurrency { get; set; }

        /// <summary>
        /// <para>The team snapshot creation concurrency quota, in requests. This value represents the maximum number of snapshot creation requests that can be executed at the same time. When updating, omit this parameter or set it to null to retain the original configuration. Set it to a positive integer to specify an exclusive quota. Set it to 0 to prohibit snapshot creation. Set it to -1 to clear the exclusive quota and restore the remaining quota of the shared account. In query responses, this parameter is omitted if it is not configured. An explicit value of 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("createSnapshotConcurrency")]
        [Validation(Required=false)]
        public int? CreateSnapshotConcurrency { get; set; }

        /// <summary>
        /// <para>The quota for active instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("instanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <para>The memory quota, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("memoryGB")]
        [Validation(Required=false)]
        public int? MemoryGB { get; set; }

        /// <summary>
        /// <para>The team sandbox hibernation concurrency quota, in requests. This value represents the maximum number of sandbox hibernation requests that can be executed at the same time. When updating, omit this parameter or set it to null to retain the original configuration. Set it to a positive integer to specify an exclusive quota. Set it to 0 to prohibit sandbox hibernation. Set it to -1 to clear the exclusive quota and restore the remaining quota of the shared account. In query responses, this parameter is omitted if it is not configured. An explicit value of 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pauseConcurrency")]
        [Validation(Required=false)]
        public int? PauseConcurrency { get; set; }

        /// <summary>
        /// <para>The team sandbox wake-up concurrency quota, in requests. This value represents the maximum number of sandbox wake-up requests that can be executed at the same time. When updating, omit this parameter or set it to null to retain the original configuration. Set it to a positive integer to specify an exclusive quota. Set it to 0 to prohibit sandbox wake-up. Set it to -1 to clear the exclusive quota and restore the remaining quota of the shared account. In query responses, this parameter is omitted if it is not configured. An explicit value of 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("resumeConcurrency")]
        [Validation(Required=false)]
        public int? ResumeConcurrency { get; set; }

        /// <summary>
        /// <para>The team CPU creation rate, in cores per minute. When updating, omit this parameter or set it to null to retain the original configuration. Set it to a positive integer to specify an exclusive rate. Set it to 0 to prohibit new CPU capacity. Set it to -1 to clear the exclusive rate and restore the remaining rate of the shared account. In query responses, this parameter is omitted if it is not configured. An explicit value of 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("scalingCpuCoresPerMinute")]
        [Validation(Required=false)]
        public long? ScalingCpuCoresPerMinute { get; set; }

        /// <summary>
        /// <para>The quota tag value, which represents the team ID. Quotas are independently calculated based on this dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7696f4cf-****</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
