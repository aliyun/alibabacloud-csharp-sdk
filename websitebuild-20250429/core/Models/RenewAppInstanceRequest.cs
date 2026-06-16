// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RenewAppInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250718165839000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique value from your client. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fdfjafdfadfenjeora</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Required. The number of subscription periods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;交付质检\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Finish\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Provider\&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The payment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Required. The unit of the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year: year</description></item>
        /// <item><description>Month: month</description></item>
        /// <item><description>Day: day</description></item>
        /// <item><description>Hour: hour.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

    }

}
