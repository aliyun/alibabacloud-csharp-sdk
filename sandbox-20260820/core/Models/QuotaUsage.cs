// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class QuotaUsage : TeaModel {
        /// <summary>
        /// <para>已占用的 CPU 配额，单位为 vCPU，不是 CPU 使用率。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpuCores")]
        [Validation(Required=false)]
        public double? CpuCores { get; set; }

        /// <summary>
        /// <para>尚未释放的实例授权数量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("instanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        /// <summary>
        /// <para>已占用的内存配额，单位为 GB，不是进程实际内存。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("memoryGB")]
        [Validation(Required=false)]
        public double? MemoryGB { get; set; }

    }

}
