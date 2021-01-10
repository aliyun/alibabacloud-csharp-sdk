// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCFederationSpannerClusterRequest : TeaModel {
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        [NameInMap("Disk")]
        [Validation(Required=false)]
        public string Disk { get; set; }

        [NameInMap("HostNetwork")]
        [Validation(Required=false)]
        public bool? HostNetwork { get; set; }

        [NameInMap("Mem")]
        [Validation(Required=false)]
        public string Mem { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("SubClustersConfig")]
        [Validation(Required=false)]
        public string SubClustersConfig { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
