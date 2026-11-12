// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateOrderRequest : TeaModel {
        /// <summary>
        /// <para>The additional parameter for business information.</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public CreateOrderRequestBusinessInfo BusinessInfo { get; set; }
        public class CreateOrderRequestBusinessInfo : TeaModel {
            /// <summary>
            /// <para>The language environment. Default value: Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("AliyunLang")]
            [Validation(Required=false)]
            public string AliyunLang { get; set; }

            /// <summary>
            /// <para>The order source.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("OrderSource")]
            [Validation(Required=false)]
            public string OrderSource { get; set; }

            /// <summary>
            /// <para>The promotion option information.</para>
            /// </summary>
            [NameInMap("PromotionOptions")]
            [Validation(Required=false)]
            public CreateOrderRequestBusinessInfoPromotionOptions PromotionOptions { get; set; }
            public class CreateOrderRequestBusinessInfoPromotionOptions : TeaModel {
                /// <summary>
                /// <para>The activity ID.</para>
                /// </summary>
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <para>The promotion filter.</para>
                /// </summary>
                [NameInMap("PromotionFilter")]
                [Validation(Required=false)]
                public CreateOrderRequestBusinessInfoPromotionOptionsPromotionFilter PromotionFilter { get; set; }
                public class CreateOrderRequestBusinessInfoPromotionOptionsPromotionFilter : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to use a voucher. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: A voucher is used.</description></item>
                    /// <item><description><b>false</b>: No voucher is used.
                    /// Default value: <b>false</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("UseCoupon")]
                    [Validation(Required=false)]
                    public bool? UseCoupon { get; set; }

                }

                /// <summary>
                /// <para>The promotion option code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>youhui_quan</para>
                /// </summary>
                [NameInMap("PromotionOptionCode")]
                [Validation(Required=false)]
                public string PromotionOptionCode { get; set; }

                /// <summary>
                /// <para>The coupon ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>802681580959</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to use a voucher. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A voucher is used.</description></item>
            /// <item><description><b>false</b>: No voucher is used.
            /// Default value: <b>false</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseCoupon")]
            [Validation(Required=false)]
            public bool? UseCoupon { get; set; }

            /// <summary>
            /// <para>The WeChat product type.</para>
            /// </summary>
            [NameInMap("WeChatProType")]
            [Validation(Required=false)]
            public string WeChatProType { get; set; }

            /// <summary>
            /// <para>The channel cookie value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IaEvKFpwjO1lMRzGWyJdT9KWob7ruIK%2F2zTcdPRkQ%2BIDp5GIJSQT%2FL3qUUcjJ3KQfud3NrMUlEqLaJWWIVwJgw%3D%3D</para>
            /// </summary>
            [NameInMap("lx_channel_cookie_value")]
            [Validation(Required=false)]
            public string LxChannelCookieValue { get; set; }

        }

        /// <summary>
        /// <para>The order configuration information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public CreateOrderRequestCommodity Commodity { get; set; }
        public class CreateOrderRequestCommodity : TeaModel {
            /// <summary>
            /// <para>The number of Simple Application Server instances to create. Valid values: 1 to 20. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <para>Specifies whether automatic payment is enabled for the order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Automatic payment.</description></item>
            /// <item><description><b>false</b>: No automatic payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal upon expiration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Auto-renewal is enabled.</description></item>
            /// <item><description>false: Auto-renewal is disabled.
            /// Default value: false.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If PeriodUnit is set to Year: 1, 2, and 3.</description></item>
            /// <item><description>If PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.
            /// Default value: 1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Server</para>
            /// </summary>
            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            /// <summary>
            /// <para>The size of the mounted data cloud disk. Unit: GB. Valid values: 0 to 16380. The value must be a multiple of 20. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            /// <summary>
            /// <para>The image ID. You can call the <a href="https://help.aliyun.com/document_detail/189313.html">ListImages</a> operation to query available image IDs in a specified region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3e8eea0c00a04ff0b34a3ad8f1df455a</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The IDs of the Simple Application Server instances.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prepaid: subscription.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The subscription period. Valid values: 1 to 20. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Month: monthly billing.</description></item>
            /// <item><description>Year: yearly billing.
            /// Default value: Month.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The plan ID. You can call the <a href="https://help.aliyun.com/document_detail/189314.html">ListPlans</a> operation to query all plans in a specified region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swas.s.c2m1s30b1.linux</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

        }

        /// <summary>
        /// <para>The coupon code. Default value: <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>772339720881</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The request source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OpenApi</b>: The request is sent from OpenAPI.</description></item>
        /// <item><description><b>mongo_buy</b>: The request is sent from the console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Buy</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Buy
        /// Default value: Buy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Buy</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
