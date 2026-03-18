// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelMetricsDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200.5</para>
        /// </summary>
        [NameInMap("avgResponseTime")]
        [Validation(Required=false)]
        public double? AvgResponseTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500000</para>
        /// </summary>
        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public long? InputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99.5</para>
        /// </summary>
        [NameInMap("successRate")]
        [Validation(Required=false)]
        public double? SuccessRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("totalCalls")]
        [Validation(Required=false)]
        public long? TotalCalls { get; set; }

    }

}
