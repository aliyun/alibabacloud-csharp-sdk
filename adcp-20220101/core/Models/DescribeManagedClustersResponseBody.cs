// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeManagedClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeManagedClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeManagedClustersResponseBodyClusters : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public DescribeManagedClustersResponseBodyClustersCluster Cluster { get; set; }
            public class DescribeManagedClustersResponseBodyClustersCluster : TeaModel {
                [NameInMap("ClusterID")]
                [Validation(Required=false)]
                public string ClusterID { get; set; }

                [NameInMap("ClusterSpec")]
                [Validation(Required=false)]
                public string ClusterSpec { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("Created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                [NameInMap("InitVersion")]
                [Validation(Required=false)]
                public string InitVersion { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

                [NameInMap("VSwitchID")]
                [Validation(Required=false)]
                public string VSwitchID { get; set; }

                [NameInMap("VpcID")]
                [Validation(Required=false)]
                public string VpcID { get; set; }

            }

            [NameInMap("MeshStatus")]
            [Validation(Required=false)]
            public DescribeManagedClustersResponseBodyClustersMeshStatus MeshStatus { get; set; }
            public class DescribeManagedClustersResponseBodyClustersMeshStatus : TeaModel {
                [NameInMap("InMesh")]
                [Validation(Required=false)]
                public bool? InMesh { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeManagedClustersResponseBodyClustersStatus Status { get; set; }
            public class DescribeManagedClustersResponseBodyClustersStatus : TeaModel {
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
