// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ChangeResellerConsumeAmountRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("AdjustType")]
        [Validation(Required=false)]
        public string AdjustType { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        [NameInMap("ExtendMap")]
        [Validation(Required=false)]
        public string ExtendMap { get; set; }

    }

}
