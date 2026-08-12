// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable auto-renewal. This parameter takes effect only when payType is PrePaid. Default: disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>List of billing instance IDs that require renewal. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-3d6dc31ba67b1839</para>
        /// </summary>
        [NameInMap("BillingInstanceIds")]
        [Validation(Required=false)]
        public string BillingInstanceIds { get; set; }

        /// <summary>
        /// <para>Subscription duration. This parameter takes effect only when payType is PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Subscription duration unit:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Year</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter takes effect only when payType is PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>Coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2345</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

    }

}
