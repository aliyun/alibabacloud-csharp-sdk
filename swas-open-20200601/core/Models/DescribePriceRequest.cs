// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The number of Simple Application Server instances to create. Valid values: 1 to 20.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Server.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Server</para>
        /// </summary>
        [NameInMap("CommodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// <para>The capacity of the mounted data cloud disk. Unit: GB. Valid values: 0 to 16380. The value must be a multiple of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The ID of the Simple Application Server instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ad1ae67295445f598017499dc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Buy.</description></item>
        /// </list>
        /// <para>Default value: Buy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPLOAD</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prepaid: subscription.</description></item>
        /// </list>
        /// <para>Example: Prepaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the PriceUnit parameter is set to Month: 1 to 9.</description></item>
        /// <item><description>If the PriceUnit parameter is set to Year: 1 to 5.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The plan ID. You can call the <a href="https://help.aliyun.com/document_detail/189314.html">ListPlans</a> operation to query all plan information in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swas.s1.cxxxxxx3t05</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The pricing unit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: the pricing unit for monthly billing.</description></item>
        /// <item><description>Year: the pricing unit for yearly billing.</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// <para>The promotion option information.</para>
        /// </summary>
        [NameInMap("PromotionOptions")]
        [Validation(Required=false)]
        public DescribePriceRequestPromotionOptions PromotionOptions { get; set; }
        public class DescribePriceRequestPromotionOptions : TeaModel {
            /// <summary>
            /// <para>The activity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12312399123</para>
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// <para>The coupon code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>youhuiquan_promotion_option_id_for_blank</para>
            /// </summary>
            [NameInMap("CouponNo")]
            [Validation(Required=false)]
            public string CouponNo { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the specified Simple Application Server instance. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the list of supported Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
