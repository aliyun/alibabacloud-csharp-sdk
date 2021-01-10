// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsRcSyncBucketRequest : TeaModel {
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        [NameInMap("ClusterTaskUniqueKey")]
        [Validation(Required=false)]
        public string ClusterTaskUniqueKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SourceCluster")]
        [Validation(Required=false)]
        public string SourceCluster { get; set; }

        [NameInMap("TargetCluster")]
        [Validation(Required=false)]
        public string TargetCluster { get; set; }

        [NameInMap("TwoWaySync")]
        [Validation(Required=false)]
        public bool? TwoWaySync { get; set; }

    }

}
