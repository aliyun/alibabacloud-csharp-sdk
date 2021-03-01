// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertClusterResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public InsertClusterResponseBodyCluster Cluster { get; set; }
        public class InsertClusterResponseBodyCluster : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public int? NetworkMode { get; set; }
            [NameInMap("IaasProvider")]
            [Validation(Required=false)]
            public string IaasProvider { get; set; }
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
