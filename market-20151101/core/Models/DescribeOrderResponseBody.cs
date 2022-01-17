// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeOrderResponseBody : TeaModel {
        [NameInMap("AccountQuantity")]
        [Validation(Required=false)]
        public long? AccountQuantity { get; set; }

        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public Dictionary<string, object> Components { get; set; }

        [NameInMap("CouponPrice")]
        [Validation(Required=false)]
        public float? CouponPrice { get; set; }

        [NameInMap("CreatedOn")]
        [Validation(Required=false)]
        public long? CreatedOn { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public DescribeOrderResponseBodyInstanceIds InstanceIds { get; set; }
        public class DescribeOrderResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }
        };

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        [NameInMap("PaidOn")]
        [Validation(Required=false)]
        public long? PaidOn { get; set; }

        [NameInMap("PayStatus")]
        [Validation(Required=false)]
        public string PayStatus { get; set; }

        [NameInMap("PaymentPrice")]
        [Validation(Required=false)]
        public float? PaymentPrice { get; set; }

        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupplierCompanyName")]
        [Validation(Required=false)]
        public string SupplierCompanyName { get; set; }

        [NameInMap("SupplierTelephones")]
        [Validation(Required=false)]
        public DescribeOrderResponseBodySupplierTelephones SupplierTelephones { get; set; }
        public class DescribeOrderResponseBodySupplierTelephones : TeaModel {
            [NameInMap("Telephone")]
            [Validation(Required=false)]
            public List<string> Telephone { get; set; }
        };

        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

    }

}
