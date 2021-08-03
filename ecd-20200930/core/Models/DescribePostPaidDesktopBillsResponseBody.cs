// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePostPaidDesktopBillsResponseBody : TeaModel {
        [NameInMap("PostPaidDesktopsBillsUrl")]
        [Validation(Required=false)]
        public string PostPaidDesktopsBillsUrl { get; set; }

        [NameInMap("PostPaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PostPaidDesktopsTotalAmount")]
        [Validation(Required=false)]
        public float? PostPaidDesktopsTotalAmount { get; set; }

        [NameInMap("Bills")]
        [Validation(Required=false)]
        public List<DescribePostPaidDesktopBillsResponseBodyBills> Bills { get; set; }
        public class DescribePostPaidDesktopBillsResponseBodyBills : TeaModel {
            [NameInMap("BillId")]
            [Validation(Required=false)]
            public string BillId { get; set; }

            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public string DiscountPrice { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("PriceUnit")]
            [Validation(Required=false)]
            public string PriceUnit { get; set; }

            [NameInMap("CashPayment")]
            [Validation(Required=false)]
            public string CashPayment { get; set; }

            [NameInMap("Payment")]
            [Validation(Required=false)]
            public string Payment { get; set; }

            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public string OriginalPrice { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ProductDetail")]
            [Validation(Required=false)]
            public string ProductDetail { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

            [NameInMap("GoldNote")]
            [Validation(Required=false)]
            public string GoldNote { get; set; }

            [NameInMap("UsageUnit")]
            [Validation(Required=false)]
            public string UsageUnit { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("BillStartTime")]
            [Validation(Required=false)]
            public string BillStartTime { get; set; }

            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ChargeItem")]
            [Validation(Required=false)]
            public string ChargeItem { get; set; }

            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            [NameInMap("ConsumeTime")]
            [Validation(Required=false)]
            public string ConsumeTime { get; set; }

            [NameInMap("ConsumeType")]
            [Validation(Required=false)]
            public string ConsumeType { get; set; }

            [NameInMap("BillEndTime")]
            [Validation(Required=false)]
            public string BillEndTime { get; set; }

        }

    }

}
