// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class AddResourceSnapshotRequest : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("clusterUID")]
        [Validation(Required=false)]
        public string ClusterUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
