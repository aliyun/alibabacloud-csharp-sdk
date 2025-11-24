// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the ASM instance.</para>
        /// </summary>
        [NameInMap("ServiceMeshes")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshesResponseBodyServiceMeshes> ServiceMeshes { get; set; }
        public class DescribeServiceMeshesResponseBodyServiceMeshes : TeaModel {
            /// <summary>
            /// <para>The edition of the ASM instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>standard</c>: Standard Edition</description></item>
            /// <item><description><c>enterprise</c>: Enterprise Edition</description></item>
            /// <item><description><c>ultimate</c>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <para>The clusters.</para>
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

            /// <summary>
            /// <para>The information about all endpoints of the ASM instance.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesEndpoints : TeaModel {
                /// <summary>
                /// <para>The endpoint that is used to access the API server over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://192.168.xx.xx:6443">https://192.168.xx.xx:6443</a></para>
                /// </summary>
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to access Istio Pilot from the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.xx.xx:15011</para>
                /// </summary>
                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to access the API server over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://123.56.xx.xx:6443">https://123.56.xx.xx:6443</a></para>
                /// </summary>
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

                /// <summary>
                /// <para>The public endpoint of the Pilot of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint of the reverse tunnel (Deprecated).</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("ReverseTunnelEndpoint")]
                [Validation(Required=false)]
                public string ReverseTunnelEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud service instance for which the ASM instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc3e96f249d124eb38b72718ec5*****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud service for which the ASM instance is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ackone</c>: The ASM instance is created for Alibaba Cloud Distributed Cloud Container Platform (ACK One).</description></item>
            /// <item><description>An empty value indicates that the ASM instance is created by the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ackone</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The basic information about the ASM instances.</para>
            /// </summary>
            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesServiceMeshInfo : TeaModel {
                /// <summary>
                /// <para>The time when the ASM instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-04-21T09:42:20+08:00</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The returned error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The name of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The edition of the ASM instance before ASM is available for commercial use. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Pro</c>: Professional Edition</description></item>
                /// <item><description><c>Default</c>: Standard Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pro</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The region ID of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cb8963379255149cb98c8686f274x****</para>
                /// </summary>
                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }

                /// <summary>
                /// <para>The state of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The time when the ASM instance was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-04-21T09:42:20+08:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The version number of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The specifications of the ASM instance.</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeServiceMeshesResponseBodyServiceMeshesSpec Spec { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesSpec : TeaModel {
                /// <summary>
                /// <para>The information about load balancing.</para>
                /// </summary>
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecLoadBalancer : TeaModel {
                    /// <summary>
                    /// <para>The ID of the CLB instance that is used when the API server is exposed to the Internet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-2zekaak10uxds44vx****</para>
                    /// </summary>
                    [NameInMap("ApiServerLoadbalancerId")]
                    [Validation(Required=false)]
                    public string ApiServerLoadbalancerId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the API server is exposed to the Internet. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ApiServerPublicEip")]
                    [Validation(Required=false)]
                    public bool? ApiServerPublicEip { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Istio Pilot is exposed to the Internet. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PilotPublicEip")]
                    [Validation(Required=false)]
                    public bool? PilotPublicEip { get; set; }

                    /// <summary>
                    /// <para>The ID of the Classic Load Balancer (CLB) instance that is used when Istio Pilot is exposed to the Internet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-2zesa8qs8kbkj9jkl****</para>
                    /// </summary>
                    [NameInMap("PilotPublicLoadbalancerId")]
                    [Validation(Required=false)]
                    public string PilotPublicLoadbalancerId { get; set; }

                }

                /// <summary>
                /// <para>The configurations of the ASM instance.</para>
                /// </summary>
                [NameInMap("MeshConfig")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfig : TeaModel {
                    /// <summary>
                    /// <para>The extended configurations of the ASM instance.</para>
                    /// </summary>
                    [NameInMap("ExtraConfiguration")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigExtraConfiguration ExtraConfiguration { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigExtraConfiguration : TeaModel {
                        /// <summary>
                        /// <para>The configurations of the ASM Playground (valid only for ASM Playground instances).</para>
                        /// </summary>
                        [NameInMap("Playground")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigExtraConfigurationPlayground Playground { get; set; }
                        public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigExtraConfigurationPlayground : TeaModel {
                            /// <summary>
                            /// <para>The ID of the ASM Playground scenario.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ewmaLb</para>
                            /// </summary>
                            [NameInMap("Scene")]
                            [Validation(Required=false)]
                            public string Scene { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>Indicates whether nearby access is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Mtls")]
                    [Validation(Required=false)]
                    public bool? Mtls { get; set; }

                    /// <summary>
                    /// <para>The outbound traffic policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>ALLOW_ANY</c>: Outbound traffic to an external service is allowed.</description></item>
                    /// <item><description><c>REGISTRY_ONLY</c>: Outbound traffic is allowed to only external services that are defined in the service registry of the ASM instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALLOW_ANY</para>
                    /// </summary>
                    [NameInMap("OutboundTrafficPolicy")]
                    [Validation(Required=false)]
                    public string OutboundTrafficPolicy { get; set; }

                    /// <summary>
                    /// <para>The configurations of the control plane.</para>
                    /// </summary>
                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigPilot : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the support for HTTP 1.0 is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }

                        /// <summary>
                        /// <para>The sampling rate when Managed Service for OpenTelemetry is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.2</para>
                        /// </summary>
                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of sidecar proxy injection.</para>
                    /// </summary>
                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjector : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether automatic sidecar proxy injection is enabled by using annotations.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("AutoInjectionPolicyEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoInjectionPolicyEnabled { get; set; }

                        /// <summary>
                        /// <para>Indicates whether automatic sidecar proxy injection is enabled for all namespaces. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("EnableNamespacesByDefault")]
                        [Validation(Required=false)]
                        public bool? EnableNamespacesByDefault { get; set; }

                        /// <summary>
                        /// <para>The initial configurations of Container Network Interface (CNI).</para>
                        /// </summary>
                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshesResponseBodyServiceMeshesSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether elevated privileges are required for the istio-init container when you perform traffic redirection for the istio-proxy container. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// <para>The namespaces in which the CNI plug-in does not check the pods.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>default,foo</para>
                            /// </summary>
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>Indicates whether mutual Transport Layer Security (mTLS) is strictly enforced.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("StrictMtls")]
                    [Validation(Required=false)]
                    public bool? StrictMtls { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Prometheus monitoring is enabled. We recommend that you use Managed Service for Prometheus. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Telemetry")]
                    [Validation(Required=false)]
                    public bool? Telemetry { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the tracing feature is enabled. This feature can be enabled only after Managed Service for OpenTelemetry is activated. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Tracing")]
                    [Validation(Required=false)]
                    public bool? Tracing { get; set; }

                }

                /// <summary>
                /// <para>The network configurations of the ASM instance.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshesResponseBodyServiceMeshesSpecNetwork Network { get; set; }
                public class DescribeServiceMeshesResponseBodyServiceMeshesSpecNetwork : TeaModel {
                    /// <summary>
                    /// <para>The ID of the security group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-2ze384sxttxbctnj****</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The IDs of the vSwitches.</para>
                    /// </summary>
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zew0rajjkmxy2369****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The details about the tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeServiceMeshesResponseBodyServiceMeshesTag> Tag { get; set; }
            public class DescribeServiceMeshesResponseBodyServiceMeshesTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yahaha</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the ASM instance can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Upgradable")]
            [Validation(Required=false)]
            public bool? Upgradable { get; set; }

        }

    }

}
