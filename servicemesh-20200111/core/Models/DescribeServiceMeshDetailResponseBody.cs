// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11fd0027-c27e-41bb-a565-75583054****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the ASM instance.</para>
        /// </summary>
        [NameInMap("ServiceMesh")]
        [Validation(Required=false)]
        public DescribeServiceMeshDetailResponseBodyServiceMesh ServiceMesh { get; set; }
        public class DescribeServiceMeshDetailResponseBodyServiceMesh : TeaModel {
            /// <summary>
            /// <para>The specification of the ASM instance. Valid values:</para>
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
            /// <para>The endpoints of the ASM instance.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints : TeaModel {
                /// <summary>
                /// <para>The endpoint that is used to access the API server from the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<c>192.168.**.**</c>:6443</para>
                /// </summary>
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to access Istio Pilot from the internal network (Intranet) during canary release.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>192.168.**.**</c>:15011</para>
                /// </summary>
                [NameInMap("IntranetCanaryPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetCanaryPilotEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to access Istio Pilot from the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>192.168.**.**</c>:15011</para>
                /// </summary>
                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to access the API server over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<c>123.56.**.**</c>:6443</para>
                /// </summary>
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to expose Istio Pilot to the public network (Internet) during canary release.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>182.92.**.**</c>:15011</para>
                /// </summary>
                [NameInMap("PublicCanaryPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicCanaryPilotEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to expose Istio Pilot to the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>182.92.**.**</c>:15011</para>
                /// </summary>
                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }

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
            /// <para>The basic information about the ASM instance.</para>
            /// </summary>
            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo : TeaModel {
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
                /// <para>mesh1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The edition of the ASM instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Default</c>: Standard Edition</description></item>
                /// <item><description><c>Pro</c>: Enterprise Edition and Ultimate Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the ASM instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ASM instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
                /// </summary>
                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }

                /// <summary>
                /// <para>The state of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The time when the ASM instance was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-03T14:48:54+08:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The version of the ASM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.7.4.0-gfb34ba99-aliyun</para>
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
            public DescribeServiceMeshDetailResponseBodyServiceMeshSpec Spec { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpec : TeaModel {
                /// <summary>
                /// <para>The information about the load balancer.</para>
                /// </summary>
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer : TeaModel {
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
                    /// <para>The ID of the endpoint that is used to expose API server to the Internet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-wz9gtwau6b2aklgjk****</para>
                    /// </summary>
                    [NameInMap("ApiServerPublicEipId")]
                    [Validation(Required=false)]
                    public string ApiServerPublicEipId { get; set; }

                    /// <summary>
                    /// <para>The ID of the Classic Load Balancer (CLB) instance that is used during the canary release of Istio Pilot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-2zesa8qs8kbkj9jkl****</para>
                    /// </summary>
                    [NameInMap("CanaryPilotLoadBalancerId")]
                    [Validation(Required=false)]
                    public string CanaryPilotLoadBalancerId { get; set; }

                    /// <summary>
                    /// <para>The ID of the endpoint that is used to expose Istio Pilot to the Internet during canary release.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-wz9gtwau6b2aklgjk****</para>
                    /// </summary>
                    [NameInMap("CanaryPilotPublicEipId")]
                    [Validation(Required=false)]
                    public string CanaryPilotPublicEipId { get; set; }

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
                    /// <para>The ID of the endpoint that is used to expose Istio Pilot to the Internet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-wz9gtwau6b2aklgjk****</para>
                    /// </summary>
                    [NameInMap("PilotPublicEipId")]
                    [Validation(Required=false)]
                    public string PilotPublicEipId { get; set; }

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
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig : TeaModel {
                    /// <summary>
                    /// <para>The configurations of access log collection.</para>
                    /// </summary>
                    [NameInMap("AccessLog")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAccessLog AccessLog { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAccessLog : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether access log collection is enabled. Valid values:</para>
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
                        /// <para>The name of the Simple Log Service project that stores access logs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k8s-log-b7b05d08670e41ca8c8fc0b7718f*****</para>
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about mesh audit.</para>
                    /// </summary>
                    [NameInMap("Audit")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit Audit { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether an audit project exists in the ASM instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>audit_project_exist</c>: An audit project exists.</description></item>
                        /// <item><description><c>audit_project_not_exist</c>: No audit project exists.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>audit_project_not_exist</para>
                        /// </summary>
                        [NameInMap("AuditProjectStatus")]
                        [Validation(Required=false)]
                        public string AuditProjectStatus { get; set; }

                        /// <summary>
                        /// <para>Indicates whether mesh audit is enabled. Valid values:</para>
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
                        /// <para>The name of the Simple Log Service project that is used for mesh audit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>audit-project</para>
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of control-plane log collection.</para>
                    /// </summary>
                    [NameInMap("ControlPlaneLogInfo")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigControlPlaneLogInfo ControlPlaneLogInfo { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigControlPlaneLogInfo : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the collection of control plane logs is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The time to live (TTL) of the collected control-plane logs. Unit: day.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("LogTTL")]
                        [Validation(Required=false)]
                        public int? LogTTL { get; set; }

                        /// <summary>
                        /// <para>The name of the Simple Log Service project that stores control plane logs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mesh-log-cbeb85a09161b4a26ab73e0ac****</para>
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether a custom Zipkin system is used. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CustomizedZipkin")]
                    [Validation(Required=false)]
                    public bool? CustomizedZipkin { get; set; }

                    /// <summary>
                    /// <para>The information about the edition.</para>
                    /// </summary>
                    [NameInMap("Edition")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigEdition Edition { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigEdition : TeaModel {
                        /// <summary>
                        /// <para>The version of the Istiod image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.9.7.1-3-gb3f1ab3c9c-pro-aliyun</para>
                        /// </summary>
                        [NameInMap("IstiodImageTag")]
                        [Validation(Required=false)]
                        public string IstiodImageTag { get; set; }

                        /// <summary>
                        /// <para>The name of the edition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pro</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The version of the Istio Proxy image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.9.7.1-3-gb3f1ab3c9c-pro-aliyun</para>
                        /// </summary>
                        [NameInMap("ProxyImageTag")]
                        [Validation(Required=false)]
                        public string ProxyImageTag { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the feature that routes traffic to the nearest instance is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableLocalityLB")]
                    [Validation(Required=false)]
                    public bool? EnableLocalityLB { get; set; }

                    /// <summary>
                    /// <para>The IP ranges in CIDR form to be excluded from redirection to sidecar proxies in the ASM instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.0.0</para>
                    /// </summary>
                    [NameInMap("ExcludeIPRanges")]
                    [Validation(Required=false)]
                    public string ExcludeIPRanges { get; set; }

                    /// <summary>
                    /// <para>The inbound ports to be excluded from redirection to sidecar proxies in the ASM instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80,81</para>
                    /// </summary>
                    [NameInMap("ExcludeInboundPorts")]
                    [Validation(Required=false)]
                    public string ExcludeInboundPorts { get; set; }

                    /// <summary>
                    /// <para>The outbound ports to be excluded from redirection to sidecar proxies in the ASM instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80,81</para>
                    /// </summary>
                    [NameInMap("ExcludeOutboundPorts")]
                    [Validation(Required=false)]
                    public string ExcludeOutboundPorts { get; set; }

                    /// <summary>
                    /// <para>The configurations of additional features for the ASM instance.</para>
                    /// </summary>
                    [NameInMap("ExtraConfiguration")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfiguration ExtraConfiguration { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfiguration : TeaModel {
                        /// <summary>
                        /// <para>The configurations of additional features for access log collection.</para>
                        /// </summary>
                        [NameInMap("AccessLogExtraConf")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAccessLogExtraConf AccessLogExtraConf { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAccessLogExtraConf : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether gateway log collection is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("GatewayEnabled")]
                            [Validation(Required=false)]
                            public bool? GatewayEnabled { get; set; }

                            /// <summary>
                            /// <para>The retention period for the access logs of the ingress gateway. Unit: day. The logs are collected by using Simple Log Service. For example, the value 30 indicates that the logs are retained for 30 days.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("GatewayLifecycle")]
                            [Validation(Required=false)]
                            public int? GatewayLifecycle { get; set; }

                            /// <summary>
                            /// <para>Indicates whether sidecar log collection is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("SidecarEnabled")]
                            [Validation(Required=false)]
                            public bool? SidecarEnabled { get; set; }

                            /// <summary>
                            /// <para>The retention period for the access logs of sidecar proxies. Unit: day. The logs are collected by using Simple Log Service. For example, the value 30 indicates that the logs are retained for 30 days.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("SidecarLifecycle")]
                            [Validation(Required=false)]
                            public int? SidecarLifecycle { get; set; }

                        }

                        /// <summary>
                        /// <para>The configurations of adaptive xDS optimization.</para>
                        /// </summary>
                        [NameInMap("AdaptiveXdsConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfiguration AdaptiveXdsConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfiguration : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether Horizontal Pod Autoscaling (HPA) is enabled for the egress gateway.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("EgressAutoscaleEnabled")]
                            [Validation(Required=false)]
                            public bool? EgressAutoscaleEnabled { get; set; }

                            /// <summary>
                            /// <para>The CPU resource configurations of the egress gateway when HPA is enabled.</para>
                            /// </summary>
                            [NameInMap("EgressHpaCpu")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaCpu EgressHpaCpu { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaCpu : TeaModel {
                                /// <summary>
                                /// <para>The expected CPU utilization when HPA is enabled. Valid values: 1 to 100. If the CPU utilization exceeds this value, the number of pod replicas increases. If the CPU utilization is less than this value, the number of pod replicas decreases.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>80</para>
                                /// </summary>
                                [NameInMap("TargetAverageUtilization")]
                                [Validation(Required=false)]
                                public int? TargetAverageUtilization { get; set; }

                            }

                            /// <summary>
                            /// <para>The memory resource configurations of the egress gateway when HPA is enabled.</para>
                            /// </summary>
                            [NameInMap("EgressHpaMemory")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaMemory EgressHpaMemory { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaMemory : TeaModel {
                                /// <summary>
                                /// <para>The expected memory usage when HPA is enabled. Valid values: 1 to 100. If the memory usage exceeds this value, the number of pod replicas increases. If the memory usage is less than this value, the number of pod replicas decreases.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>80</para>
                                /// </summary>
                                [NameInMap("TargetAverageUtilization")]
                                [Validation(Required=false)]
                                public int? TargetAverageUtilization { get; set; }

                            }

                            /// <summary>
                            /// <para>The maximum number of egress gateway pod replicas when HPA is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("EgressMaxReplica")]
                            [Validation(Required=false)]
                            public int? EgressMaxReplica { get; set; }

                            /// <summary>
                            /// <para>The minimum number of egress gateway pod replicas when HPA is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("EgressMinReplica")]
                            [Validation(Required=false)]
                            public int? EgressMinReplica { get; set; }

                            /// <summary>
                            /// <para>The number of the egress gateway pod replicas.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("EgressReplicaCount")]
                            [Validation(Required=false)]
                            public int? EgressReplicaCount { get; set; }

                            /// <summary>
                            /// <para>The resource configurations of the egress gateway that is used by adaptive xDS optimization.</para>
                            /// </summary>
                            [NameInMap("EgressResources")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressResources EgressResources { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressResources : TeaModel {
                                /// <summary>
                                /// <para>The resources that are available to the egress gateway.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{&quot;cpu&quot;:&quot;200m&quot;, &quot;memory&quot;: &quot;512Mi&quot;}</para>
                                /// </summary>
                                [NameInMap("Limits")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> Limits { get; set; }

                                /// <summary>
                                /// <para>The resources that are requested by the egress gateway.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{&quot;cpu&quot;:&quot;100m&quot;, &quot;memory&quot;: &quot;256Mi&quot;}</para>
                                /// </summary>
                                [NameInMap("Requests")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> Requests { get; set; }

                            }

                            /// <summary>
                            /// <para>Indicates whether adaptive xDS optimization is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                        }

                        /// <summary>
                        /// <para>The configurations of automatic diagnostics for the ASM instance.</para>
                        /// </summary>
                        [NameInMap("AutoDiagnosis")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAutoDiagnosis AutoDiagnosis { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAutoDiagnosis : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether automatic diagnostics is enabled for the ASM instance. If you enable this feature, the ASM instance is automatically diagnosed 5 minutes after you modify an Istio resource.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("AutoDiagnosisEnabled")]
                            [Validation(Required=false)]
                            public bool? AutoDiagnosisEnabled { get; set; }

                        }

                        /// <summary>
                        /// <para>Access to Istio resources by using the Kubernetes API on the data plane.</para>
                        /// </summary>
                        [NameInMap("CRAggregationConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationCRAggregationConfiguration CRAggregationConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationCRAggregationConfiguration : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether Istio resources can be accessed by using the Kubernetes API on the data plane.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the Kubernetes API of clusters on the data plane can be used to access Istio resources. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("CRAggregationEnabled")]
                        [Validation(Required=false)]
                        public bool? CRAggregationEnabled { get; set; }

                        /// <summary>
                        /// <para>The label selectors used to specify the namespaces of the clusters on the data plane. The control plane discovers and processes only application services in the specified namespaces.</para>
                        /// </summary>
                        [NameInMap("DiscoverySelectors")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, object>> DiscoverySelectors { get; set; }

                        /// <summary>
                        /// <para>The configurations of the rollback feature for Istio resources.</para>
                        /// </summary>
                        [NameInMap("IstioCRHistory")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstioCRHistory IstioCRHistory { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstioCRHistory : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the rollback feature for Istio resources is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("EnableHistory")]
                            [Validation(Required=false)]
                            public bool? EnableHistory { get; set; }

                        }

                        /// <summary>
                        /// <para>Additional configurations for Istiod.</para>
                        /// </summary>
                        [NameInMap("IstiodExtraConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstiodExtraConfiguration IstiodExtraConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstiodExtraConfiguration : TeaModel {
                            /// <summary>
                            /// <para>The labels for isolated workloads.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>name=xx,region=xx</para>
                            /// </summary>
                            [NameInMap("LabelsForOffloadedWorkloads")]
                            [Validation(Required=false)]
                            public string LabelsForOffloadedWorkloads { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("PilotEnableQuicListeners")]
                            [Validation(Required=false)]
                            public bool? PilotEnableQuicListeners { get; set; }

                        }

                        /// <summary>
                        /// <para>The lifecycle of Istio Proxy.</para>
                        /// </summary>
                        [NameInMap("Lifecycle")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecycle Lifecycle { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecycle : TeaModel {
                            /// <summary>
                            /// <para>The post-start parameters.</para>
                            /// </summary>
                            [NameInMap("postStart")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStart PostStart { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStart : TeaModel {
                                /// <summary>
                                /// <para>The post-start script.</para>
                                /// </summary>
                                [NameInMap("exec")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartExec Exec { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartExec : TeaModel {
                                    /// <summary>
                                    /// <para>The executed commands. The value is a string that consists of JSON arrays.</para>
                                    /// </summary>
                                    [NameInMap("command")]
                                    [Validation(Required=false)]
                                    public List<string> Command { get; set; }

                                }

                                /// <summary>
                                /// <para>The HTTP GET request that is sent before the instance stops.</para>
                                /// </summary>
                                [NameInMap("httpGet")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGet HttpGet { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGet : TeaModel {
                                    /// <summary>
                                    /// <para>The URL of the request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>127.xx.xx.1</para>
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// <para>The HTTP request headers.</para>
                                    /// </summary>
                                    [NameInMap("httpHeaders")]
                                    [Validation(Required=false)]
                                    public List<DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGetHttpHeaders> HttpHeaders { get; set; }
                                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGetHttpHeaders : TeaModel {
                                        /// <summary>
                                        /// <para>The name of the HTTP request header.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>key</para>
                                        /// </summary>
                                        [NameInMap("name")]
                                        [Validation(Required=false)]
                                        public string Name { get; set; }

                                        /// <summary>
                                        /// <para>The value of the HTTP request header.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>value</para>
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The port number of the request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>80</para>
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                    /// <summary>
                                    /// <para>The request method. Valid values: <c>http</c> and <c>https</c>.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>http</para>
                                    /// </summary>
                                    [NameInMap("scheme")]
                                    [Validation(Required=false)]
                                    public string Scheme { get; set; }

                                }

                                /// <summary>
                                /// <para>The TCP socket request that is sent.</para>
                                /// </summary>
                                [NameInMap("tcpSocket")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartTcpSocket TcpSocket { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartTcpSocket : TeaModel {
                                    /// <summary>
                                    /// <para>The URL of the TCP socket request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>127.xx.xx.1</para>
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// <para>The port number of the TCP socket request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>888</para>
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The pre-close parameters.</para>
                            /// </summary>
                            [NameInMap("preStop")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStop PreStop { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStop : TeaModel {
                                /// <summary>
                                /// <para>The pre-close script.</para>
                                /// </summary>
                                [NameInMap("exec")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopExec Exec { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopExec : TeaModel {
                                    /// <summary>
                                    /// <para>The executed commands. The value is a string that consists of JSON arrays.</para>
                                    /// </summary>
                                    [NameInMap("command")]
                                    [Validation(Required=false)]
                                    public List<string> Command { get; set; }

                                }

                                /// <summary>
                                /// <para>The HTTP GET request that is sent before the instance stops.</para>
                                /// </summary>
                                [NameInMap("httpGet")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGet HttpGet { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGet : TeaModel {
                                    /// <summary>
                                    /// <para>The URL of the request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>127.xx.xx.1</para>
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// <para>The HTTP request headers.</para>
                                    /// </summary>
                                    [NameInMap("httpHeaders")]
                                    [Validation(Required=false)]
                                    public List<DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGetHttpHeaders> HttpHeaders { get; set; }
                                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGetHttpHeaders : TeaModel {
                                        /// <summary>
                                        /// <para>The name of the HTTP request header.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>key</para>
                                        /// </summary>
                                        [NameInMap("name")]
                                        [Validation(Required=false)]
                                        public string Name { get; set; }

                                        /// <summary>
                                        /// <para>The value of the HTTP request header.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>value</para>
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The port number of the request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>80</para>
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                    /// <summary>
                                    /// <para>The request method. Valid values: <c>http</c> and <c>https</c>.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>http</para>
                                    /// </summary>
                                    [NameInMap("scheme")]
                                    [Validation(Required=false)]
                                    public string Scheme { get; set; }

                                }

                                /// <summary>
                                /// <para>The TCP socket request that is sent.</para>
                                /// </summary>
                                [NameInMap("tcpSocket")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopTcpSocket TcpSocket { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopTcpSocket : TeaModel {
                                    /// <summary>
                                    /// <para>The URL of the request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>127.xx.xx.1</para>
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// <para>The port number of the request.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>888</para>
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <para>The information about Transport Layer Security (TLS) acceleration based on MultiBuffer.</para>
                        /// </summary>
                        [NameInMap("MultiBuffer")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationMultiBuffer MultiBuffer { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationMultiBuffer : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether MultiBuffer-based TLS acceleration is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// <para>The pull-request latency.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.02s</para>
                            /// </summary>
                            [NameInMap("PollDelay")]
                            [Validation(Required=false)]
                            public string PollDelay { get; set; }

                        }

                        /// <summary>
                        /// <para>The configurations of Node Feature Discovery (NFD).</para>
                        /// </summary>
                        [NameInMap("NFDConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationNFDConfiguration NFDConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationNFDConfiguration : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether NFD is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// <para>Indicates whether feature labels on nodes are cleared when NFD is disabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("NFDLabelPruned")]
                            [Validation(Required=false)]
                            public bool? NFDLabelPruned { get; set; }

                        }

                        /// <summary>
                        /// <para>The configurations of the feature of controlling the OPA injection scope.</para>
                        /// </summary>
                        [NameInMap("OPAScopeInjection")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationOPAScopeInjection OPAScopeInjection { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationOPAScopeInjection : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the feature of controlling the OPA injection scope is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("OPAScopeInjected")]
                            [Validation(Required=false)]
                            public bool? OPAScopeInjected { get; set; }

                        }

                        [NameInMap("Playground")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationPlayground Playground { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationPlayground : TeaModel {
                            [NameInMap("Scene")]
                            [Validation(Required=false)]
                            public string Scene { get; set; }

                        }

                        /// <summary>
                        /// <para>The resource limits on the istio-init container.</para>
                        /// </summary>
                        [NameInMap("SidecarProxyInitResourceLimit")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceLimit SidecarProxyInitResourceLimit { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceLimit : TeaModel {
                            /// <summary>
                            /// <para>The maximum number of CPU cores that are available to the istio-init container.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2000m</para>
                            /// </summary>
                            [NameInMap("ResourceCPULimit")]
                            [Validation(Required=false)]
                            public string ResourceCPULimit { get; set; }

                            /// <summary>
                            /// <para>The maximum size of the memory that is available to the istio-init container.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1024Mi</para>
                            /// </summary>
                            [NameInMap("ResourceMemoryLimit")]
                            [Validation(Required=false)]
                            public string ResourceMemoryLimit { get; set; }

                        }

                        /// <summary>
                        /// <para>The resources that are required by the istio-init container.</para>
                        /// </summary>
                        [NameInMap("SidecarProxyInitResourceRequest")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceRequest SidecarProxyInitResourceRequest { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceRequest : TeaModel {
                            /// <summary>
                            /// <para>The number of CPU cores that are requested by the istio-init container.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10m</para>
                            /// </summary>
                            [NameInMap("ResourceCPURequest")]
                            [Validation(Required=false)]
                            public string ResourceCPURequest { get; set; }

                            /// <summary>
                            /// <para>The size of the memory that is requested by the istio-init container.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10Mi</para>
                            /// </summary>
                            [NameInMap("ResourceMemoryRequest")]
                            [Validation(Required=false)]
                            public string ResourceMemoryRequest { get; set; }

                        }

                        /// <summary>
                        /// <para>The maximum period of time that Istio Proxy waits for a request to end.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5s</para>
                        /// </summary>
                        [NameInMap("TerminationDrainDuration")]
                        [Validation(Required=false)]
                        public string TerminationDrainDuration { get; set; }

                    }

                    /// <summary>
                    /// <para>The IP ranges in CIDR form to redirect to the sidecar proxies in the ASM instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.0.0/16</para>
                    /// </summary>
                    [NameInMap("IncludeIPRanges")]
                    [Validation(Required=false)]
                    public string IncludeIPRanges { get; set; }

                    /// <summary>
                    /// <para>The information about the Kubernetes API.</para>
                    /// </summary>
                    [NameInMap("K8sNewAPIsSupport")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigK8sNewAPIsSupport K8sNewAPIsSupport { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigK8sNewAPIsSupport : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether Gateway API is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("GatewayAPIEnabled")]
                        [Validation(Required=false)]
                        public bool? GatewayAPIEnabled { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of mesh topology.</para>
                    /// </summary>
                    [NameInMap("Kiali")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigKiali Kiali { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigKiali : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether mesh topology is enabled. Mesh topology can be enabled only when Prometheus monitoring is enabled. If Prometheus monitoring is disabled, you must set this parameter to <c>false</c>.`` Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The endpoint of the mesh topology service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>http://<c>1.2.**.**</c>:20001</para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of cross-region load balancing.</para>
                    /// </summary>
                    [NameInMap("LocalityLB")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigLocalityLB LocalityLB { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigLocalityLB : TeaModel {
                        /// <summary>
                        /// <para>The configurations of cross-region traffic distribution.</para>
                        /// <remarks>
                        /// <para> Either <c>Failover</c> or Distribute can be set. If you set <c>Distribute</c>, you cannot set Failover.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[{&quot;from&quot;:&quot;cn-shanghai&quot;,&quot;to&quot;:{&quot;cn-hangzhou/<em>&quot;:50,&quot;cn-shanghai/</em>&quot;:25,&quot;cn-zhangjiakou/<em>&quot;:25}},{&quot;from&quot;:&quot;cn-hangzhou&quot;,&quot;to&quot;:{&quot;cn-hangzhou/</em>&quot;:50,&quot;cn-shanghai/<em>&quot;:25,&quot;cn-zhangjiakou/</em>&quot;:25}}]</para>
                        /// </summary>
                        [NameInMap("Distribute")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Distribute { get; set; }

                        /// <summary>
                        /// <para>Indicates whether cross-region load balancing is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The configurations of cross-region failover.</para>
                        /// <remarks>
                        /// <para> Either Failover or <c>Distribute</c> can be set. If you set <c>Failover</c>, you cannot set <c>Distribute</c>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;failover&quot;:[{&quot;from&quot;:&quot;cn-hangzhou&quot;,&quot;to&quot;:&quot;cn-shanghai&quot;}]}</para>
                        /// </summary>
                        [NameInMap("Failover")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Failover { get; set; }

                        [NameInMap("FailoverPriority")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> FailoverPriority { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of Microservices Engine (MSE).</para>
                    /// </summary>
                    [NameInMap("MSE")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigMSE MSE { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigMSE : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether MSE is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the Open Policy Agent (OPA) plug-in.</para>
                    /// </summary>
                    [NameInMap("OPA")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA OPA { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the OPA plug-in is installed. Valid values:</para>
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
                        /// <para>The maximum number of CPU cores that are available to the OPA proxy container.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        /// <summary>
                        /// <para>The maximum size of the memory that is available to the OPA proxy container.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512Mi</para>
                        /// </summary>
                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        /// <summary>
                        /// <para>The level of the logs to be generated for OPA.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>info</para>
                        /// </summary>
                        [NameInMap("LogLevel")]
                        [Validation(Required=false)]
                        public string LogLevel { get; set; }

                        /// <summary>
                        /// <para>The number of CPU cores that are requested by the OPA proxy container.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        /// <summary>
                        /// <para>The size of the memory that is requested by OPA.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1024Mi</para>
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                    }

                    /// <summary>
                    /// <para>The outbound traffic policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>ALLOW_ANY</c>: Outbound traffic to all external services is allowed.</description></item>
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
                    /// <para>The Pilot configurations.</para>
                    /// </summary>
                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot : TeaModel {
                        /// <summary>
                        /// <para>The configurations of communication between external services and services in the mesh.</para>
                        /// </summary>
                        [NameInMap("ConfigSource")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotConfigSource ConfigSource { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotConfigSource : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether communication is allowed between external services and services in the mesh. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// <para>The ID of the Nacos instance that provides external service information.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>mse-cn-tl326******</para>
                            /// </summary>
                            [NameInMap("NacosID")]
                            [Validation(Required=false)]
                            public string NacosID { get; set; }

                        }

                        /// <summary>
                        /// <para>The configurations of Pilot features.</para>
                        /// </summary>
                        [NameInMap("Feature")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotFeature Feature { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotFeature : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether Secret Discovery Service (SDS) is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("EnableSDSServer")]
                            [Validation(Required=false)]
                            public bool? EnableSDSServer { get; set; }

                            /// <summary>
                            /// <para>Indicates whether gateway configuration filtering is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("FilterGatewayClusterConfig")]
                            [Validation(Required=false)]
                            public bool? FilterGatewayClusterConfig { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether HTTP/1.0 is supported. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }

                        /// <summary>
                        /// <para>The sampling percentage of tracing analysis.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of Prometheus monitoring.</para>
                    /// </summary>
                    [NameInMap("Prometheus")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPrometheus Prometheus { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPrometheus : TeaModel {
                        /// <summary>
                        /// <para>The endpoint of Prometheus monitoring. If you use a custom Prometheus instance, this parameter is populated by the system.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://prometheus:9090">http://prometheus:9090</a></para>
                        /// </summary>
                        [NameInMap("ExternalUrl")]
                        [Validation(Required=false)]
                        public string ExternalUrl { get; set; }

                        /// <summary>
                        /// <para>Indicates whether a custom Prometheus instance is used. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("UseExternal")]
                        [Validation(Required=false)]
                        public bool? UseExternal { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of protocol support.</para>
                    /// </summary>
                    [NameInMap("ProtocolSupport")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProtocolSupport ProtocolSupport { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProtocolSupport : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether Dubbo Filter is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("DubboFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? DubboFilterEnabled { get; set; }

                        /// <summary>
                        /// <para>Indicates whether MySQL Filter is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("MysqlFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? MysqlFilterEnabled { get; set; }

                        /// <summary>
                        /// <para>Indicates whether Redis Filter is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("RedisFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? RedisFilterEnabled { get; set; }

                        /// <summary>
                        /// <para>Indicates whether Thrift Filter is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("ThriftFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? ThriftFilterEnabled { get; set; }

                    }

                    /// <summary>
                    /// <para>The proxy configurations.</para>
                    /// </summary>
                    [NameInMap("Proxy")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy Proxy { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy : TeaModel {
                        /// <summary>
                        /// <para>The path to the file that stores the access logs of sidecar proxies.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/dev/stdout</para>
                        /// </summary>
                        [NameInMap("AccessLogFile")]
                        [Validation(Required=false)]
                        public string AccessLogFile { get; set; }

                        /// <summary>
                        /// <para>The format of the access logs of sidecar proxies.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;authority_for&quot;:&quot;%REQ(:AUTHORITY)%&quot;,&quot;bytes_received&quot;:&quot;%BYTES_RECEIVED%&quot;,&quot;bytes_sent&quot;:&quot;%BYTES_SENT%&quot;,&quot;downstream_local_address&quot;:&quot;%DOWNSTREAM_LOCAL_ADDRESS%&quot;,&quot;downstream_remote_address&quot;:&quot;%DOWNSTREAM_REMOTE_ADDRESS%&quot;,&quot;duration&quot;:&quot;%DURATION%&quot;,&quot;istio_policy_status&quot;:&quot;%DYNAMIC_METADATA(istio.mixer:status)%&quot;,&quot;method&quot;:&quot;%REQ(:METHOD)%&quot;,&quot;path&quot;:&quot;%REQ(X-ENVOY-ORIGINAL-PATH?:PATH)%&quot;,&quot;protocol&quot;:&quot;%PROTOCOL%&quot;,&quot;request_id&quot;:&quot;%REQ(X-REQUEST-ID)%&quot;,&quot;requested_server_name&quot;:&quot;%REQUESTED_SERVER_NAME%&quot;,&quot;response_code&quot;:&quot;%RESPONSE_CODE%&quot;,&quot;response_flags&quot;:&quot;%RESPONSE_FLAGS%&quot;,&quot;route_name&quot;:&quot;%ROUTE_NAME%&quot;,&quot;start_time&quot;:&quot;%START_TIME%&quot;,&quot;trace_id&quot;:&quot;%REQ(X-B3-TRACEID)%&quot;,&quot;upstream_cluster&quot;:&quot;%UPSTREAM_CLUSTER%&quot;,&quot;upstream_host&quot;:&quot;%UPSTREAM_HOST%&quot;,&quot;upstream_local_address&quot;:&quot;%UPSTREAM_LOCAL_ADDRESS%&quot;,&quot;upstream_service_time&quot;:&quot;%RESP(X-ENVOY-UPSTREAM-SERVICE-TIME)%&quot;,&quot;upstream_transport_failure_reason&quot;:&quot;%UPSTREAM_TRANSPORT_FAILURE_REASON%&quot;,&quot;user_agent&quot;:&quot;%REQ(USER-AGENT)%&quot;,&quot;x_forwarded_for&quot;:&quot;%REQ(X-FORWARDED-FOR)%&quot;}</para>
                        /// </summary>
                        [NameInMap("AccessLogFormat")]
                        [Validation(Required=false)]
                        public string AccessLogFormat { get; set; }

                        /// <summary>
                        /// <para>Indicates whether gRPC Access Log Service (ALS) for Envoy is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("AccessLogServiceEnabled")]
                        [Validation(Required=false)]
                        public bool? AccessLogServiceEnabled { get; set; }

                        /// <summary>
                        /// <para>The endpoint of gRPC ALS for Envoy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0.0.0</para>
                        /// </summary>
                        [NameInMap("AccessLogServiceHost")]
                        [Validation(Required=false)]
                        public string AccessLogServiceHost { get; set; }

                        /// <summary>
                        /// <para>The port of gRPC ALS for Envoy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9999</para>
                        /// </summary>
                        [NameInMap("AccessLogServicePort")]
                        [Validation(Required=false)]
                        public int? AccessLogServicePort { get; set; }

                        /// <summary>
                        /// <para>The trusted domain.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cluster.domain</para>
                        /// </summary>
                        [NameInMap("ClusterDomain")]
                        [Validation(Required=false)]
                        public string ClusterDomain { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the Domain Name System (DNS) proxy feature is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("EnableDNSProxying")]
                        [Validation(Required=false)]
                        public bool? EnableDNSProxying { get; set; }

                        /// <summary>
                        /// <para>The maximum number of CPU cores.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2000m</para>
                        /// </summary>
                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        /// <summary>
                        /// <para>The maximum size of the memory.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1024Mi</para>
                        /// </summary>
                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        /// <summary>
                        /// <para>The number of CPU cores that are requested.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100m</para>
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        /// <summary>
                        /// <para>The size of the memory that is requested.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>128Mi</para>
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of the sidecar injector.</para>
                    /// </summary>
                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether automatic sidecar proxy injection can be enabled by using pod annotations. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
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
                        /// <para>The configurations of Container Network Interface (CNI).</para>
                        /// </summary>
                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the CNI plug-in is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><c>true</c></description></item>
                            /// <item><description><c>false</c></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// <para>The namespaces to exclude. The CNI plug-in ignores pods in the excluded namespaces.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>kube-system,istio-system</para>
                            /// </summary>
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }

                        }

                        /// <summary>
                        /// <para>The maximum number of CPU cores that are available to the pod where the sidecar injector resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4000m</para>
                        /// </summary>
                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        /// <summary>
                        /// <para>The maximum size of the memory that is available to the pod where the sidecar injector resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2048Mi</para>
                        /// </summary>
                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        /// <summary>
                        /// <para>The number of CPU cores that are requested by the pod where the sidecar injector resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000m</para>
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        /// <summary>
                        /// <para>The size of the memory that is requested by the pod where the sidecar injector resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512Mi</para>
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                        /// <summary>
                        /// <para>The number of component replicas that are used for sidecar proxy injection. Default value: <c>1</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SidecarInjectorNum")]
                        [Validation(Required=false)]
                        public int? SidecarInjectorNum { get; set; }

                        /// <summary>
                        /// <para>Other configurations of automatic sidecar proxy injection, in the YAML format. For more information, see <a href="https://help.aliyun.com/document_detail/186136.html">Enable automatic sidecar proxy injection</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;injectedAnnotations&quot;:{&quot;test/istio-init&quot;:&quot;runtime/default2&quot;,&quot;test/istio-proxy&quot;:&quot;runtime/default&quot;},&quot;replicaCount&quot;:2,&quot;nodeSelector&quot;:{&quot;beta.kubernetes.io/os&quot;:&quot;linux&quot;}}</para>
                        /// </summary>
                        [NameInMap("SidecarInjectorWebhookAsYaml")]
                        [Validation(Required=false)]
                        public string SidecarInjectorWebhookAsYaml { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether Prometheus monitoring is enabled. We recommend that you use <a href="https://arms.console.aliyun.com/">Managed Service for Prometheus</a>. Valid values:</para>
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
                    /// <para>Indicates whether tracing analysis is enabled. This feature can be enabled only after <a href="https://tracing-analysis.console.aliyun.com/">Managed Service for OpenTelemetry</a> is activated. Valid values:</para>
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

                    /// <summary>
                    /// <para>The configurations of WebAssembly Filter.</para>
                    /// </summary>
                    [NameInMap("WebAssemblyFilterDeployment")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigWebAssemblyFilterDeployment WebAssemblyFilterDeployment { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigWebAssemblyFilterDeployment : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether WebAssembly Filter is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }

                }

                /// <summary>
                /// <para>The network configurations of the ASM instance.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork Network { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork : TeaModel {
                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-2ze384sxttxbctnj****</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The virtual switches (vSwitches).</para>
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

        }

    }

}
