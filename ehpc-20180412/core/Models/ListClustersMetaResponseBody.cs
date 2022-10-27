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
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HasPlugin")]
                [Validation(Required=false)]
                public bool? HasPlugin { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsComputeEss")]
                [Validation(Required=false)]
                public bool? IsComputeEss { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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
