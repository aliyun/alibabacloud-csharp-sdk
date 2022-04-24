// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetCreditLabelActionRequest : TeaModel {
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("ClearCycle")]
        [Validation(Required=false)]
        public string ClearCycle { get; set; }

        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        [NameInMap("CurrencyCode")]
        [Validation(Required=false)]
        public string CurrencyCode { get; set; }

        [NameInMap("DailyCycle")]
        [Validation(Required=false)]
        public string DailyCycle { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IsNeedAddSettleLabel")]
        [Validation(Required=false)]
        public string IsNeedAddSettleLabel { get; set; }

        [NameInMap("IsNeedAdjustCreditAccount")]
        [Validation(Required=false)]
        public string IsNeedAdjustCreditAccount { get; set; }

        [NameInMap("IsNeedSaveNotifyRule")]
        [Validation(Required=false)]
        public string IsNeedSaveNotifyRule { get; set; }

        [NameInMap("IsNeedSetCreditAmount")]
        [Validation(Required=false)]
        public string IsNeedSetCreditAmount { get; set; }

        [NameInMap("NeedNotice")]
        [Validation(Required=false)]
        public bool? NeedNotice { get; set; }

        [NameInMap("NewCreateMode")]
        [Validation(Required=false)]
        public bool? NewCreateMode { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SiteCode")]
        [Validation(Required=false)]
        public string SiteCode { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
