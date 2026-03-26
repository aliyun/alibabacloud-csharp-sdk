// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class RunMetric : TeaModel {
        /// <summary>
        /// <para>The metric name.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The step number that generated the metric.</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

        /// <summary>
        /// <para>The timestamp when the metric was generated.</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <para>The metric value.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
