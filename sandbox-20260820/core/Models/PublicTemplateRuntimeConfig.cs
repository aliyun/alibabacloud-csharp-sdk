// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The CPU specification of the sandbox instance, in cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The disk specification of the sandbox instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the sandbox instance is allowed to access the Internet.</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// <para>The log delivery configuration of the sandbox instance.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public PublicTemplateLogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory specification of the sandbox instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The image and startup configuration of the sandbox instance.</para>
        /// </summary>
        [NameInMap("sandboxConfig")]
        [Validation(Required=false)]
        public PublicTemplateSandboxConfig SandboxConfig { get; set; }

        /// <summary>
        /// <para>The VPC configuration of the sandbox instance.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public PublicTemplateVPCConfig VpcConfig { get; set; }

    }

}
