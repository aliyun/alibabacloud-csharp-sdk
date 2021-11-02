// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSasOrderRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("ContainerImageScan")]
        [Validation(Required=false)]
        public string ContainerImageScan { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public string InstanceCount { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("SasAntiRansomware")]
        [Validation(Required=false)]
        public string SasAntiRansomware { get; set; }

        [NameInMap("SasProductService")]
        [Validation(Required=false)]
        public string SasProductService { get; set; }

        [NameInMap("SasSc")]
        [Validation(Required=false)]
        public string SasSc { get; set; }

        [NameInMap("SasSlsStorage")]
        [Validation(Required=false)]
        public string SasSlsStorage { get; set; }

        [NameInMap("SasWebguardBoolean")]
        [Validation(Required=false)]
        public string SasWebguardBoolean { get; set; }

        [NameInMap("SasWebguardOrderNum")]
        [Validation(Required=false)]
        public string SasWebguardOrderNum { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("Vcore")]
        [Validation(Required=false)]
        public string Vcore { get; set; }

    }

}
