// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The CPU specification of the sandboxed container instance, in cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The disk specification of the sandboxed container instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the sandboxed container instance is allowed to access the Internet.</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// <para>The log delivery configuration of the sandboxed container instance.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public CreateTemplateLogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory specification of the sandboxed container instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The image and startup configuration of the sandboxed container instance.</para>
        /// </summary>
        [NameInMap("sandboxConfig")]
        [Validation(Required=false)]
        public CreateTemplateSandboxConfig SandboxConfig { get; set; }

        /// <summary>
        /// <para>The VPC configuration of the sandboxed container instance.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public CreateTemplateVPCConfig VpcConfig { get; set; }

    }

}
