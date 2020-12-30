// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerAttributeResponseBody : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ListenerPortsAndProtocal")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocal ListenerPortsAndProtocal { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocal : TeaModel {
            [NameInMap("ListenerPortAndProtocal")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocalListenerPortAndProtocal> ListenerPortAndProtocal { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocalListenerPortAndProtocal : TeaModel {
                public string ListenerProtocal { get; set; }
                public int? ListenerPort { get; set; }
            }
        };

        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyBackendServers BackendServers { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyBackendServersBackendServer : TeaModel {
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Description { get; set; }
                public string ServerId { get; set; }
            }
        };

        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        [NameInMap("ListenerPorts")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyListenerPorts ListenerPorts { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPorts : TeaModel {
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public List<string> ListenerPort { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public long? AutoReleaseTime { get; set; }

        [NameInMap("RenewalDuration")]
        [Validation(Required=false)]
        public int? RenewalDuration { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("ListenerPortsAndProtocol")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocol ListenerPortsAndProtocol { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocol : TeaModel {
            [NameInMap("ListenerPortAndProtocol")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocolListenerPortAndProtocol> ListenerPortAndProtocol { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocolListenerPortAndProtocol : TeaModel {
                public string ListenerProtocol { get; set; }
                public string ListenerForward { get; set; }
                public string Description { get; set; }
                public int? ListenerPort { get; set; }
                public int? ForwardPort { get; set; }
            }
        };

        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("MasterZoneId")]
        [Validation(Required=false)]
        public string MasterZoneId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("RenewalCycUnit")]
        [Validation(Required=false)]
        public string RenewalCycUnit { get; set; }

        [NameInMap("SlaveZoneId")]
        [Validation(Required=false)]
        public string SlaveZoneId { get; set; }

        [NameInMap("RegionIdAlias")]
        [Validation(Required=false)]
        public string RegionIdAlias { get; set; }

        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

    }

}
