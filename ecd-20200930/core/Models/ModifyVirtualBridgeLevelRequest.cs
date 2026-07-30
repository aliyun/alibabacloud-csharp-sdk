// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyVirtualBridgeLevelRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect and is optional only when the billing method is <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The virtual bridge ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vb-sfjoasjfosdfj**</para>
        /// </summary>
        [NameInMap("BridgeId")]
        [Validation(Required=false)]
        public string BridgeId { get; set; }

        /// <summary>
        /// <para>The virtual bridge specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vb.pro</para>
        /// </summary>
        [NameInMap("BridgeLevel")]
        [Validation(Required=false)]
        public string BridgeLevel { get; set; }

        /// <summary>
        /// <para>The payment callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://wya.wuying.aliyun.com/mobileClaw">https://wya.wuying.aliyun.com/mobileClaw</a></para>
        /// </summary>
        [NameInMap("PaidCallBackUrl")]
        [Validation(Required=false)]
        public string PaidCallBackUrl { get; set; }

        /// <summary>
        /// <para>The renewal duration. Valid values of this parameter are determined by the value of the <c>PeriodUnit</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values are 1, 2, 3, and 6.</description></item>
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are 1, 2, and 3.</description></item>
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
        /// <para>The unit of the subscription duration for the prepaid cloud disk. This parameter takes effect and is required only when the <c>CdsChargeType</c> parameter is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID. You can call the pricing query operation to obtain the list of matched promotion IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the list of regions supported by WUYING Workspace.</para>
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
