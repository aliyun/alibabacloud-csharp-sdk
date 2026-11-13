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
        /// <para>The set of allowed inbound source VPCs configured for Generation 2 templates. An omitted or empty array indicates that no inbound VPC bindings are configured, and this field can be omitted for historical records without configurations. This configuration is independent of the egress network vpcConfig. Subsequent template updates do not overwrite the bindings of functions used by existing sandboxes. When the feature switch is enabled, POST /init requests without query parameters to the standard E2B sandbox envd port 49983 are temporarily exempt from VPC source checks, while other authentication mechanisms remain in effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vpc-examplea&quot;,&quot;vpc-exampleb&quot;]</para>
        /// </summary>
        [NameInMap("vpcBindings")]
        [Validation(Required=false)]
        public List<string> VpcBindings { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) configuration of the sandbox instance.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public PublicTemplateVPCConfig VpcConfig { get; set; }

    }

}
