// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class OpenAKSClusterMeshRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("EnableDiscoverySync")]
        [Validation(Required=false)]
        public bool? EnableDiscoverySync { get; set; }

        [NameInMap("EnableK8sSvcDiscovery")]
        [Validation(Required=false)]
        public bool? EnableK8sSvcDiscovery { get; set; }

        [NameInMap("Insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

        [NameInMap("Kubeconfig")]
        [Validation(Required=false)]
        public string Kubeconfig { get; set; }

        [NameInMap("RegistryMetaConfigJsonStr")]
        [Validation(Required=false)]
        public string RegistryMetaConfigJsonStr { get; set; }

        [NameInMap("UserAccessKey")]
        [Validation(Required=false)]
        public string UserAccessKey { get; set; }

        [NameInMap("UserAccessSecret")]
        [Validation(Required=false)]
        public string UserAccessSecret { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
