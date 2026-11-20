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
        /// <para>The concurrent quota for creating sandboxes from snapshots in a team. This indicates the maximum number of requests for creating sandboxes from snapshots that can be executed at the same time. Omit or pass null to retain the original configuration during updates. A positive integer sets an exclusive quota. 0 prohibits creating sandboxes from snapshots. -1 clears the exclusive quota and restores the remaining quota of the shared account. During queries, this field is omitted if not configured, an explicit 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("createSessionWithSnapshotConcurrency")]
        [Validation(Required=false)]
        public int? CreateSessionWithSnapshotConcurrency { get; set; }

        /// <summary>
        /// <para>The concurrent quota for creating snapshots in a team. This indicates the maximum number of snapshot creation requests that can be executed at the same time. Omit or pass null to retain the original configuration during updates. A positive integer sets an exclusive quota. 0 prohibits creating snapshots. -1 clears the exclusive quota and restores the remaining quota of the shared account. During queries, this field is omitted if not configured, an explicit 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("createSnapshotConcurrency")]
        [Validation(Required=false)]
        public int? CreateSnapshotConcurrency { get; set; }

        /// <summary>
        /// <para>The quota for the number of running instances.</para>
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
        /// <para>The concurrent quota for sandbox hibernation in a team. This indicates the maximum number of sandbox hibernation requests that can be executed at the same time. Omit or pass null to retain the original configuration during updates. A positive integer sets an exclusive quota. 0 prohibits sandbox hibernation. -1 clears the exclusive quota and restores the remaining quota of the shared account. During queries, this field is omitted if not configured, an explicit 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pauseConcurrency")]
        [Validation(Required=false)]
        public int? PauseConcurrency { get; set; }

        /// <summary>
        /// <para>The concurrent quota for resuming sandboxes in a team. This indicates the maximum number of sandbox resumption requests that can be executed at the same time. Omit or pass null to retain the original configuration during updates. A positive integer sets an exclusive quota. 0 prohibits resuming sandboxes. -1 clears the exclusive quota and restores the remaining quota of the shared account. During queries, this field is omitted if not configured, an explicit 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("resumeConcurrency")]
        [Validation(Required=false)]
        public int? ResumeConcurrency { get; set; }

        /// <summary>
        /// <para>The Team CPU creation rate, in cores per minute. Omit or pass null to retain the original configuration during updates. A positive integer sets an exclusive rate. 0 prohibits adding new CPU capacity. -1 clears the exclusive rate and restores the remaining rate of the shared account. During queries, this field is omitted if not configured, an explicit 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("scalingCpuCoresPerMinute")]
        [Validation(Required=false)]
        public long? ScalingCpuCoresPerMinute { get; set; }

        /// <summary>
        /// <para>The quota tag value. This value is the team ID, and quotas are calculated independently based on this dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7696f4cf-****</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
