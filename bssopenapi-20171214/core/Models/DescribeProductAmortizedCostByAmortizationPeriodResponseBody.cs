// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeProductAmortizedCostByAmortizationPeriodResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProductAmortizedCostByAmortizationPeriodResponseBodyData Data { get; set; }
        public class DescribeProductAmortizedCostByAmortizationPeriodResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185766xxxx</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The data entries.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeProductAmortizedCostByAmortizationPeriodResponseBodyDataItems> Items { get; set; }
            public class DescribeProductAmortizedCostByAmortizationPeriodResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The amount after a discount is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AfterDiscountAmount")]
                [Validation(Required=false)]
                public double? AfterDiscountAmount { get; set; }

                /// <summary>
                /// <para>The amortization month.
                /// Format: YYYYMM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202210</para>
                /// </summary>
                [NameInMap("AmortizationPeriod")]
                [Validation(Required=false)]
                public string AmortizationPeriod { get; set; }

                /// <summary>
                /// <para>The amortization status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>amortized: The cost is amortized.</para>
                /// </description></item>
                /// <item><description><para>unAmortized: The cost is not amortized.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>amortized</para>
                /// </summary>
                [NameInMap("AmortizationStatus")]
                [Validation(Required=false)]
                public string AmortizationStatus { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the bill belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>185xxxxx489</para>
                /// </summary>
                [NameInMap("BillAccountID")]
                [Validation(Required=false)]
                public long? BillAccountID { get; set; }

                /// <summary>
                /// <para>The name of the account to which the bill belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("BillAccountName")]
                [Validation(Required=false)]
                public string BillAccountName { get; set; }

                /// <summary>
                /// <para>The ID of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>185xxxxx489</para>
                /// </summary>
                [NameInMap("BillOwnerID")]
                [Validation(Required=false)]
                public long? BillOwnerID { get; set; }

                /// <summary>
                /// <para>The name of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("BillOwnerName")]
                [Validation(Required=false)]
                public string BillOwnerName { get; set; }

                /// <summary>
                /// <para>The business type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trusteeship</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The billing cycle.
                /// Format: YYYYMM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202210</para>
                /// </summary>
                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public string ConsumePeriod { get; set; }

                /// <summary>
                /// <para>The amount that is amortized in the current period, after a discount is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationAfterDiscountAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationAfterDiscountAmount { get; set; }

                /// <summary>
                /// <para>The amount deducted by cash coupons that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by coupons that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount paid by prepaid card that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount that is amortized in the current period. This amount can be invoiced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationExpenditureAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The discount that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationInvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The pretax amount that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The amount rounded down that is amortized in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationRoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The amount deducted by cash coupons.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by coupons.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount paid by prepaid card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? DeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount. This amount can be invoiced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExpenditureAmount")]
                [Validation(Required=false)]
                public double? ExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InvoiceDiscount")]
                [Validation(Required=false)]
                public double? InvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The pretax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PretaxAmount")]
                [Validation(Required=false)]
                public double? PretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PretaxGrossAmount")]
                [Validation(Required=false)]
                public double? PretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The amount that was amortized before the beginning of the period, after a discount is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedAfterDiscountAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedAfterDiscountAmount { get; set; }

                /// <summary>
                /// <para>The amount deducted by cash coupons that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by coupons that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedDeductedByCoupons")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount paid by prepaid card that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount that was amortized before the beginning of the period. This amount can be invoiced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedExpenditureAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The discount that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedInvoiceDiscount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedInvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The pretax amount that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedPretaxAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedPretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedPretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The amount rounded down that was amortized before the beginning of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedRoundDownDiscount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedRoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The details of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云数据库RDS</para>
                /// </summary>
                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                /// <summary>
                /// <para>The code of the product details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductDetailCode")]
                [Validation(Required=false)]
                public string ProductDetailCode { get; set; }

                /// <summary>
                /// <para>The product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云数据库RDS</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The unamortized amount at the end of the period, after a discount is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationAfterDiscountAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationAfterDiscountAmount { get; set; }

                /// <summary>
                /// <para>The unamortized amount deducted by cash coupons at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The unamortized amount deducted by coupons at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The unamortized amount paid by prepaid card at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The unamortized expenditure amount at the end of the period. This amount can be invoiced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationExpenditureAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The unamortized discount at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationInvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The unamortized pretax amount at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationPretaxAmount { get; set; }

                /// <summary>
                /// <para>The unamortized pretax gross amount at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationPretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The unamortized amount rounded down at the end of the period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationRoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The amount rounded down.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RoundDownDiscount")]
                [Validation(Required=false)]
                public double? RoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The subscription type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Subscription: subscription.</para>
                /// </description></item>
                /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used to query the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESEgoQCg4KCmdtdF9jcmVhdGUEARgBIkgKCQBwhGmPcAEAAAo7AzYAAAAxTDgwMDcxMjg3ZDJhNmM3ZDguTDgwMDAwMDAwMDAwMzE1MTIuTDgwMDcyZDMyZTJkYzg3N2U</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
