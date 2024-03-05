// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class SubmitPurchaseInfoRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("PurchaseCurrency")]
        [Validation(Required=false)]
        public string PurchaseCurrency { get; set; }

        [NameInMap("PurchasePrice")]
        [Validation(Required=false)]
        public double? PurchasePrice { get; set; }

        [NameInMap("PurchaseProofs")]
        [Validation(Required=false)]
        public List<string> PurchaseProofs { get; set; }

    }

}
