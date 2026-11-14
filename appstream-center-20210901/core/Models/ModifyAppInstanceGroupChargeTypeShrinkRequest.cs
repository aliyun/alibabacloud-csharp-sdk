// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupChargeTypeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of IDs of the app instance groups to be modified, in JSON array format. <b>You must and can only specify one item at a time</b>. The resources must belong to the current account, the specified product, and the business region.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupIds")]
        [Validation(Required=false)]
        public string AppInstanceGroupIdsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow automatic payment for this conversion order. Default value: <c>false</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: allows automatic payment for the conversion order.</description></item>
        /// <item><description><c>false</c>: does not allow automatic payment. If an unpaid order is generated, you must complete the payment separately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for this order. We recommend that you explicitly specify this parameter for subscription orders to determine whether to enable auto-renewal.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables auto-renewal.</description></item>
        /// <item><description><c>false</c>: disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the business region where the target app instance group is located. It must be the same as the actual region to which the resource belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The target billing method after conversion. It must be different from the current billing method.</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription.</description></item>
        /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
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
        /// <para>The numeric part of the purchase duration, used together with <c>PeriodUnit</c>. When converting to subscription and a purchase duration is required, you must specify both parameters. For example, <c>1</c> and <c>Month</c> indicate a purchase duration of one month. The specific available purchase durations are determined by the sales rules of the target resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the purchase duration, used together with <c>Period</c>. This parameter is case-sensitive. The defined units are as follows:</para>
        /// <list type="bullet">
        /// <item><description><c>Hour</c>: hour.</description></item>
        /// <item><description><c>Day</c>: day.</description></item>
        /// <item><description><c>Week</c>: week.</description></item>
        /// <item><description><c>Month</c>: month.</description></item>
        /// <item><description><c>Year</c>: year.</description></item>
        /// </list>
        /// <para>These units do not mean that any combination can be purchased for every product. When converting to subscription, select a period supported by the target resource. For example, for a resource that supports monthly purchases, you can set <c>Period</c> to <c>1</c> and <c>PeriodUnit</c> to <c>Month</c>.</para>
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
        /// <item><description><c>CloudApp</c>: Wuying Cloud App.</description></item>
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
        /// <para>The ID of the promotion used for this conversion order. It takes effect only when an order is created and the promotion is applicable. If omitted, no specific coupon is specified. The availability of the promotion is subject to the order result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
