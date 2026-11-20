// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class TimeSeriesPointDTO : TeaModel {
        /// <summary>
        /// <para>The label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>series1</para>
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The timestamp (RFC3339).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <para>The value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.76</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
