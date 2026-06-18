// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetRenewalRateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetRenewalRateListResponseBodyData> Data { get; set; }
        public class GetRenewalRateListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The adjusted customer acquisition amount due for renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CustomerAdjustedRenewalAmountDue")]
            [Validation(Required=false)]
            public double? CustomerAdjustedRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The customer acquisition amount for new purchases, upgrades, and refunds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CustomerOtherBillAmount")]
            [Validation(Required=false)]
            public double? CustomerOtherBillAmount { get; set; }

            /// <summary>
            /// <para>The customer acquisition amount due for renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalCustomerRenewalAmountDue")]
            [Validation(Required=false)]
            public double? FinalCustomerRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The customer acquisition commission renewal rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("FinalCustomerRenewalRate")]
            [Validation(Required=false)]
            public double? FinalCustomerRenewalRate { get; set; }

            /// <summary>
            /// <para>The customer acquisition renewed amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalCustomerRenewedAmount")]
            [Validation(Required=false)]
            public double? FinalCustomerRenewedAmount { get; set; }

            /// <summary>
            /// <para>The total amount for new purchases, upgrades, and refunds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalOtherBillAmount")]
            [Validation(Required=false)]
            public double? FinalOtherBillAmount { get; set; }

            /// <summary>
            /// <para>The final amount due for renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalRenewalAmountDue")]
            [Validation(Required=false)]
            public double? FinalRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The final commission renewal rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("FinalRenewalRate")]
            [Validation(Required=false)]
            public double? FinalRenewalRate { get; set; }

            /// <summary>
            /// <para>The final renewed amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalRenewedAmount")]
            [Validation(Required=false)]
            public double? FinalRenewedAmount { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition amount due for renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalSubPartnerRenewalAmountDue")]
            [Validation(Required=false)]
            public double? FinalSubPartnerRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition commission renewal rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("FinalSubPartnerRenewalRate")]
            [Validation(Required=false)]
            public double? FinalSubPartnerRenewalRate { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition renewed amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FinalSubPartnerRenewedAmount")]
            [Validation(Required=false)]
            public double? FinalSubPartnerRenewedAmount { get; set; }

            /// <summary>
            /// <para>The fiscal year and quarter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025Q4</para>
            /// </summary>
            [NameInMap("FiscalYearAndQuarter")]
            [Validation(Required=false)]
            public string FiscalYearAndQuarter { get; set; }

            /// <summary>
            /// <para>The partner PID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P123423453</para>
            /// </summary>
            [NameInMap("MasterPid")]
            [Validation(Required=false)]
            public string MasterPid { get; set; }

            /// <summary>
            /// <para>The partner PID name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX有限公司</para>
            /// </summary>
            [NameInMap("MasterPidName")]
            [Validation(Required=false)]
            public string MasterPidName { get; set; }

            /// <summary>
            /// <para>The customer acquisition commission renewal rate including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("SpecialCustomerRenewRatio")]
            [Validation(Required=false)]
            public double? SpecialCustomerRenewRatio { get; set; }

            /// <summary>
            /// <para>The customer acquisition amount due for renewal including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpecialCustomerRenewalAmountDue")]
            [Validation(Required=false)]
            public double? SpecialCustomerRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The customer acquisition renewed amount including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpecialCustomerRenewedAmount")]
            [Validation(Required=false)]
            public double? SpecialCustomerRenewedAmount { get; set; }

            /// <summary>
            /// <para>The final quarterly commission renewal rate including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("SpecialFinalRenewRatio")]
            [Validation(Required=false)]
            public double? SpecialFinalRenewRatio { get; set; }

            /// <summary>
            /// <para>The final quarterly commission amount due for renewal including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpecialFinalRenewalAmountDue")]
            [Validation(Required=false)]
            public double? SpecialFinalRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The final quarterly commission renewed amount including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpecialFinalRenewedAmount")]
            [Validation(Required=false)]
            public double? SpecialFinalRenewedAmount { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition commission renewal rate including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("SpecialSubPartnerRenewRatio")]
            [Validation(Required=false)]
            public double? SpecialSubPartnerRenewRatio { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition amount due for renewal including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpecialSubPartnerRenewalAmountDue")]
            [Validation(Required=false)]
            public double? SpecialSubPartnerRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition renewed amount including special approvals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpecialSubPartnerRenewedAmount")]
            [Validation(Required=false)]
            public double? SpecialSubPartnerRenewedAmount { get; set; }

            /// <summary>
            /// <para>The adjusted sub-partner acquisition amount due for renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SubPartnerAdjustedRenewalAmountDue")]
            [Validation(Required=false)]
            public double? SubPartnerAdjustedRenewalAmountDue { get; set; }

            /// <summary>
            /// <para>The sub-partner acquisition amount for new purchases, upgrades, and refunds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SubPartnerOtherBillAmount")]
            [Validation(Required=false)]
            public double? SubPartnerOtherBillAmount { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
