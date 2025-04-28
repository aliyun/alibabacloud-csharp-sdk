// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNetworkPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): enables the auto-payment feature.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>Make sure that your account has sufficient balance. Otherwise, no order is generated.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false: disables the auto-payment feature. In this case, an order is generated but you need to make the payment manually.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>To make the payment, log on to the Elastic Desktop Service console, go to the Orders page, and find the order based on the order ID.</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the premium bandwidth plan.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The bandwidth provided by the premium bandwidth plan. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if the premium bandwidth plan is a subscription plan: 2 to 1000.</description></item>
        /// <item><description>Valid values if the premium bandwidth plan is a pay-as-you-go plan that charges by data transfer (PayByTraffic): 2 to 200.</description></item>
        /// <item><description>Valid values if the premium bandwidth plan is a pay-as-you-go plan that charges by fixed bandwidth (PayByBandwidth): 2 to 1000.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The charge type of the premium bandwidth plan.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid value when the <c>PayType</c> parameter is set to <c>PrePaid</c>:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: charges by fixed bandwidth.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values when the <c>PayType</c> parameter is set to <c>PostPaid</c>:</para>
        /// <list type="bullet">
        /// <item><description>PayByTraffic: charges by data transfer.</description></item>
        /// <item><description>PayByBandwidth: charges by fixed bandwidth.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The billing method of the premium bandwidth plan.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the premium bandwidth plan. This parameter takes effect and is required only when the <c>PayType</c> parameter is set to <c>PrePaid</c>. The valid values of this parameter vary based on the <c>PeriodUnit</c> value.</para>
        /// <list type="bullet">
        /// <item><description>Valid value when the <c>PeriodUnit</c> parameter is set to <c>Week</c>: 1</description></item>
        /// <item><description>Valid values when the <c>PeriodUnit</c> parameter is set to <c>Month</c>: 1, 2, 3, and 6</description></item>
        /// <item><description>Valid values when the <c>PeriodUnit</c> parameter is set to <c>Year</c>: 1, 2, and 3</description></item>
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
        /// <para>The unit of the subscription duration of the premium bandwidth plan. This parameter takes effect and is required only when the <c>PayType</c> parameter is set to <c>PrePaid</c>.</para>
        /// <para>Valid values:</para>
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
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Week</para>
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
        /// <para>The ID of the sales promotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
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

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
