// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteAKSClusterMeshRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DisableK8sSvcDiscovery")]
        [Validation(Required=false)]
        public bool? DisableK8sSvcDiscovery { get; set; }

        [NameInMap("DisableRegistry")]
        [Validation(Required=false)]
        public bool? DisableRegistry { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
