// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourcePriceRequest : TeaModel {
        /// <summary>
        /// <para>The number of resources to purchase.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>The type ID of the sessions that you purchase. You can call the <c>ListAppInstanceType</c> operation to obtain the ID.</para>
        /// <para>You must specify one of AppInstanceType and NodeInstanceType. If you specify both of the parameters, the value of NodeInstanceType takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.general</para>
        /// </summary>
        [NameInMap("AppInstanceType")]
        [Validation(Required=false)]
        public string AppInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the delivery group resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shanghai: China (Shanghai).</description></item>
        /// <item><description>cn-hangzhou: China (Hangzhou)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the resource type that you purchase. You can call the <a href="https://help.aliyun.com/document_detail/428502.html">ListNodeInstanceType</a> to obtain the ID.</para>
        /// <para>You must specify one of AppInstanceType and NodeInstanceType. If you specify both of the parameters, the value of NodeInstanceType takes effect.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>appstreaming.vgpu.8c16g.4g: WUYING - Graphics - 8 vCPUs, 16 GiB Memory, 4 GiB GPU Memory</description></item>
        /// <item><description>appstreaming.general.8c16g: WUYING - General - 8 vCPUs, 16 GiB Memory</description></item>
        /// <item><description>appstreaming.general.4c8g: WUYING - General - 4 vCPUs, 8 GiB Memory</description></item>
        /// <item><description>appstreaming.vgpu.14c93g.12g: WUYING - Graphics - 14 vCPUs, 93 GiB Memory, 12 GiB GPU Memory.</description></item>
        /// <item><description>appstreaming.vgpu.8c31g.16g: WUYING - Graphics - 8 vCPUs, 31 GiB Memory, 16 GiB GPU Memory</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.vgpu.4c8g.2g</para>
        /// </summary>
        [NameInMap("NodeInstanceType")]
        [Validation(Required=false)]
        public string NodeInstanceType { get; set; }

        /// <summary>
        /// <para>The subscription duration of resources. This parameter must be configured together with <c>PeriodUnit</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter must be configured together with <c>Period</c>. The following items describe valid values for the combinations of <c>Period</c> and <c>PeriodUnit</c>:</para>
        /// <list type="bullet">
        /// <item><description>1 Week</description></item>
        /// <item><description>1 Month</description></item>
        /// <item><description>2 Month</description></item>
        /// <item><description>3 Month</description></item>
        /// <item><description>6 Month</description></item>
        /// <item><description>1 Year</description></item>
        /// <item><description>2 Year</description></item>
        /// <item><description>3 Year</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of this parameter is case-insensitive. For example, <c>Week</c> is valid and <c>week</c> is invalid. If you specify a value combination other than the preceding combinations, such as <c>2 Week</c>, the operation can still be called. However, an error occurs when you place the order.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
