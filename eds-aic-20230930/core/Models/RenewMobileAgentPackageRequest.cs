// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RenewMobileAgentPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b> (default): Only an order is generated and no payment is deducted.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the balance of your payment method is insufficient, set this parameter to false to generate an unpaid order. You can log on to the Wuying Cloud Phone console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The idempotency key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of resource plan IDs.</para>
        /// </summary>
        [NameInMap("MobileAgentPackageIds")]
        [Validation(Required=false)]
        public List<string> MobileAgentPackageIds { get; set; }

        /// <summary>
        /// <para>The redirect URL for the payment success page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aim.wuying.aliyun.com/nodes">https://aim.wuying.aliyun.com/nodes</a></para>
        /// </summary>
        [NameInMap("PaidCallbackUrl")]
        [Validation(Required=false)]
        public string PaidCallbackUrl { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource. The unit is specified by PeriodUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: Month.</description></item>
        /// <item><description><b>Year</b>: Year.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the promotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
