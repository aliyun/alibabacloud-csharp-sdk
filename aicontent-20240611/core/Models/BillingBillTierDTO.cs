// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingBillTierDTO : TeaModel {
        /// <summary>
        /// <para>The dimension key-value mapping, where the key is the dimension column name and the value is the display value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;context_tier&quot;: &quot;0-32k&quot;}</para>
        /// </summary>
        [NameInMap("dimValues")]
        [Validation(Required=false)]
        public string DimValues { get; set; }

        /// <summary>
        /// <para>The cost of the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("payableAmount")]
        [Validation(Required=false)]
        public float? PayableAmount { get; set; }

        /// <summary>
        /// <para>The usage value mapping, where the key is the metric name and the value is the numerical value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input_tokens&quot;: 1000, &quot;output_tokens&quot;: 500}</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public string Values { get; set; }

    }

}
