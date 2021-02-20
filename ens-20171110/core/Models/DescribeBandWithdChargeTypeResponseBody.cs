// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandWithdChargeTypeResponseBody : TeaModel {
        [NameInMap("BandWithTypeInfo")]
        [Validation(Required=false)]
        public string BandWithTypeInfo { get; set; }

        [NameInMap("ChargeContractType")]
        [Validation(Required=false)]
        public string ChargeContractType { get; set; }

        [NameInMap("ChargeCycleInfo")]
        [Validation(Required=false)]
        public string ChargeCycleInfo { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
