// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterDetailsResponseBody : TeaModel {
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public DescribeHubClusterDetailsResponseBodyCluster Cluster { get; set; }
        public class DescribeHubClusterDetailsResponseBodyCluster : TeaModel {
            [NameInMap("ApiServer")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterApiServer ApiServer { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterApiServer : TeaModel {
                [NameInMap("ApiServerEipId")]
                [Validation(Required=false)]
                public string ApiServerEipId { get; set; }

                [NameInMap("EnabledPublic")]
                [Validation(Required=false)]
                public bool? EnabledPublic { get; set; }

                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterClusterInfo ClusterInfo { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterClusterInfo : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterSpec")]
                [Validation(Required=false)]
                public string ClusterSpec { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeHubClusterDetailsResponseBodyClusterConditions> Conditions { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterConditions : TeaModel {
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterEndpoints Endpoints { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterEndpoints : TeaModel {
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

            }

            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterLogConfig LogConfig { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterLogConfig : TeaModel {
                [NameInMap("EnableLog")]
                [Validation(Required=false)]
                public bool? EnableLog { get; set; }

                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                [NameInMap("LogStoreTTL")]
                [Validation(Required=false)]
                public string LogStoreTTL { get; set; }

            }

            [NameInMap("MeshConfig")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterMeshConfig MeshConfig { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterMeshConfig : TeaModel {
                [NameInMap("EnableMesh")]
                [Validation(Required=false)]
                public bool? EnableMesh { get; set; }

                [NameInMap("MeshId")]
                [Validation(Required=false)]
                public string MeshId { get; set; }

            }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterNetwork Network { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterNetwork : TeaModel {
                [NameInMap("ClusterDomain")]
                [Validation(Required=false)]
                public string ClusterDomain { get; set; }

                [NameInMap("IPStack")]
                [Validation(Required=false)]
                public string IPStack { get; set; }

                [NameInMap("SecurityGroupIDs")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIDs { get; set; }

                [NameInMap("VSwitches")]
                [Validation(Required=false)]
                public List<string> VSwitches { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
