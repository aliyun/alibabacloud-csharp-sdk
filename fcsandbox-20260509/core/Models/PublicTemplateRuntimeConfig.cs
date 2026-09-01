// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicTemplateRuntimeConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public PublicTemplateLogConfig LogConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("sandboxConfig")]
        [Validation(Required=false)]
        public PublicTemplateSandboxConfig SandboxConfig { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public PublicTemplateVPCConfig VpcConfig { get; set; }

    }

}
