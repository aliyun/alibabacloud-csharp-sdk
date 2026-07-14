// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNetworkPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
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
        /// <para>The bandwidth of the premium bandwidth plan. Unit: Mbit/s.    </para>
        /// <list type="bullet">
        /// <item><description>If the premium bandwidth plan uses the subscription billing method, the valid values are 2 to 1000.</description></item>
        /// <item><description>If the premium bandwidth plan uses the pay-as-you-go billing method and the billing type is pay-by-data-transfer (PayByTraffic), the valid values are 2 to 200.</description></item>
        /// <item><description>If the premium bandwidth plan uses the pay-as-you-go billing method and the billing type is pay-by-bandwidth (PayByBandwidth), the valid values are 2 to 1000.</description></item>
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
        /// <para>The billable methods of the premium bandwidth plan.</para>
        /// <list type="bullet">
        /// <item><description>If the parameter <c>PayType</c> is set to <c>PrePaid</c>, valid values:<list type="bullet">
        /// <item><description>PayByBandwidth: billing by fixed bandwidth.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If the parameter <c>PayType</c> is set to <c>PostPaid</c>, valid values:<list type="bullet">
        /// <item><description>PayByTraffic: billing by data transfer.</description></item>
        /// <item><description>PayByBandwidth: billing by fixed bandwidth.</description></item>
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
        /// <para>The subscription duration of the premium bandwidth plan. This parameter takes effect and is required only when PayType is set to PrePaid. Valid values are determined by the PeriodUnit parameter.</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to Week, the valid value is 1.</description></item>
        /// <item><description>If PeriodUnit is set to Month, valid values are 1, 2, 3, and 6.</description></item>
        /// <item><description>If PeriodUnit is set to Year, valid values are 1, 2, and 3.</description></item>
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
        /// <para>The unit of the subscription duration for the premium bandwidth plan. This parameter takes effect and is required only when PayType is set to PrePaid.</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkPackageRequestTag> Tag { get; set; }
        public class CreateNetworkPackageRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
