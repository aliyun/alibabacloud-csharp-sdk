// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersMetaResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersMetaResponseBodyClusters Clusters { get; set; }
        public class ListClustersMetaResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfoSimple")]
            [Validation(Required=false)]
            public List<ListClustersMetaResponseBodyClustersClusterInfoSimple> ClusterInfoSimple { get; set; }
            public class ListClustersMetaResponseBodyClustersClusterInfoSimple : TeaModel {
                public string AccountType { get; set; }
                public string ClientVersion { get; set; }
                public string DeployMode { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
                public bool? IsComputeEss { get; set; }
                public string Location { get; set; }
                public string Name { get; set; }
                public string OsTag { get; set; }
                public string SchedulerType { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
