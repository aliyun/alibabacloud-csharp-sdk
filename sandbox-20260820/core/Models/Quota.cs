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
        /// <para>The quota for the number of active instances.</para>
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
        /// <para>The team CPU creation rate in cores per minute. To retain the original configuration during an update, omit this parameter or set it to null. A positive integer sets an exclusive rate. A value of 0 prevents adding new CPU capacity. A value of -1 clears the exclusive rate and restores the remaining shared account rate. When queried, this parameter is omitted if it is not configured, an explicit 0 is retained, and -1 is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("scalingCpuCoresPerMinute")]
        [Validation(Required=false)]
        public long? ScalingCpuCoresPerMinute { get; set; }

        /// <summary>
        /// <para>The quota tag value, which is set to the team ID. Quotas are independently calculated based on this dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7696f4cf-****</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
