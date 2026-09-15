// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateRuntimeConfig : TeaModel {
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateLogConfig LogConfig { get; set; }

        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("sandboxConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateSandboxConfig SandboxConfig { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateVPCConfig VpcConfig { get; set; }

    }

}
