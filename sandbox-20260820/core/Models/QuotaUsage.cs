// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class QuotaUsage : TeaModel {
        /// <summary>
        /// <para>The consumed CPU quota in vCPUs, which is not the CPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuCores")]
        [Validation(Required=false)]
        public double? CpuCores { get; set; }

        /// <summary>
        /// <para>The number of unreleased concurrency authorizations for snapshot-based sandbox creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("createSandboxWithSnapshotConcurrency")]
        [Validation(Required=false)]
        public int? CreateSandboxWithSnapshotConcurrency { get; set; }

        /// <summary>
        /// <para>The number of unreleased concurrency authorizations for snapshot creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("createSnapshotConcurrency")]
        [Validation(Required=false)]
        public int? CreateSnapshotConcurrency { get; set; }

        /// <summary>
        /// <para>The number of unreleased instance authorizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("instanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        /// <summary>
        /// <para>The consumed memory quota in GB, which is not the actual memory used by processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("memoryGB")]
        [Validation(Required=false)]
        public double? MemoryGB { get; set; }

        /// <summary>
        /// <para>The number of unreleased concurrency authorizations for sandbox hibernation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pauseConcurrency")]
        [Validation(Required=false)]
        public int? PauseConcurrency { get; set; }

        /// <summary>
        /// <para>The number of unreleased concurrency authorizations for resuming sandboxes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("resumeConcurrency")]
        [Validation(Required=false)]
        public int? ResumeConcurrency { get; set; }

        /// <summary>
        /// <para>The number of cores consumed from the exclusive CPU creation quota of the team that have not yet been naturally replenished. This is not the cumulative creation volume over the last minute. This field is omitted when no valid exclusive bucket snapshot is available. Actual zeros and decimals are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.875</para>
        /// </summary>
        [NameInMap("scalingCpuCoresPerMinute")]
        [Validation(Required=false)]
        public double? ScalingCpuCoresPerMinute { get; set; }

    }

}
