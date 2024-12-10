// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupRequestResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("requestCPU")]
        [Validation(Required=false)]
        public int? RequestCPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("requestGPU")]
        [Validation(Required=false)]
        public int? RequestGPU { get; set; }

        [NameInMap("requestGPUInfos")]
        [Validation(Required=false)]
        public List<GPUInfo> RequestGPUInfos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("requestMemory")]
        [Validation(Required=false)]
        public int? RequestMemory { get; set; }

    }

}
