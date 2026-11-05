// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The list of delivery group IDs to be modified, in JSON array format. <b>You must and can only specify one item per request</b>. The resources must belong to the current account, the specified product, and the business region.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow automatic payment for the conversion order. Default value: <c>false</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Automatic payment is allowed.</description></item>
        /// <item><description><c>false</c>: Automatic payment is not allowed. If an unpaid order is generated, you must complete the payment separately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the order. We recommend that you explicitly specify this parameter for subscription orders to determine whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Auto-renewal is enabled.</description></item>
        /// <item><description><c>false</c>: Auto-renewal is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The business region ID of the target delivery group. It must be the same as the actual region to which the resource belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The target billing method after conversion. It must be different from the current billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription</description></item>
        /// <item><description><c>PostPaid</c>: pay-as-you-go</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The numeric part of the purchase duration, used together with <c>PeriodUnit</c>. When converting to subscription and a purchase duration is required, specify both parameters. For example, <c>1</c> and <c>Month</c> indicate a purchase duration of one month. The available purchase durations are determined by the sales rules of the target resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the purchase duration, used together with <c>Period</c>. This parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Hour</c>: hour</description></item>
        /// <item><description><c>Day</c>: day</description></item>
        /// <item><description><c>Week</c>: week</description></item>
        /// <item><description><c>Month</c>: month</description></item>
        /// <item><description><c>Year</c>: year</description></item>
        /// </list>
        /// <para>These units do not mean that any combination is available for every product. When converting to subscription, select a period supported by the target resource. For example, for a resource that supports monthly purchase, you can set <c>Period</c> to <c>1</c> and <c>PeriodUnit</c> to <c>Month</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The product type. Set this parameter to the following fixed value when you call the operation:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud Application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the promotion used for the conversion order. It takes effect only when an order is created and the promotion is applicable. If omitted, no specific coupon is specified. The availability of the promotion is subject to the order result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
