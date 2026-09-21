// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class Quota : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("cpuCores")]
        [Validation(Required=false)]
        public int? CpuCores { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("instanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("memoryGB")]
        [Validation(Required=false)]
        public int? MemoryGB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7696f4cf-****</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
