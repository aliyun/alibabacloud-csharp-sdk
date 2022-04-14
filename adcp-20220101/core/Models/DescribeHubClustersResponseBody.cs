// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeHubClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeHubClustersResponseBodyClusters : TeaModel {
            [NameInMap("ApiServer")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersApiServer ApiServer { get; set; }
            public class DescribeHubClustersResponseBodyClustersApiServer : TeaModel {
                [NameInMap("EnabledPublic")]
                [Validation(Required=false)]
                public bool? EnabledPublic { get; set; }
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }
            };

            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersClusterInfo ClusterInfo { get; set; }
            public class DescribeHubClustersResponseBodyClustersClusterInfo : TeaModel {
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
            };

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersEndpoints Endpoints { get; set; }
            public class DescribeHubClustersResponseBodyClustersEndpoints : TeaModel {
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }
            };

            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersNetwork Network { get; set; }
            public class DescribeHubClustersResponseBodyClustersNetwork : TeaModel {
                [NameInMap("ClusterDomain")]
                [Validation(Required=false)]
                public string ClusterDomain { get; set; }
                [NameInMap("SecurityGroupIDs")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIDs { get; set; }
                [NameInMap("VSwitches")]
                [Validation(Required=false)]
                public List<string> VSwitches { get; set; }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
            };

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
