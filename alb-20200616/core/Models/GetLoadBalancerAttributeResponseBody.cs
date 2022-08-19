// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetLoadBalancerAttributeResponseBody : TeaModel {
        [NameInMap("AccessLogConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyAccessLogConfig AccessLogConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyAccessLogConfig : TeaModel {
            [NameInMap("LogProject")]
            [Validation(Required=false)]
            public string LogProject { get; set; }
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }
        };

        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        [NameInMap("DeletionProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }
        };

        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig : TeaModel {
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
        };

        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        [NameInMap("LoadBalancerOperationLocks")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("LockType")]
            [Validation(Required=false)]
            public string LockType { get; set; }

        }

        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyModificationProtectionConfig : TeaModel {
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyTags> Tags { get; set; }
        public class GetLoadBalancerAttributeResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetLoadBalancerAttributeResponseBodyZoneMappings : TeaModel {
            [NameInMap("LoadBalancerAddresses")]
            [Validation(Required=false)]
            public List<GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
            public class GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
