// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccountQuantity")]
        [Validation(Required=false)]
        public long? AccountQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>190311111111****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public Dictionary<string, object> Components { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("CouponPrice")]
        [Validation(Required=false)]
        public float? CouponPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1531191564000</para>
        /// </summary>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202211111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NEW</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.0</para>
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1531191675000</para>
        /// </summary>
        [NameInMap("PaidOn")]
        [Validation(Required=false)]
        public long? PaidOn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PAID</para>
        /// </summary>
        [NameInMap("PayStatus")]
        [Validation(Required=false)]
        public string PayStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("PaymentPrice")]
        [Validation(Required=false)]
        public float? PaymentPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MONTH</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj02****</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj02****-prepay</para>
        /// </summary>
        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

    }

}
