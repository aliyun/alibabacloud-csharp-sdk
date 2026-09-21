// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateMobileAgentPackageRequest : TeaModel {
        /// <summary>
        /// <para>The number of resource plans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b> (default): Only an order is generated. No payment is made.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If your payment method has an insufficient balance, set this parameter to false. An unpaid order is generated. You can log on to the Elastic Cloud Phone console to complete the payment.</para>
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
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b> (default): Auto-renewal is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The region where the instance resides. Currently, only cn-hangzhou is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The credit quota.</para>
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
        /// <para>The name of the node instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudPhone</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The resource plan specification.</para>
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
        /// <para>The redirect URL after a successful payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aim.wuying.aliyun.com/nodes">https://aim.wuying.aliyun.com/nodes</a></para>
        /// </summary>
        [NameInMap("PaidCallbackUrl")]
        [Validation(Required=false)]
        public string PaidCallbackUrl { get; set; }

        /// <summary>
        /// <para>The duration for which you want to purchase the resource. The unit is specified by <c>PeriodUnit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the duration for which you want to purchase the resource.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: month.</description></item>
        /// <item><description><b>Year</b>: year.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the promotional campaign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateMobileAgentPackageRequestTag> Tag { get; set; }
        public class CreateMobileAgentPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter cannot be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
