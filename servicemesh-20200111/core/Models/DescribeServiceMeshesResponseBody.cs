// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the ASM instances.
        /// </summary>
        [NameInMap("ServiceMeshes")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshesResponseBodyServiceMeshes> ServiceMeshes { get; set; }
        public class DescribeServiceMeshesResponseBodyServiceMeshes : TeaModel {
            /// <summary>
            /// The edition of the ASM instance. Valid values:
            /// 
            /// - `standard`: Standard Edition
            /// - `enterprise`: Enterprise Edition
            /// - `ultimate`: Ultimate Edition
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// The information about the clusters.
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

            /// <summary>
            /// All endpoints of the ASM instance.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesEndpoints : TeaModel {
                /// <summary>
                /// The endpoint that is used to access the API server from the internal network.
                /// </summary>
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                /// <summary>
                /// The endpoint that is used to access Istio Pilot from the internal network.
                /// </summary>
                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }

                /// <summary>
                /// The endpoint that is used to expose the API server to the Internet.
                /// </summary>
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

                /// <summary>
                /// The endpoint that is used to expose Istio Pilot to the Internet.
                /// </summary>
                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }

                /// <summary>
                /// The endpoint of the reverse tunnel.
                /// </summary>
                [NameInMap("ReverseTunnelEndpoint")]
                [Validation(Required=false)]
                public string ReverseTunnelEndpoint { get; set; }

            }

            /// <summary>
            /// The ID of the Alibaba Cloud service instance for which the ASM instance is created.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The Alibaba Cloud service for which the ASM instance is created. Valid values:
            /// 
            /// - `ackone`: The ASM instance is created for Alibaba Cloud Distributed Cloud Container Platform (ACK One).
            /// - An empty value indicates that the ASM instance is created by the user.
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The basic information about the ASM instance.
            /// </summary>
            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesServiceMeshInfo : TeaModel {
                /// <summary>
                /// The point in time when the ASM instance was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The error message that is returned when the call failed.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The name of the ASM instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The edition of the ASM instance before ASM is available for commercial use. Valid values:
                /// 
                /// *   `Pro`: Professional Edition
                /// *   `Default`: Standard Edition
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The ID of the region in which the ASM instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the ASM instance.
                /// </summary>
                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }

                /// <summary>
                /// The status of the ASM instance.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The point in time when the ASM instance was last modified.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The version number of the ASM instance.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The specifications of the ASM instance.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesSpec Spec { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesSpec : TeaModel {
                /// <summary>
                /// The information about load balancing.
                /// </summary>
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecLoadBalancer : TeaModel {
                    /// <summary>
                    /// The ID of the SLB instance that is used when the API server is exposed to the Internet.
                    /// </summary>
                    [NameInMap("ApiServerLoadbalancerId")]
                    [Validation(Required=false)]
                    public string ApiServerLoadbalancerId { get; set; }

                    /// <summary>
                    /// Indicates whether the API Server is exposed to the Internet. Valid values:
                    /// 
                    /// *   `true`: The API server is exposed to the Internet.
                    /// *   `false`: The API server is not exposed to the Internet.
                    /// </summary>
                    [NameInMap("ApiServerPublicEip")]
                    [Validation(Required=false)]
                    public bool? ApiServerPublicEip { get; set; }

                    /// <summary>
                    /// Indicates whether Istio Pilot is exposed to the Internet. Valid values:
                    /// 
                    /// *   `true`: Istio Pilot is exposed to the Internet.
                    /// *   `false`: Istio Pilot is not exposed to the Internet.
                    /// </summary>
                    [NameInMap("PilotPublicEip")]
                    [Validation(Required=false)]
                    public bool? PilotPublicEip { get; set; }

                    /// <summary>
                    /// The ID of the Server Load Balancer (SLB) instance that is used when Istio Pilot is exposed to the Internet.
                    /// </summary>
                    [NameInMap("PilotPublicLoadbalancerId")]
                    [Validation(Required=false)]
                    public string PilotPublicLoadbalancerId { get; set; }

                }

                /// <summary>
                /// The configurations of the ASM instance.
                /// </summary>
                [NameInMap("MeshConfig")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfig : TeaModel {
                    /// <summary>
                    /// Indicates whether the feature of routing traffic to the nearest instance is enabled. Valid values:
                    /// 
                    /// *   `true`: The feature is enabled.
                    /// *   `false`: The feature is disabled.
                    /// </summary>
                    [NameInMap("Mtls")]
                    [Validation(Required=false)]
                    public bool? Mtls { get; set; }

                    /// <summary>
                    /// The outbound traffic policy. Valid values:
                    /// 
                    /// *   `ALLOW_ANY`: Outbound traffic to an external service is allowed.
                    /// *   `REGISTRY_ONLY`: Outbound traffic is allowed to only external services that are defined in the service registry of the ASM instance.
                    /// </summary>
                    [NameInMap("OutboundTrafficPolicy")]
                    [Validation(Required=false)]
                    public string OutboundTrafficPolicy { get; set; }

                    /// <summary>
                    /// The configurations of the control plane.
                    /// </summary>
                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigPilot : TeaModel {
                        /// <summary>
                        /// Indicates whether the support for HTTP 1.0 is enabled. Valid values:
                        /// 
                        /// *   `true`: The support for HTTP 1.0 is enabled.
                        /// *   `false`: The support for HTTP 1.0 is disabled.
                        /// </summary>
                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }

                        /// <summary>
                        /// The sampling percentage of tracing.
                        /// </summary>
                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }

                    }

                    /// <summary>
                    /// The configurations of sidecar injection.
                    /// </summary>
                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjector : TeaModel {
                        /// <summary>
                        /// Indicates whether automatic sidecar injection is enabled by using annotations.
                        /// </summary>
                        [NameInMap("AutoInjectionPolicyEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoInjectionPolicyEnabled { get; set; }

                        /// <summary>
                        /// Indicates whether automatic sidecar injection is enabled for all namespaces. Valid values:
                        /// 
                        /// *   `true`: Automatic sidecar injection is enabled for all namespaces.
                        /// *   `false`: Automatic sidecar injection is disabled for all namespaces.
                        /// </summary>
                        [NameInMap("EnableNamespacesByDefault")]
                        [Validation(Required=false)]
                        public bool? EnableNamespacesByDefault { get; set; }

                        /// <summary>
                        /// The initial configurations of Container Network Interface (CNI).
                        /// </summary>
                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            /// <summary>
                            /// Indicates whether elevated privileges are required for the istio-init container when you perform traffic redirection for the istio-proxy container. Valid values:
                            /// 
                            /// *   `true`: Elevated privileges are required for the istio-init container.
                            /// *   `false`: Elevated privileges are not required for the istio-init container.
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// The namespace for which sidecar injection is disabled.
                            /// </summary>
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }

                        }

                    }

                    /// <summary>
                    /// Indicates whether mutual Transport Layer Security (mTLS) is strictly enforced.
                    /// </summary>
                    [NameInMap("StrictMtls")]
                    [Validation(Required=false)]
                    public bool? StrictMtls { get; set; }

                    /// <summary>
                    /// Indicates whether Prometheus monitoring is enabled. We recommend that you use Prometheus Service of Application Real-Time Monitoring Service (ARMS). Valid values:
                    /// 
                    /// *   `true`: Prometheus monitoring is enabled.
                    /// *   `false`: Prometheus monitoring is disabled.
                    /// </summary>
                    [NameInMap("Telemetry")]
                    [Validation(Required=false)]
                    public bool? Telemetry { get; set; }

                    /// <summary>
                    /// Indicates whether the tracing feature is enabled. This feature can be enabled only after Tracing Analysis is activated. Valid values:
                    /// 
                    /// *   `true`: The tracing feature is enabled.
                    /// *   `false`: The tracing feature is disabled.
                    /// </summary>
                    [NameInMap("Tracing")]
                    [Validation(Required=false)]
                    public bool? Tracing { get; set; }

                }

                /// <summary>
                /// The network configurations of the ASM instance.
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecNetwork Network { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecNetwork : TeaModel {
                    /// <summary>
                    /// The ID of the security group.
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// The IDs of vSwitches.
                    /// </summary>
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                    /// <summary>
                    /// The ID of the virtual private cloud (VPC).
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

        }

    }

}
