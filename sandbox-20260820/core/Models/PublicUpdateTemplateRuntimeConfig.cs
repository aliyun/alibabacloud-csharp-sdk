// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The number of vCPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The system cloud disk size in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the sandbox is allowed to access the Internet.</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// <para>The log configuration.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateLogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory size in MB.</para>
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
        public PublicUpdateTemplateSandboxConfig SandboxConfig { get; set; }

        /// <summary>
        /// <para>If omitted or set to null, the original list is retained. A non-empty array replaces the entire allowed set. An explicit empty array [] clears the inbound VPC restrictions for the new version. This field is independent of vpcConfig. An empty request body {}, an empty runtimeConfig, or a runtimeConfig that contains only vpcBindings: null returns a 400 error and does not clear the bindings. The actual JSON received by the server prevails. An empty array omitted by the SDK cannot clear the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vpc-examplea&quot;,&quot;vpc-exampleb&quot;]</para>
        /// </summary>
        [NameInMap("vpcBindings")]
        [Validation(Required=false)]
        public List<string> VpcBindings { get; set; }

        /// <summary>
        /// <para>The VPC network configuration.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateVPCConfig VpcConfig { get; set; }

    }

}
