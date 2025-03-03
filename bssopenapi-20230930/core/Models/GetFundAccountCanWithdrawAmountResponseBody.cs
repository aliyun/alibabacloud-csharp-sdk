// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanWithdrawAmountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CanOriginalWithdrawAmount")]
        [Validation(Required=false)]
        public string CanOriginalWithdrawAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("CanWithdrawAmount")]
        [Validation(Required=false)]
        public string CanWithdrawAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CannotOriginalWithdrawAmount")]
        [Validation(Required=false)]
        public string CannotOriginalWithdrawAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CashAmount")]
        [Validation(Required=false)]
        public string CashAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CreditMemoAmount")]
        [Validation(Required=false)]
        public string CreditMemoAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CurrentMonthUnclearedAmount")]
        [Validation(Required=false)]
        public string CurrentMonthUnclearedAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HistoryMonthUnclearedAmount")]
        [Validation(Required=false)]
        public string HistoryMonthUnclearedAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PayAsYouGoReversedAmount")]
        [Validation(Required=false)]
        public string PayAsYouGoReversedAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DF58589C-A06C-4224-8615-7797E6474FA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TransferAmount")]
        [Validation(Required=false)]
        public string TransferAmount { get; set; }

    }

}
