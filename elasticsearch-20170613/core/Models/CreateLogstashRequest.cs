// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateLogstashRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public CreateLogstashRequestNetworkConfig NetworkConfig { get; set; }
        public class CreateLogstashRequestNetworkConfig : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public int? NodeAmount { get; set; }

        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public CreateLogstashRequestNodeSpec NodeSpec { get; set; }
        public class CreateLogstashRequestNodeSpec : TeaModel {
            [NameInMap("disk")]
            [Validation(Required=false)]
            public long? Disk { get; set; }

            [NameInMap("diskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        [NameInMap("paymentInfo")]
        [Validation(Required=false)]
        public CreateLogstashRequestPaymentInfo PaymentInfo { get; set; }
        public class CreateLogstashRequestPaymentInfo : TeaModel {
            [NameInMap("autoRenewDuration")]
            [Validation(Required=false)]
            public long? AutoRenewDuration { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("isAutoRenew")]
            [Validation(Required=false)]
            public bool? IsAutoRenew { get; set; }

            [NameInMap("pricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

        }

        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
