// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSplitItemBillResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSplitItemBillResponseBodyData Data { get; set; }
        public class DescribeSplitItemBillResponseBodyData : TeaModel {
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSplitItemBillResponseBodyDataItems> Items { get; set; }
            public class DescribeSplitItemBillResponseBodyDataItems : TeaModel {
                public float? AdjustAmount { get; set; }
                public string BillAccountID { get; set; }
                public string BillAccountName { get; set; }
                public string BillingDate { get; set; }
                public string BillingItem { get; set; }
                public string BillingItemCode { get; set; }
                public string BillingType { get; set; }
                public string BizType { get; set; }
                public float? CashAmount { get; set; }
                public string CommodityCode { get; set; }
                public string CostUnit { get; set; }
                public string Currency { get; set; }
                public float? DeductedByCashCoupons { get; set; }
                public float? DeductedByCoupons { get; set; }
                public float? DeductedByPrepaidCard { get; set; }
                public string DeductedByResourcePackage { get; set; }
                public string InstanceConfig { get; set; }
                public string InstanceID { get; set; }
                public string InstanceSpec { get; set; }
                public string InternetIP { get; set; }
                public string IntranetIP { get; set; }
                public float? InvoiceDiscount { get; set; }
                public string Item { get; set; }
                public string ItemName { get; set; }
                public string ListPrice { get; set; }
                public string ListPriceUnit { get; set; }
                public string NickName { get; set; }
                public float? OutstandingAmount { get; set; }
                public string OwnerID { get; set; }
                public float? PaymentAmount { get; set; }
                public string PipCode { get; set; }
                public float? PretaxAmount { get; set; }
                public float? PretaxGrossAmount { get; set; }
                public string ProductCode { get; set; }
                public string ProductDetail { get; set; }
                public string ProductName { get; set; }
                public string ProductType { get; set; }
                public string Region { get; set; }
                public string ResourceGroup { get; set; }
                public string ServicePeriod { get; set; }
                public string ServicePeriodUnit { get; set; }
                public string SplitAccountID { get; set; }
                public string SplitAccountName { get; set; }
                public string SplitBillingCycle { get; set; }
                public string SplitBillingDate { get; set; }
                public string SplitCommodityCode { get; set; }
                public string SplitItemID { get; set; }
                public string SplitItemName { get; set; }
                public string SplitProductDetail { get; set; }
                public string SubscriptionType { get; set; }
                public string Tag { get; set; }
                public string Usage { get; set; }
                public string UsageUnit { get; set; }
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
        };

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
