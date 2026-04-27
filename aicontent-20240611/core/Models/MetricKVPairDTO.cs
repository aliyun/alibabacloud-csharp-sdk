// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class MetricKVPairDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>total_calls</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
