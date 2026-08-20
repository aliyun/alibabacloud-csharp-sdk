// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccountQuantity")]
        [Validation(Required=false)]
        public long? AccountQuantity { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud user (aliyunPK).</para>
        /// 
        /// <b>Example:</b>
        /// <para>190311111111****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The order component information. The metric description for the parameters in the example is as follows:</para>
        /// <list type="bullet">
        /// <item><description>package_quantity: the number of usage times (a component specific to API products)</description></item>
        /// <item><description>package_version: the version</description></item>
        /// <item><description>ord_time: the duration</description></item>
        /// <item><description>order_num: the quantity</description></item>
        /// <item><description>code: the component code</description></item>
        /// <item><description>globarKey: the component key</description></item>
        /// <item><description>name: the component name</description></item>
        /// <item><description>value: the component value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;package_quantity&quot;: { &quot;code&quot;: &quot;package_quantity&quot;, &quot;globarKey&quot;: &quot;cmapi014302_package_quantity_package_quantity_10000&quot;, &quot;name&quot;: &quot;10000次&quot;, &quot;value&quot;: &quot;10000&quot; }, &quot;package_version&quot;: { &quot;code&quot;: &quot;package_version&quot;, &quot;globarKey&quot;: &quot;cmapi014302_package_version_package_version_yuncode830200000&quot;, &quot;name&quot;: &quot;0元／10000次&quot;, &quot;value&quot;: &quot;yuncode830200000&quot; }, &quot;ord_time&quot;: { &quot;code&quot;: &quot;ord_time&quot;, &quot;globarKey&quot;: &quot;cmapi014302_ord_time_ord_time_6:Month&quot;, &quot;name&quot;: &quot;6个月&quot;, &quot;value&quot;: &quot;6:Month&quot; }, &quot;order_num&quot;: { &quot;code&quot;: &quot;order_num&quot;, &quot;globarKey&quot;: &quot;cmapi014302_order_num_order_num_1&quot;, &quot;name&quot;: &quot;1&quot;, &quot;value&quot;: &quot;1&quot; } }</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public Dictionary<string, object> Components { get; set; }

        /// <summary>
        /// <para>The amount of vouchers used, in CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("CouponPrice")]
        [Validation(Required=false)]
        public float? CouponPrice { get; set; }

        /// <summary>
        /// <para>The time when the order was placed.</para>
        /// 
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
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202211111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The order status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Normal.</description></item>
        /// <item><description>REFUND: Refunded.</description></item>
        /// <item><description>DELETE: Voided.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NEW: New purchase order.</description></item>
        /// <item><description>RENEW: Renewal order.</description></item>
        /// <item><description>TRIAL: Trial order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NEW</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The original price of the order, in CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0</para>
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// <para>The payment time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1531191675000</para>
        /// </summary>
        [NameInMap("PaidOn")]
        [Validation(Required=false)]
        public long? PaidOn { get; set; }

        /// <summary>
        /// <para>The payment status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAID: Paid.</description></item>
        /// <item><description>UNPAID: Unpaid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAID</para>
        /// </summary>
        [NameInMap("PayStatus")]
        [Validation(Required=false)]
        public string PayStatus { get; set; }

        /// <summary>
        /// <para>The actual payment amount, in CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("PaymentPrice")]
        [Validation(Required=false)]
        public float? PaymentPrice { get; set; }

        /// <summary>
        /// <para>The time unit for prepaid orders. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTH: one month</description></item>
        /// <item><description>SEASON: one quarter</description></item>
        /// <item><description>HALFYEAR: half a year</description></item>
        /// <item><description>YEAR: one year</description></item>
        /// <item><description>TWOYEARS: two years</description></item>
        /// <item><description>ONCE: one-time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MONTH</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmgj02****</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The name of the subscribed product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saas服务产品</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The specification code of the subscribed product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmgj02****-prepay</para>
        /// </summary>
        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        /// <summary>
        /// <para>The quantity of the subscribed product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The company name of the seller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**科技股份有限公司</para>
        /// </summary>
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
        /// <para>The total payable amount of the order, in CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

    }

}
