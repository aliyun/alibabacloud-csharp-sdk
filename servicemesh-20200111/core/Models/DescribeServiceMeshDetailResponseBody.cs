// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceMesh")]
        [Validation(Required=false)]
        public DescribeServiceMeshDetailResponseBodyServiceMesh ServiceMesh { get; set; }
        public class DescribeServiceMeshDetailResponseBodyServiceMesh : TeaModel {
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints : TeaModel {
                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }

                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }

                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

            }
            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshSpec Spec { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpec : TeaModel {
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork Network { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork : TeaModel {
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }
                };

                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer : TeaModel {
                    [NameInMap("PilotPublicEip")]
                    [Validation(Required=false)]
                    public bool? PilotPublicEip { get; set; }
                    [NameInMap("PilotPublicLoadbalancerId")]
                    [Validation(Required=false)]
                    public string PilotPublicLoadbalancerId { get; set; }
                    [NameInMap("ApiServerLoadbalancerId")]
                    [Validation(Required=false)]
                    public string ApiServerLoadbalancerId { get; set; }
                    [NameInMap("ApiServerPublicEip")]
                    [Validation(Required=false)]
                    public bool? ApiServerPublicEip { get; set; }
                };

                [NameInMap("MeshConfig")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig : TeaModel {
                    [NameInMap("Telemetry")]
                    [Validation(Required=false)]
                    public bool? Telemetry { get; set; }
                    [NameInMap("OPA")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA OPA { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA : TeaModel {
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                        [NameInMap("LogLevel")]
                        [Validation(Required=false)]
                        public string LogLevel { get; set; }

                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                    }
                    [NameInMap("OutboundTrafficPolicy")]
                    [Validation(Required=false)]
                    public string OutboundTrafficPolicy { get; set; }
                    [NameInMap("Tracing")]
                    [Validation(Required=false)]
                    public bool? Tracing { get; set; }
                    [NameInMap("EnableLocalityLB")]
                    [Validation(Required=false)]
                    public bool? EnableLocalityLB { get; set; }
                    [NameInMap("Audit")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit Audit { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }
                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot : TeaModel {
                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }

                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }

                    }
                    [NameInMap("CustomizedZipkin")]
                    [Validation(Required=false)]
                    public bool? CustomizedZipkin { get; set; }
                    [NameInMap("IncludeIPRanges")]
                    [Validation(Required=false)]
                    public string IncludeIPRanges { get; set; }
                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector : TeaModel {
                        [NameInMap("EnableNamespacesByDefault")]
                        [Validation(Required=false)]
                        public bool? EnableNamespacesByDefault { get; set; }

                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        [NameInMap("AutoInjectionPolicyEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoInjectionPolicyEnabled { get; set; }

                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }
                        };

                        [NameInMap("SidecarInjectorWebhookAsYaml")]
                        [Validation(Required=false)]
                        public string SidecarInjectorWebhookAsYaml { get; set; }

                    }
                    [NameInMap("Proxy")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy Proxy { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy : TeaModel {
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                        [NameInMap("ClusterDomain")]
                        [Validation(Required=false)]
                        public string ClusterDomain { get; set; }

                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                    }
                };

            }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }
        };

    }

}
