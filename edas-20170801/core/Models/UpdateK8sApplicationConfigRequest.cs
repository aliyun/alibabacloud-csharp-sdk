// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sApplicationConfigRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public string CpuLimit { get; set; }

        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public string CpuRequest { get; set; }

        [NameInMap("McpuLimit")]
        [Validation(Required=false)]
        public string McpuLimit { get; set; }

        [NameInMap("McpuRequest")]
        [Validation(Required=false)]
        public string McpuRequest { get; set; }

        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        [NameInMap("MemoryRequest")]
        [Validation(Required=false)]
        public string MemoryRequest { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
