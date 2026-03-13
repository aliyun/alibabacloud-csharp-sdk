// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class GPUConfig : TeaModel {
        /// <summary>
        /// <para>The GPU memory size. Unit: MB. The value is a multiple of 1024 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("gpuMemorySize")]
        [Validation(Required=false)]
        public int? GpuMemorySize { get; set; }

        /// <summary>
        /// <para>The type of GPU cards. Valid values: fc.gpu.tesla.1: Tesla T4 fc.gpu.ampere.1: Ampere A10</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc.gpu.ampere.1</para>
        /// </summary>
        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

    }

}
