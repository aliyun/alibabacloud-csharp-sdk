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
        /// <para>Specifies whether to enable automatic payment. When the RenewMode parameter is set to RENEW_SPECIFIED_NODE_COUNT or RENEW_SPECIFIED_NODE_IDS, this parameter must be set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The numeric part of the subscription duration. This parameter is used together with the PeriodUnit parameter to specify the complete subscription duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is used together with the Period parameter to specify the complete subscription duration. Valid combinations of Period and PeriodUnit are as follows:</para>
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
        /// <para>This parameter is case-sensitive. For example, Week is valid, but week is invalid. If the request parameters do not match the preceding valid combinations, such as 2 Week, the API call may succeed, but an error will occur during the order placement stage.</para>
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
        /// <para>The promotion ID. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation.</para>
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
        /// <para>The IDs of the nodes to renew.</para>
        /// </summary>
        [NameInMap("RenewNodes")]
        [Validation(Required=false)]
        public string RenewNodesShrink { get; set; }

    }

}
