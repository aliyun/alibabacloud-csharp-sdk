// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeEnvResourceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EnvResource")]
        [Validation(Required=false)]
        public DescribeEnvResourceResponseBodyEnvResource EnvResource { get; set; }
        public class DescribeEnvResourceResponseBodyEnvResource : TeaModel {
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceVSwitches VSwitches { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceVSwitches : TeaModel {
                [NameInMap("VSwitch")]
                [Validation(Required=false)]
                public List<DescribeEnvResourceResponseBodyEnvResourceVSwitchesVSwitch> VSwitch { get; set; }
                public class DescribeEnvResourceResponseBodyEnvResourceVSwitchesVSwitch : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

            }
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceVpc Vpc { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceVpc : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("MonitorGroup")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceMonitorGroup MonitorGroup { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceMonitorGroup : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("LaunchConfigurationId")]
            [Validation(Required=false)]
            public string LaunchConfigurationId { get; set; }
            [NameInMap("LoadBalancers")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceLoadBalancers LoadBalancers { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceLoadBalancers : TeaModel {
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public List<DescribeEnvResourceResponseBodyEnvResourceLoadBalancersLoadBalancer> LoadBalancer { get; set; }
                public class DescribeEnvResourceResponseBodyEnvResourceLoadBalancersLoadBalancer : TeaModel {
                    [NameInMap("Imported")]
                    [Validation(Required=false)]
                    public bool? Imported { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("AddressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public DescribeEnvResourceResponseBodyEnvResourceLoadBalancersLoadBalancerListeners Listeners { get; set; }
                    public class DescribeEnvResourceResponseBodyEnvResourceLoadBalancersLoadBalancerListeners : TeaModel {
                        [NameInMap("Listener")]
                        [Validation(Required=false)]
                        public List<DescribeEnvResourceResponseBodyEnvResourceLoadBalancersLoadBalancerListenersListener> Listener { get; set; }
                        public class DescribeEnvResourceResponseBodyEnvResourceLoadBalancersLoadBalancerListenersListener : TeaModel {
                            public string Protocol { get; set; }
                            public int? Port { get; set; }
                        }
                    };

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

            }
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceInstances Instances { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceInstances : TeaModel {
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public List<DescribeEnvResourceResponseBodyEnvResourceInstancesInstance> Instance { get; set; }
                public class DescribeEnvResourceResponseBodyEnvResourceInstancesInstance : TeaModel {
                    [NameInMap("Imported")]
                    [Validation(Required=false)]
                    public bool? Imported { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

            }
            [NameInMap("DefaultSecurityGroups")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceDefaultSecurityGroups DefaultSecurityGroups { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceDefaultSecurityGroups : TeaModel {
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public List<DescribeEnvResourceResponseBodyEnvResourceDefaultSecurityGroupsSecurityGroup> SecurityGroup { get; set; }
                public class DescribeEnvResourceResponseBodyEnvResourceDefaultSecurityGroupsSecurityGroup : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

            }
            [NameInMap("ScalingGroup")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceScalingGroup ScalingGroup { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceScalingGroup : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceDomains Domains { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceDomains : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public List<DescribeEnvResourceResponseBodyEnvResourceDomainsDomain> Domain { get; set; }
                public class DescribeEnvResourceResponseBodyEnvResourceDomainsDomain : TeaModel {
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    [NameInMap("HostedBy")]
                    [Validation(Required=false)]
                    public string HostedBy { get; set; }

                    [NameInMap("SubDomain")]
                    [Validation(Required=false)]
                    public string SubDomain { get; set; }

                    [NameInMap("DomainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    [NameInMap("ManagedBy")]
                    [Validation(Required=false)]
                    public string ManagedBy { get; set; }

                }

            }
            [NameInMap("RdsInstances")]
            [Validation(Required=false)]
            public DescribeEnvResourceResponseBodyEnvResourceRdsInstances RdsInstances { get; set; }
            public class DescribeEnvResourceResponseBodyEnvResourceRdsInstances : TeaModel {
                [NameInMap("RdsInstance")]
                [Validation(Required=false)]
                public List<DescribeEnvResourceResponseBodyEnvResourceRdsInstancesRdsInstance> RdsInstance { get; set; }
                public class DescribeEnvResourceResponseBodyEnvResourceRdsInstancesRdsInstance : TeaModel {
                    [NameInMap("Imported")]
                    [Validation(Required=false)]
                    public bool? Imported { get; set; }

                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                }

            }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
        };

    }

}
