// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataRequest : TeaModel {
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

    }

}
