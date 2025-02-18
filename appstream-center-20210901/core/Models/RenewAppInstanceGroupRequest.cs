// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RenewAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false: manual payment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The subscription duration of resources. This parameter must be configured together with <c>PeriodUnit</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

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

        /// <summary>
        /// <para>The promotion ID. You can call the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
