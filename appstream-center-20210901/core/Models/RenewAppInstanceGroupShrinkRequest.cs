// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RenewAppInstanceGroupShrinkRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The numeric part of the resource purchase duration. This parameter is used together with PeriodUnit to specify the complete purchase duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit part of the resource purchase duration. This parameter is used together with Period to specify the complete purchase duration. Valid combinations of Period and PeriodUnit:</para>
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
        /// <para>This parameter is case-sensitive. For example, <c>Week</c> is valid, but <c>week</c> is invalid. If the request parameters do not match the combinations listed above, such as <c>2 Week</c>, the call to this operation succeeds, but an error occurs during the order placement phase.</para>
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

        /// <summary>
        /// <para>The promotion ID. You can obtain this value by calling the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("RenewAmount")]
        [Validation(Required=false)]
        public int? RenewAmount { get; set; }

        [NameInMap("RenewMode")]
        [Validation(Required=false)]
        public string RenewMode { get; set; }

        [NameInMap("RenewNodes")]
        [Validation(Required=false)]
        public string RenewNodesShrink { get; set; }

    }

}
