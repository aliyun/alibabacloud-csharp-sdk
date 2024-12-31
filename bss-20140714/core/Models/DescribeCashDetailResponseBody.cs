// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bss20140714.Models
{
    public class DescribeCashDetailResponseBody : TeaModel {
        [NameInMap("AmountOwed")]
        [Validation(Required=false)]
        public string AmountOwed { get; set; }

        [NameInMap("AvailableCredit")]
        [Validation(Required=false)]
        public string AvailableCredit { get; set; }

        [NameInMap("BalanceAmount")]
        [Validation(Required=false)]
        public string BalanceAmount { get; set; }

        [NameInMap("CreditCardAmount")]
        [Validation(Required=false)]
        public string CreditCardAmount { get; set; }

        [NameInMap("CreditLimit")]
        [Validation(Required=false)]
        public string CreditLimit { get; set; }

        [NameInMap("EnableThresholdAlert")]
        [Validation(Required=false)]
        public string EnableThresholdAlert { get; set; }

        [NameInMap("FrozenAmount")]
        [Validation(Required=false)]
        public string FrozenAmount { get; set; }

        [NameInMap("MiniAlertThreshold")]
        [Validation(Required=false)]
        public long? MiniAlertThreshold { get; set; }

        [NameInMap("RemmitanceAmount")]
        [Validation(Required=false)]
        public string RemmitanceAmount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
