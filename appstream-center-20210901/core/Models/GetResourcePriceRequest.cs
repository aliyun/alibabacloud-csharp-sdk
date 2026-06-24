// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourcePriceRequest : TeaModel {
        /// <summary>
        /// <para>The quantity of resources to purchase.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>The ID of the session instance type to purchase. You can call the <c>ListAppInstanceType</c> operation to obtain the ID.</para>
        /// <para>Either AppInstanceType or NodeInstanceType must have a value. If both have values, NodeInstanceType is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.general</para>
        /// </summary>
        [NameInMap("AppInstanceType")]
        [Validation(Required=false)]
        public string AppInstanceType { get; set; }

        /// <summary>
        /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the resource instance type to purchase. You can call the <a href="https://help.aliyun.com/document_detail/428502.html">ListNodeInstanceType</a> operation to obtain the ID.</para>
        /// <para>Either AppInstanceType or NodeInstanceType must have a value. If both have values, NodeInstanceType is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.vgpu.4c8g.2g</para>
        /// </summary>
        [NameInMap("NodeInstanceType")]
        [Validation(Required=false)]
        public string NodeInstanceType { get; set; }

        /// <summary>
        /// <para>The numeric part of the purchase duration. This parameter is used together with PeriodUnit to specify the complete purchase duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit part of the purchase duration. This parameter is used together with Period to specify the complete purchase duration. The following combinations of Period and PeriodUnit are supported:</para>
        /// <list type="bullet">
        /// <item><description>1 Week (1 week)</description></item>
        /// <item><description>1 Month (1 month)</description></item>
        /// <item><description>2 Month (2 months)</description></item>
        /// <item><description>3 Month (3 months)</description></item>
        /// <item><description>6 Month (6 months)</description></item>
        /// <item><description>1 Year (1 year)</description></item>
        /// <item><description>2 Year (2 years)</description></item>
        /// <item><description>3 Year (3 years)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is case-sensitive. For example, <c>Week</c> is valid, but <c>week</c> is invalid. If the request parameters do not match the supported combinations, such as <c>2 Week</c>, the API call succeeds but an error occurs during the order placement stage.</para>
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
