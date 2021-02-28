// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnServiceResponseBody : TeaModel {
        [NameInMap("CurrentDDoSBasicValue")]
        [Validation(Required=false)]
        public string CurrentDDoSBasicValue { get; set; }

        [NameInMap("CurrentElasticProtectionValue")]
        [Validation(Required=false)]
        public string CurrentElasticProtectionValue { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("ElasticProtection")]
        [Validation(Required=false)]
        public string ElasticProtection { get; set; }

        [NameInMap("DomainCountValue")]
        [Validation(Required=false)]
        public string DomainCountValue { get; set; }

        [NameInMap("CurrentDomainCount")]
        [Validation(Required=false)]
        public string CurrentDomainCount { get; set; }

        [NameInMap("DDoSBasic")]
        [Validation(Required=false)]
        public string DDoSBasic { get; set; }

        [NameInMap("CcProtectionValue")]
        [Validation(Required=false)]
        public string CcProtectionValue { get; set; }

        [NameInMap("ElasticProtectionValue")]
        [Validation(Required=false)]
        public string ElasticProtectionValue { get; set; }

        [NameInMap("OpenTime")]
        [Validation(Required=false)]
        public string OpenTime { get; set; }

        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public string DomainCount { get; set; }

        [NameInMap("CurrentBandwidth")]
        [Validation(Required=false)]
        public string CurrentBandwidth { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CurrentElasticProtection")]
        [Validation(Required=false)]
        public string CurrentElasticProtection { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("CurrentCcProtectionValue")]
        [Validation(Required=false)]
        public string CurrentCcProtectionValue { get; set; }

        [NameInMap("CurrentDDoSBasic")]
        [Validation(Required=false)]
        public string CurrentDDoSBasic { get; set; }

        [NameInMap("CurrentProtectType")]
        [Validation(Required=false)]
        public string CurrentProtectType { get; set; }

        [NameInMap("CurrentDomainCountValue")]
        [Validation(Required=false)]
        public string CurrentDomainCountValue { get; set; }

        [NameInMap("CurrentBandwidthValue")]
        [Validation(Required=false)]
        public string CurrentBandwidthValue { get; set; }

        [NameInMap("ProtectTypeValue")]
        [Validation(Required=false)]
        public string ProtectTypeValue { get; set; }

        [NameInMap("CurrentProtectTypeValue")]
        [Validation(Required=false)]
        public string CurrentProtectTypeValue { get; set; }

        [NameInMap("CcProtection")]
        [Validation(Required=false)]
        public string CcProtection { get; set; }

        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeScdnServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeScdnServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeScdnServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeScdnServiceResponseBodyOperationLocksLockReason : TeaModel {
                public string LockReason { get; set; }
            }
        };

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("DDoSBasicValue")]
        [Validation(Required=false)]
        public string DDoSBasicValue { get; set; }

        [NameInMap("ProtectType")]
        [Validation(Required=false)]
        public string ProtectType { get; set; }

        [NameInMap("CurrentCcProtection")]
        [Validation(Required=false)]
        public string CurrentCcProtection { get; set; }

        [NameInMap("PriceType")]
        [Validation(Required=false)]
        public string PriceType { get; set; }

        [NameInMap("BandwidthValue")]
        [Validation(Required=false)]
        public string BandwidthValue { get; set; }

    }

}
