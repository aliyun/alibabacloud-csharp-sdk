// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GPUDetail : TeaModel {
        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tesla-V100-32G</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The full name of the GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nvidia.com/gpu-tesla-v100-sxm2-16gb</para>
        /// </summary>
        [NameInMap("GPUTypeFullName")]
        [Validation(Required=false)]
        public string GPUTypeFullName { get; set; }

    }

}
