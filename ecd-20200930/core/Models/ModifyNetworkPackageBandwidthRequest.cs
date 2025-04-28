// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyNetworkPackageBandwidthRequest : TeaModel {
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
        /// <para>The ID of the premium bandwidth plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-cxj99qb8d34vo****</para>
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public string NetworkPackageId { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500033080110596</para>
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
