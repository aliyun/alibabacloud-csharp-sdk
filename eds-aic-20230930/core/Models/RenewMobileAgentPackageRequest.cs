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
        /// <item><description><para><b>true</b>: Enables automatic payment. Make sure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Generates an unpaid order.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If your account balance is insufficient, set this parameter to <c>false</c> to generate an unpaid order. You can then pay for the order in the Wuying Mobile Cloud Phone management console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>A list of mobile agent package IDs.</para>
        /// </summary>
        [NameInMap("MobileAgentPackageIds")]
        [Validation(Required=false)]
        public List<string> MobileAgentPackageIds { get; set; }

        /// <summary>
        /// <para>The URL to which a user is redirected after a successful payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aim.wuying.aliyun.com/nodes">https://aim.wuying.aliyun.com/nodes</a></para>
        /// </summary>
        [NameInMap("PaidCallbackUrl")]
        [Validation(Required=false)]
        public string PaidCallbackUrl { get; set; }

        /// <summary>
        /// <para>The renewal period. The <c>PeriodUnit</c> parameter specifies the time unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal period.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b>: month.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: year.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
