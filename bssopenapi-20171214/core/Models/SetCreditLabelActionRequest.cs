// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetCreditLabelActionRequest : TeaModel {
        /// <summary>
        /// The type of the action. Valid values: SET: adds the pay-as-you-go tag. CANCEL: removes the pay-as-you-go tag.
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The cycle in which the account is notified of payment. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("ClearCycle")]
        [Validation(Required=false)]
        public string ClearCycle { get; set; }

        /// <summary>
        /// The credit line of the account.
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// The code of currency that is used. Valid values: USD and CNY.
        /// </summary>
        [NameInMap("CurrencyCode")]
        [Validation(Required=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The cycle in which payment can be deferred. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DailyCycle")]
        [Validation(Required=false)]
        public string DailyCycle { get; set; }

        /// <summary>
        /// The description of the action.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to add the post-settlement tag. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("IsNeedAddSettleLabel")]
        [Validation(Required=false)]
        public string IsNeedAddSettleLabel { get; set; }

        /// <summary>
        /// Specifies whether to synchronize the monthly settlement tag. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("IsNeedAdjustCreditAccount")]
        [Validation(Required=false)]
        public string IsNeedAdjustCreditAccount { get; set; }

        /// <summary>
        /// Specifies whether to save the notification rule. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("IsNeedSaveNotifyRule")]
        [Validation(Required=false)]
        public string IsNeedSaveNotifyRule { get; set; }

        /// <summary>
        /// Specifies whether to set a credit line. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("IsNeedSetCreditAmount")]
        [Validation(Required=false)]
        public string IsNeedSetCreditAmount { get; set; }

        /// <summary>
        /// Specifies whether to notify the account of an identity change. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("NeedNotice")]
        [Validation(Required=false)]
        public bool? NeedNotice { get; set; }

        /// <summary>
        /// Specifies whether to call another operation to create a credit ledger. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("NewCreateMode")]
        [Validation(Required=false)]
        public bool? NewCreateMode { get; set; }

        /// <summary>
        /// The operator who performs the action.
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The code of the site. **You do not need to specify this parameter.
        /// </summary>
        [NameInMap("SiteCode")]
        [Validation(Required=false)]
        public string SiteCode { get; set; }

        /// <summary>
        /// The source of the action.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
