// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceAmortizedCostByConsumePeriodResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInstanceAmortizedCostByConsumePeriodResponseBodyData Data { get; set; }
        public class DescribeInstanceAmortizedCostByConsumePeriodResponseBodyData : TeaModel {
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInstanceAmortizedCostByConsumePeriodResponseBodyDataItems> Items { get; set; }
            public class DescribeInstanceAmortizedCostByConsumePeriodResponseBodyDataItems : TeaModel {
                [NameInMap("AmortizationPeriod")]
                [Validation(Required=false)]
                public string AmortizationPeriod { get; set; }

                [NameInMap("AmortizationStatus")]
                [Validation(Required=false)]
                public string AmortizationStatus { get; set; }

                [NameInMap("BillAccountID")]
                [Validation(Required=false)]
                public long? BillAccountID { get; set; }

                [NameInMap("BillAccountName")]
                [Validation(Required=false)]
                public string BillAccountName { get; set; }

                [NameInMap("BillOwnerID")]
                [Validation(Required=false)]
                public long? BillOwnerID { get; set; }

                [NameInMap("BillOwnerName")]
                [Validation(Required=false)]
                public string BillOwnerName { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public string ConsumePeriod { get; set; }

                [NameInMap("CostUnit")]
                [Validation(Required=false)]
                public string CostUnit { get; set; }

                [NameInMap("CostUnitCode")]
                [Validation(Required=false)]
                public string CostUnitCode { get; set; }

                [NameInMap("CurrentAmortizationDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCashCoupons { get; set; }

                [NameInMap("CurrentAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCoupons { get; set; }

                [NameInMap("CurrentAmortizationDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByPrepaidCard { get; set; }

                [NameInMap("CurrentAmortizationExpenditureAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationExpenditureAmount { get; set; }

                [NameInMap("CurrentAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationInvoiceDiscount { get; set; }

                [NameInMap("CurrentAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxAmount { get; set; }

                [NameInMap("CurrentAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxGrossAmount { get; set; }

                [NameInMap("CurrentAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationRoundDownDiscount { get; set; }

                [NameInMap("DeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCashCoupons { get; set; }

                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCoupons { get; set; }

                [NameInMap("DeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? DeductedByPrepaidCard { get; set; }

                [NameInMap("ExpenditureAmount")]
                [Validation(Required=false)]
                public double? ExpenditureAmount { get; set; }

                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                [NameInMap("InternetIP")]
                [Validation(Required=false)]
                public string InternetIP { get; set; }

                [NameInMap("IntranetIP")]
                [Validation(Required=false)]
                public string IntranetIP { get; set; }

                [NameInMap("InvoiceDiscount")]
                [Validation(Required=false)]
                public double? InvoiceDiscount { get; set; }

                [NameInMap("PretaxAmount")]
                [Validation(Required=false)]
                public double? PretaxAmount { get; set; }

                [NameInMap("PretaxGrossAmount")]
                [Validation(Required=false)]
                public double? PretaxGrossAmount { get; set; }

                [NameInMap("PreviouslyAmortizedDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByCashCoupons { get; set; }

                [NameInMap("PreviouslyAmortizedDeductedByCoupons")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByCoupons { get; set; }

                [NameInMap("PreviouslyAmortizedDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedDeductedByPrepaidCard { get; set; }

                [NameInMap("PreviouslyAmortizedExpenditureAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedExpenditureAmount { get; set; }

                [NameInMap("PreviouslyAmortizedInvoiceDiscount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedInvoiceDiscount { get; set; }

                [NameInMap("PreviouslyAmortizedPretaxAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedPretaxAmount { get; set; }

                [NameInMap("PreviouslyAmortizedPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedPretaxGrossAmount { get; set; }

                [NameInMap("PreviouslyAmortizedRoundDownDiscount")]
                [Validation(Required=false)]
                public double? PreviouslyAmortizedRoundDownDiscount { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                [NameInMap("ProductDetailCode")]
                [Validation(Required=false)]
                public string ProductDetailCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RemainingAmortizationDeductedByCashCoupons")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByCashCoupons { get; set; }

                [NameInMap("RemainingAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByCoupons { get; set; }

                [NameInMap("RemainingAmortizationDeductedByPrepaidCard")]
                [Validation(Required=false)]
                public double? RemainingAmortizationDeductedByPrepaidCard { get; set; }

                [NameInMap("RemainingAmortizationExpenditureAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationExpenditureAmount { get; set; }

                [NameInMap("RemainingAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationInvoiceDiscount { get; set; }

                [NameInMap("RemainingAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationPretaxAmount { get; set; }

                [NameInMap("RemainingAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationPretaxGrossAmount { get; set; }

                [NameInMap("RemainingAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? RemainingAmortizationRoundDownDiscount { get; set; }

                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                [NameInMap("RoundDownDiscount")]
                [Validation(Required=false)]
                public double? RoundDownDiscount { get; set; }

                [NameInMap("SplitAccountName")]
                [Validation(Required=false)]
                public string SplitAccountName { get; set; }

                [NameInMap("SplitItemID")]
                [Validation(Required=false)]
                public string SplitItemID { get; set; }

                [NameInMap("SplitItemName")]
                [Validation(Required=false)]
                public string SplitItemName { get; set; }

                [NameInMap("SplitProductDetail")]
                [Validation(Required=false)]
                public string SplitProductDetail { get; set; }

                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
