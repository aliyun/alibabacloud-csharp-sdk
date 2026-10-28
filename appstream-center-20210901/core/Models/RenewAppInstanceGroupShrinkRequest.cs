// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RenewAppInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. If RenewMode is set to RENEW_SPECIFIED_NODE_COUNT or RENEW_SPECIFIED_NODE_IDS, this parameter must be set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The numeric part of the resource purchase duration. Use this parameter together with <c>PeriodUnit</c> to specify the full purchase duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit part of the resource purchase duration. Use this parameter together with <c>Period</c> to specify the full purchase duration. The valid combinations of <c>Period</c> and <c>PeriodUnit</c> are as follows:</para>
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
        /// <para>This parameter is case-sensitive. For example, <c>Week</c> is valid, but <c>week</c> is not. If the request parameters do not match the combinations listed above, such as <c>2 Week</c>, the operation call succeeds but an error occurs during order placement.</para>
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
        /// <para>The promotion ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The number of nodes to renew.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RenewAmount")]
        [Validation(Required=false)]
        public int? RenewAmount { get; set; }

        /// <summary>
        /// <para>The renewal mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RENEW_ORIGINAL_CONFIG</para>
        /// </summary>
        [NameInMap("RenewMode")]
        [Validation(Required=false)]
        public string RenewMode { get; set; }

        /// <summary>
        /// <para>The list of node IDs to renew.</para>
        /// </summary>
        [NameInMap("RenewNodes")]
        [Validation(Required=false)]
        public string RenewNodesShrink { get; set; }

    }

}
