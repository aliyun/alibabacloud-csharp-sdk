// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DetachClusterFromHubRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

        [NameInMap("DetachFromMesh")]
        [Validation(Required=false)]
        public bool? DetachFromMesh { get; set; }

    }

}
