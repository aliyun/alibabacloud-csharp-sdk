// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBandwidthPackagePriceRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the network. Unit: Mbit/s.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth plan. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b> (default): billing by bandwidth.</description></item>
        /// <item><description><b>PayBy95</b>: billing by traditional 95th percentile. IPv6 Internet bandwidth does not support billing by traditional 95th percentile by default. To use this billing method, contact your account manager.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b> (default): billing by bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource. The unit is specified by <c>PeriodUnit</c>. Valid values: 1 month, 2 months, 3 months, 6 months, 1 year, 2 years, and 3 years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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

        /// <summary>
        /// <para>The payment channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JvsMobile</para>
        /// </summary>
        [NameInMap("PurchaseChannelType")]
        [Validation(Required=false)]
        public string PurchaseChannelType { get; set; }

    }

}
