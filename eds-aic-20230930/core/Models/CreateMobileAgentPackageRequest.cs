// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateMobileAgentPackageRequest : TeaModel {
        /// <summary>
        /// <para>The number of packages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables auto-payment. You must ensure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): An unpaid order is generated. Your account is not charged.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If your account balance is insufficient, you can set this parameter to <c>false</c> to generate an unpaid order. Then, you can log in to the Wuying Cloud Phone management console to pay for the order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The region where the instance is located. Currently, only <c>cn-hangzhou</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The credit amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000.0</para>
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// <para>The credit limit configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CreditConfig")]
        [Validation(Required=false)]
        public string CreditConfig { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudPhone</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The package specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("MobileAgentPackageSpec")]
        [Validation(Required=false)]
        public string MobileAgentPackageSpec { get; set; }

        [NameInMap("PackageSpecId")]
        [Validation(Required=false)]
        public long? PackageSpecId { get; set; }

        /// <summary>
        /// <para>The callback URL to which the user is redirected after a successful payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aim.wuying.aliyun.com/nodes">https://aim.wuying.aliyun.com/nodes</a></para>
        /// </summary>
        [NameInMap("PaidCallbackUrl")]
        [Validation(Required=false)]
        public string PaidCallbackUrl { get; set; }

        /// <summary>
        /// <para>The subscription period. The unit of the period is specified by the <c>PeriodUnit</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// <item><description><para><b>Year</b></para>
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
