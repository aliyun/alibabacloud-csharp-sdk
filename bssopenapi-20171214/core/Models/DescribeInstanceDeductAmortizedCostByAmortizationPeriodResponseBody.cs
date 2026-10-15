// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyData Data { get; set; }
        public class DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyData : TeaModel {
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyDataItems> Items { get; set; }
            public class DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyDataItems : TeaModel {
                [NameInMap("AmortizationPeriod")]
                [Validation(Required=false)]
                public string AmortizationPeriod { get; set; }

                [NameInMap("AmortizationPeriodDay")]
                [Validation(Required=false)]
                public string AmortizationPeriodDay { get; set; }

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

                [NameInMap("CurrentAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCoupons { get; set; }

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

                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCoupons { get; set; }

                [NameInMap("InstanceConfig")]
                [Validation(Required=false)]
                public string InstanceConfig { get; set; }

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

                [NameInMap("ReferFrInstanceID")]
                [Validation(Required=false)]
                public string ReferFrInstanceID { get; set; }

                [NameInMap("ReferFrOwnerID")]
                [Validation(Required=false)]
                public string ReferFrOwnerID { get; set; }

                [NameInMap("ReferFrProductDetailCode")]
                [Validation(Required=false)]
                public string ReferFrProductDetailCode { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

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

                [NameInMap("UnusedAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? UnusedAmortizationDeductedByCoupons { get; set; }

                [NameInMap("UnusedAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationInvoiceDiscount { get; set; }

                [NameInMap("UnusedAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationPretaxAmount { get; set; }

                [NameInMap("UnusedAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationPretaxGrossAmount { get; set; }

                [NameInMap("UnusedAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationRoundDownDiscount { get; set; }

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
