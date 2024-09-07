// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateNodesShrinkRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ComputeNode")]
        [Validation(Required=false)]
        public string ComputeNodeShrink { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("HPCInterConnect")]
        [Validation(Required=false)]
        public string HPCInterConnect { get; set; }

        [NameInMap("HostnamePrefix")]
        [Validation(Required=false)]
        public string HostnamePrefix { get; set; }

        [NameInMap("HostnameSuffix")]
        [Validation(Required=false)]
        public string HostnameSuffix { get; set; }

        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public string KeepAlive { get; set; }

        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
