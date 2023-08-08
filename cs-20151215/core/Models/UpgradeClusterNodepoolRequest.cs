// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterNodepoolRequest : TeaModel {
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        [NameInMap("runtime_type")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        [NameInMap("runtime_version")]
        [Validation(Required=false)]
        public string RuntimeVersion { get; set; }

    }

}
