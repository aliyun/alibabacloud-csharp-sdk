// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SetFundAccountCreditAmountRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to cancel credit control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cancel credit control.</description></item>
        /// <item><description>false or empty: Set credit control.</description></item>
        /// </list>
        /// <para>When canceling credit control, CreditAmount must be set to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CancelCredit")]
        [Validation(Required=false)]
        public string CancelCredit { get; set; }

        /// <summary>
        /// <para>The credit limit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// <para>The currency of the credit limit. Currently, only CNY is supported for Chinese mainland accounts, and only USD is supported for international accounts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The fund account ID. If this parameter is not specified, the account owned by the current account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232312</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

    }

}
