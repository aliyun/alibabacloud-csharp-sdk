// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class GPUConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("gpuMemorySize")]
        [Validation(Required=false)]
        public int? GpuMemorySize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fc.gpu.tesla.1</para>
        /// </summary>
        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

    }

}
