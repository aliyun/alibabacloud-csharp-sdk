// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class CreateLoadBalancerRequestLoadBalancerBillingConfig : TeaModel {
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
        };

        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestModificationProtectionConfig : TeaModel {
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateLoadBalancerRequestZoneMappings : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
