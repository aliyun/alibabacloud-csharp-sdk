// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayAttributeResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ForwardTable")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyForwardTable ForwardTable { get; set; }
        public class GetNatGatewayAttributeResponseBodyForwardTable : TeaModel {
            [NameInMap("ForwardEntryCount")]
            [Validation(Required=false)]
            public int? ForwardEntryCount { get; set; }
            [NameInMap("ForwardTableId")]
            [Validation(Required=false)]
            public string ForwardTableId { get; set; }
        };

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<GetNatGatewayAttributeResponseBodyIpList> IpList { get; set; }
        public class GetNatGatewayAttributeResponseBodyIpList : TeaModel {
            [NameInMap("UsingStatus")]
            [Validation(Required=false)]
            public string UsingStatus { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

        }

        [NameInMap("DeletionProtectionInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyDeletionProtectionInfo DeletionProtectionInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyDeletionProtectionInfo : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }
        };

        [NameInMap("BillingConfig")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyBillingConfig BillingConfig { get; set; }
        public class GetNatGatewayAttributeResponseBodyBillingConfig : TeaModel {
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public string AutoPay { get; set; }
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }
        };

        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        [NameInMap("SnatTable")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodySnatTable SnatTable { get; set; }
        public class GetNatGatewayAttributeResponseBodySnatTable : TeaModel {
            [NameInMap("SnatEntryCount")]
            [Validation(Required=false)]
            public int? SnatEntryCount { get; set; }
            [NameInMap("SnatTableId")]
            [Validation(Required=false)]
            public string SnatTableId { get; set; }
        };

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("EcsMetricEnabled")]
        [Validation(Required=false)]
        public bool? EcsMetricEnabled { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("PrivateInfo")]
        [Validation(Required=false)]
        public GetNatGatewayAttributeResponseBodyPrivateInfo PrivateInfo { get; set; }
        public class GetNatGatewayAttributeResponseBodyPrivateInfo : TeaModel {
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }
            [NameInMap("MaxBandwidth")]
            [Validation(Required=false)]
            public int? MaxBandwidth { get; set; }
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }
            [NameInMap("IzNo")]
            [Validation(Required=false)]
            public string IzNo { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

    }

}
