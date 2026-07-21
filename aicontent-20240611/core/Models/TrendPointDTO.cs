// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class TrendPointDTO : TeaModel {
        /// <summary>
        /// <para>UNIX timestamp (Unix seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <para>Metric value mapping, where the key is the metric name and the value is the numeric value</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;total_calls\&quot;:0,\&quot;video_duration\&quot;:0,\&quot;total_amount\&quot;:0,\&quot;model_count\&quot;:0,\&quot;image_count\&quot;:0}&quot;</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public string Values { get; set; }

    }

}
