// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountAvailableAmountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AvailableAmount")]
        [Validation(Required=false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("AvailableCreditAmount")]
        [Validation(Required=false)]
        public string AvailableCreditAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BankAcceptanceAmount")]
        [Validation(Required=false)]
        public string BankAcceptanceAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CashAmount")]
        [Validation(Required=false)]
        public string CashAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CreditRefundAmount")]
        [Validation(Required=false)]
        public string CreditRefundAmount { get; set; }

        [NameInMap("CreditUser")]
        [Validation(Required=false)]
        public bool? CreditUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CurrentMonthUnclearedAmount")]
        [Validation(Required=false)]
        public string CurrentMonthUnclearedAmount { get; set; }

        [NameInMap("ExtendLedgerList")]
        [Validation(Required=false)]
        public List<GetFundAccountAvailableAmountResponseBodyExtendLedgerList> ExtendLedgerList { get; set; }
        public class GetFundAccountAvailableAmountResponseBodyExtendLedgerList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>应付对冲账本</para>
            /// </summary>
            [NameInMap("LedgerName")]
            [Validation(Required=false)]
            public string LedgerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public string FundAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1344312434</para>
        /// </summary>
        [NameInMap("FundAccountOwnerAccountId")]
        [Validation(Required=false)]
        public string FundAccountOwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("FundAccountStatus")]
        [Validation(Required=false)]
        public string FundAccountStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>REDIRECT_USER</para>
        /// </summary>
        [NameInMap("FundAccountType")]
        [Validation(Required=false)]
        public string FundAccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("NegativeBillAmount")]
        [Validation(Required=false)]
        public string NegativeBillAmount { get; set; }

        [NameInMap("OriginalCashAmountList")]
        [Validation(Required=false)]
        public List<GetFundAccountAvailableAmountResponseBodyOriginalCashAmountList> OriginalCashAmountList { get; set; }
        public class GetFundAccountAvailableAmountResponseBodyOriginalCashAmountList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("QuotaAmount")]
        [Validation(Required=false)]
        public string QuotaAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("QuotaConsumedAmount")]
        [Validation(Required=false)]
        public string QuotaConsumedAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F96A2D13-7509-5DF9-A60E-E7E3A3CB68E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UnclearedAmount")]
        [Validation(Required=false)]
        public string UnclearedAmount { get; set; }

    }

}
