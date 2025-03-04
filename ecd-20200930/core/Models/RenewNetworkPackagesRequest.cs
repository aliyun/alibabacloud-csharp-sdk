// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewNetworkPackagesRequest : TeaModel {
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The IDs of premium bandwidth plans. You can specify up to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public List<string> NetworkPackageId { get; set; }

        /// <summary>
        /// <para>The subscription duration if you specify subscription as the new billing method for the cloud desktop. The unit of the value is specified by the <c>PeriodUnit</c> parameter. This parameter takes effect only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>.</para>
        /// <list type="bullet">
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Week</c>, the valid value of the Period parameter is 1.</description></item>
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Month</c>, the valid values of the Period parameter are 1, 2, 3, and 6.</description></item>
        /// <item><description>If the <c>PeriodUnit</c> parameter is set to <c>Year</c>, the valid values of the Period parameter are 1, 2, 3, 4, and 5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration specified by the Period parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
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
        /// <para>500038360030606</para>
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

    }

}
