// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClustersResponseBody : TeaModel {
        /// <summary>
        /// The information about clusters.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeHubClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeHubClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// The information about the API server.
            /// </summary>
            [NameInMap("ApiServer")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersApiServer ApiServer { get; set; }
            public class DescribeHubClustersResponseBodyClustersApiServer : TeaModel {
                /// <summary>
                /// The elastic IP address (EIP) ID.
                /// </summary>
                [NameInMap("ApiServerEipId")]
                [Validation(Required=false)]
                public string ApiServerEipId { get; set; }

                /// <summary>
                /// Indicates whether the public endpoint is enabled for the API server. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("EnabledPublic")]
                [Validation(Required=false)]
                public bool? EnabledPublic { get; set; }

                /// <summary>
                /// The ID of the Server Load Balancer (SLB) instance that is associated with the cluster.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// The details of the cluster.
            /// </summary>
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersClusterInfo ClusterInfo { get; set; }
            public class DescribeHubClustersResponseBodyClustersClusterInfo : TeaModel {
                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The specifications of the cluster.
                /// 
                /// *   Only ack.pro.small may be returned.
                /// </summary>
                [NameInMap("ClusterSpec")]
                [Validation(Required=false)]
                public string ClusterSpec { get; set; }

                /// <summary>
                /// The time when the cluster was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The error message that is returned if the cluster failed to be created.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The cluster name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The configurations of the cluster.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupID")]
                [Validation(Required=false)]
                public string ResourceGroupID { get; set; }

                /// <summary>
                /// The state of the cluster. Valid values:
                /// 
                /// *   initial: The cluster is being initialized.
                /// *   failed: The cluster failed to be created.
                /// *   running: The cluster is running
                /// *   inactive: The cluster is not activated.
                /// *   deleting: The cluster is being deleted.
                /// *   delete_failed: The cluster failed to be deleted.
                /// *   deleted: The cluster is deleted.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeHubClustersResponseBodyClustersClusterInfoTags> Tags { get; set; }
                public class DescribeHubClustersResponseBodyClustersClusterInfoTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The time when the cluster was last modified.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The version of the cluster.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The deletion conditions of the cluster.
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeHubClustersResponseBodyClustersConditions> Conditions { get; set; }
            public class DescribeHubClustersResponseBodyClustersConditions : TeaModel {
                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The reason for the deletion condition.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The state of the cluster that the deletion condition indicates. Valid values:
                /// 
                /// *   True: The cluster cannot be deleted.
                /// *   False: The cluster can be deleted.
                /// *   Unknow: Whether the cluster can be deleted is unknown.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of deletion condition.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The endpoints of the cluster.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersEndpoints Endpoints { get; set; }
            public class DescribeHubClustersResponseBodyClustersEndpoints : TeaModel {
                /// <summary>
                /// The internal endpoint of the API server.
                /// </summary>
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                /// <summary>
                /// The public endpoint of the API server.
                /// </summary>
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

            }

            /// <summary>
            /// The logging configurations.
            /// </summary>
            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersLogConfig LogConfig { get; set; }
            public class DescribeHubClustersResponseBodyClustersLogConfig : TeaModel {
                /// <summary>
                /// Indicates whether the audit logging feature is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("EnableLog")]
                [Validation(Required=false)]
                public bool? EnableLog { get; set; }

                /// <summary>
                /// The name of the project in Simple Log Service.
                /// </summary>
                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                /// <summary>
                /// The number of days that logs are retained by Simple Log Service.
                /// </summary>
                [NameInMap("LogStoreTTL")]
                [Validation(Required=false)]
                public string LogStoreTTL { get; set; }

            }

            /// <summary>
            /// The configurations of Alibaba Cloud Service Mesh (ASM).
            /// </summary>
            [NameInMap("MeshConfig")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersMeshConfig MeshConfig { get; set; }
            public class DescribeHubClustersResponseBodyClustersMeshConfig : TeaModel {
                /// <summary>
                /// Indicates whether ASM is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("EnableMesh")]
                [Validation(Required=false)]
                public bool? EnableMesh { get; set; }

                /// <summary>
                /// The ASM instance ID.
                /// </summary>
                [NameInMap("MeshId")]
                [Validation(Required=false)]
                public string MeshId { get; set; }

            }

            /// <summary>
            /// The network configurations of the cluster.
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeHubClustersResponseBodyClustersNetwork Network { get; set; }
            public class DescribeHubClustersResponseBodyClustersNetwork : TeaModel {
                /// <summary>
                /// The domain name of the cluster.
                /// </summary>
                [NameInMap("ClusterDomain")]
                [Validation(Required=false)]
                public string ClusterDomain { get; set; }

                /// <summary>
                /// The security group IDs.
                /// </summary>
                [NameInMap("SecurityGroupIDs")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIDs { get; set; }

                /// <summary>
                /// The IDs of vSwitches to which the cluster belongs.
                /// </summary>
                [NameInMap("VSwitches")]
                [Validation(Required=false)]
                public List<string> VSwitches { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) to which the cluster belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
