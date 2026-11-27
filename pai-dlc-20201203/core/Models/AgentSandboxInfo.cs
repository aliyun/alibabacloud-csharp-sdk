// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AgentSandboxInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("CPUCount")]
        [Validation(Required=false)]
        public long? CPUCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-10-30T06:00:00.500Z</para>
        /// </summary>
        [NameInMap("CollectedAt")]
        [Validation(Required=false)]
        public string CollectedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21474836480</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DiskTotal")]
        [Validation(Required=false)]
        public long? DiskTotal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4096</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MemoryMB")]
        [Validation(Required=false)]
        public long? MemoryMB { get; set; }

    }

}
