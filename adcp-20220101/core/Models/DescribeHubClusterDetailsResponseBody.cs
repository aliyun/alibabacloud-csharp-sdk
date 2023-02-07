// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterDetailsResponseBody : TeaModel {
        /// <summary>
        /// The details about the master instance.
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public DescribeHubClusterDetailsResponseBodyCluster Cluster { get; set; }
        public class DescribeHubClusterDetailsResponseBodyCluster : TeaModel {
            /// <summary>
            /// Information about the API server of the master instance.
            /// </summary>
            [NameInMap("ApiServer")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterApiServer ApiServer { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterApiServer : TeaModel {
                /// <summary>
                /// The ID of the elastic IP address (EIP).
                /// </summary>
                [NameInMap("ApiServerEipId")]
                [Validation(Required=false)]
                public string ApiServerEipId { get; set; }

                /// <summary>
                /// Indicates whether a public endpoint is used to expose the API server. Valid values: - true: a public endpoint is used to expose the API server. - false: no public endpoint is used to expose the API server.
                /// </summary>
                [NameInMap("EnabledPublic")]
                [Validation(Required=false)]
                public bool? EnabledPublic { get; set; }

                /// <summary>
                /// The ID of the Server Load Balancer (SLB) instance.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// The details about the master instance.
            /// </summary>
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterClusterInfo ClusterInfo { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterClusterInfo : TeaModel {
                /// <summary>
                /// The ID of the master instance.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The specification of the master instance. Valid values: - ack.pro.small: ACK Pro
                /// </summary>
                [NameInMap("ClusterSpec")]
                [Validation(Required=false)]
                public string ClusterSpec { get; set; }

                /// <summary>
                /// The time when the master instance was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The error message that is returned when the system fails to create the master instance.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The name of the master instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The configurations of the master instance.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The ID of the region in which the master instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of the master instance. Valid values: - initial: The master instance is being initialized. - failed: The master instance failed to be created. - running: The master instance is running. - inactive: The master instance is inactive. - deleting: The master instance is being deleted. - delete_failed: The master instance failed to be deleted. - deleted: The master instance is deleted.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The time when the master instance was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The Kubernetes version of the master instance.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The list of the deletion conditions of the master instance.
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeHubClusterDetailsResponseBodyClusterConditions> Conditions { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterConditions : TeaModel {
                /// <summary>
                /// The error message of the deletion condition.
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
                /// The status of the deletion condition. Valid values:
                /// - True: The master instance cannot be deleted.
                /// - False: The master instance can be deleted.
                /// - Unknow: Whether the master instance can be deleted is unknown.
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
            /// The endpoint of the master instance.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterEndpoints Endpoints { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterEndpoints : TeaModel {
                /// <summary>
                /// The internal endpoint of the API server of the master instance.
                /// </summary>
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                /// <summary>
                /// The public endpoint of the API server of the master instance.
                /// </summary>
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

            }

            /// <summary>
            /// The logging configuration.
            /// </summary>
            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterLogConfig LogConfig { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterLogConfig : TeaModel {
                /// <summary>
                /// Indicates whether audit logs are enabled. Valid values: - true: audit logs are enabled. - false: audit logs are disabled.
                /// </summary>
                [NameInMap("EnableLog")]
                [Validation(Required=false)]
                public bool? EnableLog { get; set; }

                /// <summary>
                /// The name of the Log Service project.
                /// </summary>
                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                /// <summary>
                /// The retention period of the logs.
                /// </summary>
                [NameInMap("LogStoreTTL")]
                [Validation(Required=false)]
                public string LogStoreTTL { get; set; }

            }

            /// <summary>
            /// The Service Mesh (ASM) configurations.
            /// </summary>
            [NameInMap("MeshConfig")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterMeshConfig MeshConfig { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterMeshConfig : TeaModel {
                /// <summary>
                /// Indicates whether ASM is enabled. Valid values: - true: ASM is enabled. - false: ASM is disabled.
                /// </summary>
                [NameInMap("EnableMesh")]
                [Validation(Required=false)]
                public bool? EnableMesh { get; set; }

                /// <summary>
                /// The ID of the ASM instance.
                /// </summary>
                [NameInMap("MeshId")]
                [Validation(Required=false)]
                public string MeshId { get; set; }

            }

            /// <summary>
            /// The network configurations of the master instance.
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterNetwork Network { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterNetwork : TeaModel {
                /// <summary>
                /// The domain name of the master instance.
                /// </summary>
                [NameInMap("ClusterDomain")]
                [Validation(Required=false)]
                public string ClusterDomain { get; set; }

                /// <summary>
                /// The IP version that is supported by the master instance. Valid values: - ipv4: IPv4. - ipv6: IPv6. - dual: IPv4 and IPv6.
                /// </summary>
                [NameInMap("IPStack")]
                [Validation(Required=false)]
                public string IPStack { get; set; }

                /// <summary>
                /// The ID of the associated security group.
                /// </summary>
                [NameInMap("SecurityGroupIDs")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIDs { get; set; }

                /// <summary>
                /// A list of the vSwitches that are used by the master instance.
                /// </summary>
                [NameInMap("VSwitches")]
                [Validation(Required=false)]
                public List<string> VSwitches { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) in which the master instance resides.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("WorkflowConfig")]
            [Validation(Required=false)]
            public DescribeHubClusterDetailsResponseBodyClusterWorkflowConfig WorkflowConfig { get; set; }
            public class DescribeHubClusterDetailsResponseBodyClusterWorkflowConfig : TeaModel {
                [NameInMap("ArgoServerEnabled")]
                [Validation(Required=false)]
                public bool? ArgoServerEnabled { get; set; }

                [NameInMap("PriceLimit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

                [NameInMap("WorkflowScheduleMode")]
                [Validation(Required=false)]
                public string WorkflowScheduleMode { get; set; }

                [NameInMap("WorkflowUnits")]
                [Validation(Required=false)]
                public List<DescribeHubClusterDetailsResponseBodyClusterWorkflowConfigWorkflowUnits> WorkflowUnits { get; set; }
                public class DescribeHubClusterDetailsResponseBodyClusterWorkflowConfigWorkflowUnits : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<DescribeHubClusterDetailsResponseBodyClusterWorkflowConfigWorkflowUnitsVSwitches> VSwitches { get; set; }
                    public class DescribeHubClusterDetailsResponseBodyClusterWorkflowConfigWorkflowUnitsVSwitches : TeaModel {
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

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
