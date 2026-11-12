// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class QuotaUsage : TeaModel {
        /// <summary>
        /// <para>The consumed CPU quota in vCPUs, not the CPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuCores")]
        [Validation(Required=false)]
        public double? CpuCores { get; set; }

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
        /// <para>The consumed memory quota in GB, not the actual memory used by processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("memoryGB")]
        [Validation(Required=false)]
        public double? MemoryGB { get; set; }

    }

}
