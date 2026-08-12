// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryModifyChargeTypePriceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter is valid only when \<c>payType\\</c> is set to \<c>PrePaid\\</c>. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>A list of billing instance IDs to modify. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-3d6dc31ba67b1839</para>
        /// </summary>
        [NameInMap("BillingInstanceIds")]
        [Validation(Required=false)]
        public string BillingInstanceIds { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is valid only when \<c>payType\\</c> is set to \<c>PrePaid\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Year</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is valid only when \<c>payType\\</c> is set to \<c>PrePaid\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

    }

}
