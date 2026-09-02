// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicTemplateRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The disk size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow access to the Internet.</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// <para>The log configuration.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public PublicTemplateLogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The sandbox configuration.</para>
        /// </summary>
        [NameInMap("sandboxConfig")]
        [Validation(Required=false)]
        public PublicTemplateSandboxConfig SandboxConfig { get; set; }

        /// <summary>
        /// <para>The VPC configuration.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public PublicTemplateVPCConfig VpcConfig { get; set; }

    }

}
