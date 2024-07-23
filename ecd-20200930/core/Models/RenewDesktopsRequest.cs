// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-payment feature.</para>
        /// <para>Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the auto-payment feature.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>Make sure that you have sufficient balance in your Alibaba Cloud account. Otherwise, your order becomes invalid.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false: disables the auto-payment feature. In this case, an order is generated, and no payment is automatically made.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>You can log on to the Elastic Desktop Service console and complete the payment based on the order ID on the Orders page.</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers. Only IDs of subscription cloud computers are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-ia2zw38bi6cm7****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The renewal duration. Valid values of this parameter are determined by the value of the <c>PeriodUnit</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set the <c>PeriodUnit</c> parameter to <c>Month</c>: 1, 2, 3, and 6</description></item>
        /// <item><description>Valid values if you set the <c>PeriodUnit</c> parameter to <c>Year</c>: 1, 2, 3, 4, 5, and 6</description></item>
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
        /// <para>The unit of the renewal duration specified by the <c>Period</c> parameter.</para>
        /// <para>Default value: Month. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Year</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the promotional activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500030980150146</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
