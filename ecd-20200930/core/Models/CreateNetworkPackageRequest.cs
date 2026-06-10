// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNetworkPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The bandwidth of the network package, in Mbps.</para>
        /// <list type="bullet">
        /// <item><description><para>For subscription network packages, the value range is 2 to 1,000.</para>
        /// </description></item>
        /// <item><description><para>For pay-as-you-go network packages that are billed by traffic, the value range is 2 to 200.</para>
        /// </description></item>
        /// <item><description><para>For pay-as-you-go network packages that are billed by bandwidth, the value range is 2 to 1,000.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The billing method for the network package.</para>
        /// <list type="bullet">
        /// <item><description><para>When <c>PayType</c> is set to <c>PrePaid</c>, the only valid value is:</para>
        /// <list type="bullet">
        /// <item><description><c>PayByBandwidth</c>: pay-by-bandwidth.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When <c>PayType</c> is set to <c>PostPaid</c>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PayByTraffic</c>: pay-by-traffic.</para>
        /// </description></item>
        /// <item><description><para><c>PayByBandwidth</c>: pay-by-bandwidth.</para>
        /// </description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the network package. This parameter is required and applies only when <c>PayType</c> is set to <c>PrePaid</c>. The valid values for this parameter depend on the value of <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Week</c>, the only valid value is 1.</para>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values are 1, 2, 3, and 6.</para>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are 1, 2, and 3.</para>
        /// </description></item>
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
        /// <para>The unit of the subscription duration for the network package. This parameter is required and applies only when <c>PayType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to get the list of regions supported by Elastic Desktop Service.</para>
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
