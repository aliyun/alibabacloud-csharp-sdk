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
        /// 
        /// <b>Example:</b>
        /// <para>loss</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The step at which the metric is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

        /// <summary>
        /// <para>The timestamp when the metric is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1793248584453</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <para>The metric value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.25</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
