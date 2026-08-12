// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>A comma-separated list of billing instance IDs to renew. Billing instances include clusters and compute groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-dd8933281e46****</para>
        /// </summary>
        [NameInMap("BillingInstanceIds")]
        [Validation(Required=false)]
        public string BillingInstanceIds { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Duration unit:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Year</para>
        /// </description></item>
        /// </list>
        /// <para>Valid only when payType is PrePaid.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_12378dfj6</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

    }

}
