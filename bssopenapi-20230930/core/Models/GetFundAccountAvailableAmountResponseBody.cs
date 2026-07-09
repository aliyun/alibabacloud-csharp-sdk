// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountAvailableAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>Available amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AvailableAmount")]
        [Validation(Required=false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// <para>Available credit amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("AvailableCreditAmount")]
        [Validation(Required=false)]
        public string AvailableCreditAmount { get; set; }

        /// <summary>
        /// <para>Bank acceptance bill amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BankAcceptanceAmount")]
        [Validation(Required=false)]
        public string BankAcceptanceAmount { get; set; }

        /// <summary>
        /// <para>Cash balance</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CashAmount")]
        [Validation(Required=false)]
        public string CashAmount { get; set; }

        /// <summary>
        /// <para>Credit quota</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// <para>Credit refund balance</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CreditRefundAmount")]
        [Validation(Required=false)]
        public string CreditRefundAmount { get; set; }

        /// <summary>
        /// <para>Indicates whether credit control is enabled</para>
        /// </summary>
        [NameInMap("CreditUser")]
        [Validation(Required=false)]
        public bool? CreditUser { get; set; }

        /// <summary>
        /// <para>Currency</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>Current month uncleared amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CurrentMonthUnclearedAmount")]
        [Validation(Required=false)]
        public string CurrentMonthUnclearedAmount { get; set; }

        /// <summary>
        /// <para>Extended ledger list</para>
        /// </summary>
        [NameInMap("ExtendLedgerList")]
        [Validation(Required=false)]
        public List<GetFundAccountAvailableAmountResponseBodyExtendLedgerList> ExtendLedgerList { get; set; }
        public class GetFundAccountAvailableAmountResponseBodyExtendLedgerList : TeaModel {
            /// <summary>
            /// <para>Currency of the ledger amount, such as CNY and USD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>Ledger name</para>
            /// 
            /// <b>Example:</b>
            /// <para>应付对冲账本</para>
            /// </summary>
            [NameInMap("LedgerName")]
            [Validation(Required=false)]
            public string LedgerName { get; set; }

            /// <summary>
            /// <para>Ledger balance</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

        }

        /// <summary>
        /// <para>Account ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public string FundAccountId { get; set; }

        /// <summary>
        /// <para>Account ID of the fund account owner</para>
        /// 
        /// <b>Example:</b>
        /// <para>1344312434</para>
        /// </summary>
        [NameInMap("FundAccountOwnerAccountId")]
        [Validation(Required=false)]
        public string FundAccountOwnerAccountId { get; set; }

        /// <summary>
        /// <para>Account status</para>
        /// 
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("FundAccountStatus")]
        [Validation(Required=false)]
        public string FundAccountStatus { get; set; }

        /// <summary>
        /// <para>Fund account type. Valid values:
        /// DIRECT_USER: Alibaba Cloud direct customer account.
        /// RESELLER_QUOTA: ecosystem account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REDIRECT_USER</para>
        /// </summary>
        [NameInMap("FundAccountType")]
        [Validation(Required=false)]
        public string FundAccountType { get; set; }

        /// <summary>
        /// <para>Historical months uncleared amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("HistoryMonthUnclearedAmount")]
        [Validation(Required=false)]
        public string HistoryMonthUnclearedAmount { get; set; }

        /// <summary>
        /// <para>Response metadata</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Negative bill amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NegativeBillAmount")]
        [Validation(Required=false)]
        public string NegativeBillAmount { get; set; }

        /// <summary>
        /// <para>Original cash ledger list. International site users may have cash ledgers in multiple currencies.</para>
        /// </summary>
        [NameInMap("OriginalCashAmountList")]
        [Validation(Required=false)]
        public List<GetFundAccountAvailableAmountResponseBodyOriginalCashAmountList> OriginalCashAmountList { get; set; }
        public class GetFundAccountAvailableAmountResponseBodyOriginalCashAmountList : TeaModel {
            /// <summary>
            /// <para>Amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>Currency</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

        }

        /// <summary>
        /// <para>Ecosystem end customer quota</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("QuotaAmount")]
        [Validation(Required=false)]
        public string QuotaAmount { get; set; }

        /// <summary>
        /// <para>Consumed quota of ecosystem end customer</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("QuotaConsumedAmount")]
        [Validation(Required=false)]
        public string QuotaConsumedAmount { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>F96A2D13-7509-5DF9-A60E-E7E3A3CB68E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Uncleared amount (current month uncleared + historical months uncleared)</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UnclearedAmount")]
        [Validation(Required=false)]
        public string UnclearedAmount { get; set; }

    }

}
