// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeClustersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public DescribeClustersResponseBodyClusters Clusters { get; set; }
        public class DescribeClustersResponseBodyClusters : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<DescribeClustersResponseBodyClustersCluster> Cluster { get; set; }
            public class DescribeClustersResponseBodyClustersCluster : TeaModel {
                public string ClusterId { get; set; }
            }
        };

    }

}
