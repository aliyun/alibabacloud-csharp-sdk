// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class QuotaDetail : TeaModel {
        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// <para>The GPU details.</para>
        /// </summary>
        [NameInMap("GPUDetails")]
        [Validation(Required=false)]
        public List<GPUDetail> GPUDetails { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tesla-V100</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The full name of the GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nvidia.com/gpu</para>
        /// </summary>
        [NameInMap("GPUTypeFullName")]
        [Validation(Required=false)]
        public string GPUTypeFullName { get; set; }

        /// <summary>
        /// <para>The memory capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10Gi</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
