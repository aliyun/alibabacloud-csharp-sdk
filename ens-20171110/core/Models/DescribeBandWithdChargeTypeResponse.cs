// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandWithdChargeTypeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("BandWithTypeInfo")]
        [Validation(Required=true)]
        public string BandWithTypeInfo { get; set; }

        [NameInMap("ChargeCycleInfo")]
        [Validation(Required=true)]
        public string ChargeCycleInfo { get; set; }

        [NameInMap("ChargeContractType")]
        [Validation(Required=true)]
        public string ChargeContractType { get; set; }

    }

}
