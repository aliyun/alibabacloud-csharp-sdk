// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceAmortizedCostByAmortizationPeriodResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
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
        public DescribeInstanceAmortizedCostByAmortizationPeriodResponseBodyData Data { get; set; }
        public class DescribeInstanceAmortizedCostByAmortizationPeriodResponseBodyData : TeaModel {
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
            /// <para>The data entries returned.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInstanceAmortizedCostByAmortizationPeriodResponseBodyDataItems> Items { get; set; }
            public class DescribeInstanceAmortizedCostByAmortizationPeriodResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The allocation month. Format: YYYYMM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202210</para>
                /// </summary>
                [NameInMap("AmortizationPeriod")]
                [Validation(Required=false)]
                public string AmortizationPeriod { get; set; }

                /// <summary>
                /// <para>The allocation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>amortized: allocated</description></item>
                /// <item><description>unAmortized: not allocated</description></item>
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
                /// <para>The ID of the account to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>185xxxxx489</para>
                /// </summary>
                [NameInMap("BillOwnerID")]
                [Validation(Required=false)]
                public long? BillOwnerID { get; set; }

                /// <summary>
                /// <para>The name of the account to which the resource belongs.</para>
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
                /// <para>The billing cycle. Format: YYYYMM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202210</para>
                /// </summary>
                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public string ConsumePeriod { get; set; }

                /// <summary>
                /// <para>The cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Not allocated</para>
                /// </summary>
                [NameInMap("CostUnit")]
                [Validation(Required=false)]
                public string CostUnit { get; set; }

                /// <summary>
                /// <para>The code of the cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("CostUnitCode")]
                [Validation(Required=false)]
                public string CostUnitCode { get; set; }

                /// <summary>
                /// <para>The amount deducted by using vouchers and allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using coupons and allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using prepaid cards and allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount allocated to the current allocation month. Invoicing is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationExpenditureAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The discount amount allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationInvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The pretax amount allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The round-off amount allocated to the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationRoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The amount deducted by using vouchers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using coupons.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using prepaid cards.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? DeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount. Invoicing is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExpenditureAmount")]
                [Validation(Required=false)]
                public double? ExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-kjhdskjgshfdlkjfdh</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The public IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34.xx.x.x</para>
                /// </summary>
                [NameInMap("InternetIP")]
                [Validation(Required=false)]
                public string InternetIP { get; set; }

                /// <summary>
                /// <para>The private IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.xx.xx.xx</para>
                /// </summary>
                [NameInMap("IntranetIP")]
                [Validation(Required=false)]
                public string IntranetIP { get; set; }

                /// <summary>
                /// <para>The discount amount.</para>
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
                /// <para>The amount deducted by using vouchers and allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using coupons and allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedDeductedByCoupons")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using prepaid cards and allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount allocated before the allocation month. Invoicing is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedExpenditureAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The discount amount allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedInvoiceDiscount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedInvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The pretax amount allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedPretaxAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedPretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedPretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The round-off amount allocated before the current allocation month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviouslyAmortizedRoundDownDiscount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedRoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The code of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The specific service resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                /// <summary>
                /// <para>The code of the specific service resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductDetailCode")]
                [Validation(Required=false)]
                public string ProductDetailCode { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The amount deducted by using vouchers and to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using coupons and to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted by using prepaid cards and to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The expenditure amount to be allocated to one or more future allocation months. Invoicing is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationExpenditureAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationExpenditureAmount { get; set; }

                /// <summary>
                /// <para>The discount amount to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationInvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The pretax amount to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationPretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationPretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The round-off amount to be allocated to one or more future allocation months.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationRoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default resource group</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <para>The round-off amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RoundDownDiscount")]
                [Validation(Required=false)]
                public double? RoundDownDiscount { get; set; }

                /// <summary>
                /// <para>The name of the account to which the split item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test**1122</para>
                /// </summary>
                [NameInMap("SplitAccountName")]
                [Validation(Required=false)]
                public string SplitAccountName { get; set; }

                /// <summary>
                /// <para>The ID of the split item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-28bycvyb4</para>
                /// </summary>
                [NameInMap("SplitItemID")]
                [Validation(Required=false)]
                public string SplitItemID { get; set; }

                /// <summary>
                /// <para>The name of the split item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iZ28bycvyb4Z</para>
                /// </summary>
                [NameInMap("SplitItemName")]
                [Validation(Required=false)]
                public string SplitItemName { get; set; }

                /// <summary>
                /// <para>The name of the specific service resource to which the split item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("SplitProductDetail")]
                [Validation(Required=false)]
                public string SplitProductDetail { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Subscription: the subscription billing method</description></item>
                /// <item><description>PayAsYouGo: the pay-as-you-go billing method</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                /// <summary>
                /// <para>The tag of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

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
            /// <para>The position from which the results started to return. The parameter must be left empty or set to the value of the NextToken parameter returned from the last call. Otherwise, an error is returned. If this parameter is left empty, data is queried from the beginning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESEgoQCg4KCmdtdF9jcmVhdGUEARgBIkgKCQBwhGmPcAEAAAo7AzYAAAAxTDgwMDcxMjg3ZDJhNmM3ZDguTDgwMDAwMDAwMDAwMzE1MTIuTDgwMDcyZDMyZTJkYzg3N2U</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
