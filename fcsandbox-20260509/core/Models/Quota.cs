// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class Quota : TeaModel {
        /// <summary>
        /// <para>The vCPU quota limit. Unit: cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("cpuCores")]
        [Validation(Required=false)]
        public int? CpuCores { get; set; }

        /// <summary>
        /// <para>The memory quota limit. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("memoryGB")]
        [Validation(Required=false)]
        public int? MemoryGB { get; set; }

        /// <summary>
        /// <para>Team ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>f79d6a95-abcd-47a8-9167-eccf0622a998</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
